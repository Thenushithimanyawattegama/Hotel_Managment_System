using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_managment_system
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagment;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Employee values(@id,@name,@age)", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox2.Text);
            cnn.Parameters.AddWithValue("@Age", textBox3.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagment;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Employee values(@id,@name,@age)", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox2.Text);
            cnn.Parameters.AddWithValue("@Age", textBox3.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagment;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Employee values(@id,@name,@age)", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox2.Text);
            cnn.Parameters.AddWithValue("@Age", textBox3.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagment;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Employee values(@id,@name,@age)", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox2.Text);
            cnn.Parameters.AddWithValue("@Age", textBox3.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagmentDataSet2.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hotelManagmentDataSet2.Employee);

        }
    }
}
