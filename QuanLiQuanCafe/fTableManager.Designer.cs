namespace QuanLiQuanCafe
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáToolStripMenuItem = new ToolStripMenuItem();
            đăngToolStripMenuItem = new ToolStripMenuItem();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            thanhToánToolStripMenuItem = new ToolStripMenuItem();
            thêmMónToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            txbTotalPrice = new TextBox();
            cbSwitchTable = new ComboBox();
            btnSwitchTable = new Button();
            nmDiscount = new NumericUpDown();
            btnDiscount = new Button();
            btnCheckOut = new Button();
            panel4 = new Panel();
            nmFoodCount = new NumericUpDown();
            btnAddFood = new Button();
            cbFood = new ComboBox();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiToolStripMenuItem, chứcNăngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1140, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += toolStripMenuItem1_Click;
            // 
            // thôngTinTàiToolStripMenuItem
            // 
            thôngTinTàiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáToolStripMenuItem, đăngToolStripMenuItem });
            thôngTinTàiToolStripMenuItem.Name = "thôngTinTàiToolStripMenuItem";
            thôngTinTàiToolStripMenuItem.Size = new Size(151, 24);
            thôngTinTàiToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáToolStripMenuItem
            // 
            thôngTinCáToolStripMenuItem.Enabled = false;
            thôngTinCáToolStripMenuItem.Name = "thôngTinCáToolStripMenuItem";
            thôngTinCáToolStripMenuItem.Size = new Size(224, 26);
            thôngTinCáToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáToolStripMenuItem.Click += thôngTinCáToolStripMenuItem_Click;
            // 
            // đăngToolStripMenuItem
            // 
            đăngToolStripMenuItem.Name = "đăngToolStripMenuItem";
            đăngToolStripMenuItem.Size = new Size(224, 26);
            đăngToolStripMenuItem.Text = "Đăng xuất";
            đăngToolStripMenuItem.Click += đăngToolStripMenuItem_Click;
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thanhToánToolStripMenuItem, thêmMónToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(93, 24);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thanhToánToolStripMenuItem
            // 
            thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            thanhToánToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            thanhToánToolStripMenuItem.Size = new Size(217, 26);
            thanhToánToolStripMenuItem.Text = "Thanh toán";
            thanhToánToolStripMenuItem.Click += thanhToánToolStripMenuItem_Click;
            // 
            // thêmMónToolStripMenuItem
            // 
            thêmMónToolStripMenuItem.Name = "thêmMónToolStripMenuItem";
            thêmMónToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            thêmMónToolStripMenuItem.Size = new Size(217, 26);
            thêmMónToolStripMenuItem.Text = "Thêm món";
            thêmMónToolStripMenuItem.Click += thêmMónToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(680, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(448, 468);
            panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(5, 3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(440, 455);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 110;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbTotalPrice);
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(nmDiscount);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(680, 580);
            panel3.Name = "panel3";
            panel3.Size = new Size(448, 68);
            panel3.TabIndex = 0;
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txbTotalPrice.ForeColor = Color.OrangeRed;
            txbTotalPrice.Location = new Point(203, 21);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new Size(142, 28);
            txbTotalPrice.TabIndex = 7;
            txbTotalPrice.Text = "0";
            txbTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(3, 37);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(94, 28);
            cbSwitchTable.TabIndex = 2;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.BackColor = SystemColors.ActiveBorder;
            btnSwitchTable.Location = new Point(3, 3);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(94, 35);
            btnSwitchTable.TabIndex = 6;
            btnSwitchTable.Text = "Chuyển bàn";
            btnSwitchTable.UseVisualStyleBackColor = false;
            btnSwitchTable.Click += btnSwitchTable_Click;
            // 
            // nmDiscount
            // 
            nmDiscount.Location = new Point(103, 38);
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new Size(92, 27);
            nmDiscount.TabIndex = 5;
            nmDiscount.TextAlign = HorizontalAlignment.Center;
            nmDiscount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(103, 3);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(92, 35);
            btnDiscount.TabIndex = 4;
            btnDiscount.Text = "Giảm giá";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = SystemColors.ActiveBorder;
            btnCheckOut.Location = new Point(351, 3);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(94, 62);
            btnCheckOut.TabIndex = 3;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(nmFoodCount);
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(cbFood);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(680, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(448, 69);
            panel4.TabIndex = 3;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new Point(392, 23);
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(51, 27);
            nmFoodCount.TabIndex = 1;
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = SystemColors.ActiveBorder;
            btnAddFood.Location = new Point(292, 0);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(94, 69);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "Thêm món";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(3, 37);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(283, 28);
            cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(3, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(283, 28);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.BackColor = Color.FromArgb(255, 255, 192);
            flpTable.Location = new Point(12, 31);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(659, 617);
            flpTable.TabIndex = 4;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 660);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lí quán cafe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáToolStripMenuItem;
        private ToolStripMenuItem đăngToolStripMenuItem;
        private Panel panel2;
        private ListView lsvBill;
        private Panel panel3;
        private Panel panel4;
        private NumericUpDown nmFoodCount;
        private Button btnAddFood;
        private ComboBox cbFood;
        private ComboBox cbCategory;
        private ComboBox cbSwitchTable;
        private Button btnSwitchTable;
        private NumericUpDown nmDiscount;
        private Button btnDiscount;
        private Button btnCheckOut;
        private FlowLayoutPanel flpTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbTotalPrice;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem thanhToánToolStripMenuItem;
        private ToolStripMenuItem thêmMónToolStripMenuItem;
    }
}