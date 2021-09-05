using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT065
{
    public partial class FormAddItems : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HG7JSRT;Initial Catalog=ICT065;Integrated Security=True");
        public FormAddItems()
        {
            InitializeComponent();
        }

        private void buttonSelectImage1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void buttonSelectImage2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void buttonAddItems_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO itmes_table VALUES ('" + textBoxID.Text + "','" + textBoxItem.Text + "','" + textBoxDesc.Text + "', '" + pictureBox1.Text + "', '" + pictureBox2.Text + "', '" + textBoxBiddingPrice.Text + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted");
            con.Close();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            FormItems frm = new FormItems();
            frm.Show(this);
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show(this);
            this.Hide();
        }

        private void card_Click(object sender, EventArgs e)
        {
            FormItems frm = new FormItems();
            frm.Show(this);
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("UPDATE itmes_table SET ID = '" + textBoxID.Text + "',Item = '" + textBoxItem.Text + "', Description = '"+textBoxDesc.Text+ "', Image1 = '" + pictureBox1.Text + "', Image2 ='" + pictureBox2.Text + "',Price = '"+ textBoxBiddingPrice.Text + "' where ID = '" + int.Parse(textBoxID.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated succssfully");
        }

        private void update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("UPDATE itmes_table SET ID = '" + textBoxID.Text + "',Item = '" + textBoxItem.Text + "', Description = '" + textBoxDesc.Text + "', Image1 = '" + pictureBox1.Text + "', Image2 ='" + pictureBox2.Text + "',Price = '" + textBoxBiddingPrice.Text + "' where ID = '" + int.Parse(textBoxID.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated succssfully");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "")
            {
                if (MessageBox.Show("Do you want to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete itmes_table where ID = '" + int.Parse(textBoxID.Text) + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Deleted succssfully");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID selected");

            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO itmes_table VALUES ('" + textBoxID.Text + "','" + textBoxItem.Text + "','" + textBoxDesc.Text + "', '" + pictureBox1.Text + "', '" + pictureBox2.Text + "', '" + textBoxBiddingPrice.Text + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted");
            con.Close();
        }
    }
}
