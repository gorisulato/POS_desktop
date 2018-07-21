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

namespace POS.Master.Supplier
{
    public partial class FormAddSupplier : Form
    {
        UtilityClass Util = new UtilityClass();
        POS_Entities Point_Of_SalesEntities;
        ThemeStyle style = new ThemeStyle();
        public delegate void DoEvent();
        public event DoEvent RefreshDgv;
        string status = "";
        int index=0;
        int affectedrows = 0;
        public FormAddSupplier(string stat,int id)
        {
            status = stat;
            index = id;
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefreshDgv();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormAddSupplier_Load(object sender, EventArgs e)
        {
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            style._primaryButton(btn_exit);
            style._primaryButton(btn_save);
            if (status == "edit")
            {
                var supp = Point_Of_SalesEntities.PSuppliers.Where(x => x.Supplier_id == index).First();
                txt_suppliername.Text = supp.supplier_name;
                txt_alamat.Text = supp.supplier_address;
                txt_phno.Text = supp.phone_number;
                txt_email.Text = supp.email_address;
                txt_cp.Text = supp.contact_Person;
                txt_cpemail.Text = supp.contact_person_email;
                txt_cpphno.Text = supp.Contact_person_phone;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateChildren())
                {
                    if (status == "edit")
                    {
                        var supp = Point_Of_SalesEntities.PSuppliers.Where(x => x.Supplier_id == index).First();
                        supp.supplier_name = txt_suppliername.Text;
                        supp.supplier_address = txt_alamat.Text;
                        supp.phone_number = txt_phno.Text;
                        supp.email_address = txt_email.Text;
                        supp.contact_Person = txt_cp.Text;
                        supp.contact_person_email = txt_cpemail.Text;
                        supp.Contact_person_phone = txt_cpphno.Text;
                        supp.modified_by = Properties.Settings.Default._userID;
                        supp.modified_on = DateTime.Today;
                        affectedrows = Point_Of_SalesEntities.SaveChanges();

                        if (affectedrows > 0)
                        {
                            MessageBox.Show("Edit Data Berhasil", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        var user = Point_Of_SalesEntities.Set<PSupplier>();
                        user.Add(new PSupplier
                        {
                            supplier_name = txt_suppliername.Text,
                            supplier_address = txt_alamat.Text,
                            phone_number = txt_alamat.Text,
                            email_address = txt_phno.Text,
                            contact_Person = txt_cp.Text,
                            contact_person_email = txt_cpemail.Text,
                           Contact_person_phone = txt_cpphno.Text,
                             created_by = Properties.Settings.Default._userID,
                            created_date = DateTime.Now,
                            is_deleted = false




                        });

                        affectedrows = Point_Of_SalesEntities.SaveChanges();
                        if (affectedrows > 0)
                        {
                            MessageBox.Show("Tambah Data Berhasil", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Util.ClearTextBoxes(this.Controls);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Data Not Complete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
