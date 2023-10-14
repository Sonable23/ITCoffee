namespace ITCoffee
{
    partial class fSell
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
            this.Close = new FontAwesome.Sharp.IconButton();
            this.minimize = new FontAwesome.Sharp.IconButton();
            this.maximize = new FontAwesome.Sharp.IconButton();
            this.menu = new System.Windows.Forms.Panel();
            this.btnQuyDinh = new FontAwesome.Sharp.IconButton();
            this.btnPhongBan = new FontAwesome.Sharp.IconButton();
            this.btn_support = new FontAwesome.Sharp.IconButton();
            this.btn_BillHistory = new FontAwesome.Sharp.IconButton();
            this.btn_BillReport = new FontAwesome.Sharp.IconButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnUserManual = new FontAwesome.Sharp.IconButton();
            this.btnSyncData = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.icon_Menu = new FontAwesome.Sharp.IconButton();
            this.fp_container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.maximize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 33);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Silver;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Close.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.Close.IconColor = System.Drawing.Color.White;
            this.Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Close.IconSize = 20;
            this.Close.Location = new System.Drawing.Point(920, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(42, 27);
            this.Close.TabIndex = 10;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Silver;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimize.IconColor = System.Drawing.Color.White;
            this.minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimize.IconSize = 20;
            this.minimize.Location = new System.Drawing.Point(824, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(42, 27);
            this.minimize.TabIndex = 9;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // maximize
            // 
            this.maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize.BackColor = System.Drawing.Color.Silver;
            this.maximize.FlatAppearance.BorderSize = 0;
            this.maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maximize.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.maximize.IconColor = System.Drawing.Color.White;
            this.maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximize.IconSize = 20;
            this.maximize.Location = new System.Drawing.Point(872, 3);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(42, 27);
            this.maximize.TabIndex = 8;
            this.maximize.UseVisualStyleBackColor = false;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu.Controls.Add(this.btnQuyDinh);
            this.menu.Controls.Add(this.btnPhongBan);
            this.menu.Controls.Add(this.btn_support);
            this.menu.Controls.Add(this.btn_BillHistory);
            this.menu.Controls.Add(this.btn_BillReport);
            this.menu.Controls.Add(this.btnSetting);
            this.menu.Controls.Add(this.btnUserManual);
            this.menu.Controls.Add(this.btnSyncData);
            this.menu.Controls.Add(this.panel2);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.SystemColors.Control;
            this.menu.Location = new System.Drawing.Point(0, 33);
            this.menu.Margin = new System.Windows.Forms.Padding(2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(236, 505);
            this.menu.TabIndex = 1;
            // 
            // btnQuyDinh
            // 
            this.btnQuyDinh.BackColor = System.Drawing.Color.White;
            this.btnQuyDinh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuyDinh.FlatAppearance.BorderSize = 0;
            this.btnQuyDinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuyDinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnQuyDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuyDinh.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnQuyDinh.ForeColor = System.Drawing.Color.Black;
            this.btnQuyDinh.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.btnQuyDinh.IconColor = System.Drawing.Color.Black;
            this.btnQuyDinh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuyDinh.IconSize = 40;
            this.btnQuyDinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuyDinh.Location = new System.Drawing.Point(0, 431);
            this.btnQuyDinh.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuyDinh.Name = "btnQuyDinh";
            this.btnQuyDinh.Size = new System.Drawing.Size(236, 45);
            this.btnQuyDinh.TabIndex = 7;
            this.btnQuyDinh.Text = " Điều khoản";
            this.btnQuyDinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuyDinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuyDinh.UseVisualStyleBackColor = false;
            this.btnQuyDinh.Click += new System.EventHandler(this.btnQuyDinh_Click);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.BackColor = System.Drawing.Color.White;
            this.btnPhongBan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPhongBan.FlatAppearance.BorderSize = 0;
            this.btnPhongBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPhongBan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhongBan.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnPhongBan.ForeColor = System.Drawing.Color.Black;
            this.btnPhongBan.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnPhongBan.IconColor = System.Drawing.Color.Black;
            this.btnPhongBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPhongBan.IconSize = 40;
            this.btnPhongBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhongBan.Location = new System.Drawing.Point(0, 88);
            this.btnPhongBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(236, 45);
            this.btnPhongBan.TabIndex = 9;
            this.btnPhongBan.Text = " Phòng bàn";
            this.btnPhongBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhongBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhongBan.UseVisualStyleBackColor = false;
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // btn_support
            // 
            this.btn_support.BackColor = System.Drawing.Color.White;
            this.btn_support.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_support.FlatAppearance.BorderSize = 0;
            this.btn_support.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_support.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_support.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_support.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btn_support.ForeColor = System.Drawing.Color.Black;
            this.btn_support.IconChar = FontAwesome.Sharp.IconChar.PhoneFlip;
            this.btn_support.IconColor = System.Drawing.Color.Black;
            this.btn_support.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_support.IconSize = 40;
            this.btn_support.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_support.Location = new System.Drawing.Point(0, 333);
            this.btn_support.Margin = new System.Windows.Forms.Padding(2);
            this.btn_support.Name = "btn_support";
            this.btn_support.Size = new System.Drawing.Size(236, 45);
            this.btn_support.TabIndex = 8;
            this.btn_support.Text = " Hỗ trợ";
            this.btn_support.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_support.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_support.UseVisualStyleBackColor = false;
            this.btn_support.Click += new System.EventHandler(this.btn_support_Click);
            // 
            // btn_BillHistory
            // 
            this.btn_BillHistory.BackColor = System.Drawing.Color.White;
            this.btn_BillHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_BillHistory.FlatAppearance.BorderSize = 0;
            this.btn_BillHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_BillHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_BillHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BillHistory.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btn_BillHistory.ForeColor = System.Drawing.Color.Black;
            this.btn_BillHistory.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.btn_BillHistory.IconColor = System.Drawing.Color.Black;
            this.btn_BillHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_BillHistory.IconSize = 40;
            this.btn_BillHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BillHistory.Location = new System.Drawing.Point(0, 235);
            this.btn_BillHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btn_BillHistory.Name = "btn_BillHistory";
            this.btn_BillHistory.Size = new System.Drawing.Size(236, 45);
            this.btn_BillHistory.TabIndex = 6;
            this.btn_BillHistory.Text = " Lịch sử đơn hàng";
            this.btn_BillHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BillHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_BillHistory.UseVisualStyleBackColor = false;
            this.btn_BillHistory.Click += new System.EventHandler(this.btn_BillHistory_Click);
            // 
            // btn_BillReport
            // 
            this.btn_BillReport.BackColor = System.Drawing.Color.White;
            this.btn_BillReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_BillReport.FlatAppearance.BorderSize = 0;
            this.btn_BillReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_BillReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_BillReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BillReport.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btn_BillReport.ForeColor = System.Drawing.Color.Black;
            this.btn_BillReport.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btn_BillReport.IconColor = System.Drawing.Color.Black;
            this.btn_BillReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_BillReport.IconSize = 40;
            this.btn_BillReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BillReport.Location = new System.Drawing.Point(0, 186);
            this.btn_BillReport.Margin = new System.Windows.Forms.Padding(2);
            this.btn_BillReport.Name = "btn_BillReport";
            this.btn_BillReport.Size = new System.Drawing.Size(236, 45);
            this.btn_BillReport.TabIndex = 5;
            this.btn_BillReport.Text = " Báo cáo cuối ngày";
            this.btn_BillReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BillReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_BillReport.UseVisualStyleBackColor = false;
            this.btn_BillReport.Click += new System.EventHandler(this.btn_BillReport_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.White;
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnSetting.ForeColor = System.Drawing.Color.Black;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnSetting.IconColor = System.Drawing.Color.Black;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 40;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 284);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(236, 45);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = " Thiết lập";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnUserManual
            // 
            this.btnUserManual.BackColor = System.Drawing.Color.White;
            this.btnUserManual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUserManual.FlatAppearance.BorderSize = 0;
            this.btnUserManual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUserManual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUserManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManual.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnUserManual.ForeColor = System.Drawing.Color.Black;
            this.btnUserManual.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnUserManual.IconColor = System.Drawing.Color.Black;
            this.btnUserManual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserManual.IconSize = 40;
            this.btnUserManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManual.Location = new System.Drawing.Point(0, 382);
            this.btnUserManual.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserManual.Name = "btnUserManual";
            this.btnUserManual.Size = new System.Drawing.Size(236, 45);
            this.btnUserManual.TabIndex = 3;
            this.btnUserManual.Text = " Hướng dẫn sử dụng";
            this.btnUserManual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserManual.UseVisualStyleBackColor = false;
            this.btnUserManual.Click += new System.EventHandler(this.btnUserManual_Click);
            // 
            // btnSyncData
            // 
            this.btnSyncData.BackColor = System.Drawing.Color.White;
            this.btnSyncData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSyncData.FlatAppearance.BorderSize = 0;
            this.btnSyncData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSyncData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSyncData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyncData.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnSyncData.ForeColor = System.Drawing.Color.Black;
            this.btnSyncData.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnSyncData.IconColor = System.Drawing.Color.Black;
            this.btnSyncData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSyncData.IconSize = 40;
            this.btnSyncData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSyncData.Location = new System.Drawing.Point(0, 137);
            this.btnSyncData.Margin = new System.Windows.Forms.Padding(2);
            this.btnSyncData.Name = "btnSyncData";
            this.btnSyncData.Size = new System.Drawing.Size(236, 45);
            this.btnSyncData.TabIndex = 0;
            this.btnSyncData.Text = " Đồng bộ dữ liệu";
            this.btnSyncData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSyncData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSyncData.UseVisualStyleBackColor = false;
            this.btnSyncData.Click += new System.EventHandler(this.btnSyncData_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.icon_Menu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 86);
            this.panel2.TabIndex = 0;
            // 
            // icon_Menu
            // 
            this.icon_Menu.BackColor = System.Drawing.Color.Transparent;
            this.icon_Menu.FlatAppearance.BorderSize = 0;
            this.icon_Menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.icon_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.icon_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon_Menu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.icon_Menu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.icon_Menu.IconColor = System.Drawing.Color.Black;
            this.icon_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_Menu.IconSize = 40;
            this.icon_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icon_Menu.Location = new System.Drawing.Point(3, 23);
            this.icon_Menu.Name = "icon_Menu";
            this.icon_Menu.Size = new System.Drawing.Size(46, 47);
            this.icon_Menu.TabIndex = 9;
            this.icon_Menu.UseVisualStyleBackColor = false;
            this.icon_Menu.Click += new System.EventHandler(this.icon_Menu_Click);
            // 
            // fp_container
            // 
            this.fp_container.BackColor = System.Drawing.Color.White;
            this.fp_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fp_container.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fp_container.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fp_container.Location = new System.Drawing.Point(236, 33);
            this.fp_container.Margin = new System.Windows.Forms.Padding(2);
            this.fp_container.Name = "fp_container";
            this.fp_container.Size = new System.Drawing.Size(729, 505);
            this.fp_container.TabIndex = 7;
            // 
            // fSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(965, 538);
            this.Controls.Add(this.fp_container);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.fSell_Resize);
            this.panel1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnSyncData;
        private FontAwesome.Sharp.IconButton btn_BillHistory;
        private FontAwesome.Sharp.IconButton btn_BillReport;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnUserManual;
        private FontAwesome.Sharp.IconButton btnPhongBan;
        private FontAwesome.Sharp.IconButton btn_support;
        private FontAwesome.Sharp.IconButton btnQuyDinh;
        private System.Windows.Forms.Panel fp_container;
        private FontAwesome.Sharp.IconButton Close;
        private FontAwesome.Sharp.IconButton minimize;
        private FontAwesome.Sharp.IconButton maximize;
        private FontAwesome.Sharp.IconButton icon_Menu;
    }
}

