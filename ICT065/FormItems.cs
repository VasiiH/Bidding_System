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
using System.IO;

namespace ICT065
{
    public partial class FormItems : Form
    {
        public FormItems()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HG7JSRT;Initial Catalog=ICT065;Integrated Security=True");

        void BindData()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM itmes_table", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void FormItems_Load(object sender, EventArgs e)
        {
            
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Show(this);
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
