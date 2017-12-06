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
    public partial class Form1 : Form
    {
        private Form2 frm2;
        private Form3 frm3;
        public int gejalaNow = 0;
        public int A1 = 0;
        public int A2 = 0;
        public int A3 = 0;
        public double rendah = 0.333333333333;
        public double sedang = 0.333333333333;
        public double berat = 0.333333333333;
        public string pRingan = "P(x) = 1/3 = 0.333333333333" + Environment.NewLine;
        public string pSedang = "P(x) = 1/3 = 0.333333333333" + Environment.NewLine;
        public string pBerat = "P(x) = 1/3 = 0.333333333333" + Environment.NewLine;


        public int[] gejalaDiAlami = new int[33];

        public string[,] gejala = new string [33, 2]
            {
                {"Anak sering mengabaikan dan tidak menoleh saat dipanggil.", "1"},
                {"Anak sering mengabaikan orang di sekitar dan tidak menoleh saat dipanggil.", "2"},
                {"Anak kesulitan dalam berinteraksi sosial.", "3"},
                {"Anak tidak suka disentuh, digendong, atau dipeluk.", "1"},
                {"Anak sering mengelak ketika disentuh, digendong, atau dipeluk.", "2"},
                {"Anak kesulitan menghentikan gerakan yang biasanya dilakukan berulang- ulang.", "3"},
                {"Anak tidak suka pada keramaian/tempat baru", "1"},
                {"Anak sering menutup telinga ketika berada di keramaian/ tempat baru.", "2"},
                {"Anak kesulitan menghentikan kebiasaan mengulang-ulang suara/ ucapan.", "3"},
                {"Anak terkadang melakukan kontak mata saat diajak berinteraksi kadang tidak.", "1"},
                {"Anak menangis/ berteriak jika dipaksa untuk menghentikan kebiasaannya.", "3"},
                {"Anak bisa saja menangis tiba- tiba dan tertawa tiba- tiba dengan tidak wajar.", "1"},
                {"Anak sering menangis atau tertawa dengan tidak wajar.", "2"},
                {"Anak suka memukulkan benda/mainan ke tubuhnya.", "3"},
                {"Anak suka diam (Misalnya bengong, tidak melakukan apa- apa)/anak tidak bisa diam.", "1"},
                {"Anak lebih suka memojokkan diri atau anak lebih aktif dalam bermain.", "2"},
                {"Anak suka membenturkan kepalanya pada suatu benda.", "3"},
                {"Anak sering memainkan tangan atau jari.", "1"},
                {"Anak sering mengepakkan tangan/jari sendiri.", "2"},
                {"Anak sering menangis/tertawa tidak wajar.", "3"},
                {"Anak mengeluarkan suara yang tidak biasa. Seperti meracau, omong kosong, maupun jargon.", "1"},
                {"Anak sering mengeluarkan suara yang tidak biasa. Seperti meracau, omong kosong, maupun jargon", "2"},
                {"Anak mengabaikan rasa sakit. Misalnya, mengalami benjolan di kepala tanpa bereaksi.", "3"},
                {"Anak mengulang- ulang kata/ucapan", "1"},
                {"Anak memiliki minat yang terbatas. Seperti menonton video yang sama berulang- ulang.", "2"},
                {"Anak mempunyai gerakan favorit yang dilakukan setiap hari.", "3"},
                {"Anak tidak pernah menunjuk dengan jari (pointing) pada usia 1 tahun.", "1"},
                {"Anak tidak pernah berpura- pura bermain.", "1"},
                {"Perhatian anak terfokus pada objek tertentu saja,misalnya pada kipas angin.", "1"},
                {"Anak tidak babbling (mengoceh) pada usia sekitar 1,5 tahun. Artinya tak mengucapkan satu kata pun.", "2"},
                {"Anak tidak peduli dengan yang lainnya,kalaupun memberikan perhatian hanya sedikit sekali.", "2"},
                {"Anak tidak pernah mengucapkan 2 kata pada usia 2 tahun.", "3"},
                {"Setiap saat kemampuan berbahasa anak dapat hilang", "3"}
                };

        public double Rendah { get { return rendah; } set { rendah = value; } }
        public double Sedang { get => sedang; set => sedang = value; }
        public double Berat { get => berat; set => berat = value; }

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Form2 FormBiodata)
        {
            InitializeComponent();
            frm3 = new Form3(FormBiodata, this);
            rendah = sedang = berat = 0.333333333333;
            gejalaNow = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 33; i++)
            {
                lbGejala.Text = gejala[0, 0];
                if (Int32.Parse(gejala[gejalaNow, 1]) == 1)
                {
                    lbJenis.Text = "Autis Ringan";
                }
                else if (Int32.Parse(gejala[gejalaNow, 1]) == 2)
                {
                    lbJenis.Text = "Autis Sedang";
                }
                else
                {
                    lbJenis.Text = "Autis Berat";
                }
            }
            
        }

        private void btYa_Click(object sender, EventArgs e)
        {
            gejalaDiAlami[gejalaNow] = 1;
            
            if (gejalaNow < 32)
            {
                int n = 1;
                double p = n / 3;
                int m = 33;
                int ncr, ncs, ncb;
                if (Int32.Parse(gejala[gejalaNow, 1]) == 1)
                {
                    A1++;
                    rendah *= (1 + m * 0.3) / (n + m);
                    sedang *= (0 + m * 0.3) / (n + m);
                    berat *= (0 + m * 0.3) / (n + m);
                    ncr = 1;ncs = 0;ncb = 0;
                    lbJenisSebelum.Text = "Autis Ringan";
                }
                else if (Int32.Parse(gejala[gejalaNow, 1]) == 2)
                {
                    A2++;
                    rendah *= (0 + m * 0.3) / (n + m);
                    sedang *= (1 + m * 0.3) / (n + m);
                    berat *= (0 + m * 0.3) / (n + m);
                    ncr = 0; ncs = 1; ncb = 0;
                    lbJenisSebelum.Text = "Autis Sedang";
                }
                else
                {
                    A3++;
                    rendah *= (0 + m * 0.3) / (n + m);
                    sedang *= (0 + m * 0.3) / (n + m);
                    berat *= (1 + m * 0.3) / (n + m);
                    ncr = 0; ncs = 0; ncb = 1;
                    lbJenisSebelum.Text = "Autis Berat";
                }
                Console.WriteLine(rendah);
                Console.WriteLine(sedang);
                Console.WriteLine(berat);
                lbRendah.Text = rendah.ToString("0.000000000000");
                lbSedang.Text = sedang.ToString("0.000000000000");
                lbBerat.Text = berat.ToString("0.000000000000");
                lbRendah2.Text = "P("+ (gejalaNow+1) + "|x) = (" + ncr + " + 33 * 0.3) / (1 + 33)" + Environment.NewLine + "          = " + ((ncr + m * 0.3) / (n + m));
                lbSedang2.Text = "P(" + (gejalaNow + 1) + "|x) = (" + ncs + " + 33 * 0.3) / (1 + 33)" + Environment.NewLine + "          = " + ((ncr + m * 0.3) / (n + m));
                lbBerat2.Text = "P(" + (gejalaNow + 1) + "|x) = (" + ncb + " + 33 * 0.3) / (1 + 33)" + Environment.NewLine + "          = " + ((ncr + m * 0.3) / (n + m));
                pRingan += "P(" + (gejalaNow + 1) + "|x) = (" + ncr + " + 33 * 0.3) / (1 + 33)" + " = " + ((ncr + m * 0.3) / (n + m)) + Environment.NewLine;
                pSedang += "P(" + (gejalaNow + 1) + "|x) = (" + ncr + " + 33 * 0.3) / (1 + 33)" + " = " + ((ncs + m * 0.3) / (n + m)) + Environment.NewLine;
                pBerat += "P(" + (gejalaNow + 1) + "|x) = (" + ncr + " + 33 * 0.3) / (1 + 33)" + " = " + ((ncb + m * 0.3) / (n + m)) + Environment.NewLine;

                gejalaNow++;
                lbNomorGejala.Text = "Gejala " + gejalaNow;
                lbGejala.Text = gejala[gejalaNow, 0];
                if (Int32.Parse(gejala[gejalaNow, 1]) == 1)
                {
                    lbJenis.Text = "Autis Ringan";
                }
                else if (Int32.Parse(gejala[gejalaNow, 1]) == 2)
                {
                    lbJenis.Text = "Autis Sedang";
                }
                else
                {
                    lbJenis.Text = "Autis Berat";
                }

            } else
            {
                hasil();
            }
        }

        private void btTidak_Click(object sender, EventArgs e)
        {

            gejalaDiAlami[gejalaNow] = 0;
            if (Int32.Parse(gejala[gejalaNow, 1]) == 1)
            {
                lbJenisSebelum.Text = "Autis Ringan";
            }
            else if (Int32.Parse(gejala[gejalaNow, 1]) == 2)
            {
                lbJenisSebelum.Text = "Autis Sedang";
            }
            else
            {
                lbJenisSebelum.Text = "Autis Berat";
            }
            gejalaNow++;
            lbNomorGejala.Text = "Gejala " + gejalaNow;
            if (gejalaNow < 33)
            {
                
                lbGejala.Text = gejala[gejalaNow, 0];

                if (Int32.Parse(gejala[gejalaNow, 1]) == 1)
                {
                    lbJenis.Text = "Autis Ringan";
                }
                else if (Int32.Parse(gejala[gejalaNow, 1]) == 2)
                {
                    lbJenis.Text = "Autis Sedang";
                }
                else
                {
                    lbJenis.Text = "Autis Berat";
                }

            }
            else
            {
                hasil();
            }
        }

        private void hasil()
        {
            int n = 1;
            double p = n / 3;
            int m = 33;
            double rendah2, sedang2, berat2 = 0;
            rendah = 0.333333333333;
            sedang = 0.333333333333;
            berat = 0.333333333333;

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 33; i++)
                {
                    if (gejalaDiAlami[i] == 1)
                    {
                        int nc = 0;
                        if (Int32.Parse(gejala[i, 1]) == j+1)
                        {
                            nc = 1;
                        }
                        if (j == 0) //kalau rendah
                        {
                            if (rendah == 0)
                            {
                                rendah += (nc + m * 0.3) / (n + m);
                            }
                            
                            else
                            {
                                rendah *= (nc + m * 0.3) / (n + m);
                            }
                            Console.WriteLine("ringan " + i+1 + ": " + (nc + m * 0.3) / (n + m));
                            Console.WriteLine("ringan2 " + i+1 + ": " + rendah);
                        } else if (j == 1)
                        {
                            if (sedang == 0)
                            {
                                sedang += (nc + m * 0.3) / (n + m);
                            }
                            else
                            {
                                sedang *= (nc + m * 0.3) / (n + m);
                            }
                            Console.WriteLine("sedang " + i + 1 + ": " + (nc + m * 0.3) / (n + m));
                            Console.WriteLine("sedang2 " + i + 1 + ": " + sedang);
                        } else
                        {
                            if (berat == 0)
                            {
                                berat += (nc + m * 0.3) / (n + m);
                            }
                            else
                            {
                                berat *= (nc + m * 0.3) / (n + m);
                            }
                            Console.WriteLine("berat " + i + 1 + ": " + (nc + m * 0.3) / (n + m));
                            Console.WriteLine("berat2 " + i + 1 + ": " + berat);
                        }
                    }
                }
                
            }
            Console.WriteLine(rendah);
            Console.WriteLine(sedang);
            Console.WriteLine(berat);
            //label2.Text = rendah.ToString("0.0000000000");
            frm3.hasil(rendah, sedang, berat);
            frm3.Show();
            this.Hide();
        }
    }
}
