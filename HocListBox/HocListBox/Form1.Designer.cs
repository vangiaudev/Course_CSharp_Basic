namespace HocListBox
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
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChonSoLe = new System.Windows.Forms.Button();
            this.btnChonSoChan = new System.Windows.Forms.Button();
            this.btnThayBangBinhPhuong = new System.Windows.Forms.Button();
            this.btnTangLen2 = new System.Windows.Forms.Button();
            this.btnXoaPhanTuDangChon = new System.Windows.Forms.Button();
            this.btnXoaDauVaCuoi = new System.Windows.Forms.Button();
            this.btnTongDanhSach = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(80, 13);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(167, 20);
            this.txtNhapSo.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Blue;
            this.btnCapNhat.Location = new System.Drawing.Point(290, 13);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstSo);
            this.groupBox1.Location = new System.Drawing.Point(16, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 222);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách số";
            // 
            // lstSo
            // 
            this.lstSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSo.FormattingEnabled = true;
            this.lstSo.Location = new System.Drawing.Point(3, 16);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSo.Size = new System.Drawing.Size(225, 203);
            this.lstSo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChonSoLe);
            this.groupBox2.Controls.Add(this.btnChonSoChan);
            this.groupBox2.Controls.Add(this.btnThayBangBinhPhuong);
            this.groupBox2.Controls.Add(this.btnTangLen2);
            this.groupBox2.Controls.Add(this.btnXoaPhanTuDangChon);
            this.groupBox2.Controls.Add(this.btnXoaDauVaCuoi);
            this.groupBox2.Controls.Add(this.btnTongDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(290, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 233);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các chức năng";
            // 
            // btnChonSoLe
            // 
            this.btnChonSoLe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChonSoLe.Location = new System.Drawing.Point(7, 199);
            this.btnChonSoLe.Name = "btnChonSoLe";
            this.btnChonSoLe.Size = new System.Drawing.Size(203, 23);
            this.btnChonSoLe.TabIndex = 6;
            this.btnChonSoLe.Text = "Chọn số lẻ";
            this.btnChonSoLe.UseVisualStyleBackColor = false;
            this.btnChonSoLe.Click += new System.EventHandler(this.btnChonSoLe_Click);
            // 
            // btnChonSoChan
            // 
            this.btnChonSoChan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChonSoChan.Location = new System.Drawing.Point(6, 169);
            this.btnChonSoChan.Name = "btnChonSoChan";
            this.btnChonSoChan.Size = new System.Drawing.Size(204, 23);
            this.btnChonSoChan.TabIndex = 5;
            this.btnChonSoChan.Text = "Chọn số chẵn";
            this.btnChonSoChan.UseVisualStyleBackColor = false;
            this.btnChonSoChan.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnThayBangBinhPhuong
            // 
            this.btnThayBangBinhPhuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThayBangBinhPhuong.Location = new System.Drawing.Point(7, 140);
            this.btnThayBangBinhPhuong.Name = "btnThayBangBinhPhuong";
            this.btnThayBangBinhPhuong.Size = new System.Drawing.Size(204, 23);
            this.btnThayBangBinhPhuong.TabIndex = 4;
            this.btnThayBangBinhPhuong.Text = "Thay bằng bình phương";
            this.btnThayBangBinhPhuong.UseVisualStyleBackColor = false;
            this.btnThayBangBinhPhuong.Click += new System.EventHandler(this.btnThayBangBinhPhuong_Click);
            // 
            // btnTangLen2
            // 
            this.btnTangLen2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTangLen2.Location = new System.Drawing.Point(7, 110);
            this.btnTangLen2.Name = "btnTangLen2";
            this.btnTangLen2.Size = new System.Drawing.Size(204, 23);
            this.btnTangLen2.TabIndex = 3;
            this.btnTangLen2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTangLen2.UseVisualStyleBackColor = false;
            this.btnTangLen2.Click += new System.EventHandler(this.btnTangLen2_Click);
            // 
            // btnXoaPhanTuDangChon
            // 
            this.btnXoaPhanTuDangChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoaPhanTuDangChon.Location = new System.Drawing.Point(7, 80);
            this.btnXoaPhanTuDangChon.Name = "btnXoaPhanTuDangChon";
            this.btnXoaPhanTuDangChon.Size = new System.Drawing.Size(204, 23);
            this.btnXoaPhanTuDangChon.TabIndex = 2;
            this.btnXoaPhanTuDangChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaPhanTuDangChon.UseVisualStyleBackColor = false;
            this.btnXoaPhanTuDangChon.Click += new System.EventHandler(this.btnXoaPhanTuDangChon_Click);
            // 
            // btnXoaDauVaCuoi
            // 
            this.btnXoaDauVaCuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoaDauVaCuoi.Location = new System.Drawing.Point(7, 50);
            this.btnXoaDauVaCuoi.Name = "btnXoaDauVaCuoi";
            this.btnXoaDauVaCuoi.Size = new System.Drawing.Size(204, 23);
            this.btnXoaDauVaCuoi.TabIndex = 1;
            this.btnXoaDauVaCuoi.Text = "Xóa phần tử đầu và cuối";
            this.btnXoaDauVaCuoi.UseVisualStyleBackColor = false;
            this.btnXoaDauVaCuoi.Click += new System.EventHandler(this.btnXoaDauVaCuoi_Click);
            // 
            // btnTongDanhSach
            // 
            this.btnTongDanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTongDanhSach.Location = new System.Drawing.Point(7, 20);
            this.btnTongDanhSach.Name = "btnTongDanhSach";
            this.btnTongDanhSach.Size = new System.Drawing.Size(204, 23);
            this.btnTongDanhSach.TabIndex = 0;
            this.btnTongDanhSach.Text = "Tổng của danh sách";
            this.btnTongDanhSach.UseVisualStyleBackColor = false;
            this.btnTongDanhSach.Click += new System.EventHandler(this.btnTongDanhSach_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.Red;
            this.btnKetThuc.Location = new System.Drawing.Point(106, 311);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(352, 23);
            this.btnKetThuc.TabIndex = 5;
            this.btnKetThuc.Text = "Kết thúc chương trình";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(574, 346);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bài tập List Box";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChonSoChan;
        private System.Windows.Forms.Button btnThayBangBinhPhuong;
        private System.Windows.Forms.Button btnTangLen2;
        private System.Windows.Forms.Button btnXoaPhanTuDangChon;
        private System.Windows.Forms.Button btnXoaDauVaCuoi;
        private System.Windows.Forms.Button btnTongDanhSach;
        private System.Windows.Forms.Button btnChonSoLe;
        private System.Windows.Forms.Button btnKetThuc;
    }
}

