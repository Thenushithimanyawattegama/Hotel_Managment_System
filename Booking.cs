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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagmentSystem;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Booking values(@id,@name,@roomno,@roomtype,@hotelcode)", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox2.Text);
            cnn.Parameters.AddWithValue("@RoomNo", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@RoomType", comboBox1.Text);
            cnn.Parameters.AddWithValue("@HotelCode", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagmentSystem;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Booking values(@id,@name,@roomno,@roomtype,@hotelcode)", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox2.Text);
            cnn.Parameters.AddWithValue("@RoomNo", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@RoomType", comboBox1.Text);
            cnn.Parameters.AddWithValue("@HotelCode", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagmentSystem;Integrated Security=True;Encrypt=FalseSystem");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Booking values(@id,@name,@roomno,@roomtype,@hotelcode)", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox2.Text);
            cnn.Parameters.AddWithValue("@RoomNo", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@RoomType", comboBox1.Text);
            cnn.Parameters.AddWithValue("@HotelCode", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagmentSystem;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Booking values(@id,@name,@roomno,@roomtype,@hotelcode)", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox2.Text);
            cnn.Parameters.AddWithValue("@RoomNo", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@RoomType", comboBox1.Text);
            cnn.Parameters.AddWithValue("@HotelCode", textBox5.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            
        }

        private void Booking_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagmentSystemDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.hotelManagmentSystemDataSet.Booking);

        }
    }
}
