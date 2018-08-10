using POS.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.SystemAdmin
{
    public partial class FormAddUsers : Form
    {
        int flag = 0;
        string u_filename = "";
        int maxid = 0;
        string Filename = "";
        int[] id_role;
        int AffectedRows = 0;
        public delegate void DoEvent();
        public event DoEvent RefreshDgv;
        POS_Entities Point_Of_SalesEntities;
        int id = 0;
        string type = "";
        string admin="";
        UtilityClass Util = new UtilityClass();
        ThemeStyle ts = new ThemeStyle();
        public FormAddUsers(int Id, string Type , string Admin)
        {
            id = Id;
            admin = Admin;
            type = Type;
            InitializeComponent();
        }

        private void FormAddUsers_Load(object sender, EventArgs e)
        {
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            // ts._primaryButton(btn_Batal);
            ts._primaryButton(btn_exit);
            ts._primaryButton(btn_save);
            initcomborole();
            if (type == "ADD")
            {
                lbl_jancuk.Visible = false;
                txt_newPass.Visible = false;
            }
            else
            {
                Load_Image();
                LoadDataUser();
            }
            if (admin == "Admin")
            {
                bunifuCheckbox1.Visible = true;

            }
            else
            {
                bunifuCheckbox1.Visible = true;
            }

            
        }

        private void initcomborole()
        {
            var popu = Point_Of_SalesEntities.TRoles.ToList();

            var populate = popu.ToArray();

            // ComboboxItem item = new ComboboxItem();
            //item.Text = "Item text1";
            //item.Value = 12;

            for (int i = 0; i < populate.Length; i++)
            {
                cb_idrole.AddItem(populate[i].Role_id.ToString());
                cb_role.AddItem(populate[i].Role_Name.ToString());
            }
            id_role = populate.Select(x => x.Role_id).ToArray();

        }
        public void LoadDataUser()
        {
            try
            {
                var usr = Point_Of_SalesEntities.TUsers.Where(x => x.User_id == id).First();
                txt_username.Text = usr.Username;
                txt_password.Text = usr.password;
                bunifuCheckbox1.Checked = usr.is_active;
                int index = Array.IndexOf(id_role, usr.Role_id);
                cb_idrole.selectedIndex = index;
                cb_role.selectedIndex = index;


            }
            catch (Exception x)
            {

                MessageBox.Show(x.ToString(), "error collecting data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    flag = 1;
                    Filename = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(Filename);
                  

                }
            }
        }

        public async void saveimage()
        {
            try
            {
                var imagesread = Point_Of_SalesEntities.PUserImages.Where(x => x.user_id == maxid).Count();


                string[] words = Filename.Split('\\');

                if (imagesread == 0)
                {
                    var podetail = Point_Of_SalesEntities.Set<PUserImage>();
                    podetail.Add(new PUserImage
                    {
                        user_id =maxid,
                        Filename = words[words.Length - 1],
                        Image = convertimagetoarray(pictureBox1.Image)


                    });
                }

                if (imagesread > 0)
                {
                    var image = Point_Of_SalesEntities.PUserImages.Where(x => x.user_id == maxid).First();
                    image.Image = convertimagetoarray(pictureBox1.Image);
                    image.Filename = words[words.Length - 1];
                }


                AffectedRows = await Point_Of_SalesEntities.SaveChangesAsync();
                if (AffectedRows > 0)
                {
                    MessageBox.Show("Gambar Berhasil disimpan/diupdate", "Mengganti profil gambar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString(), "Mengganti profil gambar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        byte[] convertimagetoarray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        Image convertbinarytoimage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {

                return Image.FromStream(ms);
            }
        }
        public void Load_Image()
        {
            var _sessions = Properties.Settings.Default;
            var image = Point_Of_SalesEntities.PUserImages.Where(x => x.user_id == id).FirstOrDefault();
           
            if (image != null)
            {
                pictureBox1.Image = convertbinarytoimage(image.Image);
            }

            else
            {
                pictureBox1.Image = Properties.Resources.Question_Mark_48px;
            }


          
        }

        public string generatePassword()
        {
            string jancuk = "";
            if (type == "ADD")
            {
                jancuk = txt_password.Text;
            }
            else
            {
                jancuk = txt_newPass.Text;
            }
            string Password_hash = string.Join("", MD5.Create().ComputeHash(
                  Encoding.ASCII.GetBytes(jancuk)).Select(s => s.ToString("x2")));
            return Password_hash;
        }
        public int getmaxid()
        {
            var tusermax = Point_Of_SalesEntities.TUsers.Where(x => x.is_deleted == false).ToArray();
            int max = tusermax.Max(x => x.User_id);
            return max;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (type == "ADD")
                {
                    if (this.ValidateChildren())
                    {
                        var user = Point_Of_SalesEntities.Set<TUser>();
                        user.Add(new TUser
                        {
                            Username = txt_username.Text,
                            password = generatePassword(),
                            is_active = bunifuCheckbox1.Checked,
                            created_by = Properties.Settings.Default._userID,
                            created_date = DateTime.Now,
                            is_deleted = false,
                            Role_id = int.Parse(cb_idrole.selectedValue),




                        });
                        AffectedRows = Point_Of_SalesEntities.SaveChanges();
                        if (AffectedRows > 0)
                        {
                            MessageBox.Show("Data Has Been Inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            maxid = getmaxid();
                            saveimage();

                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Data Not Complete");
                    }
                }
                else
                {

                   
                    if (this.ValidateChildren())
                    {
                        var usr = Point_Of_SalesEntities.TUsers.Where(x => x.User_id == id).First();
                         usr.Username= txt_username.Text ;
                        if (txt_newPass.Text != "")
                        {
                            usr.password = generatePassword();
                        }
                        
                        usr.is_active =bunifuCheckbox1.Checked ;
                        usr.Role_id= int.Parse(cb_idrole.selectedValue) ;
                        usr.modified_by = Properties.Settings.Default._userID;
                        usr.modified_on = DateTime.Now;
                        AffectedRows = Point_Of_SalesEntities.SaveChanges();
                        if (AffectedRows > 0)
                        {
                            MessageBox.Show("User Berhasil Di Edit", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            maxid = id;
                            if (flag == 1)
                            {
                                saveimage();
                            }
                            
                        }
                      
                    }
                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefreshDgv();
        }

        private void cb_role_onItemSelected(object sender, EventArgs e)
        {
            cb_idrole.selectedIndex = cb_role.selectedIndex;
        }
    }
}
