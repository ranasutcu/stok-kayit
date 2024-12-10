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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kozmetik
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data source = RANA\\SQLEXPRESS;Initial Catalog = kozmetik;integrated security=True");
       

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            Form2 git = new Form2();
            git.Show();
            this.Hide();
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            string t3 = textBox3.Text;
            string t4 = comboBox1.Text;
            string t5 = maskedTextBox1.Text;
            string t6= textBox4.Text;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Personel (Personelid,PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek) VALUES('" + t1 + "','" + t2 + "','" + t3 + "','" + t4 + "','" + t5 + "','" + t6 + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void listele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Personel", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string t1 = textBox1.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Personel WHERE Personelid=('" + t1 + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            string t3 = textBox3.Text;
            string t4 = comboBox1.Text;
            string t5 = maskedTextBox1.Text;
            string t6 = textBox4.Text;
            


            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Personel SET Personelid='" + t1 + "',PerAd='" + t2 + "',PerSoyad='" + t3 + "',PerSehir='" + t4 + "',PerMaas='" + t5 + "', PerMeslek='" + t6 + "' WHERE Personelid='" + t1 + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable table = new DataTable();
            SqlDataAdapter ara = new SqlDataAdapter("Select*from Personel where PerAd like '%" + textBox5.Text + "%' ", baglanti);
            ara.Fill(table);
            baglanti.Close();
            dataGridView1.DataSource = table;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
