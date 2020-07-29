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
    public partial class bogiedetails : UserControl
    {
        public bogiedetails()
        {
            InitializeComponent();
            show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bogiedetails_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection abc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\RailwayManagementSystem2\RailwayManagementSystem2\Railway.mdf;Integrated Security=True");
            abc.Open();
            SqlCommand query = new SqlCommand("Insert into bogiedetails(trainid,bogietype,noofbogie,seattypeno) values('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", abc);

            int i = query.ExecuteNonQuery();

            if (i != 0)
            {
                MessageBox.Show("Done");
            }

            show();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();





        }


        public void show()
        {
            SqlConnection abc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\RailwayManagementSystem2\RailwayManagementSystem2\Railway.mdf;Integrated Security=True");
            abc.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from bogiedetails", abc);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();

            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
           


            String s = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            String s1 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            String s2 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            String s3 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
      





        }

        private void button3_Click(object sender, EventArgs e)
        {
            String s = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            String s1 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            String s2 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            String s3 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            


            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\RailwayManagementSystem2\RailwayManagementSystem2\Railway.mdf;Integrated Security=True");
            sql.Open();
            SqlCommand abc = new SqlCommand("update bogiedetails set trainid = '" + textBox1.Text + "', bogietype = '" + textBox2.Text + "', noofbogie = '" + textBox3.Text + "', seattypeno = '" + textBox4.Text + "' where trainid = '" + s + "' and bogietype = '" + s1 + "' and noofbogie = '" + s2 + "' and seattypeno= '" + s3 + "' ", sql);
            int J = abc.ExecuteNonQuery();

            if (J != 0)
            {
                MessageBox.Show("Done");
            }
            show();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();





        }

        private void button4_Click(object sender, EventArgs e)
        {

            String s = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            String s1 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            String s2 = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            String s3 = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\RailwayManagementSystem2\RailwayManagementSystem2\Railway.mdf;Integrated Security=True");
            sql.Open();
            SqlCommand abc = new SqlCommand("Delete  from bogiedetails where trainid = '" + s + "' and bogietype = '" + s1 + "' and noofbogie = '" + s2 + "' and seattypeno= '" + s3 + "' ", sql);
            int J = abc.ExecuteNonQuery();

            if (J != 0)
            {
                MessageBox.Show("Done");
            }
            show();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();



        }
    }
}
