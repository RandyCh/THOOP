using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace OOP
{
    public partial class FrmLogo : Form
    {
        public FrmLogo()
        {
            InitializeComponent();
            this.Paint += FrmLogo_Paint;
        }

        private void FrmLogo_Paint(object sender, PaintEventArgs e)
        {
            //GDI+///
            Graphics g = e.Graphics;
            //SolidBrush brush1 = new SolidBrush(Color.Blue);
            Point pt1 = new Point(0, 0);
            Point pt2 = new Point(0, this.ClientRectangle.Height);
          
            LinearGradientBrush brush2 = new LinearGradientBrush(pt1, pt2, Color.Blue, Color.Black);
            g.FillRectangle(brush2, this.ClientRectangle);
        }

        //protected string Paint2
        //{
        //    get
        //    {
        //        return this.label2.Text;
        //    }
        //    set
        //    {
        //        this.brush2 = value;
        //    }
        //}

        protected string Title
        {
            get
            {
                return this.label2.Text;
            }
            set
            {
                this.label2.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "kjkj";
            this.label1.Text = "2112";
            this.label1.ForeColor = Color.Red;

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmLogo_Load(object sender, EventArgs e)
        {

        }
    }
}
