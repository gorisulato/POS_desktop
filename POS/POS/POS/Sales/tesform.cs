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
    public partial class tesform : Form
    {
        public tesform()
        {
            InitializeComponent();
        }

        private void tesform_Load(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add("No Jual", typeof(string));
            //dt.Columns.Add("NO Barang", typeof(string));
            //dataGridView1.DataSource = dt;
            dataGridView1.Columns.Add("Nama", "Nama");
            dataGridView1.Columns.Add("haha", "haha");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = textBox1.Text;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                var b = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (b == a)
                {
                    MessageBox.Show(this, "duplicate value of" + textBox1.Text);
                }
            }
            dataGridView1.Rows.Add(textBox1.Text,textBox2.Text);
        }
    }
}
