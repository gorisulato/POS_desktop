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

namespace POS.Master.Inventory
{
    public partial class FormAddInventory : Form
    {
        int AffectedRows = 0;
        public delegate void DoEvent();
        public event DoEvent RefreshDgv;
        POS_Entities Point_Of_SalesEntities;
        int id = 0;
        string type1 = "";
        UtilityClass Util = new UtilityClass();

        ThemeStyle ts = new ThemeStyle();
        public FormAddInventory(string type,int id1)
        {
            type1 = type;
            id = id1;
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefreshDgv();
            
        }

        private void FormAddInventory_Load(object sender, EventArgs e)
        {
            ts._primaryButton(btn_exit);
            ts._primaryButton(btn_save);
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            var popu = Point_Of_SalesEntities.P_Colour.ToList();

            var populate = popu.ToArray();

           // ComboboxItem item = new ComboboxItem();
            //item.Text = "Item text1";
            //item.Value = 12;

            for (int i = 0; i < populate.Length; i++)
            {
                cb_warna.AddItem(populate[i].Description);
                cb_idwarna.AddItem(populate[i].clor_id.ToString());
            }


            var tes = populate.Select(x => x.clor_id).ToArray();
            

            if (type1 != "add")
            {
                var inventory = Point_Of_SalesEntities.TInventories.Where(x => x.Items_Id == id).First();
                txt_KodeBarang.Text = inventory.Items_number;
                txt_itemname.Text = inventory.Items_Name;
                txt_size.Value =int.Parse(inventory.Size.ToString());
                txt_stock.Text = inventory.Stock.ToString();
                txt_price.Text = inventory.MarginPrice.ToString();
                int index = Array.IndexOf(tes,inventory.Colour);
                cb_idwarna.selectedIndex= index;
                cb_warna.selectedIndex = index;


            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
               if (type1 == "add")
                {
                    if (this.ValidateChildren())
                    {
                        var user = Point_Of_SalesEntities.Set<TInventory>();
                        user.Add(new TInventory
                        {
                            Items_number = txt_KodeBarang.Text,
                            Items_Name = txt_itemname.Text,
                            Size = txt_size.Value,
                            Stock = 0,
                            MarginPrice = 0,
                            Unit_Price = 0,
                            Colour = int.Parse(cb_idwarna.selectedValue.ToString()),
                            created_by=Properties.Settings.Default._userID,
                            created_date=DateTime.Today,
                            is_deleted=false
                           




                        });
                        AffectedRows = Point_Of_SalesEntities.SaveChanges();
                        if (AffectedRows > 0)
                        {
                            MessageBox.Show("Data Insert SUkses", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                        var update = Point_Of_SalesEntities.TInventories.Where(x => x.Items_Id == id).First();
                        update.Items_number = txt_KodeBarang.Text;
                        update.Items_Name = txt_itemname.Text;
                        update.Size = txt_size.Value;
                        update.modified_by = Properties.Settings.Default._userID;
                        update.modified_on = DateTime.Today;

                        AffectedRows = Point_Of_SalesEntities.SaveChanges();
                        if (AffectedRows > 0)
                        {
                            MessageBox.Show("Update Data Sukses", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    
                    }
                    else
                    {
                        MessageBox.Show(this, "Data Not Complete");
                    }

                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(),"Error Saving /Deleting Data",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void cb_warna_onItemSelected(object sender, EventArgs e)
        {
            cb_idwarna.selectedIndex = cb_warna.selectedIndex;
        }
    }
}
