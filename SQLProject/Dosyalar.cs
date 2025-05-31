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
    public partial class Dosyalar : Form
    {
        public Dosyalar()
        {
            InitializeComponent();
        }

        private void dosyalarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dosyalarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.temporaryDataSet);

        }

        private void Dosyalar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'temporaryDataSet.dosyalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dosyalarTableAdapter.Fill(this.temporaryDataSet.dosyalar);

        }

        private void search(object sender, EventArgs e)
        {
            string query = this.toolStripTextBox1.Text;
            if (string.IsNullOrWhiteSpace(query))
                dosyalarBindingSource.RemoveFilter();
            else
                dosyalarBindingSource.Filter = $"id LIKE '%{query}%'";
        }

        private void goHome(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Close();
        }
    }
}
