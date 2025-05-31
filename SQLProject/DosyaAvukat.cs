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
    public partial class DosyaAvukat : Form
    {
        public DosyaAvukat()
        {
            InitializeComponent();
        }

        private void dosya_avukatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dosya_avukatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.temporaryDataSet);

        }

        private void DosyaAvukat_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'temporaryDataSet.dosya_avukat' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dosya_avukatTableAdapter.Fill(this.temporaryDataSet.dosya_avukat);

        }

        private void search(object sender, EventArgs e)
        {
            string query=this.toolStripTextBox1.Text;
            if (string.IsNullOrWhiteSpace(query))
                dosya_avukatBindingSource.RemoveFilter();
            else
                dosya_avukatBindingSource.Filter = $"dosya_id LIKE '%{query}%'";
        }

        private void goHome(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Close();
        }
    }
}
