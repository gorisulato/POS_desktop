using POS.DB;
using POS.Purchasing;
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

namespace POS.Purchasing
{
    public partial class FormAddPO : Form
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
        public FormAddPO(string type)
        {
            Type = type;
            InitializeComponent();
        }
        public FormAddPO(string type,int id)
        {
            ID_Po = id;
            Type = type;
            InitializeComponent();
        }


        #region Load Data
        private void FormAddPO_Load(object sender, EventArgs e)
        {
            if (txt_PurchaseNumber.Text!="")
            {
                btn_print.Visible = true;
            }
            else
            {
                btn_print.Visible = false;
            }
                this.KeyPreview = true;
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            dg_po_detail.MultiSelect = false;
            if (Type == "add")
            {
                btn_Batal.Visible = false;
                panel_detail.Visible = false;
                this.Height = 401;
            }
            else
            {
                btn_Batal.Visible = true;
                panel_detail.Visible = true;
                btn_addDetails.Visible = false;
                this.Height = 616;
                LoadPO();
                LoadDetailPO();
            }

        }
        private void LoadPO()
        {
            var PO = Point_Of_SalesEntities.TPurchaseOrders.Where(x => x.PO_id == ID_Po).First();
            var supp = Point_Of_SalesEntities.PSuppliers.Where(x => x.Supplier_id == PO.PSupplierId).First();
            txt_PurchaseNumber.Text = PO.PO_Number;
            dt_purchasedate.Value = PO.PO_date;
            txt_supplier_id.Text = PO.PSupplierId.ToString();
            txt_supplier_show.Text = supp.supplier_name;
        }
        public void LoadDetailPO()
        {
            try
            {

                dg_po_detail.DataSource = null;
                dg_po_detail.Columns.Clear();

                DataTable dt = new DataTable();


                if (Util.OpenConnection())
                {
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("PO Number", typeof(string));
                    dt.Columns.Add("ItemsId", typeof(int));
                    dt.Columns.Add("Items Name", typeof(string));
                    dt.Columns.Add("Size", typeof(string));
                    dt.Columns.Add("Colours", typeof(string));
                    dt.Columns.Add("Items Code", typeof(string));
                    dt.Columns.Add("Qty", typeof(string));


                    Util.command.Parameters.Clear();

                    Util.command.CommandType = CommandType.StoredProcedure;
                    Util.command.CommandText = "[GetDataPODetail]";
                    Util.command.Connection = Util.connection;
                    Util.command.Parameters.AddWithValue("@PONo", txt_PurchaseNumber.Text);

                    Util.dtreader = Util.command.ExecuteReader();

                    while (Util.dtreader.Read())
                    {
                        dt.Rows.Add
                            (
                            Util.dtreader[0],
                            Util.dtreader[1].ToString(),
                            Util.dtreader[2],
                            Util.dtreader[3].ToString(),
                            Util.dtreader[4].ToString(),
                            Util.dtreader[5].ToString(),
                            Util.dtreader[6].ToString(),
                            Util.dtreader[7].ToString()


                            );
                    }
                    dg_po_detail.DataSource = dt;
                    dg_po_detail.Refresh();
                    //dg_po_detail.Columns[0].Visible = false;

                    Util.dtreader.Close();
                    Util.connection.Close();
                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(), "Error Collecting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region click action
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_supplier_id.Text = "0";
            txt_supplier_show.Text = "";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Anda akan Keluar dari pembuatan/edit pembelian?, pastikan semua data sudah tersimpan", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                this.RefreshDgv();
            }
        }

        private void btn_LovSupp_Click(object sender, EventArgs e)
        {
            FormLov = new FLOV(this, "PSupplier", txt_supplier_show, txt_supplier_id, "supplier_name", new string[] { "supplier_address", "supplier_name", "Supplier_id" }, "supplier_name");
            FormLov.ShowDialog();
        }

        private void btn_search_LOV_Click(object sender, EventArgs e)
        {
            FormLov = new FLOV(this, "TInventory", txt_items_show, txt_items_id, "Items_number", new string[] { "Items_number", "Items_Name", "Items_Id" }, "Items_Name");
            FormLov.ShowDialog();
        }
        private void btn_addDetails_Click(object sender, EventArgs e)
        {
            btn_Batal.Visible = true;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(this, "Height", 616);
            t.run();
            panel_detail.Visible = true;
            btn_Batal.Visible = true;
            InsertPO();
            LoadDetailPO();
            btn_addDetails.Visible = false;

        }


        private void btn_search_LOV_Click_1(object sender, EventArgs e)
        {
            FormLov = new FLOV(this, "TInventory", txt_items_show, txt_items_id, "Items_number", new string[] { "Items_number", "Items_Name", "Items_Id" }, "Items_Name");
            FormLov.ShowDialog();
        }

        private void btn_addItems_Click(object sender, EventArgs e)
        {
            AffectedRows = 0;


            insert_salesDetail();

            clear_txtdetail();
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (indexdetail > 0)
            {
                var _sessions = Properties.Settings.Default;
                int UserId = (int)_sessions._userID;
                var itemsid = int.Parse(txt_items_id.Text);
                var editdetail = Point_Of_SalesEntities.TPurchaseOrderDetails.Where(s => s.PODetailId == indexdetail).First();
                editdetail.Items = int.Parse(txt_items_id.Text);
                editdetail.Qty = Convert.ToInt32(txt_qty.Value);
                editdetail.modified_by = UserId;
                editdetail.modified_on = DateTime.Now;
                AffectedRows = Point_Of_SalesEntities.SaveChanges();
                if (AffectedRows > 0)
                {
                    MessageBox.Show("Data Berhasil Di Edit", "Sukses Melakukan Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDetailPO();


                    clear_txtdetail();
                }

            }
            else
            {

                MessageBox.Show("Harap Pilih Data Yang Akan Di Edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dg_po_detail_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_po_detail.SelectedRows)
            {
                indexdetail = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
            if (indexdetail > 0)
            {
                var poedit = (from u in Point_Of_SalesEntities.TPurchaseOrderDetails
                              from inv in Point_Of_SalesEntities.TInventories.Where(x => x.Items_Id == u.Items).DefaultIfEmpty()

                              select new { Purchasedetail = u, inventory = inv }).Where(x => x.Purchasedetail.PODetailId == indexdetail).FirstOrDefault();

                txt_items_id.Text = poedit.inventory.Items_Id.ToString();
                txt_items_show.Text = poedit.inventory.Items_Name;

                txt_qty.Value = Convert.ToDouble(poedit.Purchasedetail.Qty);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (indexdetail > 0)
            {
                var _sessions = Properties.Settings.Default;
                int UserId = (int)_sessions._userID;
                var itemsid = int.Parse(txt_items_id.Text);
                var editdetail = Point_Of_SalesEntities.TPurchaseOrderDetails.Where(s => s.PODetailId == indexdetail).First();
                editdetail.is_deleted = true;
                editdetail.deleted_by = UserId;
                editdetail.deleted_date = DateTime.Now;
                AffectedRows = Point_Of_SalesEntities.SaveChanges();
                if (AffectedRows > 0)
                {
                    MessageBox.Show("Data Berhasil Di Hapus", "Sukses Melakukan Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDetailPO();


                    clear_txtdetail();
                }

            }
            else
            {

                MessageBox.Show("Harap Pilih Data Yang Akan Di Hapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            editpurchase();
        }
        private void btn_Batal_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("anda yakin akan Membatalkan Pembelian?, jika anda membatalkan pembelian maka data pembelian akan terhapus", "Konfirmasi"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                AffectedRows = 0;
                delete_multiple_detail();
                var _sessions = Properties.Settings.Default;
                int UserId = (int)_sessions._userID;
                var PO = Point_Of_SalesEntities.TPurchaseOrders.Where(x => x.PO_Number == txt_PurchaseNumber.Text).First();
                PO.is_deleted = true;
                PO.deleted_by = UserId;
                PO.deleted_date = DateTime.Now;
                AffectedRows = Point_Of_SalesEntities.SaveChanges();
                if (AffectedRows > 0)
                {
                    MessageBox.Show("Pembelian Berhasil Dibatalkan dan dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    this.RefreshDgv();
                }
            }

        }
        #endregion

        #region Methods

        public void InsertPO()
        {
            try
            {
                var _sessions = Properties.Settings.Default;
                int UserId = (int)_sessions._userID;
                var count = (from u in Point_Of_SalesEntities.TPurchaseOrders
                                       .Where(u => u.created_date.Month == DateTime.Now.Month && u.created_date.Year == DateTime.Now.Year && u.created_date.Day == DateTime.Now.Day)

                             select new { Reservation = u }).Count();
                int result = count;
                int code = count + 1;
                string generated = "PO" + DateTime.Now.Day.ToString("D4") + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() + "/" + code.ToString("D5");


                if (this.ValidateChildren())
                {
                    var user = Point_Of_SalesEntities.Set<TPurchaseOrder>();
                    user.Add(new TPurchaseOrder
                    {
                        PO_Number = generated,
                        PO_date = dt_purchasedate.Value,
                        created_date = DateTime.Now,
                        created_by = UserId,
                        status = 0,
                        PSupplierId = Convert.ToInt32(txt_supplier_id.Text == "" ? "0" : txt_supplier_id.Text),
                        is_deleted = false,




                    });
                    AffectedRows = Point_Of_SalesEntities.SaveChanges();
                    if (AffectedRows > 0)
                    {
                        txt_PurchaseNumber.Text = generated;


                    }
                }
                else
                {
                    MessageBox.Show(this, "Data Not Complete");
                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public void insert_salesDetail()
        {
            try
            {
                var _sessions = Properties.Settings.Default;
                int UserId = (int)_sessions._userID;
                var itemsid = int.Parse(txt_items_id.Text);

                var purchase = (from u in Point_Of_SalesEntities.TPurchaseOrders
                                        .Where(u => u.PO_Number == txt_PurchaseNumber.Text)

                                select new { Purchase = u }).FirstOrDefault();

                var count = (from u in Point_Of_SalesEntities.TPurchaseOrderDetails


                             select new { rp = u }).Where(x => x.rp.Items == itemsid && x.rp.PurchaseOrder == purchase.Purchase.PO_id).Count();

                var items = (from u in Point_Of_SalesEntities.TInventories
                             from c in Point_Of_SalesEntities.P_Colour.Where(s => s.clor_id == u.Colour).DefaultIfEmpty()

                             select new { rp = u, col = c }).Where(x => x.rp.Items_Id == itemsid).FirstOrDefault();

                if (count == 0)
                {
                    int unitprice = Convert.ToInt32(items.rp.Unit_Price);
                    if (this.ValidateChildren())
                    {
                        var podetail = Point_Of_SalesEntities.Set<TPurchaseOrderDetail>();
                        podetail.Add(new TPurchaseOrderDetail
                        {
                            PurchaseOrder = purchase.Purchase.PO_id,
                            Items = int.Parse(txt_items_id.Text),
                            Qty = Convert.ToInt32(txt_qty.Value),
                            created_by = UserId,
                            created_date = DateTime.Now,
                            is_deleted = false,
                            differenceqty= Convert.ToInt32(txt_qty.Value)

                        });
                        AffectedRows = Point_Of_SalesEntities.SaveChanges();
                        if (AffectedRows > 0)
                        {
                            MessageBox.Show("Item Pembelian Berhasil Ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        }
                        LoadDetailPO();
                    }
                    else
                    {
                        MessageBox.Show(this, "Data Not Complete");
                    }
                }
                if (count > 0)
                {
                    var podetailupdate = Point_Of_SalesEntities.TPurchaseOrderDetails.Where(x => x.PurchaseOrder == purchase.Purchase.PO_id && x.Items == items.rp.Items_Id).First();
                    podetailupdate.Qty = podetailupdate.Qty + Convert.ToInt32(txt_qty.Value);
                    podetailupdate.modified_by = UserId;
                    podetailupdate.modified_on = DateTime.Now;
                    AffectedRows = Point_Of_SalesEntities.SaveChanges();
                    if (AffectedRows > 0)
                    {
                        MessageBox.Show("Item Pembelian Berhasil Diupdate", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDetailPO();
                    }
                }

            }
            catch (Exception z)
            {

                MessageBox.Show(this, z.ToString());
            }
        }
        private void clear_txtdetail()
        {
            txt_items_id.Text = "";
            txt_items_show.Text = "";
            txt_qty.Value = 0;
        }

        private void FormAddPO_KeyDown(object sender, KeyEventArgs e)
        {
            if (btn_addDetails.Visible == true)
            {
                if (e.KeyCode == Keys.F3)
                {
                    btn_Batal.Visible = true;
                    Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                    t.add(this, "Height", 616);
                    t.run();
                    panel_detail.Visible = true;
                    btn_Batal.Visible = true;
                    InsertPO();
                    LoadDetailPO();
                    btn_addDetails.Visible = false;
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult dr = MessageBox.Show("Anda akan Keluar dari pembuatan/edit pembelian?, pastikan semua data sudah tersimpan", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                    this.RefreshDgv();
                }


            }

        }
        private void editpurchase()
        {
            try
            {
                AffectedRows = 0;
                var _sessions = Properties.Settings.Default;
                int UserId = (int)_sessions._userID;
                var PO = Point_Of_SalesEntities.TPurchaseOrders.Where(x => x.PO_Number == txt_PurchaseNumber.Text).First();
                PO.PSupplierId = int.Parse(txt_supplier_id.Text);
                PO.PO_date = dt_purchasedate.Value;
                PO.modified_by = UserId;
                PO.modified_on = DateTime.Now;
                AffectedRows = Point_Of_SalesEntities.SaveChanges();
                if (AffectedRows > 0)
                {
                    MessageBox.Show("Data Penjualan Berhasil Diedit", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString(), "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void delete_multiple_detail()
        {
            try
            {
                var _sessions = Properties.Settings.Default;
                int UserId = (int)_sessions._userID;
                var PO = Point_Of_SalesEntities.TPurchaseOrders.Where(x => x.PO_Number == txt_PurchaseNumber.Text).First();
                var detail = Point_Of_SalesEntities.TPurchaseOrderDetails.Where(x => x.PurchaseOrder == PO.PO_id).ToList();
                var detail2 = detail.Select(x => new {

                    x.PODetailId

                }).ToArray();

                for (int i = 0; i < detail2.Length; i++)
                {
                    int id = detail2[i].PODetailId;
                    var delete = Point_Of_SalesEntities.TPurchaseOrderDetails.Where(x => x.PODetailId == id).First();
                    delete.is_deleted = true;
                    delete.deleted_by = UserId;
                    delete.deleted_date = DateTime.Now;
                    Point_Of_SalesEntities.SaveChanges();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        #endregion

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            POPrint pr = new POPrint(txt_PurchaseNumber.Text);
            pr.ShowDialog();
        }

        private void txt_PurchaseNumber_TextChanged(object sender, EventArgs e)
        {
            if (txt_PurchaseNumber.Text == "")
            {
                btn_print.Visible = false;
            }
            else
            {
                btn_print.Visible = true;
            }
        }
    }
}
