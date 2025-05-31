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
    public partial class Savcılar : Form
    {
        public Savcılar()
        {
            InitializeComponent();
        }

        private void savcilarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.savcilarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.temporaryDataSet);

        }

        private void Savcılar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'temporaryDataSet.savcilar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.savcilarTableAdapter.Fill(this.temporaryDataSet.savcilar);

        }

        private void search(object sender, EventArgs e)
        {
            string query=this.toolStripTextBox1.Text;
            if (string.IsNullOrWhiteSpace(query))
                savcilarBindingSource.RemoveFilter();
            else
                savcilarBindingSource.Filter = $"ad LIKE '%{query}%'";
        }

        private void goHome(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Close();
        }
    }
}
