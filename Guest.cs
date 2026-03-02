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
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagment;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Guest values(@id,@name,@age,@phone,@address)", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox3.Text);
            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox2.Text));
            cnn.Parameters.AddWithValue("@Phone", textBox4.Text);
            cnn.Parameters.AddWithValue("@Address", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagment;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Guest values(@id,@name,@age,@phone,@address)", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox3.Text);
            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox2.Text));
            cnn.Parameters.AddWithValue("@Phone", textBox4.Text);
            cnn.Parameters.AddWithValue("@Address", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagment;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Guest values(@id,@name,@age,@phone,@address)", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox3.Text);
            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox2.Text));
            cnn.Parameters.AddWithValue("@Phone", textBox4.Text);
            cnn.Parameters.AddWithValue("@Address", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagment;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Guest values(@id,@name,@age,@phone,@address)", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox3.Text);
            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox2.Text));
            cnn.Parameters.AddWithValue("@Phone", textBox4.Text);
            cnn.Parameters.AddWithValue("@Address", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagmentDataSet1.Guest' table. You can move, or remove it, as needed.
            this.guestTableAdapter.Fill(this.hotelManagmentDataSet1.Guest);

        }
    }
}
