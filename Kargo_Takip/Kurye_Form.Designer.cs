
namespace Kargo_Takip
{
    partial class Kurye_Form
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
            this.grpbxKargoTakip = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmBoxIslemDurumu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTakipNo = new System.Windows.Forms.TextBox();
            this.cmbBoxIslemSube = new System.Windows.Forms.ComboBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKuryeKargo = new System.Windows.Forms.DataGridView();
            this.dgvKuryeKargoDurum = new System.Windows.Forms.DataGridView();
            this.islemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemsubeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemtarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kargoDurumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.takipnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kargoadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpbxKargoTakip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuryeKargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuryeKargoDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargoDurumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxKargoTakip
            // 
            this.grpbxKargoTakip.Controls.Add(this.btnAra);
            this.grpbxKargoTakip.Controls.Add(this.cmBoxIslemDurumu);
            this.grpbxKargoTakip.Controls.Add(this.label3);
            this.grpbxKargoTakip.Controls.Add(this.txtTakipNo);
            this.grpbxKargoTakip.Controls.Add(this.cmbBoxIslemSube);
            this.grpbxKargoTakip.Controls.Add(this.btnOnayla);
            this.grpbxKargoTakip.Controls.Add(this.label2);
            this.grpbxKargoTakip.Controls.Add(this.label1);
            this.grpbxKargoTakip.Location = new System.Drawing.Point(536, 12);
            this.grpbxKargoTakip.Name = "grpbxKargoTakip";
            this.grpbxKargoTakip.Size = new System.Drawing.Size(255, 254);
            this.grpbxKargoTakip.TabIndex = 3;
            this.grpbxKargoTakip.TabStop = false;
            // 
            // btnAra
            // 
            this.btnAra.AutoSize = true;
            this.btnAra.Location = new System.Drawing.Point(6, 67);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(246, 34);
            this.btnAra.TabIndex = 10;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmBoxIslemDurumu
            // 
            this.cmBoxIslemDurumu.FormattingEnabled = true;
            this.cmBoxIslemDurumu.Items.AddRange(new object[] {
            "İletildi",
            "Dağıtıma çıktı",
            "İletilmedi",
            "Kuryeye verildi",
            "Aktarmada"});
            this.cmBoxIslemDurumu.Location = new System.Drawing.Point(131, 184);
            this.cmBoxIslemDurumu.Name = "cmBoxIslemDurumu";
            this.cmBoxIslemDurumu.Size = new System.Drawing.Size(121, 24);
            this.cmBoxIslemDurumu.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "İşem Durumu :";
            // 
            // txtTakipNo
            // 
            this.txtTakipNo.Location = new System.Drawing.Point(125, 13);
            this.txtTakipNo.Name = "txtTakipNo";
            this.txtTakipNo.Size = new System.Drawing.Size(121, 22);
            this.txtTakipNo.TabIndex = 8;
            // 
            // cmbBoxIslemSube
            // 
            this.cmbBoxIslemSube.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.subeBindingSource, "Sube_adi", true));
            this.cmbBoxIslemSube.FormattingEnabled = true;
            this.cmbBoxIslemSube.Location = new System.Drawing.Point(131, 133);
            this.cmbBoxIslemSube.Name = "cmbBoxIslemSube";
            this.cmbBoxIslemSube.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxIslemSube.TabIndex = 5;
            // 
            // btnOnayla
            // 
            this.btnOnayla.AutoSize = true;
            this.btnOnayla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOnayla.Location = new System.Drawing.Point(3, 224);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(249, 27);
            this.btnOnayla.TabIndex = 4;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şube :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Takip No :";
            // 
            // dgvKuryeKargo
            // 
            this.dgvKuryeKargo.AutoGenerateColumns = false;
            this.dgvKuryeKargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKuryeKargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.takipnoDataGridViewTextBoxColumn,
            this.aliciidDataGridViewTextBoxColumn,
            this.kargoadresDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn});
            this.dgvKuryeKargo.DataSource = this.kargoBindingSource;
            this.dgvKuryeKargo.Location = new System.Drawing.Point(12, 12);
            this.dgvKuryeKargo.Name = "dgvKuryeKargo";
            this.dgvKuryeKargo.RowHeadersWidth = 51;
            this.dgvKuryeKargo.RowTemplate.Height = 24;
            this.dgvKuryeKargo.Size = new System.Drawing.Size(504, 251);
            this.dgvKuryeKargo.TabIndex = 7;
            this.dgvKuryeKargo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVdiew1_CellContentClick);
            // 
            // dgvKuryeKargoDurum
            // 
            this.dgvKuryeKargoDurum.AutoGenerateColumns = false;
            this.dgvKuryeKargoDurum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKuryeKargoDurum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.islemDataGridViewTextBoxColumn,
            this.ıslemsubeDataGridViewTextBoxColumn,
            this.ıslemtarihiDataGridViewTextBoxColumn});
            this.dgvKuryeKargoDurum.DataSource = this.kargoDurumBindingSource;
            this.dgvKuryeKargoDurum.Location = new System.Drawing.Point(12, 288);
            this.dgvKuryeKargoDurum.Name = "dgvKuryeKargoDurum";
            this.dgvKuryeKargoDurum.RowHeadersWidth = 51;
            this.dgvKuryeKargoDurum.RowTemplate.Height = 24;
            this.dgvKuryeKargoDurum.Size = new System.Drawing.Size(779, 150);
            this.dgvKuryeKargoDurum.TabIndex = 9;
            // 
            // islemDataGridViewTextBoxColumn
            // 
            this.islemDataGridViewTextBoxColumn.DataPropertyName = "islem";
            this.islemDataGridViewTextBoxColumn.HeaderText = "islem";
            this.islemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.islemDataGridViewTextBoxColumn.Name = "islemDataGridViewTextBoxColumn";
            this.islemDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıslemsubeDataGridViewTextBoxColumn
            // 
            this.ıslemsubeDataGridViewTextBoxColumn.DataPropertyName = "Islem_sube";
            this.ıslemsubeDataGridViewTextBoxColumn.HeaderText = "Islem_sube";
            this.ıslemsubeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemsubeDataGridViewTextBoxColumn.Name = "ıslemsubeDataGridViewTextBoxColumn";
            this.ıslemsubeDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıslemtarihiDataGridViewTextBoxColumn
            // 
            this.ıslemtarihiDataGridViewTextBoxColumn.DataPropertyName = "Islem_tarihi";
            this.ıslemtarihiDataGridViewTextBoxColumn.HeaderText = "Islem_tarihi";
            this.ıslemtarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemtarihiDataGridViewTextBoxColumn.Name = "ıslemtarihiDataGridViewTextBoxColumn";
            this.ıslemtarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kargoDurumBindingSource
            // 
            this.kargoDurumBindingSource.DataSource = typeof(Kargo_Takip.Kargo_Durum);
            // 
            // takipnoDataGridViewTextBoxColumn
            // 
            this.takipnoDataGridViewTextBoxColumn.DataPropertyName = "Takip_no";
            this.takipnoDataGridViewTextBoxColumn.HeaderText = "Takip_no";
            this.takipnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.takipnoDataGridViewTextBoxColumn.Name = "takipnoDataGridViewTextBoxColumn";
            this.takipnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // aliciidDataGridViewTextBoxColumn
            // 
            this.aliciidDataGridViewTextBoxColumn.DataPropertyName = "Alici_id";
            this.aliciidDataGridViewTextBoxColumn.HeaderText = "Alici_id";
            this.aliciidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aliciidDataGridViewTextBoxColumn.Name = "aliciidDataGridViewTextBoxColumn";
            this.aliciidDataGridViewTextBoxColumn.Width = 125;
            // 
            // kargoadresDataGridViewTextBoxColumn
            // 
            this.kargoadresDataGridViewTextBoxColumn.DataPropertyName = "Kargo_adres";
            this.kargoadresDataGridViewTextBoxColumn.HeaderText = "Kargo_adres";
            this.kargoadresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kargoadresDataGridViewTextBoxColumn.Name = "kargoadresDataGridViewTextBoxColumn";
            this.kargoadresDataGridViewTextBoxColumn.Width = 125;
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "Ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "Ucret";
            this.ucretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            this.ucretDataGridViewTextBoxColumn.Width = 125;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.Width = 125;
            // 
            // kargoBindingSource
            // 
            this.kargoBindingSource.DataSource = typeof(Kargo_Takip.Kargo);
            // 
            // subeBindingSource
            // 
            this.subeBindingSource.DataSource = typeof(Kargo_Takip.Sube);
            // 
            // Kurye_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.dgvKuryeKargoDurum);
            this.Controls.Add(this.dgvKuryeKargo);
            this.Controls.Add(this.grpbxKargoTakip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Kurye_Form";
            this.Text = "Kurye_Form";
            this.Load += new System.EventHandler(this.Kurye_Form_Load);
            this.grpbxKargoTakip.ResumeLayout(false);
            this.grpbxKargoTakip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuryeKargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKuryeKargoDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargoDurumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxKargoTakip;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxIslemSube;
        private System.Windows.Forms.DataGridView dgvKuryeKargo;
        private System.Windows.Forms.TextBox txtTakipNo;
        private System.Windows.Forms.ComboBox cmBoxIslemDurumu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource kargoBindingSource;
        private System.Windows.Forms.DataGridView dgvKuryeKargoDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemsubeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemtarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kargoDurumBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn takipnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kargoadresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.BindingSource subeBindingSource;
    }
}