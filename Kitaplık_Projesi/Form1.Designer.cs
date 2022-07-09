namespace Kitaplık_Projesi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblKitapid = new System.Windows.Forms.Label();
            this.TxtKitapid = new System.Windows.Forms.TextBox();
            this.TxtKitapAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtYazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbTur = new System.Windows.Forms.ComboBox();
            this.Radiobttnikinciel = new System.Windows.Forms.RadioButton();
            this.Radiobtnsifir = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSayfa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.TxtKitapbul = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBul = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnHarfAra = new System.Windows.Forms.Button();
            this.TxtKitapHarfAra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // LblKitapid
            // 
            this.LblKitapid.AutoSize = true;
            this.LblKitapid.Location = new System.Drawing.Point(12, 33);
            this.LblKitapid.Name = "LblKitapid";
            this.LblKitapid.Size = new System.Drawing.Size(59, 18);
            this.LblKitapid.TabIndex = 1;
            this.LblKitapid.Text = "Kitapid";
            // 
            // TxtKitapid
            // 
            this.TxtKitapid.Enabled = false;
            this.TxtKitapid.Location = new System.Drawing.Point(105, 25);
            this.TxtKitapid.Name = "TxtKitapid";
            this.TxtKitapid.Size = new System.Drawing.Size(121, 26);
            this.TxtKitapid.TabIndex = 2;
            // 
            // TxtKitapAd
            // 
            this.TxtKitapAd.Location = new System.Drawing.Point(105, 80);
            this.TxtKitapAd.Name = "TxtKitapAd";
            this.TxtKitapAd.Size = new System.Drawing.Size(121, 26);
            this.TxtKitapAd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Ad";
            // 
            // TxtYazar
            // 
            this.TxtYazar.Location = new System.Drawing.Point(105, 139);
            this.TxtYazar.Name = "TxtYazar";
            this.TxtYazar.Size = new System.Drawing.Size(121, 26);
            this.TxtYazar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yazar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tür";
            // 
            // CmbTur
            // 
            this.CmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTur.FormattingEnabled = true;
            this.CmbTur.Items.AddRange(new object[] {
            "Roman",
            "Şiir",
            "Hikaye",
            "Deneme",
            "Tiyatro"});
            this.CmbTur.Location = new System.Drawing.Point(105, 186);
            this.CmbTur.Name = "CmbTur";
            this.CmbTur.Size = new System.Drawing.Size(121, 26);
            this.CmbTur.TabIndex = 8;
            // 
            // Radiobttnikinciel
            // 
            this.Radiobttnikinciel.AutoSize = true;
            this.Radiobttnikinciel.Location = new System.Drawing.Point(172, 256);
            this.Radiobttnikinciel.Name = "Radiobttnikinciel";
            this.Radiobttnikinciel.Size = new System.Drawing.Size(84, 22);
            this.Radiobttnikinciel.TabIndex = 9;
            this.Radiobttnikinciel.TabStop = true;
            this.Radiobttnikinciel.Text = "İkinci El";
            this.Radiobttnikinciel.UseVisualStyleBackColor = true;
            this.Radiobttnikinciel.CheckedChanged += new System.EventHandler(this.Radiobttnikinciel_CheckedChanged);
            // 
            // Radiobtnsifir
            // 
            this.Radiobtnsifir.AutoSize = true;
            this.Radiobtnsifir.Location = new System.Drawing.Point(85, 259);
            this.Radiobtnsifir.Name = "Radiobtnsifir";
            this.Radiobtnsifir.Size = new System.Drawing.Size(81, 22);
            this.Radiobtnsifir.TabIndex = 10;
            this.Radiobtnsifir.TabStop = true;
            this.Radiobtnsifir.Text = "Pakette";
            this.Radiobtnsifir.UseVisualStyleBackColor = true;
            this.Radiobtnsifir.CheckedChanged += new System.EventHandler(this.Radiobtnsifir_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Durum";
            // 
            // TxtSayfa
            // 
            this.TxtSayfa.Location = new System.Drawing.Point(105, 227);
            this.TxtSayfa.Name = "TxtSayfa";
            this.TxtSayfa.Size = new System.Drawing.Size(121, 26);
            this.TxtSayfa.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sayfa";
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(280, 25);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(230, 42);
            this.BtnListele.TabIndex = 14;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(280, 88);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(230, 42);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(280, 147);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(230, 42);
            this.BtnSil.TabIndex = 16;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(280, 211);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(230, 42);
            this.BtnGuncelle.TabIndex = 17;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // TxtKitapbul
            // 
            this.TxtKitapbul.Location = new System.Drawing.Point(34, 46);
            this.TxtKitapbul.Name = "TxtKitapbul";
            this.TxtKitapbul.Size = new System.Drawing.Size(142, 26);
            this.TxtKitapbul.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Kitap Ad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBul);
            this.groupBox1.Controls.Add(this.TxtKitapbul);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(531, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 120);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ada Göre Kitap Ara";
            // 
            // BtnBul
            // 
            this.BtnBul.Location = new System.Drawing.Point(71, 78);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(75, 23);
            this.BtnBul.TabIndex = 20;
            this.BtnBul.Text = "ARA";
            this.BtnBul.UseVisualStyleBackColor = true;
            this.BtnBul.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnHarfAra);
            this.groupBox2.Controls.Add(this.TxtKitapHarfAra);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(531, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 113);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Harfe Göre Arama";
            // 
            // BtnHarfAra
            // 
            this.BtnHarfAra.Location = new System.Drawing.Point(71, 90);
            this.BtnHarfAra.Name = "BtnHarfAra";
            this.BtnHarfAra.Size = new System.Drawing.Size(75, 23);
            this.BtnHarfAra.TabIndex = 23;
            this.BtnHarfAra.Text = "ARA";
            this.BtnHarfAra.UseVisualStyleBackColor = true;
            this.BtnHarfAra.Click += new System.EventHandler(this.BtnHarfAra_Click);
            // 
            // TxtKitapHarfAra
            // 
            this.TxtKitapHarfAra.Location = new System.Drawing.Point(34, 58);
            this.TxtKitapHarfAra.Name = "TxtKitapHarfAra";
            this.TxtKitapHarfAra.Size = new System.Drawing.Size(142, 26);
            this.TxtKitapHarfAra.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Kitap Ad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(743, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.TxtSayfa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Radiobtnsifir);
            this.Controls.Add(this.Radiobttnikinciel);
            this.Controls.Add(this.CmbTur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtYazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtKitapAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKitapid);
            this.Controls.Add(this.LblKitapid);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kitaplık";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblKitapid;
        private System.Windows.Forms.TextBox TxtKitapid;
        private System.Windows.Forms.TextBox TxtKitapAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtYazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbTur;
        private System.Windows.Forms.RadioButton Radiobttnikinciel;
        private System.Windows.Forms.RadioButton Radiobtnsifir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSayfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.TextBox TxtKitapbul;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnHarfAra;
        private System.Windows.Forms.TextBox TxtKitapHarfAra;
        private System.Windows.Forms.Label label7;
    }
}

