namespace ITCoffee.src.forms_children
{
    partial class fInputDiaLog
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
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.lb_InputDiaLog = new System.Windows.Forms.Label();
            this.btn_InputDiaLog = new FontAwesome.Sharp.IconButton();
            this.btn_CountTru = new FontAwesome.Sharp.IconButton();
            this.btn_CountCong = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txt_Count
            // 
            this.txt_Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.txt_Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Count.Enabled = false;
            this.txt_Count.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.txt_Count.Location = new System.Drawing.Point(60, 58);
            this.txt_Count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(118, 30);
            this.txt_Count.TabIndex = 0;
            this.txt_Count.Text = "0";
            this.txt_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Count.TextChanged += new System.EventHandler(this.txt_Count_TextChanged);
            // 
            // lb_InputDiaLog
            // 
            this.lb_InputDiaLog.AutoSize = true;
            this.lb_InputDiaLog.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InputDiaLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.lb_InputDiaLog.Location = new System.Drawing.Point(12, 9);
            this.lb_InputDiaLog.Name = "lb_InputDiaLog";
            this.lb_InputDiaLog.Size = new System.Drawing.Size(70, 19);
            this.lb_InputDiaLog.TabIndex = 1;
            this.lb_InputDiaLog.Text = "Số lượng";
            // 
            // btn_InputDiaLog
            // 
            this.btn_InputDiaLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.btn_InputDiaLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btn_InputDiaLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InputDiaLog.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btn_InputDiaLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.btn_InputDiaLog.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_InputDiaLog.IconColor = System.Drawing.Color.Black;
            this.btn_InputDiaLog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_InputDiaLog.Location = new System.Drawing.Point(72, 126);
            this.btn_InputDiaLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_InputDiaLog.Name = "btn_InputDiaLog";
            this.btn_InputDiaLog.Size = new System.Drawing.Size(106, 26);
            this.btn_InputDiaLog.TabIndex = 2;
            this.btn_InputDiaLog.Text = "Xác nhận";
            this.btn_InputDiaLog.UseVisualStyleBackColor = true;
            this.btn_InputDiaLog.Click += new System.EventHandler(this.okButton_Click);
            // 
            // btn_CountTru
            // 
            this.btn_CountTru.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.btn_CountTru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btn_CountTru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CountTru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.btn_CountTru.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_CountTru.IconColor = System.Drawing.Color.Black;
            this.btn_CountTru.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CountTru.Location = new System.Drawing.Point(12, 57);
            this.btn_CountTru.Name = "btn_CountTru";
            this.btn_CountTru.Size = new System.Drawing.Size(41, 29);
            this.btn_CountTru.TabIndex = 3;
            this.btn_CountTru.Text = "-";
            this.btn_CountTru.UseVisualStyleBackColor = true;
            this.btn_CountTru.Click += new System.EventHandler(this.btn_CountTru_Click);
            // 
            // btn_CountCong
            // 
            this.btn_CountCong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.btn_CountCong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btn_CountCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CountCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.btn_CountCong.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_CountCong.IconColor = System.Drawing.Color.Black;
            this.btn_CountCong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CountCong.Location = new System.Drawing.Point(184, 57);
            this.btn_CountCong.Name = "btn_CountCong";
            this.btn_CountCong.Size = new System.Drawing.Size(45, 29);
            this.btn_CountCong.TabIndex = 4;
            this.btn_CountCong.Text = "+";
            this.btn_CountCong.UseVisualStyleBackColor = true;
            this.btn_CountCong.Click += new System.EventHandler(this.btn_CountCong_Click);
            // 
            // fInputDiaLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(241, 165);
            this.Controls.Add(this.btn_CountCong);
            this.Controls.Add(this.btn_CountTru);
            this.Controls.Add(this.btn_InputDiaLog);
            this.Controls.Add(this.lb_InputDiaLog);
            this.Controls.Add(this.txt_Count);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fInputDiaLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fInputDiaLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.Label lb_InputDiaLog;
        private FontAwesome.Sharp.IconButton btn_InputDiaLog;
        private FontAwesome.Sharp.IconButton btn_CountTru;
        private FontAwesome.Sharp.IconButton btn_CountCong;
    }
}