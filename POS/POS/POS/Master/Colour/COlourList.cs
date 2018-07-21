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

namespace POS.Master.Colour
{
    public partial class COlourList : Form
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
        public COlourList()
        {
            InitializeComponent();
        }

        private void COlourList_Load(object sender, EventArgs e)
        {
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            style._primaryButton(btnresetsearch);
            style._primaryButton(btn_exit);
            style._primaryButton(btn_add_Colour);
            style._primaryButton(btn_search);

            Load_DataColour();

        }

        public void Load_DataColour()
        {
            try
            {
                CountRecords();
                dg_warna.DataSource = null;
                dg_warna.Columns.Clear();

                DataTable dt = new DataTable();


                if (Util.OpenConnection())
                {
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("Nama Warna", typeof(string));
               





                    Util.command.Parameters.Clear();

                    Util.command.CommandType = CommandType.StoredProcedure;
                    Util.command.CommandText = "[GetColourData]";
                    Util.command.Connection = Util.connection;
                    Util.command.Parameters.AddWithValue("@stat", Stat);
                    Util.command.Parameters.AddWithValue("@name", txt_warna.Text);

                    Util.command.Parameters.AddWithValue("@offset", offset_data);
                    Util.dtreader = Util.command.ExecuteReader();

                    while (Util.dtreader.Read())
                    {
                        dt.Rows.Add
                            (
                            Util.dtreader[0].ToString(),
                            Util.dtreader[1].ToString()
                          



                            );
                    }
                    dg_warna.DataSource = dt;
                    dg_warna.Refresh();
                    dg_warna.Columns[0].Visible = false;

                    Util.dtreader.Close();
                    Util.connection.Close();
                    foreach (DataGridViewRow row in dg_warna.Rows)
                    {
                        row.HeaderCell.Value = String.Format("{0}", row.Index + 1);


                    }
                    foreach (DataGridViewColumn col in dg_warna.Columns)
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
                total_records = Point_Of_SalesEntities.P_Colour.Where(x => x.is_deleted == false).Count();
            }
            else
            {
                string dt = txt_warna.Text == "" ? txt_warna.Text : txt_warna.Text.ToUpper();


                total_records = Point_Of_SalesEntities.P_Colour.ToList().Where(x => x.Description.ToUpper().Contains(dt)&&x.is_deleted==false).Count();
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
            Load_DataColour();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            StartPaginationShow = StartPaginationShow - 1;
            offset_data = 25 * (StartPaginationShow - 1);
            Load_DataColour();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {

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
            Load_DataColour();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Stat = 1;
            Load_DataColour();
        }

        private void btnresetsearch_Click(object sender, EventArgs e)
        {
            Stat = 0;
            Util.ClearTextBoxes(this.Controls);
            Load_DataColour();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.RefreshDgv();
        }

        private void btn_add_Colour_Click(object sender, EventArgs e)
        {
            FormAddColour colour = new FormAddColour("add",0);
            colour.RefreshDgv += new FormAddColour.DoEvent(Load_DataColour);
            colour.ShowDialog(this);
        }

        private void EditWarna_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                FormAddColour colour = new FormAddColour("edit", id);
                colour.RefreshDgv += new FormAddColour.DoEvent(Load_DataColour);
                colour.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Silahkan Pilih Data Terlebih Dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteWarnaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dr= MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (id != 0)
                    {
                        var delete = Point_Of_SalesEntities.P_Colour.Where(x => x.clor_id == id).First();
                        delete.is_deleted = true;
                        delete.deleted_by = Properties.Settings.Default._userID;
                        delete.deleted_date = DateTime.Today;

                        int affected = Point_Of_SalesEntities.SaveChanges();
                        if (affected > 0)
                        {
                            MessageBox.Show("Data BErhasil Dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Load_DataColour();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Silahkan Pilih Data Terlebih Dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dg_warna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                dg_warna.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dg_warna_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dg_warna.RowCount > 0)
            {
                dg_warna.Rows[0].Selected = true;
            }
        }

        private void dg_warna_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    row_main_selected = e.RowIndex;
                    dg_warna.Rows[e.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dg_warna, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void dg_warna_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dg_warna.SelectedRows)
            {
                id = int.Parse(row.Cells[0].Value.ToString());
            }
        }
    }
}
