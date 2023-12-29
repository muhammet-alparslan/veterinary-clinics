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
    public partial class muayane : Form
    {
        public muayane()
        {
            InitializeComponent();
        }
        // Sql Bağlantı//
        SqlConnection bağlan = new SqlConnection("Data Source=DESKTOP-0DOOTGM\\SQLEXPRESS01;Initial Catalog=veterinerson;Integrated Security=True");
        // Sql Bağlantı//
        // Sql Bağlantı//
        SqlConnection bağlavn = new SqlConnection("Data Source=DESKTOP-0DOOTGM\\SQLEXPRESS01;Initial Catalog=veterinerson;Integrated Security=True");
        // Sql Bağlantı//

        void tablogüncelelr()
        {

            // TODO: Bu kod satırı 'veterinersonDataSet1.Muayene' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.muayeneTableAdapter.Fill(this.veterinersonDataSet1.Muayene);
        }
        private void muayane_Load(object sender, EventArgs e)
        {
            tablogüncelelr();

            bağlavn.Open();

            SqlCommand verimgönderm = new SqlCommand("Select VeterinerID,Adı from Veterinerler", bağlavn);
            SqlDataReader dxr = verimgönderm.ExecuteReader();
            while (dxr.Read())
            {
                comboBoxVeteriner.Items.Add(dxr[0].ToString());
                listBox2.Items.Add(("ID : " + dxr[0].ToString() + " Adı : " + dxr[1].ToString()));
                //   comboBox1.SelectedIndex(label4.Text);


            }
            bağlavn.Close();

            bağlan.Open();
            SqlCommand verimgönder = new SqlCommand("Select HayvanID,Adı from Hayvanlar", bağlan);
            SqlDataReader dr = verimgönder.ExecuteReader();
            while (dr.Read())
            {
                comboBoxHayvanId.Items.Add(dr[0].ToString());
                listBox1.Items.Add(("ID : " + dr[0].ToString() + " Adı : " + dr[1].ToString()));
                //   comboBox1.SelectedIndex(label4.Text);


            }
            bağlan.Close();

 

        }

        private void buttonekleMuayene_Click(object sender, EventArgs e)
        {

            if (textBoxteşhis.Text == "" || textBox2.Text == "" || comboBoxHayvanId.Text == "")
            {
                MessageBox.Show(" Boş Bırakmayınızi");
                return;
            }
            else
            {
                bağlan.Open();
                SqlCommand verigönder = new SqlCommand("insert into Muayene(HayvanID,VeterinerID,MuayeneTarihi,Teşhis,Tedavi) values(@p1,@p2,@p3,@p4,@p5)", bağlan);
                verigönder.Parameters.AddWithValue("@p1", comboBoxHayvanId.Text);
                verigönder.Parameters.AddWithValue("@p2", comboBoxVeteriner.Text);
                verigönder.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
                verigönder.Parameters.AddWithValue("@p4", textBoxteşhis.Text);
                verigönder.Parameters.AddWithValue("@p5", textBox2.Text);
                verigönder.ExecuteNonQuery();
                bağlan.Close();


                MessageBox.Show(textBoxteşhis.Text + " Başarılı Şekilde Eklendi");
                tablogüncelelr();

            }
        }

        private void buttonmuayenesil_Click(object sender, EventArgs e)
        {
            // Delete Öğrenci
            bağlan.Open();
            SqlCommand delete = new SqlCommand("Delete from Muayene where MuayeneID=@q2", bağlan);
            delete.Parameters.AddWithValue("@q2", textBoxid.Text);
            delete.ExecuteNonQuery();
            bağlan.Close();
            MessageBox.Show("Başarılı Şekildi Öğrenci Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Delete Öğrenci
            tablogüncelelr();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBoxid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            comboBoxHayvanId.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            comboBoxVeteriner.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBoxteşhis.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void buttonmuayenegüncelle_Click(object sender, EventArgs e)
        {
            bağlan.Open();
            SqlCommand muayaneupdate = new SqlCommand("Update Muayene set HayvanID=@a2,VeterinerID=@q2,MuayeneTarihi=@q4,Teşhis=@q5,Tedavi=@q6 where MuayeneID=@fq3", bağlan);
            muayaneupdate.Parameters.AddWithValue("@a2", comboBoxHayvanId.Text);
            muayaneupdate.Parameters.AddWithValue("@q2", comboBoxVeteriner.Text);
            muayaneupdate.Parameters.AddWithValue("@q4", dateTimePicker1.Value);
            muayaneupdate.Parameters.AddWithValue("@q5", textBoxteşhis.Text);
            muayaneupdate.Parameters.AddWithValue("@q6", textBox2.Text);
            muayaneupdate.Parameters.AddWithValue("@fq3", textBoxid.Text);
            muayaneupdate.ExecuteNonQuery();
            bağlan.Close();
            MessageBox.Show("Başarılı Şekildi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tablogüncelelr();
        }

        void clearbox()
        {
            textBoxid.Text = "";
            textBox2.Text = "";
            comboBoxHayvanId.Text = "";
            textBoxteşhis.Text = "";
            comboBoxVeteriner.Text = "";

        }
        private void buttontemizle_Click(object sender, EventArgs e)
        {
            clearbox();
        }
    }
}
