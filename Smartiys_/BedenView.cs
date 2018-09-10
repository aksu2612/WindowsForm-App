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
    
    public partial class BedenView : Form
    {
        SmartDataBase db = new SmartDataBase();
        public BedenView()
        {
            InitializeComponent();
        }

        private void BedenView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartDataSet1.Beden' table. You can move, or remove it, as needed.
            this.bedenTableAdapter.Fill(this.smartDataSet1.Beden);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Beden b = new Beden();
            b.Tur = textBox1.Text;
            db.Beden.Add(b);
            db.SaveChanges();
            this.Refresh();
            MessageBox.Show("Kayıt Basarılı !");
          
        }
    }
}
