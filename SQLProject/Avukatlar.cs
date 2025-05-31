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
    public partial class Avukatlar : Form
    {
        public Avukatlar()
        {
            InitializeComponent();
        }

        private void avukatlarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avukatlarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.temporaryDataSet);

        }

        private void Avukatlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'temporaryDataSet.avukatlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.avukatlarTableAdapter.Fill(this.temporaryDataSet.avukatlar);

        }

        private void search(object sender, EventArgs e)
        {
            string query=this.toolStripTextBox1.Text;
            if (string.IsNullOrWhiteSpace(query))
                avukatlarBindingSource.RemoveFilter();
            else
                avukatlarBindingSource.Filter = $"ad LIKE '%{query}%'";
        }

        private void goHome(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Close();
        }
    }
}
