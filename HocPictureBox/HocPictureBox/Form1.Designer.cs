namespace HocPictureBox
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnTurnOnOrOff = new System.Windows.Forms.Button();
            this.lblDesigner = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureOff = new System.Windows.Forms.PictureBox();
            this.pictureOn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Info;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(57, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnTurnOnOrOff
            // 
            this.btnTurnOnOrOff.Location = new System.Drawing.Point(57, 159);
            this.btnTurnOnOrOff.Name = "btnTurnOnOrOff";
            this.btnTurnOnOrOff.Size = new System.Drawing.Size(173, 23);
            this.btnTurnOnOrOff.TabIndex = 4;
            this.btnTurnOnOrOff.UseVisualStyleBackColor = true;
            this.btnTurnOnOrOff.Click += new System.EventHandler(this.btnTurnOnOrOff_Click);
            // 
            // lblDesigner
            // 
            this.lblDesigner.AutoSize = true;
            this.lblDesigner.Location = new System.Drawing.Point(12, 239);
            this.lblDesigner.Name = "lblDesigner";
            this.lblDesigner.Size = new System.Drawing.Size(69, 13);
            this.lblDesigner.TabIndex = 5;
            this.lblDesigner.Text = "Designed by:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(97, 239);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Mr.Tèo";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 234);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pictureOff
            // 
            this.pictureOff.Image = global::HocPictureBox.Properties.Resources.images1;
            this.pictureOff.Location = new System.Drawing.Point(96, 46);
            this.pictureOff.Name = "pictureOff";
            this.pictureOff.Size = new System.Drawing.Size(95, 98);
            this.pictureOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOff.TabIndex = 3;
            this.pictureOff.TabStop = false;
            this.pictureOff.Click += new System.EventHandler(this.pictureOff_Click);
            // 
            // pictureOn
            // 
            this.pictureOn.Image = global::HocPictureBox.Properties.Resources.light_on;
            this.pictureOn.Location = new System.Drawing.Point(96, 46);
            this.pictureOn.Name = "pictureOn";
            this.pictureOn.Size = new System.Drawing.Size(95, 98);
            this.pictureOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOn.TabIndex = 2;
            this.pictureOn.TabStop = false;
            this.pictureOn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDesigner);
            this.Controls.Add(this.btnTurnOnOrOff);
            this.Controls.Add(this.pictureOff);
            this.Controls.Add(this.pictureOn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tắt mở đèn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pictureOn;
        private System.Windows.Forms.PictureBox pictureOff;
        private System.Windows.Forms.Button btnTurnOnOrOff;
        private System.Windows.Forms.Label lblDesigner;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnExit;
    }
}

