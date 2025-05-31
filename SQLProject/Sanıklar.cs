using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLProject
{
    public partial class Sanıklar : Form
    {
        public Sanıklar()
        {
            InitializeComponent();
        }

        private void saniklarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.saniklarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.temporaryDataSet);

        }

        private void Sanıklar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'temporaryDataSet.saniklar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.saniklarTableAdapter.Fill(this.temporaryDataSet.saniklar);

        }

        private void search(object sender, EventArgs e)
        {
            string query=this.toolStripTextBox1.Text;
            if (string.IsNullOrWhiteSpace(query))
                saniklarBindingSource.RemoveFilter();
            else
                saniklarBindingSource.Filter = $"ad LIKE '%{query}%'";
        }

        private void goHome(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Close();
        }
    }
}
