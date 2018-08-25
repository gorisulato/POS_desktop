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
using Transitions;

namespace POS.Receiving
{
    public partial class FormAddReceiveing : Form
    {
        int insert = 0;
        int changeable = 0;
        int checkeds=0;
        int status = 0;
        int indexdetail = 0;
        int AffectedRows = 0;
        int ID_RC = 0;
        FLOV FormLov;
        public delegate void DoEvent();
        public event DoEvent RefreshDgv;
        string Type = "";
        POS_Entities Point_Of_SalesEntities;
        UtilityClass Util = new UtilityClass();
        public FormAddReceiveing(string type)
        {
            Type = type;
            InitializeComponent();
        }

        public FormAddReceiveing(string type,int id)
        {
            Type = type;
            ID_RC = id;
            InitializeComponent();
        }

        private void FormAddReceiveing_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Point_Of_SalesEntities = new POS_Entities(Util.CheckDatabaseConnection());
            btn_lov_po.Enabled = true;
            btn_clearPo.Enabled = true;
            dg_rc_detail.MultiSelect = false;
            dt_Rcdate.Value = DateTime.Now;
            if (Type == "add")
            {
                status = 1;
                //btn_Batal.Visible = false;
                //panel_detail.Visible = false;
                //this.Height = 401;
            }
            else
            {
                status = 0;
                //btn_Batal.Visible = true;
                //panel_detail.Visible = true;
                //btn_addDetails.Visible = false;
                //this.Height = 616;
                btn_clearPo.Enabled = false;
                btn_lov_po.Enabled = false;
                btn_LovSupp.Enabled = false;
                btn_simpan.Enabled = false;
                btn_clear.Enabled = false;
                LoadRc();
                Load_Detail_Po();
            }
        }

        private void LoadRc()
        {
            var Rc = Point_Of_SalesEntities.TReceiveingStocks.Where(x => x.TReceiveID == ID_RC&&x.is_deleted==false).First();
            var supp = Point_Of_SalesEntities.PSuppliers.Where(x => x.Supplier_id == Rc.PsupplierId&&x.is_deleted==false).First();
            var po = Point_Of_SalesEntities.TPurchaseOrders.Where(x => x.PO_id == Rc.PurchaseOrder&&x.is_deleted==false).First();
            txt_RcNo.Text = Rc.ReceiveNumber;
            dt_Rcdate.Value = Rc.ReceiveDate;
            txt_supplier_id.Text = Rc.PsupplierId.ToString();
            txt_supplier_show.Text = supp.supplier_name;
            txt_po_id.Text = Rc.PurchaseOrder.ToString();
            txt_Po_show.Text = po.PO_Number;
            

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefreshDgv();
        }

        private void btn_LovSupp_Click(object sender, EventArgs e)
        {
            FormLov = new FLOV(this, "PSupplier", txt_supplier_show, txt_supplier_id, "supplier_name", new string[] { "supplier_address", "supplier_name", "Supplier_id" }, "supplier_name");
            FormLov.ShowDialog();
        }

        private void btn_lov_po_Click(object sender, EventArgs e)
        {
            FormLov = new FLOV(this, "TPurchaseOrder", txt_Po_show, txt_po_id, "PO_Number", new string[] { "PO_date", "PO_Number", "PO_id" }, "PO_Number", txt_supplier_id.Text);
            FormLov.ShowDialog();
        }
        public void InsertRC()
        {
            try
            {
                var _sessions = Properties.Settings.Default;
                int UserId = (int)_sessions._userID;
                var count = (from u in Point_Of_SalesEntities.TReceiveingStocks
                                       .Where(u => u.created_date.Month == DateTime.Now.Month && u.created_date.Year == DateTime.Now.Year && u.created_date.Day == DateTime.Now.Day)

                             select new { Reservation = u }).Count();
                int result = count;
                int code = count + 1;
                string generated = "GR" + DateTime.Now.Day.ToString("D2") + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() + "/" + code.ToString("D5");


                if (this.ValidateChildren())
                {
                    var user = Point_Of_SalesEntities.Set<TReceiveingStock>();
                    user.Add(new TReceiveingStock
                    {
                        ReceiveNumber = generated,
                        PurchaseOrder =int.Parse( txt_po_id.Text),
                        PsupplierId=int.Parse(txt_supplier_id.Text),
                        created_date = DateTime.Now,
                        created_by = UserId,
                        ReceiveDate =DateTime.Now,
                       
                        is_deleted = false,




                    });
                    AffectedRows = Point_Of_SalesEntities.SaveChanges();
                    if (AffectedRows > 0)
                    {
                        txt_RcNo.Text = generated;
                        if (txt_po_id.Text != "")
                        {
                           
                        }

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


        public void Load_Detail_Po()
        {
            try
            {

                dg_rc_detail.DataSource = null;
                dg_rc_detail.Columns.Clear();

                DataTable dt = new DataTable();


                if (Util.OpenConnection())
                {
                    if (status == 0)
                    {
                        dt.Columns.Add("ID", typeof(int));
                      
                        dt.Columns.Add("ItemsId", typeof(int));
                        dt.Columns.Add("Items Name", typeof(string));
                        dt.Columns.Add("Size", typeof(string));
                        dt.Columns.Add("Colours", typeof(string));
                        dt.Columns.Add("Nomor Item", typeof(string));
                        dt.Columns.Add("Qty Dipesan", typeof(int));
                        dt.Columns.Add("Qty Diterima", typeof(int));
                        dt.Columns.Add("Harga Beli", typeof(float));
                        dt.Columns.Add("status_hide", typeof(int));
                        
                    }

                    else
                    {
                        dt.Columns.Add("ID", typeof(int));
                        
                        dt.Columns.Add("ItemsId", typeof(int));
                        dt.Columns.Add("Items Name", typeof(string));
                        dt.Columns.Add("Size", typeof(string));
                        dt.Columns.Add("Colours", typeof(string));
                        dt.Columns.Add("Nomor Item", typeof(string));
                        dt.Columns.Add("Qty Dipesan", typeof(int));
                        dt.Columns.Add("Qty Diterima", typeof(int));
                        dt.Columns.Add("Harga Beli", typeof(float));
                        dt.Columns.Add("status_hide", typeof(int));
                       
                    }

                    Util.command.Parameters.Clear();

                    Util.command.CommandType = CommandType.StoredProcedure;
                    Util.command.CommandText = "[GetReceiveingDetails]";
                    Util.command.Connection = Util.connection;
                    Util.command.Parameters.AddWithValue("@pono", txt_po_id.Text);
                    Util.command.Parameters.AddWithValue("@stat", status); 
                    Util.command.Parameters.AddWithValue("@rcno", txt_RcNo.Text);

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
                            Util.dtreader[7].ToString(),
                            Util.dtreader[8].ToString(),
                            Util.dtreader[9]
                           


                            );
                    }
                    dg_rc_detail.DataSource = dt;
                    dg_rc_detail.Refresh();
                    dg_rc_detail.Columns[0].Visible = false;
                    dg_rc_detail.Columns[1].Visible = false;
                    dg_rc_detail.Columns[9].Visible = false;

                    Util.dtreader.Close();
                    Util.connection.Close();
                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(), "Error Collecting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_addDetails_Click(object sender, EventArgs e)
        {
            status = 1;
            //btn_Batal.Visible = true;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(this, "Height", 616);
            t.run();
            panel_detail.Visible = true;
          //  btn_Batal.Visible = true;
            InsertRC();
            Load_Detail_Po();
            btn_addDetails.Visible = false;
        }

        private void dg_rc_detail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dg_rc_detail.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void insertdetail(int items,int qty,double price,int receiveqty)
        {
            try
            {
                var _sessions = Properties.Settings.Default;
                int UserId = (int)_sessions._userID;


                var Rc = Point_Of_SalesEntities.TReceiveingStocks.Where(x => x.ReceiveNumber == txt_RcNo.Text).First();
                if (this.ValidateChildren())
                {
                    var user = Point_Of_SalesEntities.Set<TReceiveingDetail>();
                    user.Add(new TReceiveingDetail
                    {
                        TReceiveingStock = Rc.TReceiveID,
                        items = items,
                        Qty = qty,
                        Price=price,
                        created_date = DateTime.Now,
                        created_by = UserId,
                        status = true,
                        ReceiveQty=receiveqty,
                        is_deleted = false,




                    });
                    AffectedRows = Point_Of_SalesEntities.SaveChanges();
                    if (AffectedRows > 0)
                    {
                        //txt_RcNo.Text = generated;
                        if (txt_po_id.Text != "")
                        {
                            
                        }

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
        private void dg_rc_detail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dg_rc_detail.CommitEdit(DataGridViewDataErrorContexts.Commit);
            //if (checkeds == 0)
            //{
            //MessageBox.Show(this, dg_rc_detail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            //string a = dg_rc_detail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //int items = int.Parse(dg_rc_detail.Rows[e.RowIndex].Cells[1].Value.ToString());
            //int qtyorder = int.Parse(dg_rc_detail.Rows[e.RowIndex].Cells[6].Value.ToString());
            //int qtyreceive = int.Parse(dg_rc_detail.Rows[e.RowIndex].Cells[7].Value.ToString());
            //double price = double.Parse(dg_rc_detail.Rows[e.RowIndex].Cells[8].Value.ToString());
            //    if (a == "True")
            //    {
            //        checkeds = 1;
            //        InsertRC();
            //        insertdetail(items, qtyorder, price, qtyreceive);
            //        DataGridViewCell cell = dg_rc_detail.Rows[e.RowIndex].Cells[10];
            //        DataGridViewCheckBoxCell chkCell = cell as DataGridViewCheckBoxCell;
            //        chkCell.Value = true;
            //        dg_rc_detail.Rows[e.RowIndex].Cells[10].ReadOnly = true;
            //    }
            //    else
            //    {

            //    }
            //}
            //checkeds = 0;


        }

        private void btn_Batal_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Po_show_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clearPo_Click(object sender, EventArgs e)
        {
            txt_po_id.Text = "";
            txt_Po_show.Text="";
        }

        private void txt_supplier_show_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void txt_po_id_OnValueChanged(object sender, EventArgs e)
        {
           // status = 1;
            ////btn_Batal.Visible = true;
            //Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            //t.add(this, "Height", 616);
            //t.run();
            //panel_detail.Visible = true;
            //  btn_Batal.Visible = true;
            //InsertRC();
            Load_Detail_Po();
            //btn_addDetails.Visible = false;
        }

        private void dg_rc_detail_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                string[] tes= new string[dg_rc_detail.RowCount];
                dg_rc_detail.CommitEdit(DataGridViewDataErrorContexts.Commit);
               
                int sum = 0;

                for (int i = 0; i < dg_rc_detail.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dg_rc_detail.Rows[i].Cells[7].Value);
                }

                if (sum > 0)
                {
                    InsertRC();
                    for (int i = 0; i < dg_rc_detail.RowCount; i++)
                    {
                        string itemsname = dg_rc_detail.Rows[i].Cells[2].Value.ToString();
                        int items = int.Parse(dg_rc_detail.Rows[i].Cells[1].Value.ToString());
                        int qtyorder = int.Parse(dg_rc_detail.Rows[i].Cells[6].Value.ToString());
                        int qtyreceive = int.Parse(dg_rc_detail.Rows[i].Cells[7].Value.ToString());
                        double price = double.Parse(dg_rc_detail.Rows[i].Cells[8].Value.ToString());
                        if (qtyreceive > 0)
                        {
                            if (price > 0)
                            {
                                insertdetail(items, qtyorder, price, qtyreceive);
                                insert = i;
                            }
                            else
                            {
                                tes[i] = itemsname;
                               
                            }

                        }

                    }
                    if (insert == dg_rc_detail.RowCount - 1)
                    {
                        MessageBox.Show("Penerimaan Barang Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string toDisplay = string.Join(Environment.NewLine, tes);
                     
                        MessageBox.Show("Harga Untuk Item :" + Environment.NewLine + " " + toDisplay+ "," + Environment.NewLine + " belum ditentukan silahkan menentukan harga beli untuk item yang bersangkutan", "Gagal Menentukan Harga Beli", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        deleteRC();

                        txt_RcNo.Text = "";
                    }
                    btn_lov_po.Enabled = false;
                    btn_clearPo.Enabled = false;
                }

                else
                {
                    MessageBox.Show("Harap Menentukan Kuantitas Item yang akan diterima untuk salah satu item atau seluruh item", "Gagal Menghitung penerimaan item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
                    txt_RcNo.Text = "";
                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.Message.ToString(), "Sesuatu Kesalahan Terjadi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           


           
            
            
           
            
        }
        public void deleteRC()
        {
            var delete = Point_Of_SalesEntities.TReceiveingStocks.Where(x => x.ReceiveNumber == txt_RcNo.Text).First();
            Point_Of_SalesEntities.TReceiveingStocks.Remove(delete);
            Point_Of_SalesEntities.SaveChanges();
        }
    }
}
