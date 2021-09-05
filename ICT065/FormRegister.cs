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
    public partial class Form_Register : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HG7JSRT;Initial Catalog=ICT065;Integrated Security=True");

        public Form_Register()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text == "" && textBoxAddress.Text == "" && textBoxAddress.Text == "" && textBoxNIC.Text == "")
            {
                MessageBox.Show("Invalid Input! \n" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO user_table values ('" + textBoxName.Text + "','" + textBoxAddress.Text + "','" + textBoxNIC.Text + "', '" + comboBoxGender.Text + "')", con);
                command.ExecuteNonQuery();
                MessageBox.Show(textBoxNIC.Text + " is Your Password \n", "Account Has Been Successfully Created ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                FormLogin frm = new FormLogin();
                frm.Show(this);
                this.Hide();
            }
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show(this);
            this.Hide();
        }

        private void Form_Register_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
