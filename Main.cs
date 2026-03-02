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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking BoookinInfo = new Booking();
            BoookinInfo.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Guest guest = new Guest();
            guest.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
           employee.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.Show();

        }
    }
}
