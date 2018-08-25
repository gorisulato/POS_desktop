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

namespace POS.SystemAdmin
{
    public partial class UserList : Form
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
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            dg_user.MultiSelect = false;
            var user = Properties.Settings.Default._userRolename;
            if (user != "Admin")
            {
                btn_add_sales.Visible = false;
            }
            
            Load_DataUser();
           
        }
        private void Load_DataUser()
        {
            try
            {
                CountRecords();
                dg_user.DataSource = null;
                dg_user.Columns.Clear();

                DataTable dt = new DataTable();


                if (Util.OpenConnection())
                {
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("User Name", typeof(string));
                    dt.Columns.Add("Tanggal Dibuat", typeof(string));
                    dt.Columns.Add("Role", typeof(string));
                  





                    Util.command.Parameters.Clear();

                    Util.command.CommandType = CommandType.StoredProcedure;
                    Util.command.CommandText = "[GetDataUser]";
                    Util.command.Connection = Util.connection;
                    Util.command.Parameters.AddWithValue("@username", txt_usrname.Text);
                    Util.command.Parameters.AddWithValue("@offset", offset_data);
                    Util.command.Parameters.AddWithValue("@user", Properties.Settings.Default._userRolename);
                    Util.command.Parameters.AddWithValue("@userid", Properties.Settings.Default._userID);
                    Util.dtreader = Util.command.ExecuteReader();

                    while (Util.dtreader.Read())
                    {
                        dt.Rows.Add
                            (
                            Util.dtreader[0].ToString(),
                            Util.dtreader[1].ToString(),
                            Util.dtreader[2].ToString(),
                            Util.dtreader[3].ToString()

                            );
                    }
                    dg_user.DataSource = dt;

                    dg_user.Columns[0].Visible = false;

                    Util.dtreader.Close();
                    Util.connection.Close();
                    foreach (DataGridViewRow row in dg_user.Rows)
                    {
                        row.HeaderCell.Value = String.Format("{0}", row.Index + 1);

                    }
                    dg_user.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ze)
            {
                MessageBox.Show(ze.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CountRecords()
        {
            if (Stat == 0)
            {
                if (Properties.Settings.Default._userRolename == "Admin")
                {
                    total_records = Point_Of_SalesEntities.TUsers.Where(x => x.is_deleted == false).Count();
                }
                else
                {
                    total_records = Point_Of_SalesEntities.TUsers.Where(x => x.is_deleted == false &&  x.User_id== Properties.Settings.Default._userID).Count();
                }
                
            }
            else
            {
                int UserId = Properties.Settings.Default._userID;
                string code = txt_usrname.Text == "" ? txt_usrname.Text : txt_usrname.Text.ToUpper();
                if (Properties.Settings.Default._userRolename == "Admin")
                {
                    total_records = Point_Of_SalesEntities.TUsers.ToList().Where(x => x.Username.ToUpper().Contains(code) && x.is_deleted == false).Count();
                }
                else
                {
                    total_records = Point_Of_SalesEntities.TUsers.ToList().Where(x => x.Username.ToUpper().Contains(code) && x.is_deleted == false&&x.User_id==UserId).Count();
                }
                    
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
            Load_DataUser();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            StartPaginationShow = StartPaginationShow - 1;
            offset_data = 25 * (StartPaginationShow - 1);
            Load_DataUser();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            offset_data = 25 * (Convert.ToInt32(total_pages) - 1);
            StartPaginationShow = Convert.ToInt32(total_pages);
            Load_DataUser();
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
            Load_DataUser();
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            Stat = 1;
            offset_data = 0;
            StartPaginationShow = 1;
            Load_DataUser();
        }

        private void btnresetsearch_Click(object sender, EventArgs e)
        {
            Stat = 0;
            offset_data = 0;
            StartPaginationShow = 1;
            txt_usrname.Text = "";
            Load_DataUser();
        }

        private void dg_user_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dg_user.RowCount > 0)
            {
                dg_user.Rows[0].Selected = true;
            }
        }

        private void dg_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dg_user.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dg_user_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    row_main_selected = e.RowIndex;
                    dg_user.Rows[e.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dg_user, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void dg_user_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dg_user.SelectedRows)
            {
                id = int.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void editcustomer_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                FormAddUsers add = new FormAddUsers(id, "Edit", Properties.Settings.Default._userRolename);
                add.RefreshDgv += new FormAddUsers.DoEvent(Load_DataUser);
                add.ShowDialog();
            }
            else
            {
                MessageBox.Show("Harap Pilih Data Yang Akan Di Edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                DialogResult dr = MessageBox.Show("Anda Yakin Menghapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    var delete = Point_Of_SalesEntities.TUsers.Where(x => x.User_id == id).First();
                    delete.is_deleted = true;
                    delete.deleted_by = Properties.Settings.Default._userID;
                    delete.deleted_date = DateTime.Now;
                    int affected = Point_Of_SalesEntities.SaveChanges();
                    if (affected > 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DataUser();
                    }
                }

            }
            else
            {
                MessageBox.Show("Harap Pilih Data Yang Akan Dihapus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_sales_Click(object sender, EventArgs e)
        {

            FormAddUsers add = new FormAddUsers(0, "ADD",Properties.Settings.Default._userRolename);
            add.RefreshDgv += new FormAddUsers.DoEvent(Load_DataUser);
            add.ShowDialog();
        }

        private void contextMenuStrip1_VisibleChanged(object sender, EventArgs e)
        {
          
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            if (Properties.Settings.Default._userRolename != "Admin")
            {
                deleteUserToolStripMenuItem.Visible = false;
            }
        }
    }
    }
