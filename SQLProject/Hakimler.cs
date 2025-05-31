using System;
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
    public partial class Hakimler : Form
    {
        public Hakimler()
        {
            InitializeComponent();
        }

        private void hakimlerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hakimlerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.temporaryDataSet);

        }

        private void Hakimler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'temporaryDataSet.hakimler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hakimlerTableAdapter.Fill(this.temporaryDataSet.hakimler);

        }

        private void search(object sender, EventArgs e)
        {
            string query = this.toolStripTextBox1.Text;
            if (string.IsNullOrWhiteSpace(query))
                hakimlerBindingSource.RemoveFilter();
            else
                hakimlerBindingSource.Filter = $"ad LIKE '%{query}%'";
        }

        private void goHome(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Close();
        }
    }
}
