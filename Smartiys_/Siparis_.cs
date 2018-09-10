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
    public partial class Siparis_ : Form
    {
        public Siparis_()
        {
            InitializeComponent();
        }
        SmartDataBase db = new SmartDataBase();
        private void Siparis__Load(object sender, EventArgs e)
        {
            var beden = db.Beden.ToList();
            var dep = db.Departman.ToList();
            var para = db.ParaBirimi.ToList();

            for (int i = 0; i < beden.Count; i++)
            {
                comboBox1.Items.Add(beden[i].Tur);
            }
            for (int i = 0; i < dep.Count; i++)
            {
                comboBox2.Items.Add(dep[i].Ad);
            }
            for (int i = 0; i < para.Count; i++)
            {
                comboBox3.Items.Add(para[i].Ad);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Siparis n = new Siparis();
                n.Ad = textBox1.Text;
                n.TeslimTarihi = dateTimePicker2.Value;
                n.VerilisTarihi = dateTimePicker1.Value;
                n.Adet = Convert.ToInt32(textBox2.Text);
                var aaa = db.Departman.Where(w => w.Ad == comboBox2.SelectedItem).FirstOrDefault();
                var bbb = db.Beden.Where(q => q.Tur == comboBox1.SelectedItem).FirstOrDefault();
                var ccc = db.ParaBirimi.Where(es => es.Ad == comboBox3.SelectedItem).FirstOrDefault();
                n.DepartmanID = aaa.ID;
                n.BedenID = bbb.ID;
                n.ParaBirimiID = ccc.ID;
                n.TeslimAdresi = textBox4.Text;
                n.TeslimFirma = textBox3.Text;
                db.Siparis.Add(n);
                db.SaveChanges();
                MessageBox.Show("Kayıt Başarılı", "", MessageBoxButtons.OK);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Başarısız","",MessageBoxButtons.OK);
                throw;
            }
        
           
        }
    }
}
