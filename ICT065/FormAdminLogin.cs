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
    public partial class FormAdminLogin : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HG7JSRT;Initial Catalog=ICT065;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public FormAdminLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxUserName.Text;
            string pass = textBoxPassword.Text;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM admin_table where ID='" + textBoxUserName.Text + "' AND NIC='" + textBoxPassword.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("LOGIN Success \n", "SUCCUESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAddItems frm = new FormAddItems();
                frm.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
