using POS.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.SystemAdmin
{
    public partial class FormLogin : Form
    {
        POS_Entities Point_Of_SalesEntities;
        UtilityClass util = new UtilityClass();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            txt_password._TextBox.PasswordChar = '*';
            var _sessions = Properties.Settings.Default;
            if (_sessions.remembered_password != "" || _sessions.remembered_userid != "")
            {
                txt_password.text = _sessions.remembered_password;
                txt_username.text = _sessions.remembered_userid;
            }
            else
            {
                txt_password.text = "";
                txt_username.text = "";
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            Login_Action();
          
        }

        private void Login_Action()
        {
            try
            {
       
                string Username = txt_username.text;
                string Password = txt_password.text;
                Point_Of_SalesEntities = new POS_Entities(util.CheckDatabaseConnection());
                string ret = "success";
                // Get data User 
                var dataUser = (from User in Point_Of_SalesEntities.TUsers
                                from Role in Point_Of_SalesEntities.TRoles.Where(r => r.Role_id == User.Role_id)
                                select new
                                { User = User, Role = Role })
                                .Where(s => s.User.Username == Username)
                                .FirstOrDefault();

                //cek Password & Delete user
                string Password_hash = string.Join("", MD5.Create().ComputeHash(
                   Encoding.ASCII.GetBytes(Password)).Select(s => s.ToString("x2")));

                if (dataUser == null || dataUser.User.password.Trim() != Password_hash || dataUser.User.is_deleted == true)
                {
                    //raiseLoginAttempt(Username);
                    MessageBox.Show("username/password anda salah", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                //cek active
                if (dataUser != null && dataUser.User.is_active == false)
                {
                    // ret = "Please contact your Administrator to Activate your account";
                    MessageBox.Show("Akun anda tidak aktif/terblokir, Silahkan hubungi admin untuk mengaktifkan kembali akun anda", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // raiseLoginAttempt(Username);

                }

                if (dataUser != null && dataUser.User.password.Trim() == Password_hash && dataUser.User.is_deleted == false && dataUser.User.is_active == true)
                {
                    MessageBox.Show("Login Sukses Selamat datang User: " + dataUser.User.Username, "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //register session
                    var _sessions = Properties.Settings.Default;
                    _sessions._username = dataUser.User.Username;
                    _sessions._userID = dataUser.User.User_id;
                    _sessions.password = txt_password.text.Replace(Environment.NewLine, "");

                    _sessions._userRole = dataUser.User.Role_id;
                    _sessions._userRolename = dataUser.Role.Role_Name;
                    if (cb_remember.Checked == true)
                    {
                        _sessions.remembered_password= txt_password.text;
                        _sessions.remembered_userid= txt_username.text ;
                        _sessions.Save();
                    }

                    FormHome fh = new FormHome();
                    fh.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Koneksi gagal silahkan periksa konfigurasi koneksi database", "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_editdb_Click(object sender, EventArgs e)
        {
            SettingDbForm sdb = new SettingDbForm();
            sdb.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Anda Yakin Keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            txt_username.text = txt_username.text.Replace(Environment.NewLine, "");
            txt_password.text = txt_password.text.Replace(Environment.NewLine, "");
            if (e.KeyCode == Keys.Enter)
            {
                
                Login_Action();
               
            }
            if (e.KeyCode == Keys.F2)
            {
                SettingDbForm sd = new SettingDbForm();
                sd.ShowDialog();
            }

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dr = MessageBox.Show("Anda Yakin Keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
           
        }

        private void txt_username_KeyDown(object sender, EventArgs e)
        {

            txt_username.Text = txt_username.Text.Replace(Environment.NewLine, "");
            txt_password.Text = txt_password.Text.Replace(Environment.NewLine, "");
         
        }

        private void txt_password_KeyDown(object sender, EventArgs e)
        {
            txt_username.Text = txt_username.Text.Replace(Environment.NewLine, "");
            txt_password.Text = txt_password.Text.Replace(Environment.NewLine, "");
        }
    }
}
