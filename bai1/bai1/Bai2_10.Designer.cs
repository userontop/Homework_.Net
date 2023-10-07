namespace bai1
{
    partial class Bai2_10
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
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_DuongCheo = new System.Windows.Forms.Button();
            this.btn_DienTich = new System.Windows.Forms.Button();
            this.btn_ChuVi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(484, 296);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(62, 42);
            this.btn_thoat.TabIndex = 30;
            this.btn_thoat.Text = "Thoat";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_DuongCheo
            // 
            this.btn_DuongCheo.Location = new System.Drawing.Point(407, 296);
            this.btn_DuongCheo.Name = "btn_DuongCheo";
            this.btn_DuongCheo.Size = new System.Drawing.Size(62, 42);
            this.btn_DuongCheo.TabIndex = 29;
            this.btn_DuongCheo.Text = "Duong cheo";
            this.btn_DuongCheo.UseVisualStyleBackColor = true;
            this.btn_DuongCheo.Click += new System.EventHandler(this.btn_DuongCheo_Click);
            // 
            // btn_DienTich
            // 
            this.btn_DienTich.Location = new System.Drawing.Point(330, 296);
            this.btn_DienTich.Name = "btn_DienTich";
            this.btn_DienTich.Size = new System.Drawing.Size(62, 42);
            this.btn_DienTich.TabIndex = 28;
            this.btn_DienTich.Text = "Dien Tich";
            this.btn_DienTich.UseVisualStyleBackColor = true;
            this.btn_DienTich.Click += new System.EventHandler(this.btn_DienTich_Click);
            // 
            // btn_ChuVi
            // 
            this.btn_ChuVi.Location = new System.Drawing.Point(253, 296);
            this.btn_ChuVi.Name = "btn_ChuVi";
            this.btn_ChuVi.Size = new System.Drawing.Size(62, 42);
            this.btn_ChuVi.TabIndex = 27;
            this.btn_ChuVi.Text = "Chu Vi";
            this.btn_ChuVi.UseVisualStyleBackColor = true;
            this.btn_ChuVi.Click += new System.EventHandler(this.btn_ChuVi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Phep Toan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtso2);
            this.groupBox1.Controls.Add(this.txtso1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(286, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 118);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong Tin";
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(87, 57);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(110, 20);
            this.txtso2.TabIndex = 3;
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(87, 34);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(110, 20);
            this.txtso1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a:";
            // 
            // Bai2_10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_DuongCheo);
            this.Controls.Add(this.btn_DienTich);
            this.Controls.Add(this.btn_ChuVi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bai2_10";
            this.Text = "Bai2_10";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_DuongCheo;
        private System.Windows.Forms.Button btn_DienTich;
        private System.Windows.Forms.Button btn_ChuVi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}