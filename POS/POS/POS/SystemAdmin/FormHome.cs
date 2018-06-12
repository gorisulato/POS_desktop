﻿using POS.DB;
using POS.Purchasing;
using POS.Receiving;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace POS.SystemAdmin
{
    public partial class FormHome : Form
    {
        int AffectedRows = 0;
        string Filename = "";
        List<PUserImage> list;
        Notification_Form n = null;
        POS_Entities Point_Of_SalesEntities;
        UtilityClass Util = new UtilityClass();
        public FormHome()
        {
            InitializeComponent();
        }

        #region Load
        public void Load_Notif()
        {
            Notification_Form n = new Notification_Form();
            int countrecords = n.count();
            if (countrecords > Properties.Settings.Default.notif_count)
            {
                btn_notif.Image = Properties.Resources.Notification_48px;
            }
            else
            {
                btn_notif.Image = Properties.Resources.Notification_white;
            }
            Properties.Settings.Default.notif_count = countrecords;
            Properties.Settings.Default.Save();
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            timer1.Start();
            Set_SafetyStock();
            Load_Image();
            check_Method();



        }
        #endregion

        #region btnclick
        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Anda Yakin Keluar Aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SalesList_Click(object sender, EventArgs e)
        {
            sales_list slist = new sales_list();
            slist.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Anda Yakin Akan Log Off? , Mohon Pastikan Semua Transaksi SUdah Tersimpan Sebelumnya", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                FormLogin fl = new FormLogin();
                fl.Show();
                this.Close();
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "FormLogin")
                    {
                        Application.OpenForms[i].Close();
                    }

                }
            }



        }



        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            FormADDSales sl = new FormADDSales("cashier");
            sl.ShowDialog();
        }

        private void btn_expandsubmenusales_Click(object sender, EventArgs e)
        {

            if (panel_sales.Height == 133)
            {

                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(panel_sales, "Height", 10);
                t.run();
                btn_expandsubmenusales.Image = Properties.Resources.chevron_white;
            }
            else
            {

                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(panel_sales, "Height", 133);
                t.run();
                btn_expandsubmenusales.Image = Properties.Resources.unexpand;
            }
        }

        private void btn_saleslist_Click(object sender, EventArgs e)
        {

            //sl.Show();
            if (su == null)
            {
                su = new sales_list();
                su.FormClosed += delegate { su = null; };
                su.RefreshDgv += new sales_list.DoEvent(setsu);
                su.Show();
            }
            else
            {
                su.WindowState = FormWindowState.Normal;
                su.Focus();
            }



        }

        private void btn_po_Click(object sender, EventArgs e)
        {
            if (purchase == null)
            {
                purchase = new PurchaseOrder();
                purchase.FormClosed += delegate { purchase = null; };
                purchase.RefreshDgv += new PurchaseOrder.DoEvent(updatepo);
                purchase.Show();
            }
            else
            {
                purchase.WindowState = FormWindowState.Normal;
                purchase.Focus();
            }
        }

        private void btn_expandpembelian_Click(object sender, EventArgs e)
        {

            if (panel_pembelian.Height == 133)
            {

                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(panel_pembelian, "Height", 10);
                t.run();
                btn_expandpembelian.Image = Properties.Resources.chevron_white;
            }
            else
            {

                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(panel_pembelian, "Height", 133);
                t.run();
                btn_expandpembelian.Image = Properties.Resources.unexpand;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (panel_pembelian.Height == 133)
            {

                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(panel_pembelian, "Height", 10);
                t.run();
                btn_expandpembelian.Image = Properties.Resources.chevron_white;
            }
            else
            {

                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(panel_pembelian, "Height", 133);
                t.run();
                btn_expandpembelian.Image = Properties.Resources.unexpand;
            }
        }
        private void btn_notif_Click(object sender, EventArgs e)
        {
            //= new Notification_Form(); 
            if (n == null)
            {
                //su = new sales_list();
                //su.FormClosed += delegate { su = null; };
                //su.RefreshDgv += new sales_list.DoEvent(setsu);
                //su.Show();

                n = new Notification_Form();
                n.RefreshDgv += new Notification_Form.DoEvent(setnullnotif);
                n.Show(this);

                btn_notif.Image = Properties.Resources.Notification_white;
            }
            else
            {
                n.WindowState = FormWindowState.Normal;
                n.Focus();
            }



        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            if (panel_burger.Width == 200)
            {

                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(panel_burger, "Width", 0);
                t.run();

            }
            else
            {

                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(panel_burger, "Width", 200);
                t.run();

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            if (panel_sales.Height == 133)
            {

                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(panel_sales, "Height", 10);
                t.run();
                btn_expandsubmenusales.Image = Properties.Resources.chevron_white;
            }
            else
            {

                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(panel_sales, "Height", 133);
                t.run();
                btn_expandsubmenusales.Image = Properties.Resources.unexpand;
            }
        }
        #endregion


        #region methods
        public void check_Method()
        {
            Notification_Form n = new Notification_Form();
            int countrecords = n.count();
            if (countrecords > 0)
            {
                btn_notif.Image = Properties.Resources.Notification_48px;
            }
            else
            {
                btn_notif.Image = Properties.Resources.Notification_white;
            }
            Properties.Settings.Default.notif_count = countrecords;
            Properties.Settings.Default.Save();
        }


        public void Set_SafetyStock()
        {
            try
            {
                var start = DateTime.Now.AddDays(1);
                var enddays = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                var endcount = DateTime.DaysInMonth(start.Year, start.Month);
                var end = start.AddDays(endcount - 1);

                var _sessions = Properties.Settings.Default;
                int UserId = (int)_sessions._userID;
                var Inventory = Point_Of_SalesEntities.TInventories.Where(x => x.is_deleted == false).ToList();
                var invenarray = Inventory.Select(x => new
                {

                    x.Items_Id
                }).ToArray();

                var safety = Point_Of_SalesEntities.TSafetyStocks.FirstOrDefault();
                var a = DateTime.Now;
                if (safety != null)
                {

                    a = safety.safetystockDateStart;
                }

                if (DateTime.Now.Day == enddays && a.Date < start.Date)
                {
                    for (int i = 0; i < invenarray.Length; i++)
                    {
                        if (Util.OpenConnection())
                        {



                            Util.command.Parameters.Clear();

                            Util.command.CommandType = CommandType.StoredProcedure;
                            Util.command.CommandText = "[SetSafetyStock]";
                            Util.command.Connection = Util.connection;
                            Util.command.Parameters.AddWithValue("@itemsId", invenarray[i].Items_Id);
                            Util.command.Parameters.AddWithValue("@month", DateTime.Now.Month);
                            Util.command.Parameters.AddWithValue("@user", UserId);
                            Util.command.Parameters.AddWithValue("@start", start);
                            Util.command.Parameters.AddWithValue("@end", end.Date);

                            Util.dtreader = Util.command.ExecuteReader();



                            Util.dtreader.Close();
                            Util.connection.Close();
                        }
                    }
                }

                _sessions.last_safetystock_updated = DateTime.Now.Date;
                _sessions.Save();


            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(), "Error Seting Safety Stock, Harap Periksa Data dan Cek Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        sales_list su;
        PurchaseOrder purchase;
        public void setsu()
        {
            su = null;
        }
        void updatepo()
        {
            purchase = null;
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_receive_Click(object sender, EventArgs e)
        {
            ReceivingList rc = new ReceivingList();
            rc.Show(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Load_Notif();

        }
        public void setnullnotif()
        {
            n = null;
        }

        #endregion

        #region image processing

        private void pp_user_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Filename = ofd.FileName;
                    pp_user.Image = Image.FromFile(Filename);
                    saveimage();

                }
            }
        }
        public async void saveimage()
        {
            try
            {
                var imagesread = Point_Of_SalesEntities.PUserImages.Where(x => x.user_id == Properties.Settings.Default._userID).Count();


                string[] words = Filename.Split('\\');

                if (imagesread == 0)
                {
                    var podetail = Point_Of_SalesEntities.Set<PUserImage>();
                    podetail.Add(new PUserImage
                    {
                        user_id = Properties.Settings.Default._userID,
                        Filename = words[words.Length - 1],
                        Image = convertimagetoarray(pp_user.Image)


                    });
                }

                if (imagesread > 0)
                {
                    var image = Point_Of_SalesEntities.PUserImages.Where(x => x.user_id == Properties.Settings.Default._userID).First();
                    image.Image = convertimagetoarray(pp_user.Image);
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
            var image = Point_Of_SalesEntities.PUserImages.Where(x => x.user_id == Properties.Settings.Default._userID).FirstOrDefault();
            if (image != null)
            {
                pp_user.Image = convertbinarytoimage(image.Image);
            }

            else
            {
                pp_user.Image = Properties.Resources.Question_Mark_48px;
            }

            var user = (from u in Point_Of_SalesEntities.TUsers
                        from r in Point_Of_SalesEntities.TRoles.Where(x => x.Role_id == u.Role_id).DefaultIfEmpty()
                        select new { GCF = u, r = r.Role_Name }).Where(s => s.GCF.is_deleted == false && s.GCF.User_id == _sessions._userID).FirstOrDefault();

            lbl_content_username.Text = user.GCF.Username;
            lbl_contentuserrole.Text = user.r;
            var host = Dns.GetHostEntry(Dns.GetHostName());
            lbl_contentipaddress.Text = host.AddressList[1].ToString();
        }
        #endregion



    }
}
