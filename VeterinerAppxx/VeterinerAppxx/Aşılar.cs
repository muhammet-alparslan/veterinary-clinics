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
    public partial class Aşılar : Form
    {
        public Aşılar()
        {
            InitializeComponent();
        }



        // Sql Bağlantı//
        SqlConnection bağlan = new SqlConnection("Data Source=DESKTOP-0DOOTGM\\SQLEXPRESS01;Initial Catalog=veterinerson;Integrated Security=True");
        // Sql Bağlantı//

        private void Aşılar_Load(object sender, EventArgs e)
        {
            bağlan.Open();
            SqlCommand verimgönder = new SqlCommand("Select HayvanID,Adı from Hayvanlar", bağlan);
            SqlDataReader dr = verimgönder.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
                listBox1.Items.Add(("ID : " + dr[0].ToString() + " Adı : " + dr[1].ToString()));
             //   comboBox1.SelectedIndex(label4.Text);


            }
            bağlan.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //try {
            //    bağlan.Open();
            //    SqlCommand verigönder = new SqlCommand("insert into Aşılar(AşıAdı,AşıTürü,AşılamaTarihi,HayvanID) values(@p1,@p2,@p3,@p4)", bağlan);
            //    verigönder.Parameters.AddWithValue("@p1", asıname.Text);
            //    verigönder.Parameters.AddWithValue("@p2", asııveriables.Text);
            //    verigönder.Parameters.AddWithValue("@p3", dateTimePickrası.Value);
            //    verigönder.Parameters.AddWithValue("@p4", comboBox1.Text);
            //    verigönder.ExecuteNonQuery();
            //    bağlan.Close();


            //    MessageBox.Show(asxxxxxxxxxxıname.Text + " Başarılı Şekilde Eklendi");
            //}xoş Bırakmayınızi");
            //    this.Hide();xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

            //}x


            if(asıname.Text == "" || asııveriables.Text ==""|| comboBox1.Text == "")
            {
                 MessageBox.Show(asıname.Text + " Boş Bırakmayınızi");
                 return;
            }
            else
            {
                bağlan.Open();
                SqlCommand verigönder = new SqlCommand("insert into Aşılar(AşıAdı,AşıTürü,AşılamaTarihi,HayvanID) values(@p1,@p2,@p3,@p4)", bağlan);
                verigönder.Parameters.AddWithValue("@p1", asıname.Text);
                verigönder.Parameters.AddWithValue("@p2", asııveriables.Text);
                verigönder.Parameters.AddWithValue("@p3", dateTimePickrası.Value);
                verigönder.Parameters.AddWithValue("@p4", comboBox1.Text);
                verigönder.ExecuteNonQuery();
                bağlan.Close();


                MessageBox.Show(asıname.Text + " Başarılı Şekilde Eklendi");

            }


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
