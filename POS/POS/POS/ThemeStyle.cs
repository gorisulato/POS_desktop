using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    class ThemeStyle
    { //Primary Button
        public void _primaryButton(Bunifu.Framework.UI.BunifuFlatButton btn, string BtnSize = "md")
        {
            //default size
            var _iconZoom = 50;
            var _btnHeight = 33;
            switch (BtnSize)
            {
                case "sm":
                    _iconZoom = 32;
                    _btnHeight = 32;
                    break;
                case "lg":
                    _iconZoom = 60;
                    _btnHeight = 40;
                    break;
            }



            BunifuElipse Eclipse = new BunifuElipse();
            Eclipse.TargetControl = btn;
            Eclipse.ElipseRadius = 20;
            btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(253)))));
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));

            btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.DisabledColor = System.Drawing.Color.Gray;
            btn.IconVisible = true;
            btn.IconZoom = _iconZoom;
            btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(162)))), ((int)(((byte)(224)))));
            btn.OnHoverTextColor = System.Drawing.Color.White;
            btn.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            btn.Height = _btnHeight;

            btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btn.Textcolor = System.Drawing.Color.White;
            btn.TextFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        public void _buttonNotRounded(Bunifu.Framework.UI.BunifuFlatButton btn)
        {
            //int _iconZoom = 75;
            //int _btnHeight = 50;
            btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(253)))));
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.DisabledColor = System.Drawing.Color.Gray;
            btn.IconVisible = true;
            //btn.IconZoom = _iconZoom;
            btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(162)))), ((int)(((byte)(224)))));
            btn.OnHoverTextColor = System.Drawing.Color.White;
            btn.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            //btn.Height = _btnHeight;
            btn.Size = new Size(24, 24);
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btn.Textcolor = System.Drawing.Color.White;
            btn.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        //label
        public void _formLabel(Bunifu.Framework.UI.BunifuCustomLabel lbl)
        {
            //lbl.AutoSize = true;
            lbl.BackColor = System.Drawing.Color.Transparent;
            lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            lbl.Size = new System.Drawing.Size(104, 15);
        }

        //Textbox
        public void _formText(AltoControls.AltoTextBox text, bool clear_text = true)
        {
            text.BackColor = System.Drawing.Color.Transparent;
            text.BackColor = System.Drawing.Color.White;
            text.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            text.ForeColor = System.Drawing.Color.DimGray;
            text.Radius = 6;
            text.Height = 33;
            if (clear_text)
            {
                text.Text = "";
            }

            //text.Size = new System.Drawing.Size;
        }

        public void _formDateTimePicker(Bunifu.Framework.UI.BunifuDatepicker DatePicker)
        {
            DatePicker.BackColor = System.Drawing.Color.Transparent;
            DatePicker.BackColor = System.Drawing.Color.White;
            DatePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DatePicker.ForeColor = System.Drawing.Color.DimGray;
            DatePicker.BorderRadius = 6;
            DatePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            DatePicker.Height = 33;
            DatePicker.Format = DateTimePickerFormat.Short;

            //text.Size = new System.Drawing.Size;
        }

        //Datagrid

        public void _formDatagridviewCoolGrid(System.Windows.Forms.DataGridView dgv)
        {
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            dgv.AllowDrop = true;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.ColumnHeadersHeight = 50;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgv.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            dgv.AdvancedRowHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedRowHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgv.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgv.RowsDefaultCellStyle.BackColor = Color.Black;
            dgv.RowsDefaultCellStyle.ForeColor = Color.White;

            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = true;
            //dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.TabIndex = 0;
            dgv.TabStop = false;

            dgv.RowPostPaint += Dgv_RowPostPaint;

        }

        public void _formDatagridviewCoolGrid2(System.Windows.Forms.DataGridView dgv)
        {
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            dgv.AllowDrop = true;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.ColumnHeadersHeight = 50;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgv.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            dgv.AdvancedRowHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedRowHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgv.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgv.RowsDefaultCellStyle.BackColor = Color.Black;
            dgv.RowsDefaultCellStyle.ForeColor = Color.White;

            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = true;
            //dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.TabIndex = 0;
            dgv.TabStop = false;

            dgv.RowPostPaint += Dgv_RowPostPaint;

        }

        public void _formDatagridviewCoolGrid3(System.Windows.Forms.DataGridView dgv)
        {
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            dgv.AllowDrop = true;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.ColumnHeadersHeight = 50;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgv.RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            dgv.AdvancedRowHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedRowHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dgv.RowHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgv.RowsDefaultCellStyle.BackColor = Color.Black;
            dgv.RowsDefaultCellStyle.ForeColor = Color.White;

            dgv.MultiSelect = false;
            // dgv.ReadOnly = true;
            dgv.RowHeadersVisible = true;
            //dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.TabIndex = 0;
            dgv.TabStop = false;

            dgv.RowPostPaint += Dgv_RowPostPaint;

        }

        private void Dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(Color.FromArgb(255, 255, 255));
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
        }

    }
}
