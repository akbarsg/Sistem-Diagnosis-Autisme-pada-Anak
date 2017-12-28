namespace project2_rp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbGejala = new System.Windows.Forms.Label();
            this.btYa = new System.Windows.Forms.Button();
            this.btTidak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbJenisSebelum = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbJenis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbRendah = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbRendah2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbSedang = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbSedang2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbBerat = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbBerat2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbNomorGejala = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbGejala
            // 
            this.lbGejala.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGejala.AutoSize = true;
            this.lbGejala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbGejala.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGejala.Location = new System.Drawing.Point(12, 57);
            this.lbGejala.Name = "lbGejala";
            this.lbGejala.Size = new System.Drawing.Size(574, 40);
            this.lbGejala.TabIndex = 0;
            this.lbGejala.Text = "Anak kesulitan menghentikan gerakan yang biasanya dilakukan berulang- ulang. \r\nMi" +
    "salnya, gerakan khusus yang dilakukan berulang- ulang di setiap harinya.";
            this.lbGejala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btYa
            // 
            this.btYa.BackColor = System.Drawing.Color.PaleGreen;
            this.btYa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btYa.Location = new System.Drawing.Point(12, 131);
            this.btYa.Name = "btYa";
            this.btYa.Size = new System.Drawing.Size(743, 50);
            this.btYa.TabIndex = 1;
            this.btYa.Text = "YA";
            this.btYa.UseVisualStyleBackColor = false;
            this.btYa.Click += new System.EventHandler(this.btYa_Click);
            // 
            // btTidak
            // 
            this.btTidak.AutoSize = true;
            this.btTidak.BackColor = System.Drawing.Color.LightSalmon;
            this.btTidak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTidak.Location = new System.Drawing.Point(12, 187);
            this.btTidak.Name = "btTidak";
            this.btTidak.Size = new System.Drawing.Size(743, 50);
            this.btTidak.TabIndex = 2;
            this.btTidak.Text = "TIDAK";
            this.btTidak.UseVisualStyleBackColor = false;
            this.btTidak.Click += new System.EventHandler(this.btTidak_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apakah gejala berikut dialami oleh pasien?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbJenisSebelum);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbJenis);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jenis Gejala";
            // 
            // lbJenisSebelum
            // 
            this.lbJenisSebelum.AutoSize = true;
            this.lbJenisSebelum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJenisSebelum.Location = new System.Drawing.Point(16, 157);
            this.lbJenisSebelum.Name = "lbJenisSebelum";
            this.lbJenisSebelum.Size = new System.Drawing.Size(13, 17);
            this.lbJenisSebelum.TabIndex = 2;
            this.lbJenisSebelum.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Jenis Gejala sebelumnya";
            // 
            // lbJenis
            // 
            this.lbJenis.AutoSize = true;
            this.lbJenis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJenis.Location = new System.Drawing.Point(14, 68);
            this.lbJenis.Name = "lbJenis";
            this.lbJenis.Size = new System.Drawing.Size(21, 30);
            this.lbJenis.TabIndex = 1;
            this.lbJenis.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jenis Gejala saat ini";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lbRendah);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbRendah2);
            this.groupBox2.Location = new System.Drawing.Point(195, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 130);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autis Ringan";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "P (ai│vj) gejala sebelumnya";
            // 
            // lbRendah
            // 
            this.lbRendah.AutoSize = true;
            this.lbRendah.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRendah.Location = new System.Drawing.Point(14, 108);
            this.lbRendah.Name = "lbRendah";
            this.lbRendah.Size = new System.Drawing.Size(130, 20);
            this.lbRendah.TabIndex = 1;
            this.lbRendah.Text = "0.333333333333";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "P (x) = 1/3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "P(ai│vj) x P (vj)";
            // 
            // lbRendah2
            // 
            this.lbRendah2.AutoSize = true;
            this.lbRendah2.Location = new System.Drawing.Point(14, 56);
            this.lbRendah2.Name = "lbRendah2";
            this.lbRendah2.Size = new System.Drawing.Size(10, 13);
            this.lbRendah2.TabIndex = 0;
            this.lbRendah2.Text = "-";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbSedang);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lbSedang2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(387, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 130);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Autis Sedang";
            // 
            // lbSedang
            // 
            this.lbSedang.AutoSize = true;
            this.lbSedang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSedang.Location = new System.Drawing.Point(13, 108);
            this.lbSedang.Name = "lbSedang";
            this.lbSedang.Size = new System.Drawing.Size(130, 20);
            this.lbSedang.TabIndex = 3;
            this.lbSedang.Text = "0.333333333333";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "P(ai│vj) x P (vj)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "P (ai│vj) gejala sebelumnya";
            // 
            // lbSedang2
            // 
            this.lbSedang2.AutoSize = true;
            this.lbSedang2.Location = new System.Drawing.Point(13, 56);
            this.lbSedang2.Name = "lbSedang2";
            this.lbSedang2.Size = new System.Drawing.Size(10, 13);
            this.lbSedang2.TabIndex = 1;
            this.lbSedang2.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "P (x) = 1/3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbBerat);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.lbBerat2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(569, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 130);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Autis Berat";
            // 
            // lbBerat
            // 
            this.lbBerat.AutoSize = true;
            this.lbBerat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBerat.Location = new System.Drawing.Point(12, 108);
            this.lbBerat.Name = "lbBerat";
            this.lbBerat.Size = new System.Drawing.Size(130, 20);
            this.lbBerat.TabIndex = 4;
            this.lbBerat.Text = "0.333333333333";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "P(ai│vj) x P (vj)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "P (ai│vj) gejala sebelumnya";
            // 
            // lbBerat2
            // 
            this.lbBerat2.AutoSize = true;
            this.lbBerat2.Location = new System.Drawing.Point(12, 56);
            this.lbBerat2.Name = "lbBerat2";
            this.lbBerat2.Size = new System.Drawing.Size(10, 13);
            this.lbBerat2.TabIndex = 2;
            this.lbBerat2.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "P (x) = 1/3";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(195, 243);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(560, 58);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rumus";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(271, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "P (ai│vj) = (nc + jumlah gejala * 0.3) / (n + jumlah gejala)";
            // 
            // lbNomorGejala
            // 
            this.lbNomorGejala.AutoSize = true;
            this.lbNomorGejala.Location = new System.Drawing.Point(25, 21);
            this.lbNomorGejala.Name = "lbNomorGejala";
            this.lbNomorGejala.Size = new System.Drawing.Size(46, 13);
            this.lbNomorGejala.TabIndex = 8;
            this.lbNomorGejala.Text = "Gejala 1";
            this.lbNomorGejala.Click += new System.EventHandler(this.lbNomorGejala_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 243);
            this.Controls.Add(this.lbNomorGejala);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btTidak);
            this.Controls.Add(this.btYa);
            this.Controls.Add(this.lbGejala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pertanyaan - Diagnosis Autisme pada Anak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGejala;
        private System.Windows.Forms.Button btYa;
        private System.Windows.Forms.Button btTidak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbJenis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbRendah2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbSedang2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbBerat2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbRendah;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbSedang;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbBerat;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbJenisSebelum;
        private System.Windows.Forms.Label lbNomorGejala;
    }
}

