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
    public partial class frmceviri : Form
    {
        public frmceviri()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            frmhayvanekle fr = new frmhayvanekle();
            fr.Show();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (cmbcevirilecek.SelectedIndex==0)
            {
                SqlCommand komut = new SqlCommand("select Türkçe from tbl_diller", bgl.baglanti());             
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[0] + "\n");
                }
                bgl.baglanti().Close();
            }
           else if (cmbcevirilecek.SelectedIndex == 1)
            {
                SqlCommand komut = new SqlCommand("select İngilizce from tbl_diller", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[0] + "\n");
                }
                bgl.baglanti().Close();
            }
           else if (cmbcevirilecek.SelectedIndex == 2)
            {
                SqlCommand komut = new SqlCommand("select Almanca from tbl_diller", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[0] + "\n");
                }
                bgl.baglanti().Close();
            }
            if (cmbcevirilecek.SelectedIndex == 3)
            {
                SqlCommand komut = new SqlCommand("select Fransızca from tbl_diller", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[0] + "\n");
                }
                bgl.baglanti().Close();
            }
        }

        private void comboBox1_TextChanged_1(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (cmbcevirilen.SelectedIndex == 0)
            {
                SqlCommand komut = new SqlCommand("select Türkçe from tbl_diller", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    listBox2.Items.Add(dr[0] + "\n");
                }
                bgl.baglanti().Close();
            }
            else if (cmbcevirilen.SelectedIndex == 1)
            {
                SqlCommand komut = new SqlCommand("select İngilizce from tbl_diller", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    listBox2.Items.Add(dr[0] + "\n");
                }
                bgl.baglanti().Close();
            }
            else if (cmbcevirilen.SelectedIndex == 2)
            {
                SqlCommand komut = new SqlCommand("select Almanca from tbl_diller", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    listBox2.Items.Add(dr[0] + "\n");
                }
                bgl.baglanti().Close();
            }
            if (cmbcevirilen.SelectedIndex == 3)
            {
                SqlCommand komut = new SqlCommand("select Fransızca from tbl_diller", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    listBox2.Items.Add(dr[0] + "\n");
                }
                bgl.baglanti().Close();
            }
        }
    }
}
