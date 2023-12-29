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
namespace VeterinerAppxx
{
    public partial class HAYVAN : Form
    {
        public HAYVAN()
        {
            InitializeComponent();
        }
        // Sql Bağlantı//
        SqlConnection bağlan = new SqlConnection("Data Source=DESKTOP-0DOOTGM\\SQLEXPRESS01;Initial Catalog=veterinerson;Integrated Security=True");
        // Sql Bağlantı//

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttoneklehayvan_Click(object sender, EventArgs e)
        {

            if (textBoxhayvanismi.Text == "" || textBoxhayvantür.Text == "" || textBoxhayvanırkı.Text == "")
            {
                MessageBox.Show(" Boş Bırakmayınız");
                return;
            }
            else
            {
                bağlan.Open();
                SqlCommand verigönder = new SqlCommand("insert into Hayvanlar(Adı,Türü,Irkı,Cinsiyeti,DoğumTarihi) values(@p1,@p2,@p3,@p4,@p5)", bağlan);
                verigönder.Parameters.AddWithValue("@p1", textBoxhayvanismi.Text);
                verigönder.Parameters.AddWithValue("@p2", textBoxhayvantür.Text);
                verigönder.Parameters.AddWithValue("@p3", textBoxhayvanırkı.Text);
                verigönder.Parameters.AddWithValue("@p4", comboBoxhayvansiniyet.Text);
                verigönder.Parameters.AddWithValue("@p5", dateTimePickerhayvantime.Value);
                verigönder.ExecuteNonQuery();
                bağlan.Close();


                MessageBox.Show(textBoxhayvanismi.Text + " Başarılı Şekilde Eklendi");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Delete Öğrenci
            bağlan.Open();
            SqlCommand delete = new SqlCommand("Delete from Hayvanlar where HayvanID=@q2", bağlan);
            delete.Parameters.AddWithValue("@q2", textBox1.Text);
            delete.ExecuteNonQuery();
            bağlan.Close();
            MessageBox.Show("Başarılı Şekildi Öğrenci Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Delete Öğrenci
            updatetable();
            clearbox();

        
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        void updatetable()
        {
            this.hayvanlarTableAdapter.Fill(this.veterinersonDataSetx.Hayvanlar);
        }

        void clearbox()
        {
            textBox1.Text = "";
            textBoxhayvanismi.Text = "";
            textBoxhayvantür.Text = "";
            textBoxhayvanırkı.Text = "";
            comboBoxhayvansiniyet.Text = "";
        }

        private void HAYVAN_Load(object sender, EventArgs e)
        {

            updatetable();
    
        }


   
        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBoxhayvanismi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxhayvantür.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBoxhayvanırkı.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            comboBoxhayvansiniyet.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            //     dateTimePickerhayvantime.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarılı Şekildi  Temizlendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            clearbox();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            bağlan.Open();
            SqlCommand hayvanup = new SqlCommand("Update Hayvanlar set Adı=@a2,Türü=@q2,Irkı=@q4,Cinsiyeti=@q5,DoğumTarihi=@q6 where HayvanID=@fq3", bağlan);
            hayvanup.Parameters.AddWithValue("@a2", textBoxhayvanismi.Text);
            hayvanup.Parameters.AddWithValue("@q2", textBoxhayvantür.Text);
            hayvanup.Parameters.AddWithValue("@q4", textBoxhayvanırkı.Text);
            hayvanup.Parameters.AddWithValue("@q5", comboBoxhayvansiniyet.Text);
            hayvanup.Parameters.AddWithValue("@q6", dateTimePickerhayvantime.Value);
            hayvanup.Parameters.AddWithValue("@fq3", textBox1.Text);
            hayvanup.ExecuteNonQuery();
            bağlan.Close();
            MessageBox.Show("Başarılı Şekildi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updatetable();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
