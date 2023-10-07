
namespace bai1
{
    partial class frmBai6
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
            this.btn_cong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_tru = new System.Windows.Forms.Button();
            this.btn_Nhan = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cong
            // 
            this.btn_cong.Location = new System.Drawing.Point(264, 301);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(71, 25);
            this.btn_cong.TabIndex = 5;
            this.btn_cong.Text = "Cong";
            this.btn_cong.UseVisualStyleBackColor = true;
            this.btn_cong.Click += new System.EventHandler(this.Tong);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phep Toan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtso2);
            this.groupBox1.Controls.Add(this.txtso1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(288, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong Tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(87, 57);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(110, 20);
            this.txtso2.TabIndex = 3;
            this.txtso2.TextAlignChanged += new System.EventHandler(this.so2);
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(87, 34);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(110, 20);
            this.txtso1.TabIndex = 2;
            this.txtso1.TextChanged += new System.EventHandler(this.so1);
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
            // btn_tru
            // 
            this.btn_tru.Location = new System.Drawing.Point(341, 301);
            this.btn_tru.Name = "btn_tru";
            this.btn_tru.Size = new System.Drawing.Size(71, 25);
            this.btn_tru.TabIndex = 6;
            this.btn_tru.Text = "Tru";
            this.btn_tru.UseVisualStyleBackColor = true;
            this.btn_tru.Click += new System.EventHandler(this.Tru);
            // 
            // btn_Nhan
            // 
            this.btn_Nhan.Location = new System.Drawing.Point(418, 301);
            this.btn_Nhan.Name = "btn_Nhan";
            this.btn_Nhan.Size = new System.Drawing.Size(71, 25);
            this.btn_Nhan.TabIndex = 7;
            this.btn_Nhan.Text = "Nhan";
            this.btn_Nhan.UseVisualStyleBackColor = true;
            this.btn_Nhan.Click += new System.EventHandler(this.Nhan);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(495, 301);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(71, 25);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Chia";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.chia);
            // 
            // frmBai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_Nhan);
            this.Controls.Add(this.btn_tru);
            this.Controls.Add(this.btn_cong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBai6";
            this.Text = "Bai 2.6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tru;
        private System.Windows.Forms.Button btn_Nhan;
        private System.Windows.Forms.Button btn_thoat;
    }
}