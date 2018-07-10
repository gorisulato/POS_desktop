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
    public partial class RPT_LossProfitViewer : Form
    {
        ReportDocument rpt = new ReportDocument();
        ParameterFields parameter = new ParameterFields();
        ConnectionInfo info = new ConnectionInfo();
        UtilityClass Util = new UtilityClass();
        public RPT_LossProfitViewer()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            rpt.Load(AppDomain.CurrentDomain.BaseDirectory + "\\Reports\\RPT_LossProfit.rpt");

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




                ParameterField paramMonth = new ParameterField();
                ParameterDiscreteValue paramMonthindex = new ParameterDiscreteValue();
                paramMonthindex.Value = cb_month.selectedIndex+1;
                paramMonth.Name = "@month";
                paramMonth.CurrentValues.Add(paramMonthindex);

                ParameterField paramYear = new ParameterField();
                ParameterDiscreteValue paramYearIndex = new ParameterDiscreteValue();
                paramYearIndex.Value = int.Parse(txt_year.Text);
                paramYear.Name = "@year";
                paramYear.CurrentValues.Add(paramYearIndex);
                parameter.Add(paramYear);



                parameter.Add(paramMonth);




                lossprofitviewer.ParameterFieldInfo = parameter;
                Util.AssignConnectionInfo(rpt, info, lossprofitviewer);
                lossprofitviewer.ReportSource = rpt;
            }
            catch (Exception z)
            {

                MessageBox.Show("Info", z.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
