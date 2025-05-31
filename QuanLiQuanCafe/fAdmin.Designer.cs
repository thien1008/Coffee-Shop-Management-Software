namespace QuanLiQuanCafe
{
    partial class fAdmin
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
            tcAdmin = new TabControl();
            tpBill = new TabPage();
            panel2 = new Panel();
            btnViewBill = new Button();
            dtpkToDay = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            panel1 = new Panel();
            txbPageBill = new TextBox();
            btnNextBillPage = new Button();
            btnPrevioursBillPage = new Button();
            btnLastBillPage = new Button();
            btnFirstBillPage = new Button();
            dtgvBill = new DataGridView();
            tpFood = new TabPage();
            panel6 = new Panel();
            txbSearchFoodName = new TextBox();
            btnSearchFood = new Button();
            panel5 = new Panel();
            panel10 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label4 = new Label();
            panel9 = new Panel();
            cbFoodCategory = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            txbFoodName = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            txbFoodID = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            btnShowFood = new Button();
            btnEditFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            panel3 = new Panel();
            dtgvFood = new DataGridView();
            tpFoodCategory = new TabPage();
            panel12 = new Panel();
            panel15 = new Panel();
            txbCategoryName = new TextBox();
            label7 = new Label();
            panel16 = new Panel();
            txbCategoryID = new TextBox();
            label8 = new Label();
            panel17 = new Panel();
            btnShowCategory = new Button();
            btnEditCategory = new Button();
            btnDeleteCtegory = new Button();
            btnAddCategory = new Button();
            panel18 = new Panel();
            dtgvCategory = new DataGridView();
            tbTable = new TabPage();
            panel11 = new Panel();
            panel21 = new Panel();
            txbTableStatus = new TextBox();
            label9 = new Label();
            panel13 = new Panel();
            txbTableName = new TextBox();
            label5 = new Label();
            panel14 = new Panel();
            txbTableID = new TextBox();
            label6 = new Label();
            panel19 = new Panel();
            btnShowTable = new Button();
            btnEditTable = new Button();
            btnDeleteTabla = new Button();
            btnAddTable = new Button();
            panel20 = new Panel();
            dtgvTable = new DataGridView();
            tpAccount = new TabPage();
            panel23 = new Panel();
            btnResetPassword = new Button();
            panel25 = new Panel();
            nmType = new NumericUpDown();
            label11 = new Label();
            panel26 = new Panel();
            txbDisplayName = new TextBox();
            label12 = new Label();
            panel27 = new Panel();
            txbUserName = new TextBox();
            label13 = new Label();
            panel28 = new Panel();
            btnShowAccount = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
            panel29 = new Panel();
            dtgvAccount = new DataGridView();
            tabPage1 = new TabPage();
            tcAdmin.SuspendLayout();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            tpFood.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            tpFoodCategory.SuspendLayout();
            panel12.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            tbTable.SuspendLayout();
            panel11.SuspendLayout();
            panel21.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            tpAccount.SuspendLayout();
            panel23.SuspendLayout();
            panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmType).BeginInit();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            panel28.SuspendLayout();
            panel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpBill);
            tcAdmin.Controls.Add(tpFood);
            tcAdmin.Controls.Add(tpFoodCategory);
            tcAdmin.Controls.Add(tbTable);
            tcAdmin.Controls.Add(tpAccount);
            tcAdmin.Controls.Add(tabPage1);
            tcAdmin.Location = new Point(12, 12);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(950, 624);
            tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 29);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(942, 591);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnViewBill);
            panel2.Controls.Add(dtpkToDay);
            panel2.Controls.Add(dtpkFromDate);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 34);
            panel2.TabIndex = 3;
            // 
            // btnViewBill
            // 
            btnViewBill.BackColor = SystemColors.ActiveBorder;
            btnViewBill.Location = new Point(442, 2);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(94, 29);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "Thống kê";
            btnViewBill.UseVisualStyleBackColor = false;
            btnViewBill.Click += btnViewBill_Click;
            // 
            // dtpkToDay
            // 
            dtpkToDay.Location = new Point(677, 4);
            dtpkToDay.Name = "dtpkToDay";
            dtpkToDay.Size = new Size(250, 27);
            dtpkToDay.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(3, 3);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(250, 27);
            dtpkFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbPageBill);
            panel1.Controls.Add(btnNextBillPage);
            panel1.Controls.Add(btnPrevioursBillPage);
            panel1.Controls.Add(btnLastBillPage);
            panel1.Controls.Add(btnFirstBillPage);
            panel1.Controls.Add(dtgvBill);
            panel1.Location = new Point(6, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 539);
            panel1.TabIndex = 2;
            // 
            // txbPageBill
            // 
            txbPageBill.Location = new Point(407, 506);
            txbPageBill.Name = "txbPageBill";
            txbPageBill.ReadOnly = true;
            txbPageBill.Size = new Size(129, 27);
            txbPageBill.TabIndex = 5;
            txbPageBill.Text = "1";
            txbPageBill.TextAlign = HorizontalAlignment.Center;
            txbPageBill.TextChanged += txbPageBill_TextChanged;
            // 
            // btnNextBillPage
            // 
            btnNextBillPage.BackColor = SystemColors.ActiveBorder;
            btnNextBillPage.Location = new Point(690, 503);
            btnNextBillPage.Name = "btnNextBillPage";
            btnNextBillPage.Size = new Size(116, 33);
            btnNextBillPage.TabIndex = 4;
            btnNextBillPage.Text = "Next";
            btnNextBillPage.UseVisualStyleBackColor = false;
            btnNextBillPage.Click += btnNextBillPage_Click;
            // 
            // btnPrevioursBillPage
            // 
            btnPrevioursBillPage.BackColor = SystemColors.ActiveBorder;
            btnPrevioursBillPage.Location = new Point(118, 503);
            btnPrevioursBillPage.Name = "btnPrevioursBillPage";
            btnPrevioursBillPage.Size = new Size(116, 33);
            btnPrevioursBillPage.TabIndex = 3;
            btnPrevioursBillPage.Text = "Previours";
            btnPrevioursBillPage.UseVisualStyleBackColor = false;
            btnPrevioursBillPage.Click += btnPrevioursBillPage_Click;
            // 
            // btnLastBillPage
            // 
            btnLastBillPage.BackColor = SystemColors.ActiveBorder;
            btnLastBillPage.Location = new Point(812, 503);
            btnLastBillPage.Name = "btnLastBillPage";
            btnLastBillPage.Size = new Size(115, 33);
            btnLastBillPage.TabIndex = 2;
            btnLastBillPage.Text = "Last";
            btnLastBillPage.UseVisualStyleBackColor = false;
            btnLastBillPage.Click += btnLastBillPage_Click;
            // 
            // btnFirstBillPage
            // 
            btnFirstBillPage.BackColor = SystemColors.ActiveBorder;
            btnFirstBillPage.Location = new Point(3, 503);
            btnFirstBillPage.Name = "btnFirstBillPage";
            btnFirstBillPage.Size = new Size(109, 33);
            btnFirstBillPage.TabIndex = 1;
            btnFirstBillPage.Text = "First";
            btnFirstBillPage.UseVisualStyleBackColor = false;
            btnFirstBillPage.Click += btnFirstBillPage_Click;
            // 
            // dtgvBill
            // 
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(3, 3);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 51;
            dtgvBill.RowTemplate.Height = 29;
            dtgvBill.Size = new Size(924, 494);
            dtgvBill.TabIndex = 0;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 29);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(942, 591);
            tpFood.TabIndex = 1;
            tpFood.Text = "Thức ăn";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(txbSearchFoodName);
            panel6.Controls.Add(btnSearchFood);
            panel6.Location = new Point(517, 9);
            panel6.Name = "panel6";
            panel6.Size = new Size(419, 77);
            panel6.TabIndex = 3;
            // 
            // txbSearchFoodName
            // 
            txbSearchFoodName.Location = new Point(3, 25);
            txbSearchFoodName.Name = "txbSearchFoodName";
            txbSearchFoodName.Size = new Size(313, 27);
            txbSearchFoodName.TabIndex = 5;
            // 
            // btnSearchFood
            // 
            btnSearchFood.BackColor = SystemColors.ActiveBorder;
            btnSearchFood.Location = new Point(322, 3);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(94, 71);
            btnSearchFood.TabIndex = 4;
            btnSearchFood.Text = "Tìm";
            btnSearchFood.UseVisualStyleBackColor = false;
            btnSearchFood.Click += btnSearchFood_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(517, 92);
            panel5.Name = "panel5";
            panel5.Size = new Size(419, 493);
            panel5.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Controls.Add(nmFoodPrice);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(3, 180);
            panel10.Name = "panel10";
            panel10.Size = new Size(413, 53);
            panel10.TabIndex = 4;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(121, 10);
            nmFoodPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(289, 27);
            nmFoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(49, 24);
            label4.TabIndex = 0;
            label4.Text = "Giá:";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbFoodCategory);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(3, 121);
            panel9.Name = "panel9";
            panel9.Size = new Size(413, 53);
            panel9.TabIndex = 3;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(121, 10);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(289, 28);
            cbFoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(112, 24);
            label3.TabIndex = 0;
            label3.Text = "Danh mục:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txbFoodName);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(3, 62);
            panel8.Name = "panel8";
            panel8.Size = new Size(413, 53);
            panel8.TabIndex = 2;
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(121, 10);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(289, 27);
            txbFoodName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 0;
            label2.Text = "Tên món:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbFoodID);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(413, 53);
            panel7.TabIndex = 1;
            // 
            // txbFoodID
            // 
            txbFoodID.Location = new Point(121, 10);
            txbFoodID.Name = "txbFoodID";
            txbFoodID.ReadOnly = true;
            txbFoodID.Size = new Size(289, 27);
            txbFoodID.TabIndex = 1;
            txbFoodID.TextChanged += txbFoodID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(36, 24);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnShowFood);
            panel4.Controls.Add(btnEditFood);
            panel4.Controls.Add(btnDeleteFood);
            panel4.Controls.Add(btnAddFood);
            panel4.Location = new Point(6, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(505, 77);
            panel4.TabIndex = 1;
            // 
            // btnShowFood
            // 
            btnShowFood.BackColor = SystemColors.ActiveBorder;
            btnShowFood.Location = new Point(408, 3);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(94, 71);
            btnShowFood.TabIndex = 3;
            btnShowFood.Text = "Xem";
            btnShowFood.UseVisualStyleBackColor = false;
            btnShowFood.Click += btnShowFood_Click;
            // 
            // btnEditFood
            // 
            btnEditFood.BackColor = SystemColors.ActiveBorder;
            btnEditFood.Location = new Point(277, 3);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(94, 71);
            btnEditFood.TabIndex = 2;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = false;
            btnEditFood.Click += btnEditFood_Click;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.BackColor = SystemColors.ActiveBorder;
            btnDeleteFood.Location = new Point(142, 3);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(94, 71);
            btnDeleteFood.TabIndex = 1;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = false;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = SystemColors.ActiveBorder;
            btnAddFood.Location = new Point(3, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(94, 71);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvFood);
            panel3.Location = new Point(6, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(505, 493);
            panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(3, 3);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.RowTemplate.Height = 29;
            dtgvFood.Size = new Size(499, 487);
            dtgvFood.TabIndex = 0;
            // 
            // tpFoodCategory
            // 
            tpFoodCategory.Controls.Add(panel12);
            tpFoodCategory.Controls.Add(panel17);
            tpFoodCategory.Controls.Add(panel18);
            tpFoodCategory.Location = new Point(4, 29);
            tpFoodCategory.Name = "tpFoodCategory";
            tpFoodCategory.Padding = new Padding(3);
            tpFoodCategory.Size = new Size(942, 591);
            tpFoodCategory.TabIndex = 2;
            tpFoodCategory.Text = "Danh mục";
            tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel15);
            panel12.Controls.Add(panel16);
            panel12.Location = new Point(517, 90);
            panel12.Name = "panel12";
            panel12.Size = new Size(419, 493);
            panel12.TabIndex = 6;
            // 
            // panel15
            // 
            panel15.Controls.Add(txbCategoryName);
            panel15.Controls.Add(label7);
            panel15.Location = new Point(3, 62);
            panel15.Name = "panel15";
            panel15.Size = new Size(413, 53);
            panel15.TabIndex = 2;
            // 
            // txbCategoryName
            // 
            txbCategoryName.Location = new Point(161, 10);
            txbCategoryName.Name = "txbCategoryName";
            txbCategoryName.Size = new Size(249, 27);
            txbCategoryName.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 10);
            label7.Name = "label7";
            label7.Size = new Size(152, 24);
            label7.TabIndex = 0;
            label7.Text = "Tên danh mục:";
            // 
            // panel16
            // 
            panel16.Controls.Add(txbCategoryID);
            panel16.Controls.Add(label8);
            panel16.Location = new Point(3, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(413, 53);
            panel16.TabIndex = 1;
            // 
            // txbCategoryID
            // 
            txbCategoryID.Location = new Point(161, 10);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(249, 27);
            txbCategoryID.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 10);
            label8.Name = "label8";
            label8.Size = new Size(36, 24);
            label8.TabIndex = 0;
            label8.Text = "ID:";
            // 
            // panel17
            // 
            panel17.Controls.Add(btnShowCategory);
            panel17.Controls.Add(btnEditCategory);
            panel17.Controls.Add(btnDeleteCtegory);
            panel17.Controls.Add(btnAddCategory);
            panel17.Location = new Point(6, 7);
            panel17.Name = "panel17";
            panel17.Size = new Size(505, 77);
            panel17.TabIndex = 5;
            // 
            // btnShowCategory
            // 
            btnShowCategory.BackColor = SystemColors.ActiveBorder;
            btnShowCategory.Location = new Point(408, 3);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(94, 71);
            btnShowCategory.TabIndex = 3;
            btnShowCategory.Text = "Xem";
            btnShowCategory.UseVisualStyleBackColor = false;
            btnShowCategory.Click += btnShowCategory_Click;
            // 
            // btnEditCategory
            // 
            btnEditCategory.BackColor = SystemColors.ActiveBorder;
            btnEditCategory.Location = new Point(275, 3);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(94, 71);
            btnEditCategory.TabIndex = 2;
            btnEditCategory.Text = "Sửa";
            btnEditCategory.UseVisualStyleBackColor = false;
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // btnDeleteCtegory
            // 
            btnDeleteCtegory.BackColor = SystemColors.ActiveBorder;
            btnDeleteCtegory.Enabled = false;
            btnDeleteCtegory.Location = new Point(139, 3);
            btnDeleteCtegory.Name = "btnDeleteCtegory";
            btnDeleteCtegory.Size = new Size(94, 71);
            btnDeleteCtegory.TabIndex = 1;
            btnDeleteCtegory.Text = "Xóa";
            btnDeleteCtegory.UseVisualStyleBackColor = false;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = SystemColors.ActiveBorder;
            btnAddCategory.Location = new Point(3, 3);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(94, 71);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // panel18
            // 
            panel18.Controls.Add(dtgvCategory);
            panel18.Location = new Point(6, 90);
            panel18.Name = "panel18";
            panel18.Size = new Size(505, 493);
            panel18.TabIndex = 4;
            // 
            // dtgvCategory
            // 
            dtgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(3, 3);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.RowHeadersWidth = 51;
            dtgvCategory.RowTemplate.Height = 29;
            dtgvCategory.Size = new Size(499, 487);
            dtgvCategory.TabIndex = 0;
            // 
            // tbTable
            // 
            tbTable.Controls.Add(panel11);
            tbTable.Controls.Add(panel19);
            tbTable.Controls.Add(panel20);
            tbTable.Location = new Point(4, 29);
            tbTable.Name = "tbTable";
            tbTable.Padding = new Padding(3);
            tbTable.Size = new Size(942, 591);
            tbTable.TabIndex = 3;
            tbTable.Text = "Bàn ăn";
            tbTable.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel21);
            panel11.Controls.Add(panel13);
            panel11.Controls.Add(panel14);
            panel11.Location = new Point(517, 90);
            panel11.Name = "panel11";
            panel11.Size = new Size(419, 493);
            panel11.TabIndex = 9;
            // 
            // panel21
            // 
            panel21.Controls.Add(txbTableStatus);
            panel21.Controls.Add(label9);
            panel21.Location = new Point(3, 121);
            panel21.Name = "panel21";
            panel21.Size = new Size(413, 53);
            panel21.TabIndex = 3;
            // 
            // txbTableStatus
            // 
            txbTableStatus.Location = new Point(161, 10);
            txbTableStatus.Name = "txbTableStatus";
            txbTableStatus.Size = new Size(249, 27);
            txbTableStatus.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 10);
            label9.Name = "label9";
            label9.Size = new Size(113, 24);
            label9.TabIndex = 0;
            label9.Text = "Trạng thái:";
            // 
            // panel13
            // 
            panel13.Controls.Add(txbTableName);
            panel13.Controls.Add(label5);
            panel13.Location = new Point(3, 62);
            panel13.Name = "panel13";
            panel13.Size = new Size(413, 53);
            panel13.TabIndex = 2;
            // 
            // txbTableName
            // 
            txbTableName.Location = new Point(161, 10);
            txbTableName.Name = "txbTableName";
            txbTableName.Size = new Size(249, 27);
            txbTableName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(94, 24);
            label5.TabIndex = 0;
            label5.Text = "Tên bàn:";
            // 
            // panel14
            // 
            panel14.Controls.Add(txbTableID);
            panel14.Controls.Add(label6);
            panel14.Location = new Point(3, 3);
            panel14.Name = "panel14";
            panel14.Size = new Size(413, 53);
            panel14.TabIndex = 1;
            // 
            // txbTableID
            // 
            txbTableID.Location = new Point(161, 10);
            txbTableID.Name = "txbTableID";
            txbTableID.ReadOnly = true;
            txbTableID.Size = new Size(249, 27);
            txbTableID.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(36, 24);
            label6.TabIndex = 0;
            label6.Text = "ID:";
            // 
            // panel19
            // 
            panel19.Controls.Add(btnShowTable);
            panel19.Controls.Add(btnEditTable);
            panel19.Controls.Add(btnDeleteTabla);
            panel19.Controls.Add(btnAddTable);
            panel19.Location = new Point(6, 7);
            panel19.Name = "panel19";
            panel19.Size = new Size(505, 77);
            panel19.TabIndex = 8;
            // 
            // btnShowTable
            // 
            btnShowTable.BackColor = SystemColors.ActiveBorder;
            btnShowTable.Location = new Point(408, 3);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(94, 71);
            btnShowTable.TabIndex = 3;
            btnShowTable.Text = "Xem";
            btnShowTable.UseVisualStyleBackColor = false;
            btnShowTable.Click += btnShowTable_Click;
            // 
            // btnEditTable
            // 
            btnEditTable.BackColor = SystemColors.ActiveBorder;
            btnEditTable.Location = new Point(275, 3);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(94, 71);
            btnEditTable.TabIndex = 2;
            btnEditTable.Text = "Sửa";
            btnEditTable.UseVisualStyleBackColor = false;
            btnEditTable.Click += btnEditTable_Click;
            // 
            // btnDeleteTabla
            // 
            btnDeleteTabla.BackColor = SystemColors.ActiveBorder;
            btnDeleteTabla.Enabled = false;
            btnDeleteTabla.Location = new Point(137, 3);
            btnDeleteTabla.Name = "btnDeleteTabla";
            btnDeleteTabla.Size = new Size(94, 71);
            btnDeleteTabla.TabIndex = 1;
            btnDeleteTabla.Text = "Xóa";
            btnDeleteTabla.UseVisualStyleBackColor = false;
            // 
            // btnAddTable
            // 
            btnAddTable.BackColor = SystemColors.ActiveBorder;
            btnAddTable.Location = new Point(3, 3);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(94, 71);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = false;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // panel20
            // 
            panel20.Controls.Add(dtgvTable);
            panel20.Location = new Point(6, 90);
            panel20.Name = "panel20";
            panel20.Size = new Size(505, 493);
            panel20.TabIndex = 7;
            // 
            // dtgvTable
            // 
            dtgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(3, 3);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.RowHeadersWidth = 51;
            dtgvTable.RowTemplate.Height = 29;
            dtgvTable.Size = new Size(499, 487);
            dtgvTable.TabIndex = 0;
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel23);
            tpAccount.Controls.Add(panel28);
            tpAccount.Controls.Add(panel29);
            tpAccount.Location = new Point(4, 29);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(942, 591);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Tài khoản";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel23
            // 
            panel23.Controls.Add(btnResetPassword);
            panel23.Controls.Add(panel25);
            panel23.Controls.Add(panel26);
            panel23.Controls.Add(panel27);
            panel23.Location = new Point(517, 90);
            panel23.Name = "panel23";
            panel23.Size = new Size(419, 493);
            panel23.TabIndex = 6;
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = SystemColors.ActiveBorder;
            btnResetPassword.Location = new Point(322, 180);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(94, 71);
            btnResetPassword.TabIndex = 4;
            btnResetPassword.Text = "Đặt lại mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // panel25
            // 
            panel25.Controls.Add(nmType);
            panel25.Controls.Add(label11);
            panel25.Location = new Point(3, 121);
            panel25.Name = "panel25";
            panel25.Size = new Size(413, 53);
            panel25.TabIndex = 3;
            // 
            // nmType
            // 
            nmType.Location = new Point(155, 10);
            nmType.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nmType.Name = "nmType";
            nmType.Size = new Size(40, 27);
            nmType.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 10);
            label11.Name = "label11";
            label11.Size = new Size(150, 24);
            label11.TabIndex = 0;
            label11.Text = "Loại tài khoản:";
            // 
            // panel26
            // 
            panel26.Controls.Add(txbDisplayName);
            panel26.Controls.Add(label12);
            panel26.Location = new Point(3, 62);
            panel26.Name = "panel26";
            panel26.Size = new Size(413, 53);
            panel26.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(155, 10);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(255, 27);
            txbDisplayName.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 10);
            label12.Name = "label12";
            label12.Size = new Size(129, 24);
            label12.TabIndex = 0;
            label12.Text = "Tên hiển thị:";
            // 
            // panel27
            // 
            panel27.Controls.Add(txbUserName);
            panel27.Controls.Add(label13);
            panel27.Location = new Point(3, 3);
            panel27.Name = "panel27";
            panel27.Size = new Size(413, 53);
            panel27.TabIndex = 1;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(155, 10);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(255, 27);
            txbUserName.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(3, 10);
            label13.Name = "label13";
            label13.Size = new Size(146, 24);
            label13.TabIndex = 0;
            label13.Text = "Tên tài khoản:";
            // 
            // panel28
            // 
            panel28.Controls.Add(btnShowAccount);
            panel28.Controls.Add(btnEditAccount);
            panel28.Controls.Add(btnDeleteAccount);
            panel28.Controls.Add(btnAddAccount);
            panel28.Location = new Point(6, 7);
            panel28.Name = "panel28";
            panel28.Size = new Size(505, 77);
            panel28.TabIndex = 5;
            // 
            // btnShowAccount
            // 
            btnShowAccount.BackColor = SystemColors.ActiveBorder;
            btnShowAccount.Location = new Point(408, 3);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(94, 71);
            btnShowAccount.TabIndex = 3;
            btnShowAccount.Text = "Xem";
            btnShowAccount.UseVisualStyleBackColor = false;
            btnShowAccount.Click += btnShowAccount_Click;
            // 
            // btnEditAccount
            // 
            btnEditAccount.BackColor = SystemColors.ActiveBorder;
            btnEditAccount.Location = new Point(274, 3);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(94, 71);
            btnEditAccount.TabIndex = 2;
            btnEditAccount.Text = "Sửa";
            btnEditAccount.UseVisualStyleBackColor = false;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = SystemColors.ActiveBorder;
            btnDeleteAccount.Location = new Point(141, 3);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(94, 71);
            btnDeleteAccount.TabIndex = 1;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.BackColor = SystemColors.ActiveBorder;
            btnAddAccount.Location = new Point(3, 3);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(94, 71);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = false;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // panel29
            // 
            panel29.Controls.Add(dtgvAccount);
            panel29.Location = new Point(6, 90);
            panel29.Name = "panel29";
            panel29.Size = new Size(505, 493);
            panel29.TabIndex = 4;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 3);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.RowTemplate.Height = 29;
            dtgvAccount.Size = new Size(499, 487);
            dtgvAccount.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(942, 591);
            tabPage1.TabIndex = 5;
            tabPage1.Text = "Report";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 648);
            Controls.Add(tcAdmin);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tcAdmin.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            tpFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            tpFoodCategory.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            tbTable.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel19.ResumeLayout(false);
            panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            tpAccount.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmType).EndInit();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel28.ResumeLayout(false);
            panel29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tpBill;
        private TabPage tpFood;
        private TabPage tpFoodCategory;
        private TabPage tbTable;
        private TabPage tpAccount;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Button btnEditFood;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private Panel panel3;
        private Button btnShowFood;
        private DataGridView dtgvFood;
        private TextBox txbSearchFoodName;
        private Button btnSearchFood;
        private Panel panel8;
        private TextBox txbFoodName;
        private Label label2;
        private Panel panel7;
        private TextBox txbFoodID;
        private Label label1;
        private Panel panel10;
        private NumericUpDown nmFoodPrice;
        private Label label4;
        private Panel panel9;
        private ComboBox cbFoodCategory;
        private Label label3;
        private Panel panel2;
        private Button btnViewBill;
        private DateTimePicker dtpkToDay;
        private DateTimePicker dtpkFromDate;
        private Panel panel1;
        private DataGridView dtgvBill;
        private Panel panel12;
        private Panel panel15;
        private TextBox txbCategoryName;
        private Label label7;
        private Panel panel16;
        private TextBox txbCategoryID;
        private Label label8;
        private Panel panel17;
        private Button btnShowCategory;
        private Button btnEditCategory;
        private Button btnDeleteCtegory;
        private Button btnAddCategory;
        private Panel panel18;
        private DataGridView dtgvCategory;
        private Panel panel11;
        private Panel panel21;
        private Label label9;
        private Panel panel13;
        private TextBox txbTableName;
        private Label label5;
        private Panel panel14;
        private TextBox txbTableID;
        private Label label6;
        private Panel panel19;
        private Button btnShowTable;
        private Button btnEditTable;
        private Button btnDeleteTabla;
        private Button btnAddTable;
        private Panel panel20;
        private DataGridView dtgvTable;
        private Panel panel23;
        private Panel panel25;
        private Label label11;
        private Panel panel26;
        private TextBox txbDisplayName;
        private Label label12;
        private Panel panel27;
        private TextBox txbUserName;
        private Label label13;
        private Panel panel28;
        private Button btnShowAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private Panel panel29;
        private DataGridView dtgvAccount;
        private Button btnResetPassword;
        private NumericUpDown nmType;
        private Button btnNextBillPage;
        private Button btnPrevioursBillPage;
        private Button btnLastBillPage;
        private Button btnFirstBillPage;
        private TextBox txbPageBill;
        private TabPage tabPage1;
        private TextBox txbTableStatus;
    }
}