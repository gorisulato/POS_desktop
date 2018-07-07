﻿using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Sales
{
    public partial class InvoiceViewer : Form
    {
       
      
        ReportDocument rpt = new ReportDocument();
        ParameterFields parameter = new ParameterFields();
        ConnectionInfo info = new ConnectionInfo();
        UtilityClass Util = new UtilityClass();

        string sales;
        public InvoiceViewer( string salesno)
        {
            sales = salesno;
            InitializeComponent();
        }

        private void InvoiceViewer_Load(object sender, EventArgs e)
        {
            rpt.Load(AppDomain.CurrentDomain.BaseDirectory + "\\Sales\\rEPORTiNVOICE.rpt");

            try
            {
                info.DatabaseName = Properties.Settings.Default._databaseName;
                info.ServerName = Properties.Settings.Default._databaseServer;
                info.UserID = Properties.Settings.Default._databaseUser;
                info.Password = Properties.Settings.Default._databasePassword;
                info.IntegratedSecurity = false;

               
                //IFormatProvider culture = new CultureInfo("en-US", true);
                //DateTime dateVal = DateTime.ParseExact(countriesname, "yyyy-MM-dd", culture);
                //string datefrom = Convert.ToString(dateVal);
           
                
                //DateTime dateValto = DateTime.ParseExact(dt_dateto.Value, "yyyy-MM-dd", culture);
                //string dateto = Convert.ToString(dateValto);




                ParameterField paramSales = new ParameterField();
                ParameterDiscreteValue paramsalesNo = new ParameterDiscreteValue();
                paramsalesNo.Value = sales;
                paramSales.Name = "@salesNo";
                paramSales.CurrentValues.Add(paramsalesNo);

               



                parameter.Add(paramSales);
                



                invoiceReportViewer.ParameterFieldInfo = parameter;
                Util.AssignConnectionInfo(rpt, info, invoiceReportViewer);
                invoiceReportViewer.ReportSource = rpt;
            }
            catch (Exception z)
            {

                MessageBox.Show("Info", z.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
