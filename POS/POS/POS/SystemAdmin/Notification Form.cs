using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.SystemAdmin
{
    public partial class Notification_Form : Form
    {
        FormHome Home = null;
        UtilityClass Util = new UtilityClass();
        public Notification_Form()
        {
            InitializeComponent();
        }
        public Notification_Form(FormHome FormHome)
        {
            Home = FormHome;
            InitializeComponent();
        }
        public void load_data()
        {
            try
            {
                //CountRecords();
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();

                DataTable dt = new DataTable();


                if (Util.OpenConnection())
                {
                    dt.Columns.Add("type", typeof(string));
                    dt.Columns.Add("Modul", typeof(string));
                    dt.Columns.Add("Pesan", typeof(string));




                    Util.command.Parameters.Clear();

                    Util.command.CommandType = CommandType.StoredProcedure;
                    Util.command.CommandText = "[TaskingList]";
                    Util.command.Connection = Util.connection;

                    Util.dtreader = Util.command.ExecuteReader();

                    while (Util.dtreader.Read())
                    {
                        dt.Rows.Add
                            (
                            Util.dtreader[0].ToString(),
                            Util.dtreader[1].ToString(),
                            Util.dtreader[2].ToString()




                            );
                    }
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    dataGridView1.Columns[0].Visible = false;

                    Util.dtreader.Close();
                    Util.connection.Close();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                    }
                    DataGridViewImageColumn btn = new DataGridViewImageColumn();
                    btn.Image = Properties.Resources.Error_20px;
                    dataGridView1.Columns.Add(btn);
                    this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                }
            }
            catch (Exception z)
            {

                MessageBox.Show(z.ToString(), "Error Collecting Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int count()
        {
            load_data();
            return dataGridView1.RowCount;
        }
        private void Notification_Form_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
