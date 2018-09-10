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
    public partial class Band__Tanimlama : Form
    {
        public Band__Tanimlama()
        {
            InitializeComponent();
        }
        SmartDataBase db = new SmartDataBase();
        private void Band__Tanimlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartDataSet3.BantTanim' table. You can move, or remove it, as needed.
            this.bantTanimTableAdapter.Fill(this.smartDataSet3.BantTanim);
   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BantTanim bt = new BantTanim();
            bt.BantKodu = textBox1.Text;
            bt.BantAdi = textBox2.Text;
            bt.Durum = checkBox1.Checked;
            db.BantTanim.Add(bt);
            db.SaveChanges();
            this.Refresh();

            MessageBox.Show("Bant Kaydı Başarılı");
        }
    }
}
