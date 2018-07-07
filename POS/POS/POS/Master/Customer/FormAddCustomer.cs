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

namespace POS.Master.Customer
{
    public partial class FormAddCustomer : Form
    {
        int AffectedRows = 0;
        public delegate void DoEvent();
        public event DoEvent RefreshDgv;
        POS_Entities Point_Of_SalesEntities;
        int id = 0;
        string type = "";
        UtilityClass Util = new UtilityClass();
        ThemeStyle ts = new ThemeStyle();
        public FormAddCustomer(int Id,string Type)
        {
            id = Id;
            type = Type;
            InitializeComponent();
        }
        public void LoadDataCustomer()
        {
            try
            {
                var cus = Point_Of_SalesEntities.PCustomers.Where(x => x.id_Customer == id).First();
                txt_membercode.Text = cus.MemberCode;
                txt_cusname.Text = cus.CustomerName;
                txt_alamat.Text = cus.Alamat;
                txt_tempatlahir.Text = cus.TempatLahir;
                txt_point.Value = Convert.ToInt32(cus.PointReward);
                dt_tgllahir.Value = cus.TanggalLahir;

            }
            catch (Exception x)
            {

                MessageBox.Show(x.ToString(), "error collecting data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            ts._primaryButton(btn_Batal);
            ts._primaryButton(btn_exit);
            ts._primaryButton(btn_save);
            if (type == "ADD")
            {
                
            }
            else
            {
                LoadDataCustomer();
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (type == "ADD")
                {
                    var number = Point_Of_SalesEntities.PCustomers.Where(x => x.created_date.Month == DateTime.Today.Month && x.created_date.Year == DateTime.Today.Year).Count();
                    int code = number + 1;
                    string generated = "Cus" + DateTime.Now.Day.ToString("D2") + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() + "/" + code.ToString("D5");


                    if (this.ValidateChildren())
                    {
                        var user = Point_Of_SalesEntities.Set<PCustomer>();
                        user.Add(new PCustomer
                        {
                            MemberCode = generated,
                            CustomerName = txt_cusname.Text,
                            Alamat = txt_alamat.Text,
                            TempatLahir = txt_tempatlahir.Text,
                            TanggalLahir = dt_tgllahir.Value,
                            PointReward = Convert.ToInt32(txt_point.Value),
                            created_by = Properties.Settings.Default._userID,
                            created_date = DateTime.Now,
                            is_deleted = false




                        });
                        AffectedRows = Point_Of_SalesEntities.SaveChanges();
                        if (AffectedRows > 0)
                        {
                            MessageBox.Show("Data Has Been Inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_membercode.Text = generated;

                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Data Not Complete");
                    }
                }
              else
                {
                    var customer = Point_Of_SalesEntities.PCustomers.Where(x => x.MemberCode == txt_membercode.Text).First();
                    customer.CustomerName = txt_cusname.Text;
                    customer.Alamat = txt_alamat.Text;
                    customer.TempatLahir = txt_tempatlahir.Text;
                    customer.TanggalLahir = dt_tgllahir.Value;
                    customer.PointReward = Convert.ToInt32(txt_point.Value);

                    AffectedRows = Point_Of_SalesEntities.SaveChanges();
                    if (AffectedRows > 0)
                    {
                        MessageBox.Show("data Has Been Edited", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(), "Something Happend", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefreshDgv();
        }
    }
}
