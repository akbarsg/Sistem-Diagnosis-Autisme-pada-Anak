using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2_rp
{
    public partial class Form2 : Form
    {
        private Form1 frm1;
        private Form3 frm3;
        public string usia;
        public string namaOrtu;
        public string alamat;
        public string jenisKelamin;
        public string namaPasien;
        
        public Form2()
        {
            InitializeComponent();
            //frm1 = new Form1();
            //frm3 = new Form3();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            namaOrtu = tbNama.Text;
            alamat = tbAlamat.Text;
            jenisKelamin = tbJenis.Text;
            if (rbLaki.Checked)
            {
                jenisKelamin = rbLaki.Text;
            } else if (rbPerempuan.Checked)
            {
                jenisKelamin = rbPerempuan.Text;
            }
            namaPasien = tbNamaPasien.Text;
            usia = tbUsia.Text;
            frm1 = new Form1(this);
            //frm3.identitas("coeg", tbAlamat.Text, tbJenis.Text, tbNamaPasien.Text, tbUsia.Text);
            frm1.Show();
            this.Hide();
        }

        private void admiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
