namespace ITCoffee.src.forms_children_admin
{
    partial class fStaffAdd
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
            this.iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.cb_staffPosition = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_staffSalaryBasic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_staffAddress = new System.Windows.Forms.TextBox();
            this.txt_staffCmnd = new System.Windows.Forms.TextBox();
            this.txt_staffPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_staffName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iconSplitButton1
            // 
            this.iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconSplitButton1.IconColor = System.Drawing.Color.Black;
            this.iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSplitButton1.IconSize = 48;
            this.iconSplitButton1.Name = "iconSplitButton1";
            this.iconSplitButton1.Rotation = 0D;
            this.iconSplitButton1.Size = new System.Drawing.Size(23, 23);
            this.iconSplitButton1.Text = "iconSplitButton1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(47, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Cmnd";
            // 
            // btn_confirm
            // 
            this.btn_confirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.btn_confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.btn_confirm.Location = new System.Drawing.Point(161, 356);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(152, 52);
            this.btn_confirm.TabIndex = 40;
            this.btn_confirm.Text = "Thêm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // cb_staffPosition
            // 
            this.cb_staffPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.cb_staffPosition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_staffPosition.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_staffPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.cb_staffPosition.FormattingEnabled = true;
            this.cb_staffPosition.Items.AddRange(new object[] {
            "Quản lí ",
            "Thu ngân",
            "Pha chế",
            "Phục vụ",
            "Bảo vệ"});
            this.cb_staffPosition.Location = new System.Drawing.Point(221, 227);
            this.cb_staffPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_staffPosition.Name = "cb_staffPosition";
            this.cb_staffPosition.Size = new System.Drawing.Size(212, 29);
            this.cb_staffPosition.TabIndex = 39;
            this.cb_staffPosition.Text = "Vai trò";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(47, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Lương cơ bản";
            // 
            // txt_staffSalaryBasic
            // 
            this.txt_staffSalaryBasic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.txt_staffSalaryBasic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_staffSalaryBasic.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staffSalaryBasic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.txt_staffSalaryBasic.Location = new System.Drawing.Point(221, 272);
            this.txt_staffSalaryBasic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_staffSalaryBasic.Multiline = true;
            this.txt_staffSalaryBasic.Name = "txt_staffSalaryBasic";
            this.txt_staffSalaryBasic.Size = new System.Drawing.Size(213, 29);
            this.txt_staffSalaryBasic.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(47, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Vị trí";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.label7.Location = new System.Drawing.Point(47, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "Địa chỉ";
            // 
            // txt_staffAddress
            // 
            this.txt_staffAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.txt_staffAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_staffAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staffAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.txt_staffAddress.Location = new System.Drawing.Point(221, 187);
            this.txt_staffAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_staffAddress.Multiline = true;
            this.txt_staffAddress.Name = "txt_staffAddress";
            this.txt_staffAddress.Size = new System.Drawing.Size(213, 29);
            this.txt_staffAddress.TabIndex = 35;
            // 
            // txt_staffCmnd
            // 
            this.txt_staffCmnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.txt_staffCmnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_staffCmnd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staffCmnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.txt_staffCmnd.Location = new System.Drawing.Point(221, 145);
            this.txt_staffCmnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_staffCmnd.Multiline = true;
            this.txt_staffCmnd.Name = "txt_staffCmnd";
            this.txt_staffCmnd.Size = new System.Drawing.Size(213, 29);
            this.txt_staffCmnd.TabIndex = 33;
            // 
            // txt_staffPhone
            // 
            this.txt_staffPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.txt_staffPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_staffPhone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staffPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.txt_staffPhone.Location = new System.Drawing.Point(221, 106);
            this.txt_staffPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_staffPhone.Multiline = true;
            this.txt_staffPhone.Name = "txt_staffPhone";
            this.txt_staffPhone.Size = new System.Drawing.Size(213, 29);
            this.txt_staffPhone.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(47, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Số điện thoại";
            // 
            // txt_staffName
            // 
            this.txt_staffName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.txt_staffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_staffName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staffName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.txt_staffName.Location = new System.Drawing.Point(221, 61);
            this.txt_staffName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_staffName.Multiline = true;
            this.txt_staffName.Name = "txt_staffName";
            this.txt_staffName.Size = new System.Drawing.Size(213, 29);
            this.txt_staffName.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(47, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tên nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(140, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 29);
            this.label6.TabIndex = 42;
            this.label6.Text = "Thêm nhân viên";
            // 
            // fStaffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(473, 430);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.cb_staffPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_staffSalaryBasic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_staffAddress);
            this.Controls.Add(this.txt_staffCmnd);
            this.Controls.Add(this.txt_staffPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_staffName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fStaffAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fStaffAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.ComboBox cb_staffPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_staffSalaryBasic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_staffAddress;
        private System.Windows.Forms.TextBox txt_staffCmnd;
        private System.Windows.Forms.TextBox txt_staffPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_staffName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}