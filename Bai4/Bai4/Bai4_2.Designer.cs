﻿namespace Bai4
{
    partial class Bai4_2
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
            this.txtResuit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResuit
            // 
            this.txtResuit.Enabled = false;
            this.txtResuit.Location = new System.Drawing.Point(149, 111);
            this.txtResuit.Name = "txtResuit";
            this.txtResuit.Size = new System.Drawing.Size(130, 20);
            this.txtResuit.TabIndex = 9;
            this.txtResuit.TextChanged += new System.EventHandler(this.txtResuit_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "S:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(159, 172);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tinh";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(149, 74);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(130, 20);
            this.txtN.TabIndex = 6;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "n:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Bai4_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 269);
            this.Controls.Add(this.txtResuit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Name = "Bai4_2";
            this.Text = "Bai4_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
    }
}