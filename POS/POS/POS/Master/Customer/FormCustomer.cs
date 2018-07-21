using POS.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace POS.Master.Customer
{
    public partial class FormCustomer : Form
    {
        int id = 0;
        int total_records = 0;
        decimal total_pages = 0;
        int StartPaginationShow = 1;
        int Stat = 0;
        int offset_data = 0;
        int row_main_selected = 0;
        UtilityClass Util = new UtilityClass();
        POS_Entities Point_Of_SalesEntities;
        public delegate void DoEvent();
        public event DoEvent RefreshDgv;
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            if (searchbox.Height == 154)
            {
                bunifuImageButton1.Image = Properties.Resources.chevron_white;
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(searchbox, "Height", 10);
                t.run();
            }
            else
            {
                bunifuImageButton1.Image = Properties.Resources.checkout_white;
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(searchbox, "Height", 154);
                t.run();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.RefreshDgv();

        }
        public void Load_DataCustomer()
        {
            try
            {
                CountRecords();
                dg_cust.DataSource = null;
                dg_cust.Columns.Clear();

                DataTable dt = new DataTable();


                if (Util.OpenConnection())
                {
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("Kode Member", typeof(string));
                    dt.Columns.Add("Nama Pelanggan", typeof(string));
                    dt.Columns.Add("Alamat", typeof(string));
                    dt.Columns.Add("Reward Point", typeof(string));
                   




                    Util.command.Parameters.Clear();

                    Util.command.CommandType = CommandType.StoredProcedure;
                    Util.command.CommandText = "[getdataCus]";
                    Util.command.Connection = Util.connection;
                    Util.command.Parameters.AddWithValue("@stat", Stat);
                    Util.command.Parameters.AddWithValue("@cusname", txt_cusnome.Text);
                    Util.command.Parameters.AddWithValue("@membercode", txt_membercode.Text);
                    Util.command.Parameters.AddWithValue("@offset", offset_data);
                    Util.dtreader = Util.command.ExecuteReader();

                    while (Util.dtreader.Read())
                    {
                        dt.Rows.Add
                            (
                            Util.dtreader[0].ToString(),
                            Util.dtreader[1].ToString(),
                            Util.dtreader[2].ToString(),
                            Util.dtreader[3].ToString(),
                            Util.dtreader[4].ToString()
                           



                            );
                    }
                    dg_cust.DataSource = dt;
                    dg_cust.Refresh();
                    //dg_Rc.Columns[0].Visible = false;

                    Util.dtreader.Close();
                    Util.connection.Close();
                    foreach (DataGridViewRow row in dg_cust.Rows)
                    {
                        row.HeaderCell.Value = String.Format("{0}", row.Index + 1);

                    }
                    this.dg_cust.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    this.dg_cust.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(), "Error Collecting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            dg_cust.MultiSelect = false;
            Load_DataCustomer();
        }

        private void CountRecords()
        {

            if (Stat == 0)
            {
                total_records = Point_Of_SalesEntities.PCustomers.Where(x => x.is_deleted == false).Count();
            }
            else
            {
                string dt = txt_cusnome.Text==""?txt_cusnome.Text: txt_cusnome.Text.ToUpper();
                string code = txt_membercode.Text==""? txt_membercode.Text: txt_membercode.Text.ToUpper();
                if (code != "")
                {
                    code.ToUpper();
                }
                total_records = Point_Of_SalesEntities.PCustomers.ToList().Where(x => x.CustomerName.ToUpper()==dt || x.MemberCode.ToUpper()==code).Count();
            }
            set_info_pagination();
            setenablebtnpage();
        }
        public void setenablebtnpage()
        {
            if (StartPaginationShow == 1)
            {
                btn_prev.Enabled = false;
                btn_first.Enabled = false;

            }
            else
            {
                btn_prev.Enabled = true;
                btn_first.Enabled = true;
            }

            if (StartPaginationShow == total_pages)
            {
                btn_next.Enabled = false;
                btn_last.Enabled = false;
            }
            else
            {
                btn_next.Enabled = true;
                btn_last.Enabled = true;
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            StartPaginationShow = StartPaginationShow + 1;
            offset_data = 25 * (StartPaginationShow - 1);
            Load_DataCustomer();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            StartPaginationShow = StartPaginationShow - 1;
            offset_data = 25 * (StartPaginationShow - 1);
            Load_DataCustomer();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            offset_data = 25 * (Convert.ToInt32(total_pages) - 1);
            StartPaginationShow = Convert.ToInt32(total_pages);
            Load_DataCustomer();
        }
        public void set_info_pagination()
        {
            if (StartPaginationShow == 1)
            {
                total_pages = Math.Ceiling(total_records / Convert.ToDecimal(25));
                txt_pagination.Text = String.Format("Showing {0} To {1} Of {2} Total Records", total_records != 0 ? 1 : 0, 25 > total_records ? total_records.ToString() : "25", total_records);
                txtpageinfo.Text = "Page :" + " " + String.Format("{0} / {1}", StartPaginationShow, total_pages <= 0 ? 1 : total_pages);
            }
            else
            {
                if (StartPaginationShow != total_pages)
                {
                    total_pages = Math.Ceiling(total_records / Convert.ToDecimal(25));
                    txt_pagination.Text = String.Format("Showing {0} To {1} Of {2} Total Records", offset_data + 1, 25 * StartPaginationShow, total_records);
                    txtpageinfo.Text = "Page :" + " " + String.Format("{0} / {1}", StartPaginationShow, total_pages <= 0 ? 1 : total_pages);
                }
                else
                {
                    total_pages = Math.Ceiling(total_records / Convert.ToDecimal(25));
                    txt_pagination.Text = String.Format("Showing {0} To {1} Of {2} Total Records", offset_data + 1, total_records, total_records);
                    txtpageinfo.Text = "Page :" + " " + String.Format("{0} / {1}", StartPaginationShow, total_pages <= 0 ? 1 : total_pages);
                }

            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            offset_data = 0;
            StartPaginationShow = 1;
            Load_DataCustomer();
        }

        private void dg_cust_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    row_main_selected = e.RowIndex;
                    dg_cust.Rows[e.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dg_cust, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void btn_add_sales_Click(object sender, EventArgs e)
        {
            FormAddCustomer add = new FormAddCustomer(0, "ADD");
            add.RefreshDgv += new FormAddCustomer.DoEvent(Load_DataCustomer);
            add.ShowDialog();
        }

        private void editcustomer_Click(object sender, EventArgs e)
        {
            FormAddCustomer add = new FormAddCustomer(id, "Edit");
            add.RefreshDgv += new FormAddCustomer.DoEvent(Load_DataCustomer);
            add.ShowDialog();
        }

        private void dg_cust_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_cust.SelectedRows)
            {
                id = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Stat = 1;
            Load_DataCustomer();
        }

        private void btnresetsearch_Click(object sender, EventArgs e)
        {
            Stat = 0;
            Load_DataCustomer();
        }

        private void dg_cust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dg_cust.Rows[e.RowIndex].Selected = true;

            }
        }

        private void dg_cust_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dg_cust.RowCount > 0)
            {
                dg_cust.Rows[0].Selected = true;
            }
        }
    }
}
