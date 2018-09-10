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
    public partial class MakinaList : Form
    {
        public MakinaList()
        {
            InitializeComponent();
        }

        private void MakinaList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartDataSet5.Makina' table. You can move, or remove it, as needed.
            this.makinaTableAdapter.Fill(this.smartDataSet5.Makina);

        }
    }
}
