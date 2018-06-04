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

namespace POS.SystemAdmin
{
    public partial class SettingDbForm : Form
    {
        UtilityClass util = new UtilityClass();
        POS_Entities Point_Of_SalesEntities;
        string a, b, c, d;
        public SettingDbForm()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                var Setting = Properties.Settings.Default;
                Setting._databaseName = txt_database_name.Text;//= Setting._databaseName;
                Setting._databaseServer = txt_database_server.Text;// = Setting._databaseServer;
                Setting._databaseUser = txt_database_username.Text;// = Setting._databaseUser;
                Setting._databasePassword = txt_database_password.Text;// = Setting._databasePassword;
                Setting.Save();
                DialogResult dr = MessageBox.Show("Berhasil menyimpan setting database baru, disarankan melakukan tes koneksi dahulu sebelum melakukan login"
                                                , "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
            catch (Exception)
            {

                MessageBox.Show("Maaf Terjadi Kesalahan , silahkan coba beberapa saat lagi","Error Koneksi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void SettingDbForm_Load(object sender, EventArgs e)
        {
            Point_Of_SalesEntities = new DB.POS_Entities(util.CheckDatabaseConnection());
            try
            {
                var Setting = Properties.Settings.Default;
                txt_database_name.Text = Setting._databaseName;
                txt_database_server.Text = Setting._databaseServer;
                txt_database_username.Text = Setting._databaseUser;
                txt_database_password.Text = Setting._databasePassword;
                a= Setting._databaseName;
               b = Setting._databaseServer;
                c = Setting._databaseUser;
               d = Setting._databasePassword;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString());
            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string ret = "";
            try
            {
                var Setting = Properties.Settings.Default;
                Setting._databaseName = txt_database_name.Text;//= Setting._databaseName;
                Setting._databaseServer = txt_database_server.Text;// = Setting._databaseServer;
                Setting._databaseUser = txt_database_username.Text;// = Setting._databaseUser;
                Setting._databasePassword = txt_database_password.Text;// = Setting._databasePassword;
                Point_Of_SalesEntities = new DB.POS_Entities(util.CheckDatabaseConnection());
                
                var testcon = Point_Of_SalesEntities.TUsers.First();

                if (testcon != null)
                {
                    MessageBox.Show("Koneksi Berhasil", "Database ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
             
            }
            catch (Exception)
            {
                ret = "gagal";
                MessageBox.Show("Koneksi gagal silahkan periksa konfigurasi koneksi database. Sementara sistem akan mengembalikan ke setelan awal", "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ret == "gagal")
            {
                var Setting = Properties.Settings.Default;
                txt_database_name.Text = a;
                txt_database_server.Text = b;
                txt_database_username.Text = c;
                txt_database_password.Text = d;
                Setting._databaseName = a;//= Setting._databaseName;
                Setting._databaseServer = b;// = Setting._databaseServer;
                Setting._databaseUser = c;// = Setting._databaseUser;
                Setting._databasePassword = d;// = Setting._databasePassword;
                Setting.Save();
            }
           
        }
    }
}
