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

namespace Hotel_managment_system
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagmentSystem;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Room values(@id,@roomno,@roomtype)", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@RoomNo", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@RoomType", comboBox1.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagmentSystem;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Room values(@id,@roomno,@roomtype)", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@RoomNo", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@RoomType", comboBox1.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagmentSystem;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Room values(@id,@roomno,@roomtype)", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@RoomNo", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@RoomType", comboBox1.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagmentSystem;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Room values(@id,@roomno,@roomtype)", con);
            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@RoomNo", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@RoomType", comboBox1.Text);
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagmentDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hotelManagmentDataSet.Room);

        }
    }
}
