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
    public partial class Siparis_Bant_Atama : Form
    {
        public Siparis_Bant_Atama()
        {
            InitializeComponent();
        }
        SmartDataBase DB = new SmartDataBase();
   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Siparis_Bant_Atama_Load(object sender, EventArgs e)
        {
            var s = DB.Siparis.ToList();
            var d = DB.BantTanim.Where(r=>r.Durum==true).ToList();
            for (int i = 0; i <s.Count(); i++)
            {
                comboBox1.Items.Add(s[i].Ad);
            }
            for (int i = 0; i < d.Count(); i++)
            {
                comboBox2.Items.Add(d[i].BantAdi);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = comboBox1.SelectedIndex;
            k = k + 1;
            var a = DB.Siparis.Where(w => w.ID == k).ToList();
            int s = (int)a[0].DepartmanID;
            var dep = DB.Departman.Where(q => q.ID ==s).ToList();
            if (a.Count() == 1) { 
                label3.Text = a[0].Ad.ToString();
                label4.Text = a[0].Adet.ToString();
                label5.Text = a[0].TeslimTarihi.ToString();
                label6.Text = dep[0].Ad;
            }
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int l = comboBox2.SelectedIndex+1;
            int k = comboBox1.SelectedIndex + 1;
            var a = DB.Siparis.Where(w => w.ID == k).ToList();
            a[0].BantID = l;
            DB.SaveChanges();
            MessageBox.Show("Sipariş Ataması Başarılı.");

        }
       

    
    }
}
