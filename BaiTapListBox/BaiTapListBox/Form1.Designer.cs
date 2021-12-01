namespace BaiTapListBox
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
            this.lblTenSinhVien = new System.Windows.Forms.Label();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lstDanhSachA = new System.Windows.Forms.ListBox();
            this.lstDanhSachB = new System.Windows.Forms.ListBox();
            this.btnRight1 = new System.Windows.Forms.Button();
            this.btnRight2 = new System.Windows.Forms.Button();
            this.btnLeft1 = new System.Windows.Forms.Button();
            this.btnLeft2 = new System.Windows.Forms.Button();
            this.btnXoaLopA = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnXoaLopB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTenSinhVien
            // 
            this.lblTenSinhVien.AutoSize = true;
            this.lblTenSinhVien.Location = new System.Drawing.Point(12, 16);
            this.lblTenSinhVien.Name = "lblTenSinhVien";
            this.lblTenSinhVien.Size = new System.Drawing.Size(77, 13);
            this.lblTenSinhVien.TabIndex = 0;
            this.lblTenSinhVien.Text = "Tên Sinh Viên:";
            this.lblTenSinhVien.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Location = new System.Drawing.Point(105, 13);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(191, 20);
            this.txtNhapTen.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCapNhat.Location = new System.Drawing.Point(352, 9);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lstDanhSachA
            // 
            this.lstDanhSachA.FormattingEnabled = true;
            this.lstDanhSachA.Location = new System.Drawing.Point(34, 90);
            this.lstDanhSachA.Name = "lstDanhSachA";
            this.lstDanhSachA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDanhSachA.Size = new System.Drawing.Size(120, 160);
            this.lstDanhSachA.TabIndex = 3;
            this.lstDanhSachA.SelectedIndexChanged += new System.EventHandler(this.lstDanhSachA_SelectedIndexChanged);
            // 
            // lstDanhSachB
            // 
            this.lstDanhSachB.FormattingEnabled = true;
            this.lstDanhSachB.Location = new System.Drawing.Point(307, 90);
            this.lstDanhSachB.Name = "lstDanhSachB";
            this.lstDanhSachB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDanhSachB.Size = new System.Drawing.Size(120, 160);
            this.lstDanhSachB.TabIndex = 4;
            // 
            // btnRight1
            // 
            this.btnRight1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRight1.Location = new System.Drawing.Point(197, 90);
            this.btnRight1.Name = "btnRight1";
            this.btnRight1.Size = new System.Drawing.Size(75, 23);
            this.btnRight1.TabIndex = 5;
            this.btnRight1.Text = ">";
            this.btnRight1.UseVisualStyleBackColor = false;
            this.btnRight1.Click += new System.EventHandler(this.btnRight1_Click);
            // 
            // btnRight2
            // 
            this.btnRight2.BackColor = System.Drawing.Color.Yellow;
            this.btnRight2.Location = new System.Drawing.Point(197, 139);
            this.btnRight2.Name = "btnRight2";
            this.btnRight2.Size = new System.Drawing.Size(75, 23);
            this.btnRight2.TabIndex = 6;
            this.btnRight2.Text = ">>";
            this.btnRight2.UseVisualStyleBackColor = false;
            this.btnRight2.Click += new System.EventHandler(this.btnRight2_Click);
            // 
            // btnLeft1
            // 
            this.btnLeft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLeft1.Location = new System.Drawing.Point(197, 184);
            this.btnLeft1.Name = "btnLeft1";
            this.btnLeft1.Size = new System.Drawing.Size(75, 23);
            this.btnLeft1.TabIndex = 7;
            this.btnLeft1.Text = "<";
            this.btnLeft1.UseVisualStyleBackColor = false;
            this.btnLeft1.Click += new System.EventHandler(this.btnLeft1_Click);
            // 
            // btnLeft2
            // 
            this.btnLeft2.BackColor = System.Drawing.Color.Yellow;
            this.btnLeft2.Location = new System.Drawing.Point(197, 226);
            this.btnLeft2.Name = "btnLeft2";
            this.btnLeft2.Size = new System.Drawing.Size(75, 23);
            this.btnLeft2.TabIndex = 8;
            this.btnLeft2.Text = "<<";
            this.btnLeft2.UseVisualStyleBackColor = false;
            this.btnLeft2.Click += new System.EventHandler(this.btnLeft2_Click);
            // 
            // btnXoaLopA
            // 
            this.btnXoaLopA.BackColor = System.Drawing.Color.Red;
            this.btnXoaLopA.Location = new System.Drawing.Point(34, 305);
            this.btnXoaLopA.Name = "btnXoaLopA";
            this.btnXoaLopA.Size = new System.Drawing.Size(75, 23);
            this.btnXoaLopA.TabIndex = 9;
            this.btnXoaLopA.Text = "Xóa lớp A";
            this.btnXoaLopA.UseVisualStyleBackColor = false;
            this.btnXoaLopA.Click += new System.EventHandler(this.btnXoaLopA_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.Red;
            this.btnKetThuc.Location = new System.Drawing.Point(197, 305);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(75, 23);
            this.btnKetThuc.TabIndex = 10;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            // 
            // btnXoaLopB
            // 
            this.btnXoaLopB.BackColor = System.Drawing.Color.Red;
            this.btnXoaLopB.Location = new System.Drawing.Point(351, 304);
            this.btnXoaLopB.Name = "btnXoaLopB";
            this.btnXoaLopB.Size = new System.Drawing.Size(75, 23);
            this.btnXoaLopB.TabIndex = 11;
            this.btnXoaLopB.Text = "Xóa lớp B";
            this.btnXoaLopB.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(441, 356);
            this.Controls.Add(this.btnXoaLopB);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnXoaLopA);
            this.Controls.Add(this.btnLeft2);
            this.Controls.Add(this.btnLeft1);
            this.Controls.Add(this.btnRight2);
            this.Controls.Add(this.btnRight1);
            this.Controls.Add(this.lstDanhSachB);
            this.Controls.Add(this.lstDanhSachA);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtNhapTen);
            this.Controls.Add(this.lblTenSinhVien);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenSinhVien;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ListBox lstDanhSachA;
        private System.Windows.Forms.ListBox lstDanhSachB;
        private System.Windows.Forms.Button btnRight1;
        private System.Windows.Forms.Button btnRight2;
        private System.Windows.Forms.Button btnLeft1;
        private System.Windows.Forms.Button btnLeft2;
        private System.Windows.Forms.Button btnXoaLopA;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnXoaLopB;
    }
}

