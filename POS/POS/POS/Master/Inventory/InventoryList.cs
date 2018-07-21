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

namespace POS.Master.Inventory
{
    public partial class InventoryList : Form
    {
        int id = 0;
        int total_records = 0;
        int affectedrows = 0;
        decimal total_pages = 0;
        int StartPaginationShow = 1;
        int Stat = 0;
        int indexdatagrid=0;
        int offset_data = 0;
        int row_main_selected = 0;
        UtilityClass Util = new UtilityClass();
        ThemeStyle style = new ThemeStyle();

        POS_Entities Point_Of_SalesEntities;
        public delegate void DoEvent();
        public event DoEvent RefreshDgv;
        public InventoryList()
        {
            InitializeComponent();
        }

        private void InventoryList_Load(object sender, EventArgs e)
        {
            style._primaryButton(btnresetsearch);
            style._primaryButton(btn_exit);
            style._primaryButton(btn_add_sales);
            style._primaryButton(btn_search);
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            dg_Inventory.MultiSelect = false;
            Load_DataInvent();
        }

        private void CountRecords()
        {

            if (Stat == 0)
            {
                total_records = Point_Of_SalesEntities.PCustomers.Where(x => x.is_deleted == false).Count();
            }
            else
            {
                string dt = txtcodeitem.Text == "" ? txtcodeitem.Text : txtcodeitem.Text.ToUpper();
                string code = txt_itemname.Text == "" ? txt_itemname.Text : txt_itemname.Text.ToUpper();
                if (code != "")
                {
                    code.ToUpper();
                }
                total_records = Point_Of_SalesEntities.TInventories.ToList().Where(x => x.Items_Name.ToUpper() == dt ).Count();
            }
            set_info_pagination();
            setenablebtnpage();
        }
        public void Load_DataInvent()
        {
            try
            {
                CountRecords();
                dg_Inventory.DataSource = null;
                dg_Inventory.Columns.Clear();

                DataTable dt = new DataTable();


                if (Util.OpenConnection())
                {
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("Kode Barang", typeof(string));
                    dt.Columns.Add("Nama Barang", typeof(string));
                    dt.Columns.Add("Size", typeof(string));
                    dt.Columns.Add("Colour", typeof(string));
                    dt.Columns.Add("Unit Price", typeof(string));

                    dt.Columns.Add("Available Stock", typeof(string));


                    Util.command.Parameters.Clear();

                    Util.command.CommandType = CommandType.StoredProcedure;
                    Util.command.CommandText = "[GetDataInventory]";
                    Util.command.Connection = Util.connection;
                    Util.command.Parameters.AddWithValue("@stat", Stat);
                    Util.command.Parameters.AddWithValue("@name", txt_itemname.Text);
                    Util.command.Parameters.AddWithValue("@Code", txtcodeitem.Text);
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
                    dg_Inventory.DataSource = dt;
                    dg_Inventory.Refresh();
                    //dg_Rc.Columns[0].Visible = false;

                    Util.dtreader.Close();
                    Util.connection.Close();
                    foreach (DataGridViewRow row in dg_Inventory.Rows)
                    {
                        row.HeaderCell.Value = String.Format("{0}", row.Index + 1);

                    }
                    this.dg_Inventory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    this.dg_Inventory.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString(), "Error Colecting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Stat = 1;
            Load_DataInvent();
        }

        private void btnresetsearch_Click(object sender, EventArgs e)
        {
            Stat = 0;
            txt_itemname.Text = "";
            txtcodeitem.Text = "";
            Load_DataInvent();
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
            Load_DataInvent();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            StartPaginationShow = StartPaginationShow - 1;
            offset_data = 25 * (StartPaginationShow - 1);
            Load_DataInvent();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            offset_data = 25 * (Convert.ToInt32(total_pages) - 1);
            StartPaginationShow = Convert.ToInt32(total_pages);
            Load_DataInvent();
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
            Load_DataInvent();
        }

        private void btn_add_sales_Click(object sender, EventArgs e)
        {
            FormAddInventory add = new FormAddInventory("add",0);
       
            add.RefreshDgv += new FormAddInventory.DoEvent(Load_DataInvent);
            //dataGridView1.Columns[0].Visible = false;
            add.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.RefreshDgv();

        }

        private void dg_Inventory_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_Inventory.SelectedRows)
            {
                indexdatagrid = int.Parse(row.Cells[0].Value.ToString());

            } 
        }

        private void editinventory_Click(object sender, EventArgs e)
        {
            FormAddInventory add = new FormAddInventory("edit", indexdatagrid);

            add.RefreshDgv += new FormAddInventory.DoEvent(Load_DataInvent);
            //dataGridView1.Columns[0].Visible = false;
            add.ShowDialog();
        }

        private void dg_Inventory_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    row_main_selected = e.RowIndex;
                    dg_Inventory.Rows[e.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dg_Inventory, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void deleteInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var delete = Point_Of_SalesEntities.TInventories.Where(x => x.Items_Id == indexdatagrid).First();
                DialogResult dr = MessageBox.Show("Anda Yakin Akan Menghapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    delete.is_deleted = true;
                    delete.deleted_by = Properties.Settings.Default._userID;
                    delete.deleted_date = DateTime.Today;

                    affectedrows = Point_Of_SalesEntities.SaveChanges();
                    if (affectedrows > 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DataInvent();
                    }

                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
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

        private void dg_Inventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dg_Inventory.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dg_Inventory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dg_Inventory.RowCount > 0)
            {
                dg_Inventory.Rows[0].Selected = true;

            }
        }
    }
}
