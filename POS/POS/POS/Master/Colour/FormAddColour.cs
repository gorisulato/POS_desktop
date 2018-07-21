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

namespace POS.Master.Colour
{
    public partial class FormAddColour : Form
    {

        UtilityClass Util = new UtilityClass();
        POS_Entities Point_Of_SalesEntities;
        ThemeStyle style = new ThemeStyle();
        public delegate void DoEvent();
        public event DoEvent RefreshDgv;
        string status = "";
        int index = 0;
        int affectedrows = 0;
        public FormAddColour(string stat, int id)
        {
            status = stat;
            index = id;
            InitializeComponent();
        }

        private void FormAddColour_Load(object sender, EventArgs e)
        {
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            style._primaryButton(btn_exit);
            style._primaryButton(btn_save);
            if (status == "edit")
            {
                var color = Point_Of_SalesEntities.P_Colour.Where(x => x.clor_id == index).First();
                txt_ColourName.Text = color.Description;
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
                        var color = Point_Of_SalesEntities.P_Colour.Where(x => x.clor_id == index).First();
                        color.Description = txt_ColourName.Text;
                        color.modified_by = Properties.Settings.Default._userID;
                        color.modified_on = DateTime.Today;

                        affectedrows = Point_Of_SalesEntities.SaveChanges();
                        if (affectedrows > 0)
                        {
                            MessageBox.Show("Edit Data Berhasil", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {

                        var user = Point_Of_SalesEntities.Set<P_Colour>();
                        user.Add(new P_Colour
                        {
                            Description = txt_ColourName.Text,
                      
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

                MessageBox.Show(z.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefreshDgv();
        }
    }
}
