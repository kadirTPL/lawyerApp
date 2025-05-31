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
    public partial class SanıkAvukat : Form
    {
        public SanıkAvukat()
        {
            InitializeComponent();
        }

        private void sanik_avukatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sanik_avukatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.temporaryDataSet);

        }

        private void SanıkAvukat_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'temporaryDataSet.sanik_avukat' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sanik_avukatTableAdapter.Fill(this.temporaryDataSet.sanik_avukat);

        }

        private void search(object sender, EventArgs e)
        {
            string query = this.toolStripTextBox1.Text;
            if (string.IsNullOrWhiteSpace(query))
                sanik_avukatBindingSource.RemoveFilter();
            else
                sanik_avukatBindingSource.Filter = $"sanik_id LIKE '%{query}%'";
        }

        private void goHome(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Close();
        }
    }
}
