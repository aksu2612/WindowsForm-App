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
    public partial class Makina_Tanimlama : Form
    {
        public Makina_Tanimlama()
        {
            InitializeComponent();
        }

        SmartDataBase db = new SmartDataBase();

        private void Makina_Tanimlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartDataSet2.Makina' table. You can move, or remove it, as needed.
            this.makinaTableAdapter.Fill(this.smartDataSet2.Makina);
            var drm = db.Durum.ToList();
            var grb = db.Grup.ToList();
            for (int i = 0; i < drm.Count; i++)
            {
                comboBox2.Items.Add(drm[i].Ad);
            }

            for (int i = 0; i < grb.Count; i++)
            {
                comboBox1.Items.Add(grb[i].Ad);
            }


           

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
           
            Makina mk = new Makina();
            mk.Kod = textBox1.Text;
            mk.Ad = textBox2.Text;
            mk.Marka = textBox3.Text;
            mk.Ozellik = textBox4.Text;
            mk.Cins = textBox5.Text;
            mk.SeriNo = textBox6.Text;
            mk.Durum = checkBox1.Checked;
            mk.Grup = comboBox1.SelectedItem.ToString();
            db.Makina.Add(mk);
            db.SaveChanges();
            Makina_Tanimlama m = new Makina_Tanimlama();
            m.Refresh();


            MessageBox.Show("Makina Kaydı Başarılı");
        }
    }
}
