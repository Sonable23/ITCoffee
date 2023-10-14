namespace ITCoffee.src.forms_children_admin
{
    partial class fTableAreaNew
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
            this.lb_Area = new System.Windows.Forms.Label();
            this.btn_saveTableArea = new System.Windows.Forms.Button();
            this.txt_TableArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Area
            // 
            this.lb_Area.AutoSize = true;
            this.lb_Area.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Area.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.lb_Area.Location = new System.Drawing.Point(72, 35);
            this.lb_Area.Name = "lb_Area";
            this.lb_Area.Size = new System.Drawing.Size(151, 22);
            this.lb_Area.TabIndex = 0;
            this.lb_Area.Text = "Tên Khu Vực Bàn";
            // 
            // btn_saveTableArea
            // 
            this.btn_saveTableArea.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.btn_saveTableArea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btn_saveTableArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveTableArea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveTableArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.btn_saveTableArea.Location = new System.Drawing.Point(89, 191);
            this.btn_saveTableArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_saveTableArea.Name = "btn_saveTableArea";
            this.btn_saveTableArea.Size = new System.Drawing.Size(124, 39);
            this.btn_saveTableArea.TabIndex = 4;
            this.btn_saveTableArea.Text = "Thêm";
            this.btn_saveTableArea.UseVisualStyleBackColor = true;
            this.btn_saveTableArea.Click += new System.EventHandler(this.btn_saveTableArea_Click);
            // 
            // txt_TableArea
            // 
            this.txt_TableArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.txt_TableArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TableArea.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TableArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.txt_TableArea.Location = new System.Drawing.Point(53, 89);
            this.txt_TableArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TableArea.Multiline = true;
            this.txt_TableArea.Name = "txt_TableArea";
            this.txt_TableArea.Size = new System.Drawing.Size(193, 35);
            this.txt_TableArea.TabIndex = 5;
            // 
            // fTableAreaNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(304, 260);
            this.Controls.Add(this.txt_TableArea);
            this.Controls.Add(this.btn_saveTableArea);
            this.Controls.Add(this.lb_Area);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fTableAreaNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTableAreaNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Area;
        private System.Windows.Forms.Button btn_saveTableArea;
        private System.Windows.Forms.TextBox txt_TableArea;
    }
}