using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Linq.Dynamic;
using POS.DB;

namespace POS
{
    public class SalesModel
    {
        public int ID { get; set; }
        [DisplayName("Nomor Penjualan")]
        public string SalesNumber { get; set; }
        [DisplayName ("Tanggal Penjualan")]
        public string SalesDate { get; set; }
        [DisplayName("Total Penjualan")]
        public double? Total { get; set; }





    }

    public class SalesDetailModel
    {

        //dt.Columns.Add("ID", typeof(int));
        //            dt.Columns.Add("Sales ID", typeof(int));
        //            dt.Columns.Add("Items ID", typeof(int));
        //            dt.Columns.Add("Sales Number", typeof(string));
        //            dt.Columns.Add("Items Name", typeof(string));
        //            dt.Columns.Add("Items Color", typeof(string));
        //            dt.Columns.Add("Size", typeof(float));
        //            dt.Columns.Add("Qty", typeof(float));
        //            dt.Columns.Add("Unit Price", typeof(float));
        //            dt.Columns.Add("Discount", typeof(float));
        //            dt.Columns.Add("Subtotal", typeof(float));
        public int ID { get; set; }
        public int Sales_id { get; set; }
        public int itemsid { get; set; }

        [DisplayName("Nomor Penjualan")]
        public string SalesNumber { get; set; }
      
        [DisplayName("Items")]
        public string ItemsName { get; set; }

        public double? size { get; set; }
        public int Qty { get; set; }
        public double? unitprice { get; set; }
        public double? discount { get; set; }
        public double? subtotal { get; set; }
        
    }
 
    public class DBsalesdetail
    {
        UtilityClass util = new UtilityClass();
        POS_Entities Point_Of_SalesEntities;
        public List<SalesDetailModel> GetDataSalesdetail(string sn)
        {
            Point_Of_SalesEntities = new DB.POS_Entities(util.CheckDatabaseConnection());
            if (sn != "")
            {
                sn = sn.ToUpper();
            }

            var GCF = (from u in Point_Of_SalesEntities.TSalesDetails
                       from sales in Point_Of_SalesEntities.TSales.Where(s => s.TSales_id == u.Sales_Number).DefaultIfEmpty()
                       from inv in Point_Of_SalesEntities.TInventories.Where(s => s.Items_Id == u.Items).DefaultIfEmpty()


                       select new { salesd = u, inv = inv, sales = sales }).Where(x=>x.sales.Sales_Number==sn).ToList();
            //MessageBox.Show(GCF.GCF.p_GCF_code.ToString());



            return GCF
                                  .Select(x => new SalesDetailModel()
                                  {


                                      ID = x.salesd.Sales_Detail_id,
                                      SalesNumber = x.sales.Sales_Number,
                                      Sales_id=x.salesd.Sales_Number,
                                      itemsid=x.inv.Items_Id,
                                      ItemsName=x.inv.Items_Name,
                                      size=x.inv.Size,
                                      Qty=x.salesd.Qty,
                                      unitprice=x.inv.Unit_Price,
                                      discount = x.salesd.Discount,
                                      subtotal = x.salesd.Subtotal

                                  })


                                  .AsQueryable()

                                  .Where(x => x.SalesNumber.ToUpper().Contains(sn))
                                
                                  .ToList();




        }
    }
    public class DBSalesData
    {
        UtilityClass util = new UtilityClass();
        POS_Entities Point_Of_SalesEntities;
        public List<SalesModel> GetDataSales(int offset, int length, string code)
        {
            Point_Of_SalesEntities = new DB.POS_Entities(util.CheckDatabaseConnection());
            if (code != "")
            {
                code = code.ToUpper();
            }

            var GCF = (from u in Point_Of_SalesEntities.TSales.DefaultIfEmpty()
                     
                       select new { sales=u});
            //MessageBox.Show(GCF.GCF.p_GCF_code.ToString());



            return GCF
                                  .Select(x => new SalesModel()
                                  {


                                      ID = x.sales.TSales_id,
                                      SalesNumber = x.sales.Sales_Number,
                                      SalesDate = x.sales.SalesDate.ToString(),
                                      Total=x.sales.TotalSales

                                  })


                                  .AsQueryable()
                                  
                                  .Where(x => x.SalesNumber.ToUpper().Contains(code) )
                                  .OrderBy(x=>x.SalesDate + " " + "DESC")
                                  .Skip(offset)
                                  .Take(length)
                                  .ToList();




        }

    }

}
