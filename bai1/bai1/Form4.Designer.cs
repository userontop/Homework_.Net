
namespace bai1
{
    partial class frmBai4
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
            this.Btn_clickHienThi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_clickHienThi
            // 
            this.Btn_clickHienThi.Location = new System.Drawing.Point(322, 165);
            this.Btn_clickHienThi.Name = "Btn_clickHienThi";
            this.Btn_clickHienThi.Size = new System.Drawing.Size(146, 26);
            this.Btn_clickHienThi.TabIndex = 1;
            this.Btn_clickHienThi.Text = "Hien Thi";
            this.Btn_clickHienThi.UseVisualStyleBackColor = true;
            this.Btn_clickHienThi.Click += new System.EventHandler(this.BtnHienthi);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ho Ten:";
            // 
            // Text_input
            // 
            this.Text_input.Location = new System.Drawing.Point(312, 128);
            this.Text_input.Name = "Text_input";
            this.Text_input.Size = new System.Drawing.Size(195, 20);
            this.Text_input.TabIndex = 3;
            this.Text_input.TextChanged += new System.EventHandler(this.text_input);
            // 
            // frmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Text_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_clickHienThi);
            this.Name = "frmBai4";
            this.Text = "Bai 2.4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button Btn_clickHienThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_input;
    }
}