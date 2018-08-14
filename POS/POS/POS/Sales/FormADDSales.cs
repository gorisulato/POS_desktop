using POS.DB;
using POS.Sales;
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

namespace POS
{
    public partial class FormADDSales : Form
    {
        ThemeStyle style = new ThemeStyle();
        public delegate void DoEvent();
        public event DoEvent RefreshDgv;
        sales_list sl;
        int countrow = 1;
        string type1 = "";
        DBsalesdetail DBSalesData = new DBsalesdetail();
        int salesdetailid = 0;
        int AffectedRows = 0;
        string snumberparam = "";
        POS_Entities Point_Of_SalesEntities;
        UtilityClass Util = new UtilityClass();
        FLOV FormLov;
        public FormADDSales(string type)
        {
            type1 = type;
            InitializeComponent();
        }
        public FormADDSales(string salesno,string type)
        {
            type1 = type;
            snumberparam = salesno;
            InitializeComponent();
        }


        #region LoadData
        public void Load_datadetail()
        {
            try
            {

                string paramsp = "";
                if (type1 == "add")
                {
                    paramsp = txt_salesNumber.Text;
                }
                else
                {
                    paramsp = txt_salesNumber.Text;
                }
                dg_detail.DataSource = null;
                dg_detail.Columns.Clear();

                DataTable dt = new DataTable();


                if (Util.OpenConnection())
                {
                    dt.Columns.Add("ID", typeof(int));
                    dt.Columns.Add("Sales ID", typeof(int));
                    dt.Columns.Add("Items ID", typeof(int));
                    dt.Columns.Add("Sales Number", typeof(string));
                    dt.Columns.Add("Items Name", typeof(string));
                    dt.Columns.Add("Items Color", typeof(string));
                    dt.Columns.Add("Size", typeof(float));
                    dt.Columns.Add("Qty", typeof(float));
                    dt.Columns.Add("Unit Price", typeof(float));
                    dt.Columns.Add("Discount", typeof(float));
                    dt.Columns.Add("Subtotal", typeof(float));



                    Util.command.Parameters.Clear();

                    Util.command.CommandType = CommandType.StoredProcedure;
                    Util.command.CommandText = "[T_GetDataSalesDetail]";
                    Util.command.Connection = Util.connection;
                    Util.command.Parameters.AddWithValue("@salesNumber", paramsp);

                    Util.dtreader = Util.command.ExecuteReader();

                    while (Util.dtreader.Read())
                    {
                        dt.Rows.Add
                            (
                            Util.dtreader[0].ToString(),
                            Util.dtreader[1].ToString(),
                            Util.dtreader[2].ToString(),
                            Util.dtreader[3].ToString(),
                            Util.dtreader[4].ToString(),
                            Util.dtreader[5].ToString(),
                            Util.dtreader[6].ToString(),
                            Util.dtreader[7].ToString(),
                           Util.dtreader[8].ToString(),
                           Util.dtreader[9].ToString(),
                           Util.dtreader[10].ToString()


                            );
                    }
                    dg_detail.DataSource = dt;
                    dg_detail.Refresh();
                    dg_detail.Columns[0].Visible = false;
                     dg_detail.Columns[1].Visible = false;
                    dg_detail.Columns[2].Visible = false;
                    Util.dtreader.Close();
                    Util.connection.Close();



                }
            }
            catch (Exception d)
            {

                MessageBox.Show("", d.ToString(), MessageBoxButtons.OK);
            }
        }
        private void FormADDSales_Load(object sender, EventArgs e)
        {
            style._primaryButton(btn_print);
            style._primaryButton(btn_addDetails);
            style._primaryButton(btn_addItems);
            style._primaryButton(btn_Batal);
            style._primaryButton(btn_delete);
            style._primaryButton(btn_edit);
            style._primaryButton(btn_exit);
            style._primaryButton(btn_pay);
            style._primaryButton(btn_update_master);
            style._primaryButton(btn_search_LOV);

            txt_cardno.Enabled = false;
            txt_approvalcode.Enabled = false;
            dt_salesdate.Value = DateTime.Now;
            dg_detail.MultiSelect = false;
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            if (type1 == "add"||type1== "cashier")
            {
                lbl_payment.Text = "Rp" + " " + string.Format("{0:n}", 0);
                lbl_change.Text = "Rp" + " " + string.Format("{0:n}", 0);
                btn_Batal.Visible = false;

                Detail.Visible = false;
                this.Height = 491;
                Load_datadetail();
                LoadPaymentType();
            }
            else
            {
                LoadPaymentType();
                var pt = 0;
                var loadsales = Point_Of_SalesEntities.TSales.Where(x => x.Sales_Number == snumberparam).First();
                var loadcust = Point_Of_SalesEntities.PCustomers.Where(x => x.id_Customer == loadsales.Customer).DefaultIfEmpty().First();
                if (loadsales.PaymentType == 1)
                {
                    pt = 0;
                }
                if (loadsales.PaymentType == 2)
                {
                    pt = 1;
                }
                if (loadsales.PaymentType == 3)
                {
                    pt = 2;
                }
                if (loadsales.PaymentType == 4)
                {
                    pt = 3;
                }
                txt_salesNumber.Text = loadsales.Sales_Number;
                dt_salesdate.Value = loadsales.SalesDate;
                txt_customer_id.Text = loadsales.Customer.ToString();
                txt_customer_show.Text = loadsales.Customer == 0?"":loadcust.CustomerName;
                cb_idpayment.selectedIndex = pt;
                cb_paymentType.selectedIndex = pt;
                txt_approvalcode.Text = loadsales.Approval_No;
                txt_cardno.Text = loadsales.Card_no;
                txt_sales_discount.Value = Convert.ToDouble(loadsales.Discount);
                total_sales.Text = loadsales.TotalSales.ToString();
                lbl_payment.Text = "Rp" + " " + string.Format("{0:n}", loadsales.TotalSales);
                lbl_change.Text = "Rp" + " " + string.Format("{0:n}", loadsales.Change);
                var z = loadsales.PaymentAmount != 0 ? loadsales.PaymentAmount : 0;
                txt_paymentamount.Text = z.ToString();
                txt_change.Text = loadsales.Change.ToString();
                btn_Batal.Visible = true;
                btn_addDetails.Visible = false;
                Detail.Visible = true;
                this.Height = 788;
                Load_datadetail();
            }

        }
        public void LoadPaymentType()
        {
            string[] pt = null;
            string[] ptid = null;
            var list = (from u in Point_Of_SalesEntities.PPaymentTypes
                        select new { GCF = u });


            var list2 = list.Select(x => new
            {

                x.GCF.id_paymenttype,
                x.GCF.description
            }).ToList();


            var pc = list2.ToArray();

            for (int i = 0; i < pc.Length; i++)
            {
                //pt[i] = pc[i].description;
                //ptid[i] = pc[i].id_paymenttype;

                cb_idpayment.AddItem(pc[i].id_paymenttype.ToString());
                cb_paymentType.AddItem(pc[i].description);
                //cb_paymentType
            }
            cb_paymentType.selectedIndex = 0;
        }

        #endregion

        #region action Method
        public void cetakfaktur()
        {
            InvoiceViewer iv = new InvoiceViewer(txt_salesNumber.Text);
            iv.ShowDialog();
        }
        public void clear_txtdetail()
        {
            txt_items_id.Text = "";
            txt_items_show.Text = "";
            txt_discount.Value = 0;
            txt_qty.Value = 0;
        }
        public void update_sales()
        {
            var sales = Point_Of_SalesEntities.TSales.Where(s => s.Sales_Number == txt_salesNumber.Text).First();
            var sd = (from u in Point_Of_SalesEntities.TSalesDetails

                      select new { rp = u }).Where(x => x.rp.Sales_Number == sales.TSales_id&&x.rp.is_deleted==false);

            var sd2 = sd.Select(x => new
            {
                x.rp.Subtotal

            }).ToList();
            var sum = Convert.ToInt32(sd2.Sum(s => s.Subtotal)) - (Convert.ToInt32(sd2.Sum(s => s.Subtotal)) * txt_sales_discount.Value / 100);

            sales.Customer = int.Parse(txt_customer_id.Text==""?"0": txt_customer_id.Text);
            sales.PaymentType = int.Parse(cb_idpayment.selectedValue);
            sales.Card_no = txt_cardno.Text;
            sales.Approval_No = txt_approvalcode.Text;
            sales.Discount = txt_sales_discount.Value;
            sales.TotalSales = sum;
            sales.StatusSales = 0;


            lbl_payment.Text = "Rp" + " " + string.Format("{0:n}", sum);
            AffectedRows= Point_Of_SalesEntities.SaveChanges();
            if (AffectedRows > 0)
            {
                MessageBox.Show("Data Penjualan Berhasil Diperbaharui", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            total_sales.Text = sum.ToString();

        }
        public void insert_sales()
        {
            try
            {
                var count = (from u in Point_Of_SalesEntities.TSales
                                       .Where(u => u.CreatedDate.Month == DateTime.Now.Month && u.CreatedDate.Year == DateTime.Now.Year && u.CreatedDate.Day == DateTime.Now.Day)

                             select new { Reservation = u }).Count();
                int result = count;
                int code = count + 1;
                string generated = "Sales" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() + "/" + code.ToString("D5");


                if (this.ValidateChildren())
                {
                    var user = Point_Of_SalesEntities.Set<TSale>();
                    user.Add(new TSale
                    {
                        Sales_Number = generated,
                        SalesDate = dt_salesdate.Value,
                        CreatedDate = DateTime.Now,
                        TotalSales = 0,
                        Discount = txt_sales_discount.Value,
                        Customer = Convert.ToInt32(txt_customer_id.Text==""?"0":txt_customer_id.Text),
                        PaymentType = Convert.ToInt32(cb_idpayment.selectedValue),
                        PaymentAmount = 0,
                        Change = 0,
                        StatusSales = 0,
                        created_by=Properties.Settings.Default._userID,
                        created_date=DateTime.Now,
                        is_deleted=false,
                        Card_no=txt_cardno.Text,
                        Approval_No=txt_approvalcode.Text




                    });
                    AffectedRows = Point_Of_SalesEntities.SaveChanges();
                    if (AffectedRows > 0)
                    {
                        txt_salesNumber.Text = generated;


                    }
                }
                else
                {
                    MessageBox.Show(this, "Data Not Complete");
                }
            }
            catch (Exception z)
            {

                MessageBox.Show("Data Not Complete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update_stock(string method)
        {
            try
            {
                var itemsid = int.Parse(txt_items_id.Text);

                var stock = Point_Of_SalesEntities.TInventories.Where(x => x.Items_Id == itemsid).First();
                if (method == "add")
                {
                 
                    stock.Stock = Convert.ToInt32(stock.Stock - txt_qty.Value);
                    Point_Of_SalesEntities.SaveChanges();
                }

                if (method == "delete")
                {
                    stock.Stock =stock.Stock+ Convert.ToInt32(txt_qty.Value);
                    Point_Of_SalesEntities.SaveChanges();
                }

                if (method == "edit")
                {
                    var sales= Point_Of_SalesEntities.TSales.Where(x => x.Sales_Number == txt_salesNumber.Text).First();
                    var salesdetail = Point_Of_SalesEntities.TSalesDetails.Where(x => x.Sales_Number == sales.TSales_id && x.Items == itemsid).First();
                  
                        stock.Stock = stock.Stock+salesdetail.Qty-Convert.ToInt32(txt_qty.Value);
                    Point_Of_SalesEntities.SaveChanges();
                    

                }
               
            }
            catch (Exception z)
            {

                throw;
            }
          
        }
        public void insert_salesDetail()
        {
            try
            {

                var itemsid = int.Parse(txt_items_id.Text);

                var sales = (from u in Point_Of_SalesEntities.TSales
                                        .Where(u => u.Sales_Number == txt_salesNumber.Text)

                             select new { sales = u }).FirstOrDefault();

                var count = (from u in Point_Of_SalesEntities.TSalesDetails


                             select new { rp = u }).Where(x => x.rp.Items == itemsid && x.rp.Sales_Number == sales.sales.TSales_id).Count();

                var items = (from u in Point_Of_SalesEntities.TInventories
                             from c in Point_Of_SalesEntities.P_Colour.Where(s => s.clor_id == u.Colour).DefaultIfEmpty()

                             select new { rp = u, col = c }).Where(x => x.rp.Items_Id == itemsid).FirstOrDefault();

                if (count == 0)
                {
                    int unitprice = Convert.ToInt32(items.rp.MarginPrice);
                    if (this.ValidateChildren())
                    {
                        if (items.rp.Stock >= txt_qty.Value)
                        {
                            var user = Point_Of_SalesEntities.Set<TSalesDetail>();
                            user.Add(new TSalesDetail
                            {
                                Sales_Number = sales.sales.TSales_id,
                                Items = int.Parse(txt_items_id.Text),
                                Qty = Convert.ToInt32(txt_qty.Value),
                                Price = unitprice,
                                Discount = txt_discount.Value,
                                Subtotal = (unitprice - (unitprice * txt_discount.Value / 100)) * txt_qty.Value,
                                created_by = Properties.Settings.Default._userID,
                                created_date = DateTime.Now,
                                is_deleted = false

                            });
                            AffectedRows = Point_Of_SalesEntities.SaveChanges();
                            if (AffectedRows > 0)
                            {
                                MessageBox.Show("Data Has Been Inserted", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                update_stock("add");


                            }
                            Load_datadetail();
                        }
                        else
                        {
                            MessageBox.Show("Qty Pembelian Melebihi Stock Yang ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show(this, "Data Not Complete");
                    }

                }
                if (count > 0)
                {
                    if (items.rp.Stock >= txt_qty.Value)
                    {
                        var salesdetailupdate = Point_Of_SalesEntities.TSalesDetails.Where(x => x.Sales_Number == sales.sales.TSales_id && x.Items == items.rp.Items_Id).First();
                        salesdetailupdate.Qty = salesdetailupdate.Qty + Convert.ToInt32(txt_qty.Value);
                        salesdetailupdate.Discount = salesdetailupdate.Discount + txt_discount.Value;
                        salesdetailupdate.Subtotal = salesdetailupdate.Subtotal + (txt_qty.Value * (salesdetailupdate.Price - (salesdetailupdate.Price * (txt_discount.Value + salesdetailupdate.Discount) / 100)));
                        AffectedRows = Point_Of_SalesEntities.SaveChanges();
                        if (AffectedRows > 0)
                        {
                            MessageBox.Show("Item Penjualan Berhasil Diupdate", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Load_datadetail();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Qty Pembelian Melebihi Stock Yang ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception z)
            {

                MessageBox.Show(this, z.ToString());
            }
        }
        public void deleteall()
        {
            try
            {
                var sales = Point_Of_SalesEntities.TSales.Where(s => s.Sales_Number == txt_salesNumber.Text).First();
                sales.is_deleted = true;
                sales.deleted_date = DateTime.Now;
                sales.deleted_by = Properties.Settings.Default._userID;

                Point_Of_SalesEntities.SaveChanges();

                //AffectedRows = Point_Of_SalesEntities.SaveChanges();


                if (dg_detail.RowCount > 0)
                {
                    var detail = Point_Of_SalesEntities.TSalesDetails.Where(s => s.Sales_Number == sales.TSales_id).ToList();
                    var detail2 = detail.Select(x => new {

                        x.Sales_Detail_id
                    }).ToArray();

                    for(int i = 0; i < detail2.Length; i++)
                    {
                        var detailid =Convert.ToInt32( detail2[i].Sales_Detail_id);
                        var detaildeleted = Point_Of_SalesEntities.TSalesDetails.Where(s => s.Sales_Detail_id == detailid).First();
                        detaildeleted.is_deleted = true;
                        detaildeleted.deleted_by = Properties.Settings.Default._userID;
                        detaildeleted.deleted_date = DateTime.Now;
                        Point_Of_SalesEntities.SaveChanges();
                    }
                  
                    Point_Of_SalesEntities.SaveChanges();
                }


                AffectedRows = Point_Of_SalesEntities.SaveChanges();
                if (AffectedRows > 0)
                {
                    MessageBox.Show("Penjualan Dibatalkan", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

            }
            catch (Exception d)
            {

                MessageBox.Show(d.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
        private void cb_paymentType_onItemSelected(object sender, EventArgs e)
        {
            var a = cb_paymentType.selectedIndex;
            cb_idpayment.selectedIndex = a;

            if (cb_paymentType.selectedValue != "Cash")
            {
                txt_cardno.Enabled = true;
                txt_approvalcode.Enabled = true;
            }
            else
            {
                txt_cardno.Enabled = false;
                txt_approvalcode.Enabled = false;
            }
        }


        public void payment()
        {
            try
            {
                var sales = Point_Of_SalesEntities.TSales.Where(s => s.Sales_Number == txt_salesNumber.Text).First();

                sales.PaymentAmount = float.Parse(txt_paymentamount.Text);
                sales.Change = float.Parse(txt_change.Text);
                sales.StatusSales = 1;
                sales.Discount = txt_sales_discount.Value;
                sales.Customer = int.Parse(txt_customer_id.Text==""?"0": txt_customer_id.Text);
                sales.PaymentType = int.Parse(cb_idpayment.selectedValue);

                AffectedRows = Point_Of_SalesEntities.SaveChanges();
                if (AffectedRows > 0)
                {
                    MessageBox.Show("Pembayaran Sukses", "Sukses Melakukan Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                countrow = 1;
            }
            catch (Exception)
            {

                throw;
            }

            //total_sales.Text = sd2.Sum(s => s.Subtotal).ToString();
        }

        private void txt_paymentamount_TextChanged(object sender, EventArgs e)
        {
            //var z= 
            txt_change.Text = (float.Parse(txt_paymentamount.Text==""?"0":txt_paymentamount.Text) - float.Parse(total_sales.Text)).ToString();
            lbl_change.Text = "Rp" + " " + string.Format("{0:n}", float.Parse(txt_change.Text));
        }

        private void dg_detail_SelectionChanged(object sender, EventArgs e)
        {
            if (countrow != 0)
            {
                foreach (DataGridViewRow row in dg_detail.SelectedRows)
                {
                    salesdetailid = int.Parse(row.Cells[0].Value.ToString());
                }


                if (salesdetailid > 0)
                {
                    var salesedit = (from u in Point_Of_SalesEntities.TSalesDetails
                                     from inv in Point_Of_SalesEntities.TInventories.Where(x => x.Items_Id == u.Items).DefaultIfEmpty()

                                     select new { salesdetail = u, inventory = inv }).Where(x => x.salesdetail.Sales_Detail_id == salesdetailid).FirstOrDefault();

                    txt_items_id.Text = salesedit.inventory.Items_Id.ToString();
                    txt_items_show.Text = salesedit.inventory.Items_Name;
                    txt_discount.Value = Convert.ToDouble(salesedit.salesdetail.Discount);
                    txt_qty.Value = Convert.ToDouble(salesedit.salesdetail.Qty);
                }

            }
        }
        #endregion

        #region clickButton
        private void btn_search_LOV_Click(object sender, EventArgs e)
        {
            FormLov = new FLOV(this, "TInventory", txt_items_show, txt_items_id, "Items_number", new string[] { "Items_number", "Items_Name", "Items_Id" }, "Items_Name");
            FormLov.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

            this.Close();
            if(type1!= "cashier")
            {
                this.RefreshDgv();
            }
            

        }

        private void btn_addItems_Click(object sender, EventArgs e)
        {
            AffectedRows = 0;

            countrow = 1;
            insert_salesDetail();
            update_sales();
            clear_txtdetail();
        }
        private void btn_addDetails_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(this, "Height", 750);
            t.run();
            Detail.Visible = true;
            btn_Batal.Visible = true;
            insert_sales();
            btn_addDetails.Visible = false;
            AffectedRows = 0;

        }


        private void btn_Batal_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Anda Yakin Membatalkan Penjualan", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
                t.add(this, "Height", 453);
                t.run();
                Detail.Visible = false;
                btn_Batal.Visible = false;
                btn_addDetails.Visible = true;

                deleteall();

                this.Close();
                this.RefreshDgv();


            }

        }

        private void btn_LovCustomer_Click(object sender, EventArgs e)
        {
            FormLov = new FLOV(this, "PCustomer", txt_customer_show, txt_customer_id, "CustomerName", new string[] { "MemberCode", "CustomerName", "id_Customer" }, "CustomerName");
            FormLov.ShowDialog();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            payment();
            cetakfaktur();
        }



        private void btn_edit_Click(object sender, EventArgs e)
        {
            countrow = 1;
            if (salesdetailid > 0)
            {
                update_stock("edit");
                var editdetail = Point_Of_SalesEntities.TSalesDetails.Where(s => s.Sales_Detail_id == salesdetailid).First();
                editdetail.Items = int.Parse(txt_items_id.Text);
                editdetail.Qty = Convert.ToInt32(txt_qty.Value);
                editdetail.Discount = Convert.ToInt32(txt_discount.Value);
                editdetail.Subtotal = editdetail.Subtotal - (editdetail.Subtotal * txt_discount.Value / 100);
                AffectedRows = Point_Of_SalesEntities.SaveChanges();
                if (AffectedRows > 0)
                {
                    MessageBox.Show("Data Berhasil Di Edit", "Sukses Melakukan Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_datadetail();
                   
                    update_sales();
                    clear_txtdetail();
                }

            }
            else
            {

                MessageBox.Show("Harap Pilih Data Yang Akan Di Edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (salesdetailid > 0)
                {
                    DialogResult dr = MessageBox.Show("Anda Yakin Menghapus Data", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        var editdetail = Point_Of_SalesEntities.TSalesDetails.Where(s => s.Sales_Detail_id == salesdetailid).First();
                        editdetail.is_deleted = true;
                        editdetail.deleted_by = Properties.Settings.Default._userID;
                        editdetail.deleted_date = DateTime.Now;
                        AffectedRows = Point_Of_SalesEntities.SaveChanges();
                        if (AffectedRows > 0)
                        {
                            MessageBox.Show("Data Berhasil Dihapus", "Berhasil Hapus Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            salesdetailid = 0;
                            countrow = 0;
                            dg_detail.ClearSelection();
                            Load_datadetail();
                            update_stock("delete");
                            update_sales();
                            clear_txtdetail();
                            //Load_datadetail();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Harap Pilih Data Yang Akan Dihapus", "Gagal Menemukan Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception a)
            {

                MessageBox.Show(this, a.ToString());
            }


        }

        private void btn_update_master_Click(object sender, EventArgs e)
        {
            update_sales();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_customer_id.Text = "";
            txt_customer_show.Text = "";
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            cetakfaktur();
        }


        #endregion

        private void Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void total_sales_Click(object sender, EventArgs e)
        {

        }
    }
}
