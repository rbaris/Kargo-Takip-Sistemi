
namespace Kargo_Takip
{
    partial class Musteri_kargo_takip
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
            this.dgv_kargotakip = new System.Windows.Forms.DataGridView();
            this.ıslemtarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemsubeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kargoDurumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kargotakip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargoDurumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_kargotakip
            // 
            this.dgv_kargotakip.AutoGenerateColumns = false;
            this.dgv_kargotakip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kargotakip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıslemtarihiDataGridViewTextBoxColumn,
            this.islemDataGridViewTextBoxColumn,
            this.ıslemsubeDataGridViewTextBoxColumn});
            this.dgv_kargotakip.DataSource = this.kargoDurumBindingSource;
            this.dgv_kargotakip.Location = new System.Drawing.Point(12, 12);
            this.dgv_kargotakip.Name = "dgv_kargotakip";
            this.dgv_kargotakip.RowHeadersWidth = 51;
            this.dgv_kargotakip.RowTemplate.Height = 24;
            this.dgv_kargotakip.Size = new System.Drawing.Size(776, 426);
            this.dgv_kargotakip.TabIndex = 0;
            // 
            // ıslemtarihiDataGridViewTextBoxColumn
            // 
            this.ıslemtarihiDataGridViewTextBoxColumn.DataPropertyName = "Islem_tarihi";
            this.ıslemtarihiDataGridViewTextBoxColumn.HeaderText = "İşlem Tarihi";
            this.ıslemtarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemtarihiDataGridViewTextBoxColumn.Name = "ıslemtarihiDataGridViewTextBoxColumn";
            this.ıslemtarihiDataGridViewTextBoxColumn.Width = 150;
            // 
            // islemDataGridViewTextBoxColumn
            // 
            this.islemDataGridViewTextBoxColumn.DataPropertyName = "islem";
            this.islemDataGridViewTextBoxColumn.HeaderText = "İşlem";
            this.islemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.islemDataGridViewTextBoxColumn.Name = "islemDataGridViewTextBoxColumn";
            this.islemDataGridViewTextBoxColumn.Width = 150;
            // 
            // ıslemsubeDataGridViewTextBoxColumn
            // 
            this.ıslemsubeDataGridViewTextBoxColumn.DataPropertyName = "Islem_sube";
            this.ıslemsubeDataGridViewTextBoxColumn.HeaderText = "İşlemin Gerçekleştiği Şube";
            this.ıslemsubeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemsubeDataGridViewTextBoxColumn.Name = "ıslemsubeDataGridViewTextBoxColumn";
            this.ıslemsubeDataGridViewTextBoxColumn.Width = 150;
            // 
            // kargoDurumBindingSource
            // 
            this.kargoDurumBindingSource.DataSource = typeof(Kargo_Takip.Kargo_Durum);
            // 
            // Musteri_kargo_takip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_kargotakip);
            this.Name = "Musteri_kargo_takip";
            this.Text = "Musteri_kargo_takip";
            this.Load += new System.EventHandler(this.Musteri_kargo_takip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kargotakip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargoDurumBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_kargotakip;
        private System.Windows.Forms.BindingSource kargoDurumBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemtarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemsubeDataGridViewTextBoxColumn;
    }
}