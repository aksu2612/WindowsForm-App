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
    public partial class PersonelLiist : Form
    {
        public PersonelLiist()
        {
            InitializeComponent();
        }

        private void PersonelLiist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartDataSet4.Calisan' table. You can move, or remove it, as needed.
            this.calisanTableAdapter.Fill(this.smartDataSet4.Calisan);

        }

  
    }
}
