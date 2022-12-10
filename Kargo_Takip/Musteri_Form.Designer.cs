
namespace Kargo_Takip
{
    partial class Musteri_Form
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
            this.components = new System.ComponentModel.Container();
            this.grpbxMüsteriBilgileri = new System.Windows.Forms.GroupBox();
            this.btnDegisikleriKaydet = new System.Windows.Forms.Button();
            this.txtMüsteriSifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMüsteriBilgiGuncelle = new System.Windows.Forms.Button();
            this.txtMüsteriEmail = new System.Windows.Forms.TextBox();
            this.txtMüsteriSoyad = new System.Windows.Forms.TextBox();
            this.txtMüsteriTC = new System.Windows.Forms.TextBox();
            this.txtMüsteriAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvKargolar = new System.Windows.Forms.DataGridView();
            this.takipnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agirlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hacimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kargoadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kargoDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpbxMüsteriBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKargolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxMüsteriBilgileri
            // 
            this.grpbxMüsteriBilgileri.Controls.Add(this.btnDegisikleriKaydet);
            this.grpbxMüsteriBilgileri.Controls.Add(this.txtMüsteriSifre);
            this.grpbxMüsteriBilgileri.Controls.Add(this.label7);
            this.grpbxMüsteriBilgileri.Controls.Add(this.btnMüsteriBilgiGuncelle);
            this.grpbxMüsteriBilgileri.Controls.Add(this.txtMüsteriEmail);
            this.grpbxMüsteriBilgileri.Controls.Add(this.txtMüsteriSoyad);
            this.grpbxMüsteriBilgileri.Controls.Add(this.txtMüsteriTC);
            this.grpbxMüsteriBilgileri.Controls.Add(this.txtMüsteriAd);
            this.grpbxMüsteriBilgileri.Controls.Add(this.label6);
            this.grpbxMüsteriBilgileri.Controls.Add(this.label5);
            this.grpbxMüsteriBilgileri.Controls.Add(this.label4);
            this.grpbxMüsteriBilgileri.Controls.Add(this.label3);
            this.grpbxMüsteriBilgileri.Location = new System.Drawing.Point(924, 12);
            this.grpbxMüsteriBilgileri.Name = "grpbxMüsteriBilgileri";
            this.grpbxMüsteriBilgileri.Size = new System.Drawing.Size(364, 371);
            this.grpbxMüsteriBilgileri.TabIndex = 3;
            this.grpbxMüsteriBilgileri.TabStop = false;
            this.grpbxMüsteriBilgileri.Text = "Bilgileriniz";
            // 
            // btnDegisikleriKaydet
            // 
            this.btnDegisikleriKaydet.AutoSize = true;
            this.btnDegisikleriKaydet.Location = new System.Drawing.Point(3, 308);
            this.btnDegisikleriKaydet.Name = "btnDegisikleriKaydet";
            this.btnDegisikleriKaydet.Size = new System.Drawing.Size(358, 27);
            this.btnDegisikleriKaydet.TabIndex = 11;
            this.btnDegisikleriKaydet.Text = "Kaydet";
            this.btnDegisikleriKaydet.UseVisualStyleBackColor = true;
            this.btnDegisikleriKaydet.Click += new System.EventHandler(this.btnDegisikleriKaydet_Click);
            // 
            // txtMüsteriSifre
            // 
            this.txtMüsteriSifre.Location = new System.Drawing.Point(138, 245);
            this.txtMüsteriSifre.Name = "txtMüsteriSifre";
            this.txtMüsteriSifre.Size = new System.Drawing.Size(174, 22);
            this.txtMüsteriSifre.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Şifre :";
            // 
            // btnMüsteriBilgiGuncelle
            // 
            this.btnMüsteriBilgiGuncelle.AutoSize = true;
            this.btnMüsteriBilgiGuncelle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMüsteriBilgiGuncelle.Location = new System.Drawing.Point(3, 341);
            this.btnMüsteriBilgiGuncelle.Name = "btnMüsteriBilgiGuncelle";
            this.btnMüsteriBilgiGuncelle.Size = new System.Drawing.Size(358, 27);
            this.btnMüsteriBilgiGuncelle.TabIndex = 8;
            this.btnMüsteriBilgiGuncelle.Text = "Bilgilerimi Güncelle";
            this.btnMüsteriBilgiGuncelle.UseVisualStyleBackColor = true;
            this.btnMüsteriBilgiGuncelle.Click += new System.EventHandler(this.btnMüsteriBilgiGuncelle_Click);
            // 
            // txtMüsteriEmail
            // 
            this.txtMüsteriEmail.Location = new System.Drawing.Point(138, 197);
            this.txtMüsteriEmail.Name = "txtMüsteriEmail";
            this.txtMüsteriEmail.Size = new System.Drawing.Size(174, 22);
            this.txtMüsteriEmail.TabIndex = 7;
            // 
            // txtMüsteriSoyad
            // 
            this.txtMüsteriSoyad.Location = new System.Drawing.Point(138, 97);
            this.txtMüsteriSoyad.Name = "txtMüsteriSoyad";
            this.txtMüsteriSoyad.Size = new System.Drawing.Size(174, 22);
            this.txtMüsteriSoyad.TabIndex = 6;
            // 
            // txtMüsteriTC
            // 
            this.txtMüsteriTC.Location = new System.Drawing.Point(138, 147);
            this.txtMüsteriTC.Name = "txtMüsteriTC";
            this.txtMüsteriTC.Size = new System.Drawing.Size(174, 22);
            this.txtMüsteriTC.TabIndex = 5;
            // 
            // txtMüsteriAd
            // 
            this.txtMüsteriAd.Location = new System.Drawing.Point(138, 47);
            this.txtMüsteriAd.Name = "txtMüsteriAd";
            this.txtMüsteriAd.Size = new System.Drawing.Size(174, 22);
            this.txtMüsteriAd.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "TC :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad :";
            // 
            // dgvKargolar
            // 
            this.dgvKargolar.AutoGenerateColumns = false;
            this.dgvKargolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKargolar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.takipnoDataGridViewTextBoxColumn,
            this.agirlikDataGridViewTextBoxColumn,
            this.turDataGridViewTextBoxColumn,
            this.hacimDataGridViewTextBoxColumn,
            this.kargoadresDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn,
            this.kargoDurumDataGridViewTextBoxColumn});
            this.dgvKargolar.DataSource = this.kargoBindingSource;
            this.dgvKargolar.Location = new System.Drawing.Point(12, 12);
            this.dgvKargolar.Name = "dgvKargolar";
            this.dgvKargolar.RowHeadersWidth = 51;
            this.dgvKargolar.RowTemplate.Height = 24;
            this.dgvKargolar.Size = new System.Drawing.Size(906, 363);
            this.dgvKargolar.TabIndex = 4;
            this.dgvKargolar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKargolar_CellClick);
            // 
            // takipnoDataGridViewTextBoxColumn
            // 
            this.takipnoDataGridViewTextBoxColumn.DataPropertyName = "Takip_no";
            this.takipnoDataGridViewTextBoxColumn.HeaderText = "Kargo Takip No";
            this.takipnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.takipnoDataGridViewTextBoxColumn.Name = "takipnoDataGridViewTextBoxColumn";
            this.takipnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // agirlikDataGridViewTextBoxColumn
            // 
            this.agirlikDataGridViewTextBoxColumn.DataPropertyName = "Agirlik";
            this.agirlikDataGridViewTextBoxColumn.HeaderText = "Ağırlık";
            this.agirlikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agirlikDataGridViewTextBoxColumn.Name = "agirlikDataGridViewTextBoxColumn";
            this.agirlikDataGridViewTextBoxColumn.Width = 125;
            // 
            // turDataGridViewTextBoxColumn
            // 
            this.turDataGridViewTextBoxColumn.DataPropertyName = "Tur";
            this.turDataGridViewTextBoxColumn.HeaderText = "Tür";
            this.turDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turDataGridViewTextBoxColumn.Name = "turDataGridViewTextBoxColumn";
            this.turDataGridViewTextBoxColumn.Width = 125;
            // 
            // hacimDataGridViewTextBoxColumn
            // 
            this.hacimDataGridViewTextBoxColumn.DataPropertyName = "Hacim";
            this.hacimDataGridViewTextBoxColumn.HeaderText = "Hacim";
            this.hacimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hacimDataGridViewTextBoxColumn.Name = "hacimDataGridViewTextBoxColumn";
            this.hacimDataGridViewTextBoxColumn.Width = 125;
            // 
            // kargoadresDataGridViewTextBoxColumn
            // 
            this.kargoadresDataGridViewTextBoxColumn.DataPropertyName = "Kargo_adres";
            this.kargoadresDataGridViewTextBoxColumn.HeaderText = "Kargo Adresi";
            this.kargoadresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kargoadresDataGridViewTextBoxColumn.Name = "kargoadresDataGridViewTextBoxColumn";
            this.kargoadresDataGridViewTextBoxColumn.Width = 125;
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "Ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "Ücret";
            this.ucretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            this.ucretDataGridViewTextBoxColumn.Width = 125;
            // 
            // kargoDurumDataGridViewTextBoxColumn
            // 
            this.kargoDurumDataGridViewTextBoxColumn.DataPropertyName = "Kargo_Durum";
            this.kargoDurumDataGridViewTextBoxColumn.HeaderText = "Kargo Durumu";
            this.kargoDurumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kargoDurumDataGridViewTextBoxColumn.Name = "kargoDurumDataGridViewTextBoxColumn";
            this.kargoDurumDataGridViewTextBoxColumn.Width = 125;
            // 
            // kargoBindingSource
            // 
            this.kargoBindingSource.DataSource = typeof(Kargo_Takip.Kargo);
            // 
            // Musteri_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 387);
            this.Controls.Add(this.dgvKargolar);
            this.Controls.Add(this.grpbxMüsteriBilgileri);
            this.Name = "Musteri_Form";
            this.Text = "Musteri_Form";
            this.Load += new System.EventHandler(this.Musteri_Form_Load);
            this.grpbxMüsteriBilgileri.ResumeLayout(false);
            this.grpbxMüsteriBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKargolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxMüsteriBilgileri;
        private System.Windows.Forms.TextBox txtMüsteriEmail;
        private System.Windows.Forms.TextBox txtMüsteriSoyad;
        private System.Windows.Forms.TextBox txtMüsteriTC;
        private System.Windows.Forms.TextBox txtMüsteriAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMüsteriBilgiGuncelle;
        private System.Windows.Forms.Button btnDegisikleriKaydet;
        private System.Windows.Forms.TextBox txtMüsteriSifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvKargolar;
        private System.Windows.Forms.BindingSource kargoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn takipnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agirlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hacimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kargoadresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kargoDurumDataGridViewTextBoxColumn;
    }
}