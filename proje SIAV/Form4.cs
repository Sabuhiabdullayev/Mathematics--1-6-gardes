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
    public partial class Form4 : Form
    {
        char _islem;
        bool _ekranclaer;
        int _ilksayi;
          
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekranclaer)
            {
                ekranlabel.Text = "";
                _ekranclaer = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            
            ekranlabel.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekranclaer)
            {
                ekranlabel.Text = "";
                _ekranclaer = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
              ekranlabel.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranclaer)
            {
                ekranlabel.Text = "";
                _ekranclaer = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekranclaer)
            {
                ekranlabel.Text = "";
                _ekranclaer = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekranclaer)
            {
                ekranlabel.Text = "";
                _ekranclaer = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekranclaer)
            {
                ekranlabel.Text = "";
                _ekranclaer = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekranclaer)
            {
                ekranlabel.Text = "";
                _ekranclaer = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekranclaer)
            {
                ekranlabel.Text = "";
                _ekranclaer = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekranclaer)
            {
                ekranlabel.Text = "";
                _ekranclaer = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (_ekranclaer)
            {
                ekranlabel.Text = "";
                _ekranclaer = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "0";
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            if (_ekranclaer)
            {
                ekranlabel.Text = "";
                _ekranclaer = false;
            }
            ekranlabel.Text = "0";
            label1.Text = "";
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranclaer = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
            label1.Text = "+";
        }

        private void buttoncix_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranclaer = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
            label1.Text = "-";
        }

        private void buttonvur_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranclaer = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
            label1.Text = "*";
        }

        private void buttonbol_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranclaer = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
            label1.Text = ":";
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(ekranlabel.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                   sonuc = _ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;
                case ':':
                    sonuc = _ilksayi / ikincisayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            ekranlabel.Text = Convert.ToString(sonuc);

            label1.Text = "=";
        }
    }
}
