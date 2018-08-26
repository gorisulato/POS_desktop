using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class FLOV : Form
    {
        UtilityClass Util = new UtilityClass();
        ThemeStyle Theme = new ThemeStyle();
        string TableName;
        Form FormCall;
        string OrderBy;
        string Room_Number;
        int reservation_id;
        string SQL, SQLCount = "";
        Bunifu.Framework.UI.BunifuMaterialTextbox TextboxShow;
        AltoControls.AltoTextBox TextboxShow2;
        Bunifu.Framework.UI.BunifuMetroTextbox TextboxID;
        string[] column;
        string where;
        string code;
        string id;
        string Custom = "";
        bool ismultiple;
        string[] dependency;
        string columnwhere = null;
        string @operator = null;
        string valuewhere = null;
        string columnsearch = null;
        int roomqty;
        private string id_reservation;
        private string room_number;

        public string RI
        {
            get { return id_reservation; }
            set { id_reservation = value; }
        }

        public string RN
        {
            get { return room_number; }
            set { room_number = value; }
        }
      
        public FLOV(Form F, string TN, AltoControls.AltoTextBox TShow, Bunifu.Framework.UI.BunifuMetroTextbox Tid, string OD, string[] col,string cs,string custom)
        {
            Custom = custom;
            columnsearch = cs;
            TableName = TN;
            OrderBy = OD;
            FormCall = F;
            TextboxShow2 = TShow;
            TextboxID = Tid;
            column = col;
            InitializeComponent();
        }
        public FLOV(Form F, string TN, AltoControls.AltoTextBox TShow, Bunifu.Framework.UI.BunifuMetroTextbox Tid, string OD, string[] col, string cs)
        {
            
            columnsearch = cs;
            TableName = TN;
            OrderBy = OD;
            FormCall = F;
            TextboxShow2 = TShow;
            TextboxID = Tid;
            column = col;
            InitializeComponent();
        }

        private void FLOV_Load(object sender, EventArgs e)
        {
            if (ismultiple)
            {
                TLOV.DataGridView.MultiSelect = true;
            }
            else
            {
                TLOV.DataGridView.MultiSelect = false;
            }
            get_total_records();
            TLOV_RequestQueryData();
            Theme._formText(altoTextBox1);
            if (column != null)
            {
                altoTextBox1.Enabled = true;
            }
        }
        public void get_total_records()
        {
            if (Util.OpenConnection())
            {
                if (Custom != "")
                {
                    where = " where PSupplierId= "+Custom+ " And status=0 And ";
                    where = where + columnwhere + " " + @operator + " " + valuewhere + " ";
                }
                else
                {
                    where = " where ";
                }
                //TLOV.RequestQueryData += TLOV_RequestQueryData;
                if (columnwhere != null)
                {
                    where = " where ";
                    where = where + columnwhere + " " + @operator + " " + valuewhere + " ";
                }
                else
                {
                    where = where;
                }

                if (columnsearch != null)
                {
                    where = where + columnsearch + " like '%" + altoTextBox1.Text + "%'";
                }
                if (SQL != null)
                {
                    Util.command.CommandText = SQLCount;
                }
                else
                {
                    Util.command.CommandText = "select count(*) from dbo." + TableName + where;
                }

                Util.command.Connection = Util.connection;
                var reader = Util.command.ExecuteScalar();
                if (Convert.ToInt32(reader) > 0)
                {
                    TLOV.Initialize(Convert.ToInt32(reader));
                    TLOV.DataGridView.SelectionChanged += DataGridView_SelectionChanged;
                }

            }
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in TLOV.DataGridView.SelectedRows)
            //{
            //    string[] value = items;
            //    var valuelist = value.ToList();
            //    valuelist.Remove(row.Cells[0].Value.ToString());
            //    items = valuelist.ToArray();

            //}
        }

        //private void DataGridView1_CellDoubleClick(System.Object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        //{
        //    if (ismultiple)
        //    {
        //        foreach (DataGridViewRow row in TLOV.DataGridView.SelectedRows)
        //        {
        //            TextboxShow2.Text = TextboxShow2.Text + "," + TLOV.DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        //            TextboxID.Text = TextboxID.Text + "," + TLOV.DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        //        }

        //    }
        //    else
        //    {
        //        TextboxShow2.Text = TLOV.DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        //        TextboxID.Text = TLOV.DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    }

        //    this.Close();
        //}
        private void TLOV_RequestQueryData()
        {
            TLOV.DataSource = null;
            
            string selected_column = "";
            if (column != null)
            {
                foreach (string col in column)
                {
                    selected_column = selected_column + col + ",";
                }
                selected_column = selected_column.Remove(selected_column.Length - 1);
            }


            if (Custom != "")
            {
                where = " where PSupplierId= " + Custom + " And status=0 And ";
                where = where + columnwhere + " " + @operator + " " + valuewhere + " ";
            }
            else
            {
                where = " where ";
            }

            if (columnwhere != null)
            {
                where = " where ";
                where = where + columnwhere + " " + @operator + " " + valuewhere + " ";
            }
            else
            {
                where = where;
            }

            if (columnsearch != null)
            {
                where =  where + columnsearch + " like '%" + altoTextBox1.Text + "%'";
            }

            if (Util.OpenConnection())
            {
                if (SQL != null)
                {
                    Util.command.CommandText = SQL;
                }
                else
                {
                    Util.command.CommandText = "select " + selected_column + "  from dbo." + TableName + where + "  order by " + OrderBy ;
                }
                Util.command.Connection = Util.connection;
                Util.dtreader = Util.command.ExecuteReader();
                if (Util.dtreader.HasRows)
                {
                    TLOV.DataSource = Util.dtreader;
                    
                }
                Util.dtreader.Close();
                foreach (DataGridViewColumn C in TLOV.DataGridView.Columns)
                {
                    C.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                Util.dtreader.Close();
                Util.connection.Close();

                
            }
        }

        private void btn_pick_data_Click(object sender, EventArgs e)
        {
            if (ismultiple)
            {
                if (TLOV.DataGridView.SelectedRows.Count > roomqty)
                {
                    MessageBox.Show(this, "Jumlah Kamar Dipilih Melebihi Jumlah Kamar Yang Dipesan");
                }
                else
                {
                    foreach (DataGridViewRow row in TLOV.DataGridView.SelectedRows)
                    {
                        code = row.Cells[1].Value.ToString() + "," + code;// TLOV.DataGridView.SelectedRowsCells[1].Value.ToString();
                        id = row.Cells[2].Value.ToString() + "," + id;
                    }
                    code = code.Remove(code.LastIndexOf(','), 1);
                    id = id.Remove(id.LastIndexOf(','), 1);
                    TextboxShow2.Text = code;
                    TextboxID.Text = id;
                    this.Close();
                }
            }
            else
            {
                if (SQL != null)
                {
                    foreach (DataGridViewRow row in TLOV.DataGridView.SelectedRows)
                    {
                        RI = row.Cells[0].Value.ToString();
                        RN = row.Cells[2].Value.ToString();
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in TLOV.DataGridView.SelectedRows)
                    {
                        TextboxShow2.Text = row.Cells[1].Value.ToString();
                        TextboxID.Text = row.Cells[2].Value.ToString();
                        this.Close();
                    }
                }



            }
            this.DialogResult = DialogResult.OK;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            get_total_records();
            TLOV_RequestQueryData();
        }

     
    }
}
