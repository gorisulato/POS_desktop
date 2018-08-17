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

namespace POS.Sales
{
    public partial class FormCashier : Form
    {
        int sum = 0;
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
        public FormCashier(string type)
        {
            type1 = type;
            InitializeComponent();
        }
        public FormCashier(string salesno, string type)
        {
            type1 = type;
            snumberparam = salesno;
            InitializeComponent();
        }

        private void FormCashier_Load(object sender, EventArgs e)
        {
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            style._primaryButton(btn_print);
            style._primaryButton(btn_addItems);
            style._primaryButton(btn_Batal);
            style._primaryButton(btn_exit);
            style._primaryButton(btn_pay);
            style._primaryButton(btn_save);
            txt_sales_discount.Text = "0";
            dg_detail.MultiSelect = false;
            dt_salesdate.Value = DateTime.Now;
            if (type1 == "add" || type1 == "cashier")
            {
                dg_detail.Columns.Add("id", "idbarang");
                dg_detail.Columns.Add("KodeBrg", "Kode Barang");
                dg_detail.Columns.Add("Nama", "Nama Barang");
                dg_detail.Columns.Add("Qty", "Qty");
                dg_detail.Columns.Add("Harga", "Harga Satuan");
                dg_detail.Columns.Add("Subtotal", "Subtotal");
                lbl_payment.Text = "Rp" + " " + string.Format("{0:n}", 0);
                lbl_change.Text = "Rp" + " " + string.Format("{0:n}", 0);
                btn_Batal.Visible = false;
                dg_detail.AllowUserToDeleteRows = true;
                dg_detail.Columns[0].Visible = false;
               
                
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
              
                cb_idpayment.selectedIndex = pt;
                cb_paymentType.selectedIndex = pt;
                txt_approvalcode.Text = loadsales.Approval_No;
                txt_cardno.Text = loadsales.Card_no;
                txt_sales_discount.Text = loadsales.Discount.ToString();
                total_sales.Text = loadsales.TotalSales.ToString();
                lbl_payment.Text = "Rp" + " " + string.Format("{0:n}", loadsales.TotalSales);
                lbl_change.Text = "Rp" + " " + string.Format("{0:n}", loadsales.Change);
                var z = loadsales.PaymentAmount != 0 ? loadsales.PaymentAmount : 0;
                txt_paymentamount.Text = z.ToString();
                txt_change.Text = loadsales.Change.ToString();
                btn_Batal.Visible = true;
               
                Load_datadetail();
            }
        }
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
        public void LoadPaymentType()
        {
        
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

        private void btn_addItems_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_items_id.Text != "")
                {
                int count = 0;
                int index = 0;
                var a = txt_items_id.Text;
                int iditems = Convert.ToInt32(txt_items_id.Text);
                var items = Point_Of_SalesEntities.TInventories.Where(x => x.Items_Id == iditems).First();
               
                    if (dg_detail.RowCount > 0)
                    {
                        for (int i = 0; i < dg_detail.RowCount; i++)
                        {
                            var c = dg_detail.Rows[i].Cells[0].Value.ToString();
                            if (a == c)
                            {
                                count = count + 1;
                                index = i;
                            }

                        }
                        if (count > 0)
                        {
                            dg_detail.Rows[index].Cells[3].Value = (txt_qty.Value + Convert.ToInt32(dg_detail.Rows[index].Cells[3].Value.ToString()));
                            dg_detail.Rows[index].Cells[5].Value = (items.MarginPrice * Convert.ToInt32(dg_detail.Rows[index].Cells[3].Value.ToString()));
                        }
                        else
                        {
                            dg_detail.Rows.Add(txt_items_id.Text, items.Items_number, items.Items_Name, txt_qty.Value, items.MarginPrice, items.MarginPrice * txt_qty.Value);
                        }
                    }
                    else
                    {
                        dg_detail.Rows.Add(txt_items_id.Text, items.Items_number, items.Items_Name, txt_qty.Value, items.MarginPrice, items.MarginPrice * txt_qty.Value);

                    }

                    updateprice();
                }
                else
                {
                    MessageBox.Show("Harap Pilih Item Yang Akan ditambahkan", "Pilih Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }

           
            catch (Exception z)
            {

                MessageBox.Show(z.Message.ToString(), "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
          
        }
        public void updateprice()
        {
            sum = 0;
            for (int i = 0; i < dg_detail.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dg_detail.Rows[i].Cells[5].Value);
            }
            total_sales.Text = sum.ToString();


        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            FormLov = new FLOV(this, "TInventory", txt_items_show, txt_items_id, "Items_number", new string[] { "Items_number", "Items_Name", "Items_Id" }, "Items_Name");
            FormLov.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            if (type1 != "cashier")
            {
                this.RefreshDgv();
            }

        }

        private void total_sales_TextChanged(object sender, EventArgs e)
        {
            var diskon =  (Convert.ToInt32(Convert.ToInt32(total_sales.Text)) * Convert.ToInt32(txt_sales_discount.Text) / 100);
            lbl_payment.Text = "Rp" + " " + string.Format("{0:n}", Convert.ToInt32(total_sales.Text)-diskon);
            txt_payment_afterdiscount.Text = (Convert.ToInt32(total_sales.Text) - diskon).ToString();
        }

        private void txt_sales_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_sales_discount_TextChanged(object sender, EventArgs e)
        {
            if (total_sales.Text != "")
            {
                var diskon = (Convert.ToInt32(Convert.ToInt32(total_sales.Text)) * Convert.ToInt32(txt_sales_discount.Text) / 100);
                lbl_payment.Text = "Rp" + " " + string.Format("{0:n}", Convert.ToInt32(total_sales.Text) - diskon);
                txt_payment_afterdiscount.Text = (Convert.ToInt32(total_sales.Text) - diskon).ToString();
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            payment();
            cetakfaktur();
        }
        public void cetakfaktur()
        {
            InvoiceViewer iv = new InvoiceViewer(txt_salesNumber.Text);
            iv.ShowDialog();
        }
        public void payment()
        {
            try
            {
                if (txt_salesNumber.Text != "")
                {
                    var sales = Point_Of_SalesEntities.TSales.Where(s => s.Sales_Number == txt_salesNumber.Text).First();

                    sales.PaymentAmount = float.Parse(txt_paymentamount.Text);
                    sales.Change = float.Parse(txt_change.Text);
                    sales.StatusSales = 1;
                    sales.Discount = Convert.ToInt32(txt_sales_discount.Text);

                    sales.PaymentType = int.Parse(cb_idpayment.selectedValue);

                    AffectedRows = Point_Of_SalesEntities.SaveChanges();
                    if (AffectedRows > 0)
                    {
                        MessageBox.Show("Pembayaran Sukses", "Sukses Melakukan Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    countrow = 1;
                }
                else
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
                            TotalSales = sum- (Convert.ToInt32(Convert.ToInt32(total_sales.Text)) * Convert.ToInt32(txt_sales_discount.Text) / 100),
                            Discount = Convert.ToInt32(txt_sales_discount.Text),
                            Customer = 0,
                            PaymentType = Convert.ToInt32(cb_idpayment.selectedValue),
                            PaymentAmount = float.Parse(txt_paymentamount.Text),
                            Change = float.Parse(txt_change.Text),
                            StatusSales = 1,
                            created_by = Properties.Settings.Default._userID,
                            created_date = DateTime.Now,
                            is_deleted = false,
                            Card_no = txt_cardno.Text,
                            Approval_No = txt_approvalcode.Text




                        });
                        AffectedRows = Point_Of_SalesEntities.SaveChanges();
                        if (AffectedRows > 0)
                        {
                            
                            txt_salesNumber.Text = generated;
                            if (dg_detail.RowCount > 0)
                            {
                                insertdetail();
                            }
                            


                        }
                    }
                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.Message.ToString(), "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //total_sales.Text = sd2.Sum(s => s.Subtotal).ToString();
        }

        public void insertdetail()
        {
            try
            {
                if (type1 == "add" || type1 == "cashier")
                {
                    if (this.ValidateChildren())
                    {
                        var sales = (from u in Point_Of_SalesEntities.TSales
                                    .Where(u => u.Sales_Number == txt_salesNumber.Text)

                                     select new { sales = u }).FirstOrDefault();


                        for (int i = 0; i < dg_detail.RowCount; i++)
                        {
                            var user = Point_Of_SalesEntities.Set<TSalesDetail>();
                            user.Add(new TSalesDetail
                            {
                                Sales_Number = sales.sales.TSales_id,
                                Items =Convert.ToInt32( dg_detail.Rows[i].Cells[0].Value.ToString()),
                                Qty = Convert.ToInt32(dg_detail.Rows[i].Cells[3].Value.ToString()),
                                Price = Convert.ToInt32(dg_detail.Rows[i].Cells[4].Value.ToString()),
                                Discount = 0,
                                Subtotal = Convert.ToInt32(dg_detail.Rows[i].Cells[5].Value.ToString()),
                                created_by = Properties.Settings.Default._userID,
                                created_date = DateTime.Now,
                                is_deleted = false

                            });
                            AffectedRows = Point_Of_SalesEntities.SaveChanges();
                            if (AffectedRows > 0)
                            {
                                MessageBox.Show("Data Has Been Inserted", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                update_stock("add", Convert.ToInt32(dg_detail.Rows[i].Cells[0].Value.ToString()));


                            }
                        }
                       
                        Load_datadetail();


                    }
                    else
                    {
                        MessageBox.Show(this, "Data Not Complete");
                    }
                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
                
            
        }

        public void update_stock(string method,int id)
        {
            try
            {
                var itemsid = id;

                var stock = Point_Of_SalesEntities.TInventories.Where(x => x.Items_Id == itemsid).First();
                if (method == "add")
                {

                    stock.Stock = Convert.ToInt32(stock.Stock - txt_qty.Value);
                    Point_Of_SalesEntities.SaveChanges();
                }

                if (method == "delete")
                {
                    stock.Stock = stock.Stock + Convert.ToInt32(txt_qty.Value);
                    Point_Of_SalesEntities.SaveChanges();
                }

                if (method == "edit")
                {
                    var sales = Point_Of_SalesEntities.TSales.Where(x => x.Sales_Number == txt_salesNumber.Text).First();
                    var salesdetail = Point_Of_SalesEntities.TSalesDetails.Where(x => x.Sales_Number == sales.TSales_id && x.Items == itemsid).First();

                    stock.Stock = stock.Stock + salesdetail.Qty - Convert.ToInt32(txt_qty.Value);
                    Point_Of_SalesEntities.SaveChanges();


                }

            }
            catch (Exception z)
            {

                throw;
            }

        }

        private void cb_paymentType_onItemSelected(object sender, EventArgs e)
        {
            cb_idpayment.selectedIndex = cb_paymentType.selectedIndex;
        }

        private void txt_paymentamount_TextChanged(object sender, EventArgs e)
        {
            txt_change.Text = (float.Parse(txt_paymentamount.Text == "" ? "0" : txt_paymentamount.Text) - float.Parse(txt_payment_afterdiscount.Text)).ToString();
            lbl_change.Text = "Rp" + " " + string.Format("{0:n}", float.Parse(txt_change.Text));
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            payment();
        }

        private void btn_Batal_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Anda Yakin Membatalkan Penjualan", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
              
              
                btn_Batal.Visible = false;
               

                deleteall();

                this.Close();
                this.RefreshDgv();


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

                    for (int i = 0; i < detail2.Length; i++)
                    {
                        var detailid = Convert.ToInt32(detail2[i].Sales_Detail_id);
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

        private void btn_print_Click(object sender, EventArgs e)
        {
            cetakfaktur();
        }
    }
}
