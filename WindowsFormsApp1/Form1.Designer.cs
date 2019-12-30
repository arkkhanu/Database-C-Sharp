namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_actionform = new Bunifu.Framework.UI.BunifuThinButton2();
            this.combo_select = new Bunifu.Framework.UI.BunifuDropdown();
            this.cross_btn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tv_lname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tv_fname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tv_address = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tv_age = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tv_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_actionform);
            this.panel1.Controls.Add(this.combo_select);
            this.panel1.Controls.Add(this.cross_btn);
            this.panel1.Controls.Add(this.tv_lname);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.tv_fname);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.tv_address);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.tv_age);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.tv_id);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.datagrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_actionform
            // 
            this.btn_actionform.ActiveBorderThickness = 1;
            this.btn_actionform.ActiveCornerRadius = 20;
            this.btn_actionform.ActiveFillColor = System.Drawing.Color.Navy;
            this.btn_actionform.ActiveForecolor = System.Drawing.Color.White;
            this.btn_actionform.ActiveLineColor = System.Drawing.Color.Navy;
            this.btn_actionform.BackColor = System.Drawing.SystemColors.Control;
            this.btn_actionform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_actionform.BackgroundImage")));
            this.btn_actionform.ButtonText = "Action";
            this.btn_actionform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actionform.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actionform.ForeColor = System.Drawing.Color.Navy;
            this.btn_actionform.IdleBorderThickness = 1;
            this.btn_actionform.IdleCornerRadius = 20;
            this.btn_actionform.IdleFillColor = System.Drawing.Color.White;
            this.btn_actionform.IdleForecolor = System.Drawing.Color.Navy;
            this.btn_actionform.IdleLineColor = System.Drawing.Color.Navy;
            this.btn_actionform.Location = new System.Drawing.Point(379, 347);
            this.btn_actionform.Margin = new System.Windows.Forms.Padding(5);
            this.btn_actionform.Name = "btn_actionform";
            this.btn_actionform.Size = new System.Drawing.Size(181, 41);
            this.btn_actionform.TabIndex = 13;
            this.btn_actionform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_actionform.Click += new System.EventHandler(this.btn_actionform_Click);
            // 
            // combo_select
            // 
            this.combo_select.BackColor = System.Drawing.Color.Transparent;
            this.combo_select.BorderRadius = 10;
            this.combo_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_select.ForeColor = System.Drawing.Color.White;
            this.combo_select.Items = new string[0];
            this.combo_select.Location = new System.Drawing.Point(168, 347);
            this.combo_select.Name = "combo_select";
            this.combo_select.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.combo_select.onHoverColor = System.Drawing.Color.Blue;
            this.combo_select.selectedIndex = -1;
            this.combo_select.Size = new System.Drawing.Size(166, 41);
            this.combo_select.TabIndex = 12;
            this.combo_select.onItemSelected += new System.EventHandler(this.onselection);
            // 
            // cross_btn
            // 
            this.cross_btn.AutoSize = true;
            this.cross_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cross_btn.ForeColor = System.Drawing.Color.Red;
            this.cross_btn.Location = new System.Drawing.Point(927, 18);
            this.cross_btn.Name = "cross_btn";
            this.cross_btn.Size = new System.Drawing.Size(18, 18);
            this.cross_btn.TabIndex = 11;
            this.cross_btn.Text = "X";
            this.cross_btn.Click += new System.EventHandler(this.cross_btn_Click);
            // 
            // tv_lname
            // 
            this.tv_lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tv_lname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tv_lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tv_lname.HintForeColor = System.Drawing.Color.Empty;
            this.tv_lname.HintText = "Last Name";
            this.tv_lname.isPassword = false;
            this.tv_lname.LineFocusedColor = System.Drawing.Color.Blue;
            this.tv_lname.LineIdleColor = System.Drawing.Color.Gray;
            this.tv_lname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tv_lname.LineThickness = 3;
            this.tv_lname.Location = new System.Drawing.Point(658, 133);
            this.tv_lname.Margin = new System.Windows.Forms.Padding(4);
            this.tv_lname.Name = "tv_lname";
            this.tv_lname.Size = new System.Drawing.Size(147, 38);
            this.tv_lname.TabIndex = 10;
            this.tv_lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(664, 105);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(80, 18);
            this.bunifuCustomLabel5.TabIndex = 9;
            this.bunifuCustomLabel5.Text = "Last Name";
            // 
            // tv_fname
            // 
            this.tv_fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tv_fname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tv_fname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tv_fname.HintForeColor = System.Drawing.Color.Empty;
            this.tv_fname.HintText = "First Name";
            this.tv_fname.isPassword = false;
            this.tv_fname.LineFocusedColor = System.Drawing.Color.Blue;
            this.tv_fname.LineIdleColor = System.Drawing.Color.Gray;
            this.tv_fname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tv_fname.LineThickness = 3;
            this.tv_fname.Location = new System.Drawing.Point(504, 135);
            this.tv_fname.Margin = new System.Windows.Forms.Padding(4);
            this.tv_fname.Name = "tv_fname";
            this.tv_fname.Size = new System.Drawing.Size(141, 36);
            this.tv_fname.TabIndex = 8;
            this.tv_fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(510, 108);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(81, 18);
            this.bunifuCustomLabel4.TabIndex = 7;
            this.bunifuCustomLabel4.Text = "First Name";
            // 
            // tv_address
            // 
            this.tv_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tv_address.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tv_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tv_address.HintForeColor = System.Drawing.Color.Empty;
            this.tv_address.HintText = "Address";
            this.tv_address.isPassword = false;
            this.tv_address.LineFocusedColor = System.Drawing.Color.Blue;
            this.tv_address.LineIdleColor = System.Drawing.Color.Gray;
            this.tv_address.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tv_address.LineThickness = 3;
            this.tv_address.Location = new System.Drawing.Point(504, 229);
            this.tv_address.Margin = new System.Windows.Forms.Padding(4);
            this.tv_address.Name = "tv_address";
            this.tv_address.Size = new System.Drawing.Size(414, 34);
            this.tv_address.TabIndex = 6;
            this.tv_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(510, 197);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(62, 18);
            this.bunifuCustomLabel3.TabIndex = 5;
            this.bunifuCustomLabel3.Text = "Address";
            // 
            // tv_age
            // 
            this.tv_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tv_age.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tv_age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tv_age.HintForeColor = System.Drawing.Color.Empty;
            this.tv_age.HintText = "AGE";
            this.tv_age.isPassword = false;
            this.tv_age.LineFocusedColor = System.Drawing.Color.Blue;
            this.tv_age.LineIdleColor = System.Drawing.Color.Gray;
            this.tv_age.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tv_age.LineThickness = 3;
            this.tv_age.Location = new System.Drawing.Point(831, 138);
            this.tv_age.Margin = new System.Windows.Forms.Padding(4);
            this.tv_age.Name = "tv_age";
            this.tv_age.Size = new System.Drawing.Size(87, 33);
            this.tv_age.TabIndex = 4;
            this.tv_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(837, 105);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(39, 18);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "AGE";
            // 
            // tv_id
            // 
            this.tv_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tv_id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tv_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tv_id.HintForeColor = System.Drawing.Color.Empty;
            this.tv_id.HintText = "";
            this.tv_id.isPassword = false;
            this.tv_id.LineFocusedColor = System.Drawing.Color.Blue;
            this.tv_id.LineIdleColor = System.Drawing.Color.Gray;
            this.tv_id.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tv_id.LineThickness = 3;
            this.tv_id.Location = new System.Drawing.Point(504, 56);
            this.tv_id.Margin = new System.Windows.Forms.Padding(4);
            this.tv_id.Name = "tv_id";
            this.tv_id.Size = new System.Drawing.Size(74, 34);
            this.tv_id.TabIndex = 2;
            this.tv_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(510, 34);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(22, 18);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "ID";
            // 
            // datagrid
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.DoubleBuffered = true;
            this.datagrid.EnableHeadersVisualStyles = false;
            this.datagrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.datagrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.datagrid.Location = new System.Drawing.Point(12, 34);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid.Size = new System.Drawing.Size(475, 241);
            this.datagrid.TabIndex = 0;
            this.datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellClickedonGridView);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tv_lname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tv_fname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tv_address;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tv_age;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tv_id;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagrid;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_actionform;
        private Bunifu.Framework.UI.BunifuDropdown combo_select;
        private Bunifu.Framework.UI.BunifuCustomLabel cross_btn;
    }
}

