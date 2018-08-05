using System;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.Windows.Forms;

using System.IO;

using System.Text.RegularExpressions;
using System.Data.Entity.Core.EntityClient;
using POS.DB;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace POS
{
    class UtilityClass
    {
        public SqlCommand command = new SqlCommand();
        public SqlConnection connection = new SqlConnection();
        public SqlDataReader dtreader;
        public SqlDataAdapter DA;
        StringBuilder sb = new StringBuilder();
        public string __connstring = String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3};MultipleActiveResultSets=True;App=EntityFramework;",
                Properties.Settings.Default._databaseServer,
                Properties.Settings.Default._databaseName,
                Properties.Settings.Default._databaseUser,
                 Properties.Settings.Default._databasePassword).ToString();/* Properties.Settings.Default.Point_Of_SalesConnectionString;*/
        public SqlParameter param = new SqlParameter();
        public Boolean conn;
      
        public string lang = "";
        StringBuilder log_string = new StringBuilder(1024);
        POS_Entities Point_Of_SalesEntities;//= new Point_Of_SalesEntities();
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public POS_Entities point_Of_SalesEntities;
        //public SqlDependency commanddependency;

        //public NpgsqlCommand command = new NpgsqlCommand();
        //public NpgsqlConnection connection = new NpgsqlConnection();
        //public NpgsqlDataReader datareader;
        //public string _connstring = "User ID=sa;Password=password;Host=192.168.88.253;Port=5432;Database=db_hotel;Pooling=true;";

        #region "Connection"

        public void AssignConnectionInfo(ReportDocument document, ConnectionInfo crConnection, CrystalReportViewer crv)
        {
            try
            {
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in document.Database.Tables)
                {
                    TableLogOnInfo logOnInfo = table.LogOnInfo;
                    if (logOnInfo != null)
                    {

                        table.LogOnInfo.TableName = table.Name;
                        table.LogOnInfo.ConnectionInfo.UserID = crConnection.UserID;
                        table.LogOnInfo.ConnectionInfo.Password = crConnection.Password;
                        table.LogOnInfo.ConnectionInfo.DatabaseName = crConnection.DatabaseName;
                        table.LogOnInfo.ConnectionInfo.ServerName = crConnection.ServerName;
                        //crv.LogOnInfo.Add(table.LogOnInfo);
                        table.ApplyLogOnInfo(table.LogOnInfo);
                        var x = crConnection.DatabaseName;
                        table.Location = x + table.Name;

                        document.DataSourceConnections[0].SetLogon(crConnection.UserID, crConnection.Password);
                        document.DataSourceConnections[0].SetConnection(crConnection.ServerName, crConnection.DatabaseName, crConnection.UserID, crConnection.Password);
                        var a = document.DataSourceConnections[0].ServerName;
                    }
                }
            }
            catch (CrystalReportsException e)

            {
                e.Message.ToString();

            }


        }

        public Boolean OpenConnection()
        {

            if (!conn)
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.ConnectionString = __connstring;
                connection.Open();
                conn = true;
            }
            else
            {
                connection.Close();
                connection.ConnectionString = __connstring;
                connection.Open();
                conn = true;
            }
            return conn;


        }

        public void CloseConnection()
        {
            if (conn)
            {
                connection.Close();
            }
        }
        #endregion

        #region "Generate"

        public string RandomString(int length)
        {
            Random rdm = new Random();

            const string pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            var builder = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                var c = pool[rdm.Next(0, pool.Length)];
                builder.Append(c);
            }
            return builder.ToString();
        }

        public string RandomString2()
        {
            Random rdm = new Random();
            //DateTime date = new DateTime();


            //const string pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            const string pool = "QAZWSXEDCRFVTGBYHNUJMIKOLP5674890123";

            var builder = new StringBuilder();
            for (var i = 0; i <= 3; i++)
            {
                var c = pool[rdm.Next(0, pool.Length)];
                builder.Append(c);
            }

            builder.Append(DateTime.Now.Day);
            builder.Append(DateTime.Now.Month);
            builder.Append(DateTime.Now.Year);


            for (var i = 0; i <= 3; i++)
            {
                var c = pool[rdm.Next(0, pool.Length)];
                builder.Append(c);
            }
            return builder.ToString();
        }
        #endregion

        #region "Validate"
        public bool isRequired(Bunifu.Framework.UI.BunifuMaterialTextbox controls)
        {
            if (string.IsNullOrWhiteSpace(controls.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isRequired(Bunifu.Framework.UI.BunifuTextbox controls)
        {
            var text = controls.text;
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool isRequired(AltoControls.AltoTextBox controls)
        {
            if (string.IsNullOrWhiteSpace(controls.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool MaxLength(Bunifu.Framework.UI.BunifuMaterialTextbox controls, int max)
        {
            if (controls.Text.Length > max)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool MaxLength(AltoControls.AltoTextBox controls, int max)
        {
            if (controls.Text.Length > max)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool MinLength(Bunifu.Framework.UI.BunifuMaterialTextbox controls, int min)
        {
            if (controls.Text.Length < min)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool MinLength(AltoControls.AltoTextBox controls, int min)
        {
            if (controls.Text.Length < min)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool isNumeric(Bunifu.Framework.UI.BunifuMaterialTextbox controls)
        {
            int distance = 0;
            if (int.TryParse(controls.Text, out distance))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isNumeric(AltoControls.AltoTextBox controls)
        {
            int distance = 0;
            if (int.TryParse(controls.Text, out distance))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEmail(AltoControls.AltoTextBox controls)
        {
            Match match = regex.Match(controls.Text);
            if (!match.Success)
                return false;
            else
                return true;
        }
        #endregion

        #region ClearForm
        public void ClearTextBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Text = "";
                else
                    ClearTextBoxes(ctrl.Controls);
            }

            foreach (Control ctrl in cc)
            {
                CheckBox tb = ctrl as CheckBox;
                if (tb != null)
                    tb.Checked = false;
                else
                    ClearTextBoxes(ctrl.Controls);
            }

            foreach (Control ctrl in cc)
            {
                DateTimePicker tb = ctrl as DateTimePicker;
                if (tb != null)
                    tb.Value = DateTime.Now;
                else
                    ClearTextBoxes(ctrl.Controls);
            }
            foreach (Control ctrl in cc)
            {
                RichTextBox tb = ctrl as RichTextBox;
                if (tb != null)
                    tb.Text = "";
                else
                    ClearTextBoxes(ctrl.Controls);
            }
        }


        #endregion
        #region global variable


        #endregion

        #region activities
        //public void log_activities(int UserID, string activity, string module)
        //{
        //    Point_Of_SalesEntities = new Point_Of_SalesEntities(this.CheckDatabaseConnection());
        //    var filename = DateTime.Now.ToString("yyyyMMdd") + "_log.txt";
        //    var destinationLocation = Application.StartupPath + "\\log\\";

        //    try
        //    {
        //        var log_activities = Point_Of_SalesEntities.Set<bf_activities>();
        //        log_activities.Add(new bf_activities
        //        {
        //            user_id = UserID,
        //            activity = activity,
        //            module = module,
        //            created_on = DateTime.Now,
        //            deleted = 0


        //        });

        //        if (Point_Of_SalesEntities.SaveChanges() > 0)
        //        {
        //            //write log to file
        //            log_string.Append(activity + System.Environment.NewLine);
        //            if (Directory.Exists(destinationLocation) == false)
        //            {
        //                Directory.CreateDirectory(destinationLocation);
        //            }

        //            if (File.Exists(destinationLocation + filename) == false)
        //            {
        //                File.Create(destinationLocation + filename);
        //            }
        //            File.AppendAllText(destinationLocation + filename, log_string.ToString());

        //            log_string.Clear();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        log_string.Append("FAILED : " + ex + "event : " + activity + System.Environment.NewLine);
        //        if (Directory.Exists(destinationLocation) == false)
        //        {
        //            Directory.CreateDirectory(destinationLocation);
        //        }
        //        if (!File.Exists(destinationLocation + filename))
        //        {
        //            File.Create(destinationLocation + filename);
        //        }
        //        //File.AppendAllText(destinationLocation + filename, activity.ToString());
        //        log_string.Clear();
        //    }
        //}
        #endregion

        #region "Setting"

        
        public string CheckDatabaseConnection()
        {
            var Setting = Properties.Settings.Default;
            StringBuilder sb = new StringBuilder();
            EntityConnectionStringBuilder ecb = new EntityConnectionStringBuilder();
            ecb.ProviderConnectionString = sb.AppendFormat("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3};MultipleActiveResultSets=True;App=EntityFramework;",
                Setting._databaseServer,
                Setting._databaseName,
                Setting._databaseUser,
                Setting._databasePassword).ToString();

            ecb.Metadata = "res://*/DB.POS.csdl|res://*/DB.POS.ssdl|res://*/DB.POS.msl";
            ecb.Provider = "System.Data.SqlClient";
            return ecb.ToString();
        }

        #endregion
    }
}
