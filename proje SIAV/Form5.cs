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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            
        }
        Random rnd = new Random();
        int sayin1, sayin2, sonuc;
        int art = 1;
        int dus = 1;
        double birinci_sayi;
        bool ekranclear;


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btncavab_Enter(object sender, EventArgs e)
        {
            
        }

        private void btncavabq(object sender, KeyPressEventArgs e)
        {
          
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btncavab.PerformClick();
            }
            if(e.KeyCode == Keys.Right)
            {
                btnsayideyis.PerformClick();
            }
        }
      

        private void btn_calculator(object sender, EventArgs e)
        {

        }

        private void btncavab_Click(object sender, EventArgs e)
        {
         
            switch (comboBox1.Text)
            {
                case "+":
                    sonuc = sayin1 + sayin2;
                   
                    break;
                case "-":
                    sonuc = sayin1 - sayin2;
                    
                    break;
                case "*":
                    sonuc = sayin1 * sayin2;
                    
                    break;
                case "/":
                    sonuc = sayin1 / sayin2;
                    
                    break;
                default:
                    sonuc = 0;
                    break;
                    sonuc.ToString();
            }
            if(textBox1.Text == sonuc.ToString())
            {
                duzcavab.Text = (art++).ToString();
            }
           else
            {
                sehvcavab.Text = (dus++).ToString();
            }

            btncavab.Enabled = false;
            
            textBox1.Focus();
            if(duzcavab.Text == "20")
            {
                pictureBox1.ImageLocation = ("D:\\programs\\proje SIAV\\proje SIAV\\bin\\Debug\\icon\\1.gif");
                btncavab.Visible = false;
                MessageBox.Show("Tezeden Başla Düyməyə Basın","XƏTA",MessageBoxButtons.OK);
            }
            else if (sehvcavab.Text == "20")
            {
                pictureBox1.ImageLocation = ("D:\\programs\\proje SIAV\\proje SIAV\\bin\\Debug\\icon\\2.gif");
                MessageBox.Show("Tezeden Başla Düyməyə Basın", "XƏTA", MessageBoxButtons.OK);
                btncavab.Visible = false;
            }
            
             textBox1.Text = "";

        }

        private void btnsayideyis_Click(object sender, EventArgs e)
        {
           
            sayi1.Text = rnd.Next(1,40).ToString();
            sayi2.Text = rnd.Next(1, 40).ToString();


            sayin1 = Convert.ToInt32(sayi1.Text);
            sayin2 = Convert.ToInt32(sayi2.Text);
            btncavab.Enabled = true;
            textBox1.Focus();
           
            


        }
    }
}
