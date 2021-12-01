namespace HocTruyVanCSDL
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
            this.btnDemSoSanPham = new System.Windows.Forms.Button();
            this.lblSoSanPham = new System.Windows.Forms.Label();
            this.btnCach1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMuonTim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.btnCach2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHienThi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDemSoSanPham
            // 
            this.btnDemSoSanPham.Location = new System.Drawing.Point(74, 22);
            this.btnDemSoSanPham.Name = "btnDemSoSanPham";
            this.btnDemSoSanPham.Size = new System.Drawing.Size(163, 56);
            this.btnDemSoSanPham.TabIndex = 0;
            this.btnDemSoSanPham.Text = "Đếm số Sản Phẩm";
            this.btnDemSoSanPham.UseVisualStyleBackColor = true;
            this.btnDemSoSanPham.Click += new System.EventHandler(this.btnDemSoSanPham_Click);
            // 
            // lblSoSanPham
            // 
            this.lblSoSanPham.AutoSize = true;
            this.lblSoSanPham.Location = new System.Drawing.Point(258, 46);
            this.lblSoSanPham.Name = "lblSoSanPham";
            this.lblSoSanPham.Size = new System.Drawing.Size(41, 15);
            this.lblSoSanPham.TabIndex = 1;
            this.lblSoSanPham.Text = "label1";
            // 
            // btnCach1
            // 
            this.btnCach1.Location = new System.Drawing.Point(74, 198);
            this.btnCach1.Name = "btnCach1";
            this.btnCach1.Size = new System.Drawing.Size(163, 69);
            this.btnCach1.TabIndex = 2;
            this.btnCach1.Text = "Xem thông tin sinh viên";
            this.btnCach1.UseVisualStyleBackColor = true;
            this.btnCach1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập mã:";
            // 
            // txtMaMuonTim
            // 
            this.txtMaMuonTim.Location = new System.Drawing.Point(152, 153);
            this.txtMaMuonTim.Name = "txtMaMuonTim";
            this.txtMaMuonTim.Size = new System.Drawing.Size(85, 21);
            this.txtMaMuonTim.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày Sinh:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(152, 273);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(279, 21);
            this.txtMa.TabIndex = 8;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(152, 308);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(279, 21);
            this.txtTen.TabIndex = 9;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(152, 341);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(279, 21);
            this.txtNgaySinh.TabIndex = 10;
            this.txtNgaySinh.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnCach2
            // 
            this.btnCach2.Location = new System.Drawing.Point(261, 198);
            this.btnCach2.Name = "btnCach2";
            this.btnCach2.Size = new System.Drawing.Size(170, 69);
            this.btnCach2.TabIndex = 11;
            this.btnCach2.Text = "Xem thông tin sinh viên cách 2";
            this.btnCach2.UseVisualStyleBackColor = true;
            this.btnCach2.Click += new System.EventHandler(this.btnCach2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hiển thị danh sách sinh viên";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(406, 55);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(322, 137);
            this.lvSinhVien.TabIndex = 13;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Sinh";
            this.columnHeader3.Width = 150;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(570, 22);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 23);
            this.btnHienThi.TabIndex = 14;
            this.btnHienThi.Text = "Display";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 372);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.lvSinhVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCach2);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaMuonTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCach1);
            this.Controls.Add(this.lblSoSanPham);
            this.Controls.Add(this.btnDemSoSanPham);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDemSoSanPham;
        private System.Windows.Forms.Label lblSoSanPham;
        private System.Windows.Forms.Button btnCach1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMuonTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Button btnCach2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnHienThi;
    }
}

