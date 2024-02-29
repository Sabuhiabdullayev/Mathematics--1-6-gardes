using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_SIAV
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == true)
            {
                groupBox1.Visible = true;
                button1.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void label2_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button2.Enabled == true)
            {
                groupBox1.Visible = false;
                button1.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hour.Text = DateTime.Now.Hour.ToString();
            MInute.Text = DateTime.Now.Minute.ToString();
            Second.Text = DateTime.Now.Second.ToString();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = ("С И А В");
            label8.Text = ("Уроки");
            label5.Text = ("Математика");
            label4.Text = ("Русский язык");
            label3.Text = ("Английский язык");
            label2.Text = ("Калькулятор");
            groupBox2.Text = ("ЯЗЫК");
            checkBox1.Text = ("ЯЗЫК");
            groupBox2.Visible = false;
            checkBox1.Checked = false;
            btngiris.Text = "Войти";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = ("S I A V");
            label8.Text = ("Dersler");
            label5.Text = ("Riyaziyyat");
            label4.Text = ("Rus-Dili");
            label3.Text = ("Ingilis-Dili");
            label2.Text = ("Calculator");
            groupBox2.Text = ("Dil");
            checkBox1.Text = ("Dil");
            groupBox2.Visible = false;
            checkBox1.Checked = false;
            btngiris.Text = "Giriş";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                groupBox2.Visible = true;

            }
            else
            {
                groupBox2.Visible = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            timer2.Start();

            girispanel1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            btngiris2.Visible = false;
            button4.Visible = false;
            checkBox2.Visible = false;
            label10.Visible = false;
        }

        private void Hour_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            girispanel1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            btngiris2.Visible = true;
            button4.Visible = true;
            checkBox2.Visible = true;
            label10.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            button1.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            girispanel1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            btngiris2.Visible = false;
            button4.Visible  = false;
            checkBox2.Visible = false;
            label10.Visible = false;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void girispanel1_Click(object sender, EventArgs e)
        {

        }
        string user = "siavsabuhi";
        string password = "siav12345";
        
        private void btngiris2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == user && textBox2.Text == password)
            {
                lblgirisolundu.Text = "Təşəkkürlər Admin Hesab'a Giriş Olundu:";
                girispanel1.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                btngiris2.Visible = false;
                button4.Visible = false;
                checkBox2.Visible = false;
                label10.Visible = false;
                timer3.Enabled = true;
            }
            else
            {
                label10.Text = "Admin ve Ya Şifre Sehv'dir. Tezeden Yoxla:";
                girispanel1.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                btngiris2.Visible = false;
                button4.Visible = false;
                checkBox2.Visible = false;
                label10.Visible = false;
                timer3.Enabled = true;
            }
            
        }
        
        private void timer3_Tick(object sender, EventArgs e)
        {
            int s = 10;
            s--.ToString();
            if(s == 0)
            {
                lblgirisolundu.Text = "";
            }
        }
    }
}
