using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RailwayManagementSystem2
{
    public partial class CreateRoute : UserControl
    {
        public CreateRoute()
        {
            InitializeComponent();
            show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection abc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\RailwayManagementSystem2\RailwayManagementSystem2\Railway.mdf;Integrated Security=True");
            abc.Open();
            SqlCommand query = new SqlCommand("Insert into Route (routeid,routename) values('" + textBox1.Text + "', '" + textBox2.Text + "')", abc);

            int i = query.ExecuteNonQuery();

            if (i != 0)
            {
                MessageBox.Show("Done");
            }

            show();
            textBox1.Clear();
            textBox2.Clear();
        }
        public void show()
        {
            SqlConnection abc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\RailwayManagementSystem2\RailwayManagementSystem2\Railway.mdf;Integrated Security=True");
            abc.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Route", abc);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Parent.Controls["routedetails1"].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            String s = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\RailwayManagementSystem2\RailwayManagementSystem2\Railway.mdf;Integrated Security=True");
            sql.Open();
            SqlCommand abc = new SqlCommand("update Route set routeid = '" + textBox1.Text + "', routename = '" + textBox2.Text + "' where routeid = '" + s + "' ", sql);
            int J = abc.ExecuteNonQuery();

            if (J != 0)
            {
                MessageBox.Show("Done");
            }
            show();
            textBox1.Clear();
            textBox2.Clear();









        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {



            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            String s = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String s = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\RailwayManagementSystem2\RailwayManagementSystem2\Railway.mdf;Integrated Security=True");
            sql.Open();
            SqlCommand abc = new SqlCommand("Delete  from Route where routeid ='" + textBox1.Text + "' ", sql);
            int J = abc.ExecuteNonQuery();

            if (J != 0)
            {
                MessageBox.Show("Done");
            }
            show();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
