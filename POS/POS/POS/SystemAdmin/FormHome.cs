using POS.Purchasing;
using POS.Receiving;
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
    public partial class FormHome : Form
    {
     
  
        public FormHome()
        {
            InitializeComponent();
        }

      

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
        public void check_Method()
        {
            Notification_Form n = new Notification_Form() ;
            int countrecords = n.count();
            if (countrecords > 0)
            {
                btn_notif.Image = Properties.Resources.Notification_48px;
            }
            else
            {
                btn_notif.Image = Properties.Resources.Notification_white;
            }
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            timer1.Start();

            //check_Method();



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
            check_Method();
            
        }

        private void btn_notif_Click(object sender, EventArgs e)
        {
            Notification_Form n = new Notification_Form(); 
            n.Show(this);
        }
    }
}
