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

namespace kozmetik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data source = RANA\\SQLEXPRESS;Initial Catalog = kozmetik;integrated security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            Form3 git = new Form3();
            git.Show();
            this.Hide();
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            Form4 git = new Form4();
            git.Show();
            this.Hide();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            Form1 git = new Form1();
            git.Show();
            this.Hide();
            baglanti.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
    }
}
