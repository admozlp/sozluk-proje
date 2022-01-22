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

namespace Ceviri_Projesi
{
    public partial class frmhayvanekle : Form
    {
        public frmhayvanekle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_diller (türkçe,ingilizce,almanca,fransızca) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtturkce.Text);
            komut.Parameters.AddWithValue("@p2", txtingilizce.Text);
            komut.Parameters.AddWithValue("@p3", txtalmanca.Text);
            komut.Parameters.AddWithValue("@p4", txtfransızca.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Yapıldı", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            txtalmanca.Text = "";
            txtfransızca.Text = "";
            txtingilizce.Text = "";
            txtturkce.Text = "";

        }
    }
}
