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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void ingilisdiliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4();
            form4.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                label4.Text = "азербайджанский и русский перевод";
                riyaziyyatToolStripMenuItem.Text=("математика");
                ingilisdiliToolStripMenuItem.Text = ("английский язык");
                calculatorToolStripMenuItem.Text = ("калькулятор");
                checkBox1.Text = "язык";
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            

          if(radioButton2.Checked == true)
            {
                
                label4.Text = "Azerbaycan ve Rusca Tercume";
                riyaziyyatToolStripMenuItem.Text = ("Riyaziyyat");
                ingilisdiliToolStripMenuItem.Text = ("Ingilis-dili");
                calculatorToolStripMenuItem.Text = ("Calculator");
                checkBox1.Text = "Dil";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }
    }
}
