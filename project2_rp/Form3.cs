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
    public partial class Form3 : Form
    {
        private Form1 frm1;
        private Form2 frm2;
        double r, s, t;
        private string u;
        private string n;
        private string a;
        private string j;
        private string np;

        public string U { get => u; set => u = value; }
        public string N { get => n; set => n = value; }
        public string A { get => a; set => a = value; }
        public string J { get => j; set => j = value; }
        public string Np { get => np; set => np = value; }

        public Form3()
        {
            InitializeComponent();
            
            //frm2 = new Form2();
        }

        public Form3(Form2 FormBiodata, Form1 FormGejala)
        {
            InitializeComponent();

            frm2 = FormBiodata;
            frm1 = FormGejala;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        public void hasil(double r, double s, double t)
        {
            this.r = r;
            this.s = s;
            this.t = t;
        }

        public void identitas(System.String n, System.String a, System.String j, System.String np, System.String u)
        {
            this.N = n;
            Console.Write("wew" + this.N);
            this.A = a;
            this.J = j;
            this.Np = np;
            this.U = u;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label5.Text = r.ToString("0.000000000000");
            label6.Text = s.ToString("0.000000000000");
            Console.WriteLine(frm1.Sedang);
            label7.Text = t.ToString("0.000000000000");
            label13.Text = frm2.namaOrtu;
            label14.Text = frm2.alamat;
            label15.Text = frm2.jenisKelamin;
            label16.Text = frm2.namaPasien;
            label17.Text = frm2.usia;

            lbPRingan.Text = frm1.pRingan;
            lbPSedang.Text = frm1.pSedang;
            lbPBerat.Text = frm1.pBerat;
            
            if (r < s)
            {
                if (s < t)
                {
                    label9.Text = "Autis Berat";
                } else
                {
                    label9.Text = "Autis Sedang";
                }
            } else
            {
                label9.Text = "Autis Ringan";
            }
        }
    }
}
