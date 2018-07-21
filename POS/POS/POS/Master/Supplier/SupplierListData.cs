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

namespace POS.Master.Supplier
{
    public partial class SupplierListData : Form
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
        ThemeStyle style = new ThemeStyle();
        public delegate void DoEvent();
        public event DoEvent RefreshDgv;
        public SupplierListData()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.RefreshDgv();
        }

        private void SupplierListData_Load(object sender, EventArgs e)
        {
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            dg_supp.MultiSelect = false;
            style._primaryButton(btnresetsearch);
            style._primaryButton(btn_add_supplier);
            style._primaryButton(btn_search);
            style._primaryButton(btn_exit);

            Load_Data_Supp();
        }
        public void Load_Data_Supp()
        {
            try
            {
                CountRecords();
                dg_supp.DataSource = null;
                dg_supp.Columns.Clear();

                DataTable dt = new DataTable();


                if (Util.OpenConnection())
                {
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("Nama Suplier", typeof(string));
                    dt.Columns.Add("Alamat Supplier", typeof(string));
                    dt.Columns.Add("Nomor Telp Supplier", typeof(string));
                    dt.Columns.Add("Alamat E-mail Supplier", typeof(string));
                    dt.Columns.Add("Contact Person", typeof(string));
                    dt.Columns.Add("Nomor Telp Contact Person", typeof(string));
                   




                    Util.command.Parameters.Clear();

                    Util.command.CommandType = CommandType.StoredProcedure;
                    Util.command.CommandText = "[GetDataSupplier]";
                    Util.command.Connection = Util.connection;
                    Util.command.Parameters.AddWithValue("@stat", Stat);
                    Util.command.Parameters.AddWithValue("@suppname", txt_suppname.Text);
                  
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
                    dg_supp.DataSource = dt;
                    dg_supp.Refresh();
                    dg_supp.Columns[0].Visible = false;

                    Util.dtreader.Close();
                    Util.connection.Close();
                    foreach (DataGridViewRow row in dg_supp.Rows)
                    {
                        row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                          

                    }
                    foreach(DataGridViewColumn col in dg_supp.Columns)
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }
                 
                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(), "Error Collecting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CountRecords()

        {
            if (Stat == 0)
            {
                total_records = Point_Of_SalesEntities.PSuppliers.Where(x => x.is_deleted == false).Count();
            }
            else
            {
                string dt = txt_suppname.Text == "" ? txt_suppname.Text : txt_suppname.Text.ToUpper();
             
               
                total_records = Point_Of_SalesEntities.PSuppliers.ToList().Where(x => x.supplier_name.ToUpper().Contains(dt) &&x.is_deleted==false ).Count();
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
            Load_Data_Supp();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            StartPaginationShow = StartPaginationShow - 1;
            offset_data = 25 * (StartPaginationShow - 1);
            Load_Data_Supp();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            offset_data = 25 * (Convert.ToInt32(total_pages) - 1);
            StartPaginationShow = Convert.ToInt32(total_pages);
            Load_Data_Supp();
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
            Load_Data_Supp();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            //if (searchbox.Height == 154)
            //{
            //    bunifuImageButton1.Image = Properties.Resources.chevron_white;
            //    Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            //    t.add(searchbox, "Height", 10);
            //    t.run();
            //}
            //else
            //{
            //    bunifuImageButton1.Image = Properties.Resources.checkout_white;
            //    Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            //    t.add(searchbox, "Height", 154);
            //    t.run();
            //}
        }

        private void dg_supp_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dg_supp.RowCount != 0)
            {
                dg_supp.Rows[0].Selected = true;
            }
        }

        private void dg_supp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dg_supp.Rows[e.RowIndex].Selected = true;

            }
        }

        private void dg_supp_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    row_main_selected = e.RowIndex;
                    dg_supp.Rows[e.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dg_supp, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Stat = 1;
            Load_Data_Supp();
        }

        private void btnresetsearch_Click(object sender, EventArgs e)
        {
            Stat = 0;
            txt_suppname.Text = "";
            Load_Data_Supp();
        }

        private void btn_add_supplier_Click(object sender, EventArgs e)
        {
            FormAddSupplier supp = new FormAddSupplier("add",0);
            supp.RefreshDgv += new FormAddSupplier.DoEvent(Load_Data_Supp);
            supp.ShowDialog();
        }

        private void dg_supp_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dg_supp.SelectedRows)
            {
                id = int.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void EditSupplier_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                FormAddSupplier supp = new FormAddSupplier("edit", id);
                supp.RefreshDgv += new FormAddSupplier.DoEvent(Load_Data_Supp);
                supp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Silahkan Pilih Data Terlebih Dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
              DialogResult dr= MessageBox.Show("Anda akan Menghapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    var delete = Point_Of_SalesEntities.PSuppliers.Where(x => x.Supplier_id == id).First();
                    delete.deleted_by = Properties.Settings.Default._userID;
                    delete.deleted_date = DateTime.Today;
                    delete.is_deleted = true;
                    int affected = Point_Of_SalesEntities.SaveChanges();
                    if (affected > 0)
                    {
                        MessageBox.Show("Data Berhasil Di Hapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_Data_Supp();
                    }
                }
            


                
            }
            catch (Exception q)
            {

                MessageBox.Show(q.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
