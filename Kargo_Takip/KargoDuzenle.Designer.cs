
namespace Kargo_Takip
{
    partial class KargoDuzenle
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtHacim = new System.Windows.Forms.TextBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.txtAgirlik = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlici = new System.Windows.Forms.Label();
            this.lblGonderici = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.AutoSize = true;
            this.btnKaydet.Location = new System.Drawing.Point(532, 173);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(137, 58);
            this.btnKaydet.TabIndex = 26;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(228, 342);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(460, 22);
            this.txtAdres.TabIndex = 25;
            // 
            // txtHacim
            // 
            this.txtHacim.Location = new System.Drawing.Point(228, 288);
            this.txtHacim.Name = "txtHacim";
            this.txtHacim.Size = new System.Drawing.Size(100, 22);
            this.txtHacim.TabIndex = 24;
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(228, 227);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(100, 22);
            this.txtTur.TabIndex = 23;
            // 
            // txtAgirlik
            // 
            this.txtAgirlik.Location = new System.Drawing.Point(228, 168);
            this.txtAgirlik.Name = "txtAgirlik";
            this.txtAgirlik.Size = new System.Drawing.Size(100, 22);
            this.txtAgirlik.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hacim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tür";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ağırlık";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Gönderici";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Alici";
            // 
            // lblAlici
            // 
            this.lblAlici.AutoSize = true;
            this.lblAlici.Location = new System.Drawing.Point(225, 64);
            this.lblAlici.Name = "lblAlici";
            this.lblAlici.Size = new System.Drawing.Size(0, 17);
            this.lblAlici.TabIndex = 27;
            // 
            // lblGonderici
            // 
            this.lblGonderici.AutoSize = true;
            this.lblGonderici.Location = new System.Drawing.Point(225, 118);
            this.lblGonderici.Name = "lblGonderici";
            this.lblGonderici.Size = new System.Drawing.Size(0, 17);
            this.lblGonderici.TabIndex = 28;
            // 
            // KargoDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGonderici);
            this.Controls.Add(this.lblAlici);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtHacim);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.txtAgirlik);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KargoDuzenle";
            this.Text = "KargoDuzenle";
            this.Load += new System.EventHandler(this.KargoDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtHacim;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.TextBox txtAgirlik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlici;
        private System.Windows.Forms.Label lblGonderici;
    }
}