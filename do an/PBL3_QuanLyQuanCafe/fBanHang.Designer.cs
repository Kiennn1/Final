namespace PBL3_QuanLyQuanCafe
{
    partial class fBanHang
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
            this.flowpanelTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.listViewHoadon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxDanhmuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButtonThemmon = new FontAwesome.Sharp.IconButton();
            this.iconButtonXoamon = new FontAwesome.Sharp.IconButton();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.flowpanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTieude = new System.Windows.Forms.Label();
            this.iconButtonHuyHoaDon = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.panelHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // flowpanelTable
            // 
            this.flowpanelTable.AutoScroll = true;
            this.flowpanelTable.Location = new System.Drawing.Point(12, 21);
            this.flowpanelTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowpanelTable.Name = "flowpanelTable";
            this.flowpanelTable.Size = new System.Drawing.Size(324, 541);
            this.flowpanelTable.TabIndex = 0;
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.Controls.Add(this.listViewHoadon);
            this.panelHoaDon.Location = new System.Drawing.Point(674, 141);
            this.panelHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(355, 422);
            this.panelHoaDon.TabIndex = 3;
            // 
            // listViewHoadon
            // 
            this.listViewHoadon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewHoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewHoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewHoadon.FullRowSelect = true;
            this.listViewHoadon.GridLines = true;
            this.listViewHoadon.HideSelection = false;
            this.listViewHoadon.Location = new System.Drawing.Point(0, 0);
            this.listViewHoadon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewHoadon.Name = "listViewHoadon";
            this.listViewHoadon.Size = new System.Drawing.Size(355, 422);
            this.listViewHoadon.TabIndex = 0;
            this.listViewHoadon.UseCompatibleStateImageBehavior = false;
            this.listViewHoadon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 143;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 125;
            // 
            // comboBoxDanhmuc
            // 
            this.comboBoxDanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDanhmuc.FormattingEnabled = true;
            this.comboBoxDanhmuc.Location = new System.Drawing.Point(449, 31);
            this.comboBoxDanhmuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDanhmuc.Name = "comboBoxDanhmuc";
            this.comboBoxDanhmuc.Size = new System.Drawing.Size(195, 32);
            this.comboBoxDanhmuc.TabIndex = 4;
            this.comboBoxDanhmuc.SelectedIndexChanged += new System.EventHandler(this.comboBoxDanhmuc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh mục:";
            // 
            // iconButtonThemmon
            // 
            this.iconButtonThemmon.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonThemmon.IconColor = System.Drawing.Color.Green;
            this.iconButtonThemmon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThemmon.Location = new System.Drawing.Point(449, 65);
            this.iconButtonThemmon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButtonThemmon.Name = "iconButtonThemmon";
            this.iconButtonThemmon.Size = new System.Drawing.Size(90, 58);
            this.iconButtonThemmon.TabIndex = 6;
            this.iconButtonThemmon.Text = "Thêm món";
            this.iconButtonThemmon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonThemmon.UseVisualStyleBackColor = true;
            this.iconButtonThemmon.Click += new System.EventHandler(this.iconButtonThemmon_Click);
            // 
            // iconButtonXoamon
            // 
            this.iconButtonXoamon.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.iconButtonXoamon.IconColor = System.Drawing.Color.Maroon;
            this.iconButtonXoamon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonXoamon.Location = new System.Drawing.Point(554, 65);
            this.iconButtonXoamon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButtonXoamon.Name = "iconButtonXoamon";
            this.iconButtonXoamon.Size = new System.Drawing.Size(90, 58);
            this.iconButtonXoamon.TabIndex = 7;
            this.iconButtonXoamon.Text = "Xoá món";
            this.iconButtonXoamon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonXoamon.UseVisualStyleBackColor = true;
            this.iconButtonXoamon.Click += new System.EventHandler(this.iconButtonXoamon_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(339, 98);
            this.numericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(94, 29);
            this.numericUpDown.TabIndex = 8;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số lượng món:";
            // 
            // flowpanelMenu
            // 
            this.flowpanelMenu.AutoScroll = true;
            this.flowpanelMenu.Location = new System.Drawing.Point(338, 141);
            this.flowpanelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowpanelMenu.Name = "flowpanelMenu";
            this.flowpanelMenu.Size = new System.Drawing.Size(332, 422);
            this.flowpanelMenu.TabIndex = 10;
            this.flowpanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.flowpanelMenu_Paint);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(830, 55);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(112, 29);
            this.txtTongTien.TabIndex = 11;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconButton1.IconColor = System.Drawing.Color.Goldenrod;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(956, 46);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(72, 79);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.Text = "Thanh toán";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(754, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tổng tiền:";
            // 
            // labelTieude
            // 
            this.labelTieude.AutoSize = true;
            this.labelTieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieude.Location = new System.Drawing.Point(674, 12);
            this.labelTieude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTieude.Name = "labelTieude";
            this.labelTieude.Size = new System.Drawing.Size(0, 17);
            this.labelTieude.TabIndex = 14;
            // 
            // iconButtonHuyHoaDon
            // 
            this.iconButtonHuyHoaDon.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.iconButtonHuyHoaDon.IconColor = System.Drawing.Color.Firebrick;
            this.iconButtonHuyHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHuyHoaDon.Location = new System.Drawing.Point(674, 46);
            this.iconButtonHuyHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButtonHuyHoaDon.Name = "iconButtonHuyHoaDon";
            this.iconButtonHuyHoaDon.Size = new System.Drawing.Size(72, 79);
            this.iconButtonHuyHoaDon.TabIndex = 15;
            this.iconButtonHuyHoaDon.Text = "Huỷ hoá đơn";
            this.iconButtonHuyHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonHuyHoaDon.UseVisualStyleBackColor = true;
            this.iconButtonHuyHoaDon.Click += new System.EventHandler(this.iconButtonHuyHoaDon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(754, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Giảm giá (%):";
            // 
            // nmDiscount
            // 
            this.nmDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmDiscount.Location = new System.Drawing.Point(885, 94);
            this.nmDiscount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(56, 26);
            this.nmDiscount.TabIndex = 17;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1059, 644);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmDiscount);
            this.Controls.Add(this.iconButtonHuyHoaDon);
            this.Controls.Add(this.labelTieude);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.flowpanelMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.iconButtonXoamon);
            this.Controls.Add(this.iconButtonThemmon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDanhmuc);
            this.Controls.Add(this.panelHoaDon);
            this.Controls.Add(this.flowpanelTable);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fBanHang";
            this.Text = "fBanHang";
            this.panelHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowpanelTable;
        private System.Windows.Forms.Panel panelHoaDon;
        private System.Windows.Forms.ComboBox comboBoxDanhmuc;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonThemmon;
        private FontAwesome.Sharp.IconButton iconButtonXoamon;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowpanelMenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTieude;
        private FontAwesome.Sharp.IconButton iconButtonHuyHoaDon;
        public System.Windows.Forms.TextBox txtTongTien;
        public System.Windows.Forms.ListView listViewHoadon;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown nmDiscount;
    }
}