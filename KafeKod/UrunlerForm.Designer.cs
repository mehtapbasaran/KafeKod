namespace KafeKod
{
    partial class UrunlerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.nudBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmUrunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbmBirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirimFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, -22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Birim Fiyatı (₺)";
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbmUrunAd,
            this.cbmBirimFiyat});
            this.dgvUrunler.Location = new System.Drawing.Point(12, 71);
            this.dgvUrunler.MinimumSize = new System.Drawing.Size(667, 455);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.Size = new System.Drawing.Size(667, 455);
            this.dgvUrunler.TabIndex = 10;
            this.dgvUrunler.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvUrunler_CellValidating);
            this.dgvUrunler.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvUrunler_DataError);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Location = new System.Drawing.Point(369, 37);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(103, 30);
            this.btnUrunEkle.TabIndex = 9;
            this.btnUrunEkle.Text = "EKLE";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // nudBirimFiyat
            // 
            this.nudBirimFiyat.DecimalPlaces = 2;
            this.nudBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudBirimFiyat.Location = new System.Drawing.Point(231, 39);
            this.nudBirimFiyat.Name = "nudBirimFiyat";
            this.nudBirimFiyat.Size = new System.Drawing.Size(120, 26);
            this.nudBirimFiyat.TabIndex = 8;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAd.Location = new System.Drawing.Point(12, 39);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(203, 26);
            this.txtUrunAd.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, -22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(227, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Birim Fiyatı (₺)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ürün Adı";
            // 
            // cbmUrunAd
            // 
            this.cbmUrunAd.DataPropertyName = "UrunAd";
            this.cbmUrunAd.HeaderText = "Ürün Adı";
            this.cbmUrunAd.Name = "cbmUrunAd";
            // 
            // cbmBirimFiyat
            // 
            this.cbmBirimFiyat.DataPropertyName = "BirimFiyat";
            this.cbmBirimFiyat.HeaderText = "Birim Fiyatı";
            this.cbmBirimFiyat.Name = "cbmBirimFiyat";
            // 
            // UrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 538);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.nudBirimFiyat);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.label1);
            this.Name = "UrunlerForm";
            this.Text = "UrunlerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirimFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.NumericUpDown nudBirimFiyat;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbmUrunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbmBirimFiyat;
    }
}