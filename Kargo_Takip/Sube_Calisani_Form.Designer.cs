
namespace Kargo_Takip
{
    partial class Sube_Calisani_Form
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
            this.dgvSubeCalisaniKargoDuzenleme = new System.Windows.Forms.DataGridView();
            this.btnFaturaHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.txtKargoOlustur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kargoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takipnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agirlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hacimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gondericiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kargoadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubeCalisaniKargoDuzenleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubeCalisaniKargoDuzenleme
            // 
            this.dgvSubeCalisaniKargoDuzenleme.AutoGenerateColumns = false;
            this.dgvSubeCalisaniKargoDuzenleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubeCalisaniKargoDuzenleme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kargoidDataGridViewTextBoxColumn,
            this.takipnoDataGridViewTextBoxColumn,
            this.agirlikDataGridViewTextBoxColumn,
            this.turDataGridViewTextBoxColumn,
            this.hacimDataGridViewTextBoxColumn,
            this.gondericiidDataGridViewTextBoxColumn,
            this.aliciidDataGridViewTextBoxColumn,
            this.kargoadresDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn});
            this.dgvSubeCalisaniKargoDuzenleme.DataSource = this.kargoBindingSource;
            this.dgvSubeCalisaniKargoDuzenleme.Location = new System.Drawing.Point(12, 3);
            this.dgvSubeCalisaniKargoDuzenleme.Name = "dgvSubeCalisaniKargoDuzenleme";
            this.dgvSubeCalisaniKargoDuzenleme.RowHeadersWidth = 51;
            this.dgvSubeCalisaniKargoDuzenleme.RowTemplate.Height = 24;
            this.dgvSubeCalisaniKargoDuzenleme.Size = new System.Drawing.Size(1033, 311);
            this.dgvSubeCalisaniKargoDuzenleme.TabIndex = 0;
            this.dgvSubeCalisaniKargoDuzenleme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubeCalisaniKargoDuzenleme_CellClick);
            // 
            // btnFaturaHesapla
            // 
            this.btnFaturaHesapla.AutoSize = true;
            this.btnFaturaHesapla.Location = new System.Drawing.Point(620, 369);
            this.btnFaturaHesapla.Name = "btnFaturaHesapla";
            this.btnFaturaHesapla.Size = new System.Drawing.Size(75, 27);
            this.btnFaturaHesapla.TabIndex = 0;
            this.btnFaturaHesapla.Text = "Hesapla";
            this.btnFaturaHesapla.UseVisualStyleBackColor = true;
            this.btnFaturaHesapla.Click += new System.EventHandler(this.btnFaturaHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(761, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ücret :";
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(824, 374);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(150, 17);
            this.lblUcret.TabIndex = 2;
            this.lblUcret.Text = "Ücret_burada_yazıcak";
            // 
            // txtKargoOlustur
            // 
            this.txtKargoOlustur.AutoSize = true;
            this.txtKargoOlustur.Location = new System.Drawing.Point(120, 374);
            this.txtKargoOlustur.Name = "txtKargoOlustur";
            this.txtKargoOlustur.Size = new System.Drawing.Size(112, 27);
            this.txtKargoOlustur.TabIndex = 3;
            this.txtKargoOlustur.Text = "Kargo Oluştur";
            this.txtKargoOlustur.UseVisualStyleBackColor = true;
            this.txtKargoOlustur.Click += new System.EventHandler(this.txtKargoOlustur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(761, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // kargoidDataGridViewTextBoxColumn
            // 
            this.kargoidDataGridViewTextBoxColumn.DataPropertyName = "Kargo_id";
            this.kargoidDataGridViewTextBoxColumn.HeaderText = "Kargo_id";
            this.kargoidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kargoidDataGridViewTextBoxColumn.Name = "kargoidDataGridViewTextBoxColumn";
            this.kargoidDataGridViewTextBoxColumn.Width = 125;
            // 
            // takipnoDataGridViewTextBoxColumn
            // 
            this.takipnoDataGridViewTextBoxColumn.DataPropertyName = "Takip_no";
            this.takipnoDataGridViewTextBoxColumn.HeaderText = "Takip_no";
            this.takipnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.takipnoDataGridViewTextBoxColumn.Name = "takipnoDataGridViewTextBoxColumn";
            this.takipnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // agirlikDataGridViewTextBoxColumn
            // 
            this.agirlikDataGridViewTextBoxColumn.DataPropertyName = "Agirlik";
            this.agirlikDataGridViewTextBoxColumn.HeaderText = "Agirlik";
            this.agirlikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.agirlikDataGridViewTextBoxColumn.Name = "agirlikDataGridViewTextBoxColumn";
            this.agirlikDataGridViewTextBoxColumn.Width = 125;
            // 
            // turDataGridViewTextBoxColumn
            // 
            this.turDataGridViewTextBoxColumn.DataPropertyName = "Tur";
            this.turDataGridViewTextBoxColumn.HeaderText = "Tur";
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
            // gondericiidDataGridViewTextBoxColumn
            // 
            this.gondericiidDataGridViewTextBoxColumn.DataPropertyName = "Gonderici_id";
            this.gondericiidDataGridViewTextBoxColumn.HeaderText = "Gonderici_id";
            this.gondericiidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gondericiidDataGridViewTextBoxColumn.Name = "gondericiidDataGridViewTextBoxColumn";
            this.gondericiidDataGridViewTextBoxColumn.Width = 125;
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
            // kargoBindingSource
            // 
            this.kargoBindingSource.DataSource = typeof(Kargo_Takip.Kargo);
            // 
            // Sube_Calisani_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKargoOlustur);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSubeCalisaniKargoDuzenleme);
            this.Controls.Add(this.btnFaturaHesapla);
            this.Name = "Sube_Calisani_Form";
            this.Text = "Sube_Calisani_Form";
            this.Load += new System.EventHandler(this.Sube_Calisani_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubeCalisaniKargoDuzenleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubeCalisaniKargoDuzenleme;
        private System.Windows.Forms.Button btnFaturaHesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Button txtKargoOlustur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource kargoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn kargoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takipnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agirlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hacimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gondericiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kargoadresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
    }
}