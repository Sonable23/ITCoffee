namespace ITCoffee.src.forms_children_admin
{
    partial class fFoodGroupNew
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_saveFoodGroup = new System.Windows.Forms.Button();
            this.txt_foodGroup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(79, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhóm sản phẩm";
            // 
            // btn_saveFoodGroup
            // 
            this.btn_saveFoodGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.btn_saveFoodGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btn_saveFoodGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveFoodGroup.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_saveFoodGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.btn_saveFoodGroup.Location = new System.Drawing.Point(99, 154);
            this.btn_saveFoodGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_saveFoodGroup.Name = "btn_saveFoodGroup";
            this.btn_saveFoodGroup.Size = new System.Drawing.Size(125, 43);
            this.btn_saveFoodGroup.TabIndex = 1;
            this.btn_saveFoodGroup.Text = "Thêm";
            this.btn_saveFoodGroup.UseVisualStyleBackColor = true;
            this.btn_saveFoodGroup.Click += new System.EventHandler(this.btn_saveFoodGroup_Click);
            // 
            // txt_foodGroup
            // 
            this.txt_foodGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(47)))));
            this.txt_foodGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_foodGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.txt_foodGroup.Location = new System.Drawing.Point(55, 80);
            this.txt_foodGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_foodGroup.Multiline = true;
            this.txt_foodGroup.Name = "txt_foodGroup";
            this.txt_foodGroup.Size = new System.Drawing.Size(210, 33);
            this.txt_foodGroup.TabIndex = 2;
            // 
            // fFoodGroupNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(319, 231);
            this.Controls.Add(this.txt_foodGroup);
            this.Controls.Add(this.btn_saveFoodGroup);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fFoodGroupNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fFoodGroupNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_saveFoodGroup;
        private System.Windows.Forms.TextBox txt_foodGroup;
    }
}