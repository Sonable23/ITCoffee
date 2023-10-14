namespace ITCoffee.src.forms_children_admin
{
    partial class fTableUpdate
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.titlte_mode = new System.Windows.Forms.Label();
            this.cb_tableAreaList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nameTable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.titlte_mode);
            this.panel1.Controls.Add(this.cb_tableAreaList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_nameTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 384);
            this.panel1.TabIndex = 1;
            // 
            // btn_submit
            // 
            this.btn_submit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.btn_submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.btn_submit.Location = new System.Drawing.Point(141, 275);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(143, 43);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "Update";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // titlte_mode
            // 
            this.titlte_mode.AutoSize = true;
            this.titlte_mode.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.titlte_mode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.titlte_mode.Location = new System.Drawing.Point(121, 43);
            this.titlte_mode.Name = "titlte_mode";
            this.titlte_mode.Size = new System.Drawing.Size(204, 29);
            this.titlte_mode.TabIndex = 6;
            this.titlte_mode.Text = "Chỉnh sửa bàn mới";
            // 
            // cb_tableAreaList
            // 
            this.cb_tableAreaList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.cb_tableAreaList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_tableAreaList.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cb_tableAreaList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.cb_tableAreaList.FormattingEnabled = true;
            this.cb_tableAreaList.Location = new System.Drawing.Point(157, 167);
            this.cb_tableAreaList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_tableAreaList.Name = "cb_tableAreaList";
            this.cb_tableAreaList.Size = new System.Drawing.Size(218, 30);
            this.cb_tableAreaList.TabIndex = 5;
            this.cb_tableAreaList.Text = "Tên Khu Vực";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(48, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khu Vực";
            // 
            // txt_nameTable
            // 
            this.txt_nameTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.txt_nameTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nameTable.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_nameTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.txt_nameTable.Location = new System.Drawing.Point(157, 117);
            this.txt_nameTable.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_nameTable.Name = "txt_nameTable";
            this.txt_nameTable.Size = new System.Drawing.Size(218, 30);
            this.txt_nameTable.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(48, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Bàn";
            // 
            // fTableUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 384);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fTableUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fUpdateTable";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label titlte_mode;
        private System.Windows.Forms.ComboBox cb_tableAreaList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nameTable;
        private System.Windows.Forms.Label label1;
    }
}