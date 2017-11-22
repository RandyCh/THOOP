using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class FrmProduct : FrmLogo

    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Title = "1111";
        }
    }
}
