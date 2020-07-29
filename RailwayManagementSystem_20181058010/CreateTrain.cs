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
    public partial class CreateTrain : UserControl
    {
        public CreateTrain()
        {
            InitializeComponent();
            show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection abc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\RailwayManagementSystem2\RailwayManagementSystem2\Railway.mdf;Integrated Security=True");
            abc.Open();
            SqlCommand query = new SqlCommand("Insert into Train(trainid,trainname,routeid) values('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "')", abc);

            int i = query.ExecuteNonQuery();

            if (i != 0)
            {
                MessageBox.Show("Done");
            }

            show();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }


        public void show()
        {
            SqlConnection abc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\RailwayManagementSystem2\RailwayManagementSystem2\Railway.mdf;Integrated Security=True");
            abc.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Train", abc);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Parent.Controls["bogiedetails1"].BringToFront();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            String s = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            String s = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\RailwayManagementSystem2\RailwayManagementSystem2\Railway.mdf;Integrated Security=True");
            sql.Open();
            SqlCommand abc = new SqlCommand("update Train set trainId = '" + textBox1.Text + "', trainname = '" + textBox2.Text + "', routeid = '" + textBox3.Text + "' where trainId = '" + s + "' ", sql);
            int J = abc.ExecuteNonQuery();

            if (J != 0)
            {
                MessageBox.Show("Done");
            }
            show();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();



        }

        private void button4_Click(object sender, EventArgs e)
        {


            String s = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\RailwayManagementSystem2\RailwayManagementSystem2\Railway.mdf;Integrated Security=True");
            sql.Open();
            SqlCommand abc = new SqlCommand("Delete  from Train where trainId ='" + textBox1.Text + "' ", sql);
            int J = abc.ExecuteNonQuery();

            if (J != 0)
            {
                MessageBox.Show("Done");
            }
            show();
            textBox1.Clear();
            textBox2.Clear();
                textBox3.Clear();










        }
    }
}
