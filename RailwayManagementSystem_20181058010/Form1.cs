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

namespace RailwayManagementSystem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            home1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            createTrain1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }

        private void createTrain1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createStation1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            createRoute1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            schedule1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seatTypes1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ticket1.BringToFront();
        }
    }
}
