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
    public partial class Calisan_Hareketleri : Form
    {
        int depID;
        SmartDataBase db = new SmartDataBase();
        public Calisan_Hareketleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calisan ca = new Calisan();
            double a = Convert.ToDouble(comboBox9.SelectedItem);
            var sorgu = db.Calisan.Where(w => w.TC == a).ToList();

            string sipid = Convert.ToString(comboBox3.SelectedItem);
            var sipsorgu = db.Siparis.Where(w => w.Ad == sipid).ToList();
            sorgu[0].SiparisID =sipsorgu[0].ID;
         
            string gorevadi = Convert.ToString(comboBox5.SelectedItem);
            var gorevsorgu = db.Gorev.Where(w => w.Ad == gorevadi).ToList();
            sorgu[0].GorevID = gorevsorgu[0].ID;

            string bant = Convert.ToString(comboBox4.SelectedItem);
            var bantsorgu = db.BantTanim.Where(w => w.BantAdi == bant).ToList();
            sorgu[0].BantID = bantsorgu[0].ID;
            sorgu[0].DepartmanID = 1;

            ca = sorgu[0];
            
            db.Entry(ca).State = EntityState.Modified;
            db.SaveChanges();
        }

        private void Calisan_Hareketleri_Load(object sender, EventArgs e)
        {
            var d = db.BantTanim.ToList();
            for (int i = 0; i < d.Count(); i++)
            {
                comboBox1.Items.Add(d[i].BantAdi);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string m = (string)comboBox1.SelectedItem;
            var sor = db.BantTanim.Where(w => w.BantAdi == m).ToList();
            int id = sor[0].ID;
            var a = db.Siparis.Where(w => w.BantID == id).ToList();
            for (int i = 0; i <a.Count(); i++)
            {
                comboBox2.Items.Add(a[i].Ad);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int de = comboBox2.SelectedIndex + 1;
            var depd = db.Calisan.Where(h => h.SiparisID == de).ToList();
            comboBox9.Items.Clear();
                for (int i = 0; i < depd.Count(); i++)
                {
                    comboBox9.Items.Add(depd[i].TC);
                }
       

        }
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            comboBox7.Enabled = true;
            comboBox8.Enabled = true;
 
            var bant = db.BantTanim.ToList();
            var sip = db.Siparis.ToList();
            var gorev = db.Gorev.ToList();
            var makina = db.Makina.ToList();
            var terminal = db.Terminal.ToList();
       
            for (int i = 0; i < bant.Count(); i++)
            {
                comboBox4.Items.Add(bant[i].BantAdi);
            }
            for (int i = 0; i < sip.Count(); i++)
            {
                comboBox3.Items.Add(sip[i].Ad);
            }
            for (int i = 0; i < makina.Count(); i++)
            {
                comboBox8.Items.Add(makina[i].Ad);
            }
            for (int i = 0; i < gorev.Count(); i++)
            {
                comboBox5.Items.Add(gorev[i].Ad);
            }
            for (int i = 0; i < terminal.Count(); i++)
            {
                comboBox7.Items.Add(terminal[i].Ad);
            }

        }

       
    }
}
