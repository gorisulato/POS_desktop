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

namespace POS
{
    public partial class sales_list : Form
    {
        int row_main_selected = 0;
        public delegate void DoEvent();
        UtilityClass Util = new UtilityClass();
        public event DoEvent RefreshDgv;
        POS_Entities Point_Of_SalesEntities;// = new hartama_hotelEntities();
        string indexDatagrid = "";
        int offset_data = 0;
        string calling;
        int total_records = 0;
    
        int StartPaginationShow = 1;
        decimal total_pages = 0;
        string code, firstname_search;
        string order = "GuestCardFilename";
        string direction = "ASC";
        string type = "";
        private string guest_name;
        private string guest_title;
        private string guest_card_id;
        DBSalesData DBSalesData = new DBSalesData();
        int stat = 0;
        public sales_list()
        {
            InitializeComponent();
        }

        private void sales_list_Load(object sender, EventArgs e)
        {
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            Load_Data_Sales();

            dg_sales.MultiSelect = false;

          
        }

        private void btn_add_sales_Click(object sender, EventArgs e)
        {
            FormADDSales add = new FormADDSales("add");
            add.RefreshDgv += new FormADDSales.DoEvent(Load_Data_Sales);
            //dataGridView1.Columns[0].Visible = false;
            add.ShowDialog();
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
                bunifuImageButton1.Image=Properties.Resources.checkout_white;
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(searchbox, "Height", 70);
                t.run();
            }
        }

        private void dg_sales_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dg_sales.SelectedRows)
            {
                indexDatagrid = row.Cells[1].Value.ToString();
            }
        }

        private void editPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (indexDatagrid != "")
            {
                FormADDSales add = new FormADDSales(indexDatagrid,"edit");
                add.RefreshDgv += new FormADDSales.DoEvent(Load_Data_Sales);
                //dataGridView1.Columns[0].Visible = false;
                add.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pilih Data Yang Akan Diedit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dg_sales_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    row_main_selected = e.RowIndex;
                    dg_sales.Rows[e.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dg_sales, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            stat = 1;
            Load_Data_Sales();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.RefreshDgv();
            
        }
        private void CountRecords()
        {

            if (stat == 0)
            {
                total_records = Point_Of_SalesEntities.TReceiveingStocks.Where(x => x.is_deleted == false).Count();
            }
            else
            {
                DateTime dt = dt_salesdate_search.Value.Date;
                string code = txt_search_salesnumber.Text;
                if (code != "")
                {
                    code.ToUpper();
                }
                total_records = Point_Of_SalesEntities.TSales.ToList().Where(x => x.Sales_Number.ToUpper().Contains(code) || x.SalesDate.Date == dt).Where(x=>x.is_deleted==false).Count();
            }
            set_info_pagination();
            setenablebtnpage();
        }
        public void Load_Data_Sales()
        {
            try
            {
                CountRecords();
                dg_sales.DataSource = null;
                dg_sales.Columns.Clear();

                DataTable dt = new DataTable();


                if (Util.OpenConnection())
                {
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("Nomor Penjualan", typeof(string));
                    dt.Columns.Add("Tanggal Penjualan", typeof(DateTime));
                    dt.Columns.Add("Customer", typeof(string));
                    dt.Columns.Add("Alamat Customer", typeof(string));
                    dt.Columns.Add("Kode Member", typeof(string));




                    Util.command.Parameters.Clear();

                    Util.command.CommandType = CommandType.StoredProcedure;
                    Util.command.CommandText = "[GetSales]";
                    Util.command.Connection = Util.connection;
                    Util.command.Parameters.AddWithValue("@stat", stat);
                    Util.command.Parameters.AddWithValue("@date", dt_salesdate_search.Value);
                    Util.command.Parameters.AddWithValue("@rcno", txt_search_salesnumber.Text);
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
                    dg_sales.DataSource = dt;
                    dg_sales.Refresh();
                    //dg_Rc.Columns[0].Visible = false;

                    Util.dtreader.Close();
                    Util.connection.Close();
                    foreach (DataGridViewRow row in dg_sales.Rows)
                    {
                        row.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                        
                     
                        
                    }
                    
                    this.dg_sales.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    this.dg_sales.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(), "Error Collecting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_next_Click(object sender, EventArgs e)
        {

        }

        private void btn_prev_Click(object sender, EventArgs e)
        {

        }

        private void btn_last_Click(object sender, EventArgs e)
        {

        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            offset_data = 0;
            StartPaginationShow = 1;
            Load_Data_Sales();
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

        private void btnresetsearch_Click(object sender, EventArgs e)
        {
            stat = 0;
            txt_search_salesnumber.Text = "";
            dt_salesdate_search.Value = DateTime.Now;
            offset_data = 0;
            StartPaginationShow = 1;
        

            Load_Data_Sales();
            
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
