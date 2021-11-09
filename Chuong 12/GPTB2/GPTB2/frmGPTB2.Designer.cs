
namespace GPTB2
{
    partial class frmGPTB2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeSoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeSob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeSoc = new System.Windows.Forms.TextBox();
            this.btGiaiPhuongTrinh = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ số a:";
            // 
            // txtHeSoa
            // 
            this.txtHeSoa.Location = new System.Drawing.Point(76, 18);
            this.txtHeSoa.Name = "txtHeSoa";
            this.txtHeSoa.Size = new System.Drawing.Size(190, 23);
            this.txtHeSoa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hệ số b:";
            // 
            // txtHeSob
            // 
            this.txtHeSob.Location = new System.Drawing.Point(76, 47);
            this.txtHeSob.Name = "txtHeSob";
            this.txtHeSob.Size = new System.Drawing.Size(190, 23);
            this.txtHeSob.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hệ số c:";
            // 
            // txtHeSoc
            // 
            this.txtHeSoc.Location = new System.Drawing.Point(76, 76);
            this.txtHeSoc.Name = "txtHeSoc";
            this.txtHeSoc.Size = new System.Drawing.Size(190, 23);
            this.txtHeSoc.TabIndex = 1;
            // 
            // btGiaiPhuongTrinh
            // 
            this.btGiaiPhuongTrinh.Location = new System.Drawing.Point(76, 120);
            this.btGiaiPhuongTrinh.Name = "btGiaiPhuongTrinh";
            this.btGiaiPhuongTrinh.Size = new System.Drawing.Size(150, 23);
            this.btGiaiPhuongTrinh.TabIndex = 2;
            this.btGiaiPhuongTrinh.Text = "Giải phương trình";
            this.btGiaiPhuongTrinh.UseVisualStyleBackColor = true;
            this.btGiaiPhuongTrinh.Click += new System.EventHandler(this.btGiaiPhuongTrinh_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(21, 174);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(245, 88);
            this.txtKetQua.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả:";
            // 
            // frmGPTB2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 285);
            this.Controls.Add(this.btGiaiPhuongTrinh);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtHeSoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHeSob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHeSoa);
            this.Controls.Add(this.label1);
            this.Name = "frmGPTB2";
            this.Text = "Giai phuong trinh bac 2";
            this.Load += new System.EventHandler(this.frmGPTB2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeSoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeSob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeSoc;
        private System.Windows.Forms.Button btGiaiPhuongTrinh;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label4;
    }
}

