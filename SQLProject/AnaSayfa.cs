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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void openAvukatlar(object sender, EventArgs e)
        {
            Avukatlar avukatlar = new Avukatlar();
            avukatlar.Show();
            this.Hide();
        }

        private void openSavcılar(object sender, EventArgs e)
        {
            Savcılar savcılar =new Savcılar();
            savcılar.Show();
            this.Hide();
        }

        private void openHakimler(object sender, EventArgs e)
        {
            Hakimler hakimler =new Hakimler();
            hakimler.Show();
            this.Hide();
        }

        private void openSanıkAvukat(object sender, EventArgs e)
        {
            SanıkAvukat sanıkAvukat=new SanıkAvukat();
            sanıkAvukat.Show();
            this.Hide();    
        }

        private void openSanıklar(object sender, EventArgs e)
        {
            Sanıklar sanıklar = new Sanıklar();
            sanıklar.Show();
            this.Hide();
        }

        private void openMahkemeSalonlari(object sender, EventArgs e)
        {
            MahkemeSalonları mahkemeSalonları = new MahkemeSalonları();
            mahkemeSalonları.Show();
            this.Hide();
        }

        private void openDosyalar(object sender, EventArgs e)
        {
            Dosyalar dosyalar = new Dosyalar();
            dosyalar.Show();    
            this.Hide();
        }

        private void openDosyaAvukat(object sender, EventArgs e)
        {
            DosyaAvukat dosyaAvukat= new DosyaAvukat();
            dosyaAvukat.Show();
            this.Hide();
        }
    }
}
