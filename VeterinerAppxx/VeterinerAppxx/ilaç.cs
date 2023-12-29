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
    public partial class ilaç : Form
    {
        public ilaç()
        {
            InitializeComponent();
        }
        SqlConnection bağlan = new SqlConnection("Data Source=DESKTOP-0DOOTGM\\SQLEXPRESS01;Initial Catalog=veterinerson;Integrated Security=True");
        private void ilaç_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veterinersonDataSet.İlaçlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.İlaçlarTableAdapter.Fill(this.veterinersonDataSet.İlaçlar);

        }
        void tablogünceller(){
            this.İlaçlarTableAdapter.Fill(this.veterinersonDataSet.İlaçlar);

        }

        private void buttonekleilaç_Click(object sender, EventArgs e)
        {
            if (textBoxilaçad.Text == "" || textBoxilaçtür.Text == "" || textBoxmiktar.Text == "")
            {
                MessageBox.Show(" Boş Bırakmayınız");
                return;
            }
            else
            {
                bağlan.Open();
                SqlCommand verigönder = new SqlCommand("insert into İlaçlar(İlaçAdı,İlaçTürü,Miktar,BirimFiyat) values(@p1,@p2,@p3,@p4)", bağlan);
                verigönder.Parameters.AddWithValue("@p1", textBoxilaçad.Text);
                verigönder.Parameters.AddWithValue("@p2", textBoxilaçtür.Text);
                verigönder.Parameters.AddWithValue("@p3", textBoxmiktar.Text);
                verigönder.Parameters.AddWithValue("@p4", textBoxfiyat.Text);

                verigönder.ExecuteNonQuery();
                bağlan.Close();


                MessageBox.Show(textBoxilaçad.Text + " Başarılı Şekilde Eklendi");
                tablogünceller();

            }
        }

        void clearbox()
        {
            textBoxid.Text = "";
            textBoxilaçad.Text = "";
            textBoxilaçtür.Text = "";
            textBoxmiktar.Text = "";
            textBoxfiyat.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBoxid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBoxilaçad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxilaçtür.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBoxmiktar.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBoxfiyat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Delete Öğrenci
            bağlan.Open();
            SqlCommand delete = new SqlCommand("Delete from İlaçlar where İlaçID=@q2", bağlan);
            delete.Parameters.AddWithValue("@q2", textBoxid.Text);
            delete.ExecuteNonQuery();
            bağlan.Close();
            MessageBox.Show("Başarılı Şekildi Öğrenci Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Delete Öğrenci
            tablogünceller();
            clearbox();
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            bağlan.Open();
            SqlCommand hayvanup = new SqlCommand("Update İlaçlar set İlaçAdı=@a2,İlaçTürü=@q2,Miktar=@q4,BirimFiyat=@q5 where İlaçID=@fq3", bağlan);
            hayvanup.Parameters.AddWithValue("@a2", textBoxilaçad.Text);
            hayvanup.Parameters.AddWithValue("@q2", textBoxilaçtür.Text);
            hayvanup.Parameters.AddWithValue("@q4", textBoxmiktar.Text);
            hayvanup.Parameters.AddWithValue("@q5", textBoxfiyat.Text);
            hayvanup.Parameters.AddWithValue("@fq3", textBoxid.Text);
            hayvanup.ExecuteNonQuery();
            bağlan.Close();
            MessageBox.Show("Başarılı Şekildi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tablogünceller();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
