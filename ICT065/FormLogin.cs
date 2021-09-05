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
    public partial class FormLogin : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HG7JSRT;Initial Catalog=ICT065;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            Form_Register frm = new Form_Register();
            frm.Show(this);
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxUserName.Text;
            string pass = textBoxPassword.Text;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM user_table where ID='" + textBoxUserName.Text + "' AND NIC='" + textBoxPassword.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("LOGIN Success \n", "SUCCUESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormItems frm = new FormItems();
                frm.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }

        private void labelAdmin_Click(object sender, EventArgs e)
        {
            FormAdminLogin frm = new FormAdminLogin();
            frm.Show(this);
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }
    }
}
