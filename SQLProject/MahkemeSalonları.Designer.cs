namespace SQLProject
{
    partial class MahkemeSalonları
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MahkemeSalonları));
            this.temporaryDataSet = new SQLProject.temporaryDataSet();
            this.mahkeme_salonlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahkeme_salonlariTableAdapter = new SQLProject.temporaryDataSetTableAdapters.mahkeme_salonlariTableAdapter();
            this.tableAdapterManager = new SQLProject.temporaryDataSetTableAdapters.TableAdapterManager();
            this.mahkeme_salonlariBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mahkeme_salonlariBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mahkeme_salonlariDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.temporaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahkeme_salonlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahkeme_salonlariBindingNavigator)).BeginInit();
            this.mahkeme_salonlariBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mahkeme_salonlariDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // temporaryDataSet
            // 
            this.temporaryDataSet.DataSetName = "temporaryDataSet";
            this.temporaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahkeme_salonlariBindingSource
            // 
            this.mahkeme_salonlariBindingSource.DataMember = "mahkeme_salonlari";
            this.mahkeme_salonlariBindingSource.DataSource = this.temporaryDataSet;
            // 
            // mahkeme_salonlariTableAdapter
            // 
            this.mahkeme_salonlariTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.avukatlarTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dosya_avukatTableAdapter = null;
            this.tableAdapterManager.dosyalarTableAdapter = null;
            this.tableAdapterManager.hakimlerTableAdapter = null;
            this.tableAdapterManager.mahkeme_salonlariTableAdapter = this.mahkeme_salonlariTableAdapter;
            this.tableAdapterManager.sanik_avukatTableAdapter = null;
            this.tableAdapterManager.saniklarTableAdapter = null;
            this.tableAdapterManager.savcilarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SQLProject.temporaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mahkeme_salonlariBindingNavigator
            // 
            this.mahkeme_salonlariBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mahkeme_salonlariBindingNavigator.BindingSource = this.mahkeme_salonlariBindingSource;
            this.mahkeme_salonlariBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mahkeme_salonlariBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mahkeme_salonlariBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mahkeme_salonlariBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mahkeme_salonlariBindingNavigatorSaveItem,
            this.toolStripTextBox1,
            this.toolStripButton1});
            this.mahkeme_salonlariBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mahkeme_salonlariBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mahkeme_salonlariBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mahkeme_salonlariBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mahkeme_salonlariBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mahkeme_salonlariBindingNavigator.Name = "mahkeme_salonlariBindingNavigator";
            this.mahkeme_salonlariBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mahkeme_salonlariBindingNavigator.Size = new System.Drawing.Size(942, 27);
            this.mahkeme_salonlariBindingNavigator.TabIndex = 0;
            this.mahkeme_salonlariBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Yeni ekle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Toplam öğe sayısı";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Sil";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Başa taşı";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Öne taşı";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Konum";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Geçerli konum";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Arkaya taşı";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Sona taşı";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // mahkeme_salonlariBindingNavigatorSaveItem
            // 
            this.mahkeme_salonlariBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mahkeme_salonlariBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mahkeme_salonlariBindingNavigatorSaveItem.Image")));
            this.mahkeme_salonlariBindingNavigatorSaveItem.Name = "mahkeme_salonlariBindingNavigatorSaveItem";
            this.mahkeme_salonlariBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.mahkeme_salonlariBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.mahkeme_salonlariBindingNavigatorSaveItem.Click += new System.EventHandler(this.mahkeme_salonlariBindingNavigatorSaveItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.search);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::SQLProject.Properties.Resources.icons8_home_40;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0, 1, 200, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.goHome);
            // 
            // mahkeme_salonlariDataGridView
            // 
            this.mahkeme_salonlariDataGridView.AutoGenerateColumns = false;
            this.mahkeme_salonlariDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mahkeme_salonlariDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mahkeme_salonlariDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.mahkeme_salonlariDataGridView.DataSource = this.mahkeme_salonlariBindingSource;
            this.mahkeme_salonlariDataGridView.Location = new System.Drawing.Point(0, 30);
            this.mahkeme_salonlariDataGridView.Name = "mahkeme_salonlariDataGridView";
            this.mahkeme_salonlariDataGridView.RowHeadersWidth = 50;
            this.mahkeme_salonlariDataGridView.RowTemplate.Height = 24;
            this.mahkeme_salonlariDataGridView.Size = new System.Drawing.Size(930, 440);
            this.mahkeme_salonlariDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Salon ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "salon_no";
            this.dataGridViewTextBoxColumn2.HeaderText = "Salon No";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kat_no";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kat No";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // MahkemeSalonları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.mahkeme_salonlariDataGridView);
            this.Controls.Add(this.mahkeme_salonlariBindingNavigator);
            this.Name = "MahkemeSalonları";
            this.Text = "Mahkeme Salonları";
            this.Load += new System.EventHandler(this.MahkemeSalonları_Load);
            ((System.ComponentModel.ISupportInitialize)(this.temporaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahkeme_salonlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahkeme_salonlariBindingNavigator)).EndInit();
            this.mahkeme_salonlariBindingNavigator.ResumeLayout(false);
            this.mahkeme_salonlariBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mahkeme_salonlariDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private temporaryDataSet temporaryDataSet;
        private System.Windows.Forms.BindingSource mahkeme_salonlariBindingSource;
        private temporaryDataSetTableAdapters.mahkeme_salonlariTableAdapter mahkeme_salonlariTableAdapter;
        private temporaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mahkeme_salonlariBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton mahkeme_salonlariBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView mahkeme_salonlariDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}