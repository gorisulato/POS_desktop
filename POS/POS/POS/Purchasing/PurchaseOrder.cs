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

namespace POS.Purchasing
{
    public partial class PurchaseOrder : Form
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
      
        string type = "";
      
        //DBSalesData DBSalesData = new DBSalesData();
        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            dg_Po.MultiSelect = false;
            Load_Po();
        }
        private void CountRecords()
        {
            
            if (stat == 0)
            {
                total_records = Point_Of_SalesEntities.TPurchaseOrders.Where(x=>x.is_deleted==false).Count();
            }
            else
            {
                DateTime dt = dt_podatesearch.Value.Date;
                string code = txt_search_ponumber.Text;
                if (code != "")
                {
                    code.ToUpper();
                }
                total_records= Point_Of_SalesEntities.TPurchaseOrders.ToList().Where(x=>x.PO_Number.ToUpper().Contains(code)|| x.PO_date.Date==dt).Count();
            }
            set_info_pagination();
            setenablebtnpage();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            StartPaginationShow = StartPaginationShow + 1;
            offset_data = 25 * (StartPaginationShow - 1);
            Load_Po();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            StartPaginationShow = StartPaginationShow - 1;
            offset_data = 25* (StartPaginationShow - 1);
            Load_Po();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            offset_data = 25* (Convert.ToInt32(total_pages) - 1);
            StartPaginationShow = Convert.ToInt32(total_pages);
            Load_Po();
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
                    txtpageinfo.Text = "Page :"+" "+String.Format("{0} / {1}", StartPaginationShow, total_pages <= 0 ? 1 : total_pages);
                }

            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            offset_data = 0;
            StartPaginationShow = 1;
            Load_Po();
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

        private void btn_searchPO_Click(object sender, EventArgs e)
        {
            stat = 1;
            offset_data = 0;
            StartPaginationShow = 1;
            Load_Po();
        }

        private void btnresetsearch_Click(object sender, EventArgs e)
        {
            stat = 0;
            txt_search_ponumber.Text = "";
            offset_data = 0;
            StartPaginationShow = 1;
            Load_Po();
        }

        public void Load_Po()
        {
            try
            {
                CountRecords();
                dg_Po.DataSource = null;
                dg_Po.Columns.Clear();

                DataTable dt = new DataTable();


                if (Util.OpenConnection())
                {
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("PO Number", typeof(string));
                    dt.Columns.Add("PO Date", typeof(DateTime));
                    dt.Columns.Add("Supplier Name", typeof(string));
                    dt.Columns.Add("Supplier Address", typeof(string));
                    dt.Columns.Add("Contact Person", typeof(string));
                    dt.Columns.Add("Status", typeof(string));




                    Util.command.Parameters.Clear();

                    Util.command.CommandType = CommandType.StoredProcedure;
                    Util.command.CommandText = "[GetDataPO]";
                    Util.command.Connection = Util.connection;
                    Util.command.Parameters.AddWithValue("@stat", stat);
                    Util.command.Parameters.AddWithValue("@Podate", dt_podatesearch.Value);
                    Util.command.Parameters.AddWithValue("@ponumber", txt_search_ponumber.Text);
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
                            Util.dtreader[5].ToString(),
                            Util.dtreader[6].ToString()


                            );
                    }
                    dg_Po.DataSource = dt;
                    dg_Po.Refresh();
                    //dg_Po.Columns[0].Visible = false;

                    Util.dtreader.Close();
                    Util.connection.Close();
                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(), "Error Collecting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.RefreshDgv();
        }

        private void btn_add_po_Click(object sender, EventArgs e)
        {
            FormAddPO add = new FormAddPO("add");
            add.RefreshDgv += new FormAddPO.DoEvent(Load_Po);
            //dataGridView1.Columns[0].Visible = false;
            add.ShowDialog();
        }

        private void dg_Po_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dg_Po.SelectedRows)
            {
                indexDatagrid = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

        private void dg_Po_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    row_main_selected = e.RowIndex;
                    dg_Po.Rows[e.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dg_Po, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormAddPO add = new FormAddPO("edit", indexDatagrid);
            add.RefreshDgv += new FormAddPO.DoEvent(Load_Po);
            //dataGridView1.Columns[0].Visible = false;
            add.ShowDialog();

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
    }
}
