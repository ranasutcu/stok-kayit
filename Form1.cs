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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data source = RANA\\SQLEXPRESS;Initial Catalog = kozmetik;integrated security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand Komut = new SqlCommand("Select * From KullaniciKayit where adi='" + textBox1.Text + "' and parola='" + textBox2.Text + "', baglanti  ");


            if (textBox1.Text == "rana" && textBox2.Text == "1234567")
            {

                Form2 git = new Form2();
                git.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya parola hatalı", "HATA");

            }

            baglanti.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand Komut = new SqlCommand("Select * From KullaniciKayit where adi='" + textBox1.Text + "' and parola='" + textBox2.Text + "', baglanti  ");


            textBox1.Clear();
            textBox2.Text = "";

            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
