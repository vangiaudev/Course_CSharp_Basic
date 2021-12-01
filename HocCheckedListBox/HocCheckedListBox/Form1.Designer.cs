namespace HocCheckedListBox
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
            this.chklstLeft = new System.Windows.Forms.CheckedListBox();
            this.btnRight1 = new System.Windows.Forms.Button();
            this.btnRight2 = new System.Windows.Forms.Button();
            this.btnLeft1 = new System.Windows.Forms.Button();
            this.btnLeft2 = new System.Windows.Forms.Button();
            this.chklstRight = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // chklstLeft
            // 
            this.chklstLeft.FormattingEnabled = true;
            this.chklstLeft.Location = new System.Drawing.Point(13, 68);
            this.chklstLeft.Name = "chklstLeft";
            this.chklstLeft.Size = new System.Drawing.Size(131, 169);
            this.chklstLeft.TabIndex = 0;
            // 
            // btnRight1
            // 
            this.btnRight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight1.Location = new System.Drawing.Point(166, 68);
            this.btnRight1.Name = "btnRight1";
            this.btnRight1.Size = new System.Drawing.Size(75, 23);
            this.btnRight1.TabIndex = 1;
            this.btnRight1.Text = ">";
            this.btnRight1.UseVisualStyleBackColor = true;
            this.btnRight1.Click += new System.EventHandler(this.btnRight1_Click);
            // 
            // btnRight2
            // 
            this.btnRight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight2.Location = new System.Drawing.Point(166, 115);
            this.btnRight2.Name = "btnRight2";
            this.btnRight2.Size = new System.Drawing.Size(75, 23);
            this.btnRight2.TabIndex = 2;
            this.btnRight2.Text = ">>";
            this.btnRight2.UseVisualStyleBackColor = true;
            this.btnRight2.Click += new System.EventHandler(this.btnRight2_Click);
            // 
            // btnLeft1
            // 
            this.btnLeft1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft1.Location = new System.Drawing.Point(166, 167);
            this.btnLeft1.Name = "btnLeft1";
            this.btnLeft1.Size = new System.Drawing.Size(75, 23);
            this.btnLeft1.TabIndex = 3;
            this.btnLeft1.Text = "<";
            this.btnLeft1.UseVisualStyleBackColor = true;
            this.btnLeft1.Click += new System.EventHandler(this.btnLeft1_Click);
            // 
            // btnLeft2
            // 
            this.btnLeft2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft2.Location = new System.Drawing.Point(166, 214);
            this.btnLeft2.Name = "btnLeft2";
            this.btnLeft2.Size = new System.Drawing.Size(75, 23);
            this.btnLeft2.TabIndex = 4;
            this.btnLeft2.Text = "<<";
            this.btnLeft2.UseVisualStyleBackColor = true;
            this.btnLeft2.Click += new System.EventHandler(this.btnLeft2_Click);
            // 
            // chklstRight
            // 
            this.chklstRight.FormattingEnabled = true;
            this.chklstRight.Location = new System.Drawing.Point(258, 66);
            this.chklstRight.Name = "chklstRight";
            this.chklstRight.Size = new System.Drawing.Size(120, 169);
            this.chklstRight.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 325);
            this.Controls.Add(this.chklstRight);
            this.Controls.Add(this.btnLeft2);
            this.Controls.Add(this.btnLeft1);
            this.Controls.Add(this.btnRight2);
            this.Controls.Add(this.btnRight1);
            this.Controls.Add(this.chklstLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklstLeft;
        private System.Windows.Forms.Button btnRight1;
        private System.Windows.Forms.Button btnRight2;
        private System.Windows.Forms.Button btnLeft1;
        private System.Windows.Forms.Button btnLeft2;
        private System.Windows.Forms.CheckedListBox chklstRight;
    }
}

