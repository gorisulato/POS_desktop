using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Reports
{
    public partial class ReportViewer : Form
    {

        ReportDocument rpt = new ReportDocument();
        ParameterFields parameter = new ParameterFields();
        ConnectionInfo info = new ConnectionInfo();
        UtilityClass Util = new UtilityClass();
        ThemeStyle style = new ThemeStyle();
        string typeReport = "";
        public delegate void DoEvent();
        public event DoEvent RefreshDgv;
        public ReportViewer(string type)
        {
            typeReport = type;
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (typeReport == "SalesPeriodic")
            {
                rpt.Load(AppDomain.CurrentDomain.BaseDirectory + "\\Reports\\RPTSalesPeriodic.rpt");

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




                    ParameterField paramdatefrom = new ParameterField();
                    ParameterDiscreteValue ParamDateStart = new ParameterDiscreteValue();
                    ParamDateStart.Value = dt_datefrom.Value.Date;
                    paramdatefrom.Name = "@startdate";
                    paramdatefrom.CurrentValues.Add(ParamDateStart);

                    ParameterField paramendDate = new ParameterField();
                    ParameterDiscreteValue ParamDateEnd = new ParameterDiscreteValue();
                    ParamDateEnd.Value = dt_enddate.Value.Date;
                    paramendDate.Name = "@enddate";
                    paramendDate.CurrentValues.Add(ParamDateEnd);
                    parameter.Add(paramendDate);



                    parameter.Add(paramdatefrom);




                    crystalReportViewer1.ParameterFieldInfo = parameter;
                    Util.AssignConnectionInfo(rpt, info, crystalReportViewer1);
                    crystalReportViewer1.ReportSource = rpt;
                }
                catch (Exception z)
                {

                    MessageBox.Show("Info", z.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            style._primaryButton(btn_exit);
        }
    }
}
