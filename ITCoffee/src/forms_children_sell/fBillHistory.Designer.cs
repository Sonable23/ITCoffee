namespace ITCoffee.src.forms_children
{
    partial class fBillHistory
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
            this.lv_listBillHistory = new System.Windows.Forms.ListView();
            this.cl_idBill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_TableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_checkIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_checkOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lv_listBillHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 127);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 527);
            this.panel1.TabIndex = 0;
            // 
            // lv_listBillHistory
            // 
            this.lv_listBillHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.lv_listBillHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_idBill,
            this.cl_TableName,
            this.cl_checkIn,
            this.cl_checkOut,
            this.cl_status});
            this.lv_listBillHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_listBillHistory.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lv_listBillHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
            this.lv_listBillHistory.FullRowSelect = true;
            this.lv_listBillHistory.HideSelection = false;
            this.lv_listBillHistory.Location = new System.Drawing.Point(0, 0);
            this.lv_listBillHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_listBillHistory.Name = "lv_listBillHistory";
            this.lv_listBillHistory.Size = new System.Drawing.Size(1077, 515);
            this.lv_listBillHistory.TabIndex = 0;
            this.lv_listBillHistory.UseCompatibleStateImageBehavior = false;
            this.lv_listBillHistory.View = System.Windows.Forms.View.Details;
            // 
            // cl_idBill
            // 
            this.cl_idBill.Text = "ID";
            this.cl_idBill.Width = 149;
            // 
            // cl_TableName
            // 
            this.cl_TableName.Text = "TableName";
            this.cl_TableName.Width = 226;
            // 
            // cl_checkIn
            // 
            this.cl_checkIn.Text = "Giờ vào";
            this.cl_checkIn.Width = 203;
            // 
            // cl_checkOut
            // 
            this.cl_checkOut.Text = "Giờ ra";
            this.cl_checkOut.Width = 219;
            // 
            // cl_status
            // 
            this.cl_status.Text = "Status";
            this.cl_status.Width = 672;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch sử Bill";
            // 
            // fBillHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1077, 654);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fBillHistory";
            this.Text = "fHistoryOrder";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lv_listBillHistory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader cl_idBill;
        private System.Windows.Forms.ColumnHeader cl_TableName;
        private System.Windows.Forms.ColumnHeader cl_checkIn;
        private System.Windows.Forms.ColumnHeader cl_checkOut;
        private System.Windows.Forms.ColumnHeader cl_status;
    }
}