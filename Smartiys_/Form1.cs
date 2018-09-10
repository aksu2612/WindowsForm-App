using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Smartiys_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SmartDataBase db = new SmartDataBase();
   
        private void tanımlarToolStripMenuItem_Click_1(object sender, EventArgs e)
        { 
        }
        private void siparişİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Siparis_ n = new Siparis_();
            n.Show();
        }

        private void modelTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelPage mo = new ModelPage();
            mo.Show();
        }

        private void bantTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Band__Tanimlama bn = new Band__Tanimlama();
            bn.Show();
        }

        private void siparişBantAtamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Siparis_Bant_Atama sp = new Siparis_Bant_Atama();
            sp.Show();
        }

        private void siparişBantKopyalaTaşıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bant_Kopyala_Tasi bt = new Bant_Kopyala_Tasi();
            bt.Show();
        }

        private void çalışanHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calisan_Hareketleri cl = new Calisan_Hareketleri();
            cl.Show();
        }

        private void bedenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BedenView n = new BedenView();
            n.Show();
        }

       

        private void makinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            Makina_Tanimlama mkn = new Makina_Tanimlama();
            mkn.Show();
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenkView re = new RenkView();
            re.Show();
        }

        private void görevlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gorevler g = new Gorevler();
            g.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void bantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Band__Tanimlama bn = new Band__Tanimlama();
            bn.Show();
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelLiist n = new PersonelLiist();
            n.Show();
        }

        private void makinaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakinaList n = new MakinaList();
            n.Show();
            
        }

      
    }
}
