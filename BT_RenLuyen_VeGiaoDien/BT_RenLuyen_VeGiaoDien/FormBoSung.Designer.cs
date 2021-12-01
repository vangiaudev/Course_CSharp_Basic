namespace BT_RenLuyen_VeGiaoDien
{
    partial class FormBoSung
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDong = new System.Windows.Forms.TextBox();
            this.txtCot = new System.Windows.Forms.TextBox();
            this.btnVe = new System.Windows.Forms.Button();
            this.pnButton = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cột";
            // 
            // txtDong
            // 
            this.txtDong.Location = new System.Drawing.Point(80, 1);
            this.txtDong.Name = "txtDong";
            this.txtDong.Size = new System.Drawing.Size(100, 20);
            this.txtDong.TabIndex = 3;
            // 
            // txtCot
            // 
            this.txtCot.Location = new System.Drawing.Point(80, 29);
            this.txtCot.Name = "txtCot";
            this.txtCot.Size = new System.Drawing.Size(100, 20);
            this.txtCot.TabIndex = 4;
            // 
            // btnVe
            // 
            this.btnVe.Location = new System.Drawing.Point(197, 12);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(75, 23);
            this.btnVe.TabIndex = 5;
            this.btnVe.Text = "Vẽ";
            this.btnVe.UseVisualStyleBackColor = true;
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // pnButton
            // 
            this.pnButton.Location = new System.Drawing.Point(2, 81);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(279, 176);
            this.pnButton.TabIndex = 6;
            // 
            // FormBoSung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.btnVe);
            this.Controls.Add(this.txtCot);
            this.Controls.Add(this.txtDong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBoSung";
            this.Text = "FormBoSung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDong;
        private System.Windows.Forms.TextBox txtCot;
        private System.Windows.Forms.Button btnVe;
        private System.Windows.Forms.FlowLayoutPanel pnButton;
    }
}