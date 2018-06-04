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
        public event DoEvent RefreshDgv;
        POS_Entities Point_Of_SalesEntities;// = new hartama_hotelEntities();
        string indexDatagrid = "";
        int offset_data = 0;
        string calling;
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
        public sales_list()
        {
            InitializeComponent();
        }

        private void sales_list_Load(object sender, EventArgs e)
        {
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
            Load_Data_Sales();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.RefreshDgv();
            
        }

        public void Load_Data_Sales()
        {
            code = txt_search_salesnumber.Text.Length > 0 ? txt_search_salesnumber.Text : "";
           
            //string order = cb_order.selectedValue.ToString();
            ds_sales.DataSource = null;
           

            try
            {
               int TotalData = DBSalesData.GetDataSales(offset_data, 25, code).Count();
                ds_sales.DataSource = DBSalesData.GetDataSales(offset_data, 25, code);
                dg_sales.DataSource = ds_sales;
                dg_sales.Columns[0].Visible = false;
               
                

              
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message.ToString());
            }
        }
    }
}
