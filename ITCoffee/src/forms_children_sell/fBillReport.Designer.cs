namespace ITCoffee.src.forms_children
{
    partial class fBillReport
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_listBillReport = new System.Windows.Forms.ListView();
            this.cl_idBill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_NameTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_checkIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_checkOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_MessageBil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_totalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_totalBillAll = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lv_listBillReport);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 471);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 84);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo Cáo Cuối Ngày";
            // 
            // lv_listBillReport
            // 
            this.lv_listBillReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.lv_listBillReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_idBill,
            this.cl_NameTable,
            this.cl_checkIn,
            this.cl_checkOut,
            this.cl_MessageBil,
            this.cl_totalPrice});
            this.lv_listBillReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_listBillReport.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.lv_listBillReport.ForeColor = System.Drawing.SystemColors.Info;
            this.lv_listBillReport.HideSelection = false;
            this.lv_listBillReport.Location = new System.Drawing.Point(0, 84);
            this.lv_listBillReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_listBillReport.Name = "lv_listBillReport";
            this.lv_listBillReport.Size = new System.Drawing.Size(940, 308);
            this.lv_listBillReport.TabIndex = 3;
            this.lv_listBillReport.UseCompatibleStateImageBehavior = false;
            this.lv_listBillReport.View = System.Windows.Forms.View.Details;
            // 
            // cl_idBill
            // 
            this.cl_idBill.Text = "ID";
            this.cl_idBill.Width = 120;
            // 
            // cl_NameTable
            // 
            this.cl_NameTable.Text = "NameTable";
            this.cl_NameTable.Width = 148;
            // 
            // cl_checkIn
            // 
            this.cl_checkIn.Text = "Giờ vào";
            this.cl_checkIn.Width = 173;
            // 
            // cl_checkOut
            // 
            this.cl_checkOut.Text = "Giờ ra";
            this.cl_checkOut.Width = 128;
            // 
            // cl_MessageBil
            // 
            this.cl_MessageBil.Text = "Trạng thái";
            this.cl_MessageBil.Width = 133;
            // 
            // cl_totalPrice
            // 
            this.cl_totalPrice.Text = "Tổng bill";
            this.cl_totalPrice.Width = 204;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel4.Controls.Add(this.btn_totalBillAll);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.panel4.Location = new System.Drawing.Point(0, 392);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(940, 110);
            this.panel4.TabIndex = 4;
            // 
            // btn_totalBillAll
            // 
            this.btn_totalBillAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_totalBillAll.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btn_totalBillAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.btn_totalBillAll.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_totalBillAll.IconColor = System.Drawing.Color.Black;
            this.btn_totalBillAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_totalBillAll.Location = new System.Drawing.Point(765, 4);
            this.btn_totalBillAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_totalBillAll.Name = "btn_totalBillAll";
            this.btn_totalBillAll.Size = new System.Drawing.Size(163, 59);
            this.btn_totalBillAll.TabIndex = 1;
            this.btn_totalBillAll.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(606, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng hóa đơn";
            // 
            // fBillReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 471);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fBillReport";
            this.Text = "fBillReport";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btn_totalBillAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lv_listBillReport;
        private System.Windows.Forms.ColumnHeader cl_idBill;
        private System.Windows.Forms.ColumnHeader cl_NameTable;
        private System.Windows.Forms.ColumnHeader cl_checkIn;
        private System.Windows.Forms.ColumnHeader cl_checkOut;
        private System.Windows.Forms.ColumnHeader cl_MessageBil;
        private System.Windows.Forms.ColumnHeader cl_totalPrice;
    }
}