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
    public partial class MahkemeSalonları : Form
    {
        public MahkemeSalonları()
        {
            InitializeComponent();
        }

        private void mahkeme_salonlariBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mahkeme_salonlariBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.temporaryDataSet);

        }

        private void MahkemeSalonları_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'temporaryDataSet.mahkeme_salonlari' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mahkeme_salonlariTableAdapter.Fill(this.temporaryDataSet.mahkeme_salonlari);

        }

        private void search(object sender, EventArgs e)
        {
            string query = this.toolStripTextBox1.Text;
            if (string.IsNullOrWhiteSpace(query))
                mahkeme_salonlariBindingSource.RemoveFilter();
            else
                mahkeme_salonlariBindingSource.Filter = $"salon_no LIKE '%{query}%'";
        }

        private void goHome(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Close();
        }
    }

}
