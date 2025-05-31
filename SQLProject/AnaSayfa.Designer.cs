namespace SQLProject
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.temporaryDataSet = new SQLProject.temporaryDataSet();
            this.avukatlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avukatlarTableAdapter = new SQLProject.temporaryDataSetTableAdapters.avukatlarTableAdapter();
            this.tableAdapterManager = new SQLProject.temporaryDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.temporaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avukatlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // temporaryDataSet
            // 
            this.temporaryDataSet.DataSetName = "temporaryDataSet";
            this.temporaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avukatlarBindingSource
            // 
            this.avukatlarBindingSource.DataMember = "avukatlar";
            this.avukatlarBindingSource.DataSource = this.temporaryDataSet;
            // 
            // avukatlarTableAdapter
            // 
            this.avukatlarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.avukatlarTableAdapter = this.avukatlarTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dosya_avukatTableAdapter = null;
            this.tableAdapterManager.dosyalarTableAdapter = null;
            this.tableAdapterManager.hakimlerTableAdapter = null;
            this.tableAdapterManager.mahkeme_salonlariTableAdapter = null;
            this.tableAdapterManager.sanik_avukatTableAdapter = null;
            this.tableAdapterManager.saniklarTableAdapter = null;
            this.tableAdapterManager.savcilarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SQLProject.temporaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 160);
            this.button1.TabIndex = 0;
            this.button1.Text = "Avukatlar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.openAvukatlar);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 160);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mahkeme Salonları";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.openMahkemeSalonlari);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 160);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sanıklar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.openSanıklar);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(256, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 160);
            this.button4.TabIndex = 3;
            this.button4.Text = "Dosyalar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.openDosyalar);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(462, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 160);
            this.button5.TabIndex = 4;
            this.button5.Text = "Hakimler";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.openHakimler);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(462, 238);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 160);
            this.button6.TabIndex = 5;
            this.button6.Text = "Savcılar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.openSavcılar);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(710, 238);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 160);
            this.button7.TabIndex = 6;
            this.button7.Text = "Dosya && Avukat";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.openDosyaAvukat);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(710, 40);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 160);
            this.button8.TabIndex = 7;
            this.button8.Text = "Sanık && Avukat";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.openSanıkAvukat);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tablolar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(707, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bağlantılar";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AnaSayfa";
            this.Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.temporaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avukatlarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private temporaryDataSet temporaryDataSet;
        private System.Windows.Forms.BindingSource avukatlarBindingSource;
        private temporaryDataSetTableAdapters.avukatlarTableAdapter avukatlarTableAdapter;
        private temporaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

