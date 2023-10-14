namespace ITCoffee.src.forms_children
{
    partial class fOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv_FoodCategory = new System.Windows.Forms.ListView();
            this.cl_FoodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_FoodPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fp_ListFoodCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Close = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txt_SearchFood = new System.Windows.Forms.TextBox();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lv_ListMenu = new System.Windows.Forms.ListView();
            this.cl_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Total_Mount = new System.Windows.Forms.Button();
            this.btn_CheckOutBill = new FontAwesome.Sharp.IconButton();
            this.btn_Total_Count = new System.Windows.Forms.Button();
            this.btn_Confirm = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_combineTable = new FontAwesome.Sharp.IconButton();
            this.btn_MoveTable = new FontAwesome.Sharp.IconButton();
            this.btn_DelBill = new FontAwesome.Sharp.IconButton();
            this.cb_ListTable = new System.Windows.Forms.ComboBox();
            this.btn_NameTable = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lv_FoodCategory);
            this.panel1.Controls.Add(this.fp_ListFoodCategory);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 677);
            this.panel1.TabIndex = 0;
            // 
            // lv_FoodCategory
            // 
            this.lv_FoodCategory.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_FoodCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.lv_FoodCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_FoodCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_FoodName,
            this.cl_FoodPrice});
            this.lv_FoodCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_FoodCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_FoodCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.lv_FoodCategory.FullRowSelect = true;
            this.lv_FoodCategory.HideSelection = false;
            this.lv_FoodCategory.Location = new System.Drawing.Point(211, 61);
            this.lv_FoodCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_FoodCategory.Name = "lv_FoodCategory";
            this.lv_FoodCategory.Size = new System.Drawing.Size(666, 616);
            this.lv_FoodCategory.TabIndex = 5;
            this.lv_FoodCategory.UseCompatibleStateImageBehavior = false;
            this.lv_FoodCategory.View = System.Windows.Forms.View.Details;
            this.lv_FoodCategory.SelectedIndexChanged += new System.EventHandler(this.lv_FoodCategory_SelectedIndexChanged);
            // 
            // cl_FoodName
            // 
            this.cl_FoodName.Text = "FoodName";
            this.cl_FoodName.Width = 176;
            // 
            // cl_FoodPrice
            // 
            this.cl_FoodPrice.Text = "FoodPrice";
            this.cl_FoodPrice.Width = 207;
            // 
            // fp_ListFoodCategory
            // 
            this.fp_ListFoodCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.fp_ListFoodCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fp_ListFoodCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.fp_ListFoodCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.fp_ListFoodCategory.Location = new System.Drawing.Point(0, 61);
            this.fp_ListFoodCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fp_ListFoodCategory.Name = "fp_ListFoodCategory";
            this.fp_ListFoodCategory.Size = new System.Drawing.Size(211, 616);
            this.fp_ListFoodCategory.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Close);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txt_SearchFood);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(877, 61);
            this.panel3.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Close.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.Close.IconColor = System.Drawing.Color.White;
            this.Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Close.IconSize = 35;
            this.Close.Location = new System.Drawing.Point(836, 0);
            this.Close.Margin = new System.Windows.Forms.Padding(4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(39, 33);
            this.Close.TabIndex = 11;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.Location = new System.Drawing.Point(316, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 39);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm sản phẩm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txt_SearchFood
            // 
            this.txt_SearchFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.txt_SearchFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SearchFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.txt_SearchFood.Location = new System.Drawing.Point(36, 17);
            this.txt_SearchFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SearchFood.Name = "txt_SearchFood";
            this.txt_SearchFood.Size = new System.Drawing.Size(274, 26);
            this.txt_SearchFood.TabIndex = 0;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lv_ListMenu);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel2.Location = new System.Drawing.Point(877, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 677);
            this.panel2.TabIndex = 1;
            // 
            // lv_ListMenu
            // 
            this.lv_ListMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.lv_ListMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_ListMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_Name,
            this.cl_Count,
            this.cl_Price,
            this.cl_TotalPrice});
            this.lv_ListMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.lv_ListMenu.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lv_ListMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.lv_ListMenu.FullRowSelect = true;
            this.lv_ListMenu.HideSelection = false;
            this.lv_ListMenu.Location = new System.Drawing.Point(1, 118);
            this.lv_ListMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_ListMenu.Name = "lv_ListMenu";
            this.lv_ListMenu.Size = new System.Drawing.Size(407, 423);
            this.lv_ListMenu.TabIndex = 8;
            this.lv_ListMenu.UseCompatibleStateImageBehavior = false;
            this.lv_ListMenu.View = System.Windows.Forms.View.Details;
            this.lv_ListMenu.SelectedIndexChanged += new System.EventHandler(this.lv_ListMenu_SelectedIndexChanged);
            // 
            // cl_Name
            // 
            this.cl_Name.Text = "Name";
            this.cl_Name.Width = 112;
            // 
            // cl_Count
            // 
            this.cl_Count.Text = "Count";
            this.cl_Count.Width = 96;
            // 
            // cl_Price
            // 
            this.cl_Price.Text = "Price";
            this.cl_Price.Width = 108;
            // 
            // cl_TotalPrice
            // 
            this.cl_TotalPrice.Text = "Total Price";
            this.cl_TotalPrice.Width = 83;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btn_Total_Mount);
            this.panel5.Controls.Add(this.btn_CheckOutBill);
            this.panel5.Controls.Add(this.btn_Total_Count);
            this.panel5.Controls.Add(this.btn_Confirm);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.panel5.Location = new System.Drawing.Point(0, 541);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(408, 136);
            this.panel5.TabIndex = 10;
            // 
            // btn_Total_Mount
            // 
            this.btn_Total_Mount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.btn_Total_Mount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btn_Total_Mount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Total_Mount.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btn_Total_Mount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.btn_Total_Mount.Location = new System.Drawing.Point(221, 13);
            this.btn_Total_Mount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Total_Mount.Name = "btn_Total_Mount";
            this.btn_Total_Mount.Size = new System.Drawing.Size(151, 48);
            this.btn_Total_Mount.TabIndex = 1;
            this.btn_Total_Mount.Text = "Tổng tiền";
            this.btn_Total_Mount.UseVisualStyleBackColor = true;
            // 
            // btn_CheckOutBill
            // 
            this.btn_CheckOutBill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.btn_CheckOutBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btn_CheckOutBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheckOutBill.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btn_CheckOutBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.btn_CheckOutBill.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_CheckOutBill.IconColor = System.Drawing.Color.Black;
            this.btn_CheckOutBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CheckOutBill.Location = new System.Drawing.Point(44, 77);
            this.btn_CheckOutBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CheckOutBill.Name = "btn_CheckOutBill";
            this.btn_CheckOutBill.Size = new System.Drawing.Size(151, 44);
            this.btn_CheckOutBill.TabIndex = 0;
            this.btn_CheckOutBill.Text = "Thanh toán";
            this.btn_CheckOutBill.UseVisualStyleBackColor = true;
            this.btn_CheckOutBill.Click += new System.EventHandler(this.btn_CheckOutBill_Click);
            // 
            // btn_Total_Count
            // 
            this.btn_Total_Count.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.btn_Total_Count.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btn_Total_Count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Total_Count.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Total_Count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.btn_Total_Count.Location = new System.Drawing.Point(44, 14);
            this.btn_Total_Count.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Total_Count.Name = "btn_Total_Count";
            this.btn_Total_Count.Size = new System.Drawing.Size(151, 47);
            this.btn_Total_Count.TabIndex = 0;
            this.btn_Total_Count.Text = "Số lượng";
            this.btn_Total_Count.UseVisualStyleBackColor = true;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.btn_Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btn_Confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.btn_Confirm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Confirm.IconColor = System.Drawing.Color.Black;
            this.btn_Confirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Confirm.Location = new System.Drawing.Point(221, 77);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(151, 44);
            this.btn_Confirm.TabIndex = 1;
            this.btn_Confirm.Text = "Xác Nhận";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel4.Controls.Add(this.btn_combineTable);
            this.panel4.Controls.Add(this.btn_MoveTable);
            this.panel4.Controls.Add(this.btn_DelBill);
            this.panel4.Controls.Add(this.cb_ListTable);
            this.panel4.Controls.Add(this.btn_NameTable);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(408, 118);
            this.panel4.TabIndex = 9;
            // 
            // btn_combineTable
            // 
            this.btn_combineTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_combineTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.btn_combineTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btn_combineTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_combineTable.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btn_combineTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.btn_combineTable.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_combineTable.IconColor = System.Drawing.Color.Black;
            this.btn_combineTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_combineTable.Location = new System.Drawing.Point(87, 37);
            this.btn_combineTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_combineTable.Name = "btn_combineTable";
            this.btn_combineTable.Size = new System.Drawing.Size(249, 37);
            this.btn_combineTable.TabIndex = 1;
            this.btn_combineTable.Text = "Gộp Bàn";
            this.btn_combineTable.UseVisualStyleBackColor = true;
            this.btn_combineTable.Click += new System.EventHandler(this.btn_combineTable_Click);
            // 
            // btn_MoveTable
            // 
            this.btn_MoveTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MoveTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.btn_MoveTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btn_MoveTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MoveTable.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btn_MoveTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.btn_MoveTable.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_MoveTable.IconColor = System.Drawing.Color.Black;
            this.btn_MoveTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MoveTable.Location = new System.Drawing.Point(87, 0);
            this.btn_MoveTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_MoveTable.Name = "btn_MoveTable";
            this.btn_MoveTable.Size = new System.Drawing.Size(249, 37);
            this.btn_MoveTable.TabIndex = 2;
            this.btn_MoveTable.Text = "Chuyển Bàn";
            this.btn_MoveTable.UseVisualStyleBackColor = true;
            this.btn_MoveTable.Click += new System.EventHandler(this.btn_MoveTable_Click);
            // 
            // btn_DelBill
            // 
            this.btn_DelBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_DelBill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.btn_DelBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btn_DelBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DelBill.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btn_DelBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.btn_DelBill.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_DelBill.IconColor = System.Drawing.Color.Black;
            this.btn_DelBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DelBill.Location = new System.Drawing.Point(336, 0);
            this.btn_DelBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DelBill.Name = "btn_DelBill";
            this.btn_DelBill.Size = new System.Drawing.Size(72, 118);
            this.btn_DelBill.TabIndex = 3;
            this.btn_DelBill.Text = "Hủy Đơn";
            this.btn_DelBill.UseVisualStyleBackColor = true;
            this.btn_DelBill.Click += new System.EventHandler(this.btn_DelBill_Click);
            // 
            // cb_ListTable
            // 
            this.cb_ListTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.cb_ListTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ListTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ListTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.cb_ListTable.FormattingEnabled = true;
            this.cb_ListTable.Location = new System.Drawing.Point(87, 78);
            this.cb_ListTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_ListTable.Name = "cb_ListTable";
            this.cb_ListTable.Size = new System.Drawing.Size(247, 33);
            this.cb_ListTable.TabIndex = 4;
            // 
            // btn_NameTable
            // 
            this.btn_NameTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_NameTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.btn_NameTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btn_NameTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NameTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.btn_NameTable.Location = new System.Drawing.Point(0, 0);
            this.btn_NameTable.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NameTable.Name = "btn_NameTable";
            this.btn_NameTable.Size = new System.Drawing.Size(87, 118);
            this.btn_NameTable.TabIndex = 5;
            this.btn_NameTable.Text = "Bàn 1";
            this.btn_NameTable.UseVisualStyleBackColor = true;
            // 
            // fOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 677);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fOrder";
            this.Text = "Order";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel fp_ListFoodCategory;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TextBox txt_SearchFood;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconButton Close;
        private System.Windows.Forms.ListView lv_FoodCategory;
        private System.Windows.Forms.ColumnHeader cl_FoodName;
        private System.Windows.Forms.ColumnHeader cl_FoodPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lv_ListMenu;
        private System.Windows.Forms.ColumnHeader cl_Name;
        private System.Windows.Forms.ColumnHeader cl_Count;
        private System.Windows.Forms.ColumnHeader cl_Price;
        private System.Windows.Forms.ColumnHeader cl_TotalPrice;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_Total_Mount;
        private FontAwesome.Sharp.IconButton btn_CheckOutBill;
        private System.Windows.Forms.Button btn_Total_Count;
        private FontAwesome.Sharp.IconButton btn_Confirm;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btn_combineTable;
        private FontAwesome.Sharp.IconButton btn_MoveTable;
        private FontAwesome.Sharp.IconButton btn_DelBill;
        private System.Windows.Forms.ComboBox cb_ListTable;
        private System.Windows.Forms.Button btn_NameTable;
    }
}