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

namespace POS.Receiving
{
    public partial class ReceivingList : Form
    {
        int row_main_selected = 0;
        public delegate void DoEvent();
        public event DoEvent RefreshDgv;
        int total_records = 0;
        int offset_data = 0;
        UtilityClass Util = new UtilityClass();
        POS_Entities Point_Of_SalesEntities;// = new hartama_hotelEntities();
        int indexDatagrid = 0;
        int stat = 0;
        string calling;
        int StartPaginationShow = 1;
        decimal total_pages = 0;
        string code, firstname_search;

        public ReceivingList()
        {
            InitializeComponent();
        }

        private void Receiving_Load(object sender, EventArgs e)
        {
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            dg_Rc.MultiSelect = false;
            LoadReceiveing();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            StartPaginationShow = StartPaginationShow + 1;
            offset_data = 25 * (StartPaginationShow - 1);
            LoadReceiveing();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            StartPaginationShow = StartPaginationShow - 1;
            offset_data = 25 * (StartPaginationShow - 1);
            LoadReceiveing();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            offset_data = 25 * (Convert.ToInt32(total_pages) - 1);
            StartPaginationShow = Convert.ToInt32(total_pages);
            LoadReceiveing();
        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            offset_data = 0;
            StartPaginationShow = 1;
            LoadReceiveing();
        }
        private void CountRecords()
        {

            if (stat == 0)
            {
                total_records = Point_Of_SalesEntities.TReceiveingStocks.Where(x=>x.is_deleted==false).Count();
            }
            else
            {
                DateTime dt = dt_podatesearch.Value.Date;
                string code = txt_search_ponumber.Text;
                if (code != "")
                {
                    code.ToUpper();
                }
                total_records = Point_Of_SalesEntities.TReceiveingStocks.ToList().Where(x => x.ReceiveNumber.ToUpper().Contains(code) || x.ReceiveDate.Date == dt).Count();
            }
            set_info_pagination();
            setenablebtnpage();
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (searchbox.Height == 70)
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
                t.add(searchbox, "Height", 70);
                t.run();
            }
        }

        private void btn_add_Rc_Click(object sender, EventArgs e)
        {
            FormAddReceiveing add = new FormAddReceiveing("add");
            add.RefreshDgv += new FormAddReceiveing.DoEvent(LoadReceiveing);
            add.ShowDialog();
        }

        private void btnresetsearch_Click(object sender, EventArgs e)
        {
            stat = 0;
            txt_search_ponumber.Text = "";
            offset_data = 0;
            StartPaginationShow = 1;
            LoadReceiveing();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (indexDatagrid > 0)
            {
                FormAddReceiveing add = new FormAddReceiveing("edit", indexDatagrid);
                add.RefreshDgv += new FormAddReceiveing.DoEvent(LoadReceiveing);
                add.ShowDialog();
            }
           else
            {
                MessageBox.Show("Silahkan Pilih Data Yang Akan Di Edit", "Error Collecting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dg_Rc_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dg_Rc.SelectedRows)
            {
                indexDatagrid = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dg_Rc_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    row_main_selected = e.RowIndex;
                    dg_Rc.Rows[e.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dg_Rc, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void dg_Rc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dg_Rc.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dg_Rc_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dg_Rc.RowCount > 0)
            {
                dg_Rc.Rows[0].Selected = true;
            }
        }

        private void LoadReceiveing()
        {
            try
            {
                CountRecords();
                dg_Rc.DataSource = null;
                dg_Rc.Columns.Clear();

                DataTable dt = new DataTable();


                if (Util.OpenConnection())
                {
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("Nomor Penerimaan", typeof(string));
                    dt.Columns.Add("Tanggal Penerimaan", typeof(DateTime));
                    dt.Columns.Add("Supplier", typeof(string));
                    dt.Columns.Add("Alamat Supplier", typeof(string));
                    dt.Columns.Add("Contact Person", typeof(string));




                    Util.command.Parameters.Clear();

                    Util.command.CommandType = CommandType.StoredProcedure;
                    Util.command.CommandText = "[GetReceiveing]";
                    Util.command.Connection = Util.connection;
                    Util.command.Parameters.AddWithValue("@stat", stat);
                    Util.command.Parameters.AddWithValue("@date", dt_podatesearch.Value);
                    Util.command.Parameters.AddWithValue("@rcno", txt_search_ponumber.Text);
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
                            Util.dtreader[4].ToString(),
                            Util.dtreader[5].ToString()



                            );
                    }
                    dg_Rc.DataSource = dt;
                    dg_Rc.Refresh();
                    dg_Rc.Columns[0].Visible = false;
                    dg_Rc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    Util.dtreader.Close();
                    Util.connection.Close();
                    foreach (DataGridViewRow row in dg_Rc.Rows)
                    {
                        row.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        row.HeaderCell.Value = String.Format("{0}", row.Index + 1);



                    }
                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(), "Error Collecting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
