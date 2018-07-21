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

namespace POS.Tools
{
    public partial class FormInputBeban : Form
    {
        int row_main_selected = 0;
        int AffectedRows = 0;
        int id = 0;
        int statusedit = 0;
        FLOV FormLov;
        public delegate void DoEvent();
        public event DoEvent RefreshDgv;
        string Type = "";
        POS_Entities Point_Of_SalesEntities;
        UtilityClass Util = new UtilityClass();
        ThemeStyle style = new ThemeStyle();
        public FormInputBeban()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Lovcoa_Click(object sender, EventArgs e)
        {
            FLOV FormLov;
            FormLov = new FLOV(this, "P_Coa", txt_coa_show, txt_coa_id, "Nama_COA", new string[] { "Kode_Coa", "Nama_COA", "Id_COA" }, "Nama_COA");
            FormLov.ShowDialog();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_coa_show.Text = "";
            this.txt_coa_id.Text = "";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusedit == 0)
                {
                    var user = Point_Of_SalesEntities.Set<TPayable>();
                    user.Add(new TPayable
                    {
                        Tahun = Convert.ToInt32(txt_tahun.Text),
                        Bulan = cb_month.selectedIndex + 1,
                        created_date = DateTime.Now,
                        created_by = Properties.Settings.Default._userID,
                        NominalBeban = txt_nominal.Value,
                        Coa = Convert.ToInt32(txt_coa_id.Text == "" ? "0" : txt_coa_id.Text),
                        is_deleted = false,

                    });
                    AffectedRows = Point_Of_SalesEntities.SaveChanges();
                    if (AffectedRows > 0)
                    {

                        MessageBox.Show("Sukses Input Beban", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DataBeban();
                        txt_coa_id.Text = "";
                        txt_coa_show.Text = "";
                        txt_nominal.Value = 0;

                    }
                }

                else
                {
                    var edit = Point_Of_SalesEntities.TPayables.Where(x => x.idBeban == id).First();
                    edit.Tahun = Convert.ToInt32(txt_tahun.Text);
                    edit.Bulan = cb_month.selectedIndex + 1;
                    edit.modified_on = DateTime.Now;
                    edit.modified_by = Properties.Settings.Default._userID;
                    edit.NominalBeban = txt_nominal.Value;
                    edit.Coa = Convert.ToInt32(txt_coa_id.Text == "" ? "0" : txt_coa_id.Text);
                    AffectedRows = Point_Of_SalesEntities.SaveChanges();
                    if (AffectedRows > 0)
                    {

                        MessageBox.Show("Sukses Edit Beban", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DataBeban();
                        statusedit = 0;
                        txt_coa_id.Text = "";
                        txt_coa_show.Text = "";
                        txt_nominal.Value = 0;

                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void FormInputBeban_Load(object sender, EventArgs e)
        {
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            style._primaryButton(btn_exit);
            style._primaryButton(bunifuFlatButton1);
           
        }
        public void Load_DataBeban()
        {
            try
            {
                //CountRecords();
                dg_listBeban.DataSource = null;
                dg_listBeban.Columns.Clear();

                DataTable dt = new DataTable();


                if (Util.OpenConnection())
                {
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("Nama Akun", typeof(string));
                    dt.Columns.Add("Nominal", typeof(string));
                 

                    Util.command.Parameters.Clear();

                    Util.command.CommandType = CommandType.StoredProcedure;
                    Util.command.CommandText = "[GetDataBeban]";
                    Util.command.Connection = Util.connection;
                    Util.command.Parameters.AddWithValue("@year", int.Parse(txt_tahun.Text));
                    Util.command.Parameters.AddWithValue("@Month", cb_month.selectedIndex+1);
                   
                    Util.dtreader = Util.command.ExecuteReader();

                    while (Util.dtreader.Read())
                    {
                        dt.Rows.Add
                            (
                            Util.dtreader[0].ToString(),
                            Util.dtreader[1].ToString(),
                            Util.dtreader[2].ToString()
                           



                            );
                    }
                    dg_listBeban.DataSource = dt;
                    dg_listBeban.Refresh();
                    dg_listBeban.Columns[0].Visible = false;

                    Util.dtreader.Close();
                    Util.connection.Close();
                    foreach (DataGridViewRow row in dg_listBeban.Rows)
                    {
                        row.HeaderCell.Value = String.Format("{0}", row.Index + 1);

                    }
                    foreach(DataGridViewColumn col in dg_listBeban.Columns)
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }
                   
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString(), "Error Colecting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_tahun_TextChanged(object sender, EventArgs e)
        {
            if (txt_tahun.Text != "")
            {
                Load_DataBeban();
            }
        }

        private void cb_month_onItemSelected(object sender, EventArgs e)
        {
            if (txt_tahun.Text != "")
            {
                Load_DataBeban();
            }
            
        }

        private void dg_listBeban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dg_listBeban.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dg_listBeban_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dg_listBeban.SelectedRows)
            {
                id = int.Parse(row.Cells[0].Value.ToString());

            }
        }

        private void dg_listBeban_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    row_main_selected = e.RowIndex;
                    dg_listBeban.Rows[e.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dg_listBeban, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void editinventory_Click(object sender, EventArgs e)
        {
            var edit = Point_Of_SalesEntities.TPayables.Where(x => x.idBeban == id).First();
            var coa = Point_Of_SalesEntities.P_Coa.Where(x => x.Id_COA == edit.Coa).First();
            txt_tahun.Text=edit.Tahun.ToString() ;
            cb_month.selectedIndex =Convert.ToInt32(edit.Bulan)-1 ;

            txt_nominal.Value=int.Parse (edit.NominalBeban.ToString()) ;
            txt_coa_id.Text=edit.Coa.ToString() ;
            txt_coa_show.Text = coa.Nama_COA;
            statusedit = 1;

        }

        private void hapusBebanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Anda Yakin Menghapus Data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    var delete= Point_Of_SalesEntities.TPayables.Where(x => x.idBeban == id).First();
                    delete.is_deleted = true;
                    delete.deleted_by = Properties.Settings.Default._userID;
                    delete.deleted_date = DateTime.Today;

                    AffectedRows = Point_Of_SalesEntities.SaveChanges();
                    if (AffectedRows > 0)
                    {

                        MessageBox.Show("Sukses Hapus Beban", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DataBeban();

                    }
                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
