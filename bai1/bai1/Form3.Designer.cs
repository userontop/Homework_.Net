
namespace bai1
{
    partial class frmBai3
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
            this.btn_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(373, 180);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(75, 23);
            this.btn_click.TabIndex = 0;
            this.btn_click.Text = "Hien Thi";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.Btn_click);
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_click);
            this.Name = "frmBai3";
            this.Text = "Bai 2.3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_click;
    }
}