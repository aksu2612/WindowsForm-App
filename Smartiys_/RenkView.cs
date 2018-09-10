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
    public partial class RenkView : Form
    {
        SmartDataBase db = new SmartDataBase();

        public RenkView()
        {
            InitializeComponent();
        }

        private void RenkView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartDataSet.Renk' table. You can move, or remove it, as needed.
            this.renkTableAdapter.Fill(this.smartDataSet.Renk);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Renk r = new Renk();
            r.Ad = textBox1.Text;
            db.Renk.Add(r);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı !");
            this.Refresh();
        }
    }
}
