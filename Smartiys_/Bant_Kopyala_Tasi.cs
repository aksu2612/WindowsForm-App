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
    public partial class Bant_Kopyala_Tasi : Form
    {
        public Bant_Kopyala_Tasi()
        {
            InitializeComponent();
        }
        public String Bantadi;
        public String Siparisadi;
        public int sipid;
        SmartDataBase db = new SmartDataBase();
        private void Bant_Kopyala_Tasi_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("HH:mm ");

            var a = db.BantTanim.ToList();
            for (int i = 0; i < a.Count(); i++)
            {
                comboBox1.Items.Add(a[i].BantAdi);
                comboBox3.Items.Add(a[i].BantAdi);
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Siparisadi = Convert.ToString(comboBox2.SelectedItem);
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {     
            comboBox2.Items.Clear();
            Bantadi=Convert.ToString(comboBox1.SelectedItem);
            var sipsorgu=db.BantTanim.Where(w=> w.BantAdi == Bantadi).ToList();
            int bantid=sipsorgu[0].ID;
            var a = db.Siparis.Where(w=>w.BantID==bantid).ToList();
            for (int i = 0; i < a.Count(); i++)
            {
                comboBox2.Items.Add(a[i].Ad);
            }

    
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Siparis ss=new Siparis();
            var s=comboBox3.SelectedItem;
            var bantid = db.BantTanim.Where(w => w.BantAdi == s).ToList();
            var sip = db.Siparis.Where(w => w.Ad == Siparisadi).ToList();
            sip[0].BantID = bantid[0].ID;
            ss = sip[0];
            
            db.Entry(ss).State = EntityState.Modified;
            db.SaveChanges();
       

        }
    }
}
