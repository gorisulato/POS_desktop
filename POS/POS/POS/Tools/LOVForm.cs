using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Tools
{
    public partial class LOVForm : Form
    {
       
        UtilityClass Util = new UtilityClass();
        ThemeStyle style = new ThemeStyle();
        string sql;
        int offset_data = 0;
        Form formcall;
        string[] columns =new string[4];
        AltoControls.AltoTextBox text_show;
        Bunifu.Framework.UI.BunifuMetroTextbox textId;
        string ordercolumn;

        string collumnSearch;//= "a.Items_Name";

        public LOVForm(string SQL, Form F, AltoControls.AltoTextBox TShow, Bunifu.Framework.UI.BunifuMetroTextbox Tid, string cs, string[] coll,string Order)
        {
            sql = SQL;
            formcall = F;
            text_show = TShow;
            textId = Tid;
            collumnSearch = cs;
            ordercolumn = Order;
            for (int i = 0; i < coll.Length; i++)
            {
                columns[i] = coll[i];
            }

            InitializeComponent();
        }

        private void LOVForm_Load(object sender, EventArgs e)
        {
            style._primaryButton(btn_search);
            style._primaryButton(btn_exit);
            style._primaryButton(bunifuFlatButton1);
            style._formText(txt_searchLOV);
            LoadData();
        }
     
        private void LoadData()
        {
            try
            {
                if (Util.OpenConnection())
                {

                    var query = "";
                        query = sql + " " +"and "+ collumnSearch + " like '%"+txt_searchLOV.Text+ "%' and a.is_deleted=0";
                    
                  

                   // CountRecords();
                    dgLOV.DataSource = null;
                    dgLOV.Columns.Clear();
                    
                    DataTable dt = new DataTable();
                    dt.Clear();

                    if (Util.OpenConnection())
                    {
                        dt.Columns.Add(columns[0].ToString(), typeof(string));
                        dt.Columns.Add(columns[1].ToString(), typeof(string));
                        dt.Columns.Add(columns[2].ToString(), typeof(string));
                        dt.Columns.Add(columns[3].ToString(), typeof(string));





                        Util.command.Parameters.Clear();

                        Util.command.CommandType = CommandType.Text;
                        Util.command.CommandText = query;
                        Util.command.Connection = Util.connection;
                      
                        Util.dtreader = Util.command.ExecuteReader();

                        while (Util.dtreader.Read())
                        {
                            dt.Rows.Add
                                (
                                Util.dtreader[0].ToString(),
                                Util.dtreader[1].ToString(),
                                Util.dtreader[2].ToString(),
                                Util.dtreader[3]




                                );
                        }

                       
                        dgLOV.DataSource = dt;
                        dgLOV.Refresh();
                        dgLOV.Columns[0].Visible = false;
                       // dgLOV.Columns[3].DefaultCellStyle.Format = "N2";
                        Util.dtreader.Close();
                        Util.connection.Close();
                        foreach (DataGridViewRow row in dgLOV.Rows)
                        {
                            row.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                            row.HeaderCell.Value = String.Format("{0}", row.Index + 1);



                        }

                        dgLOV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message.ToString(), "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgLOV.SelectedRows)
            {
                text_show.Text = row.Cells[2].Value.ToString();
                textId.Text= row.Cells[0].Value.ToString();
            }
            
            this.Close();
        }

        private void dgLOV_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dgLOV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgLOV.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dgLOV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgLOV.RowCount > 0)
            {
                dgLOV.Rows[0].Selected = true;
            }
        }
    }
}
