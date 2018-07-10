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
        int indexdetail = 0;
        int AffectedRows = 0;
        int ID_Po = 0;
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
                var user = Point_Of_SalesEntities.Set<TPayable>();
                user.Add(new TPayable
                {
                    Tahun = Convert.ToInt32(txt_tahun.Text),
                    Bulan = cb_month.selectedIndex+1,
                    created_date = DateTime.Now,
                    created_by = Properties.Settings.Default._userID,
                    NominalBeban= txt_nominal.Value,
                    Coa = Convert.ToInt32(txt_coa_id.Text == "" ? "0" : txt_coa_id.Text),
                    is_deleted = false,
                    
                });
                AffectedRows = Point_Of_SalesEntities.SaveChanges();
                if (AffectedRows > 0)
                {

                    MessageBox.Show("Sukses Input Beban", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
