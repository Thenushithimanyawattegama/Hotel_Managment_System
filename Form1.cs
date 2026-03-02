using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_managment_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             panel2.Width += 6;

            if (panel2.Width >= 525)
            {
                timer1.Stop();

                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }

        }
    }
}
