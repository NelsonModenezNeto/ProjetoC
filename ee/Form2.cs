using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ee
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panel3.Visible = true;
            panel8.Visible = false;
            panel7.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradiente1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = true;
            panel8.Visible = false;
            panel7.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel2.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel7.Visible = true;
            panel8.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel1.Visible = false;
            panel6.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel8.Visible = true;
            panel7.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel1.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form4>().Count()>0)
            {
                MessageBox.Show("O formulário já está aberto.");
                return;
            }
            else { 
                Form4 tela = new Form4();
                tela.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form5>().Count() > 0)
            {
                MessageBox.Show("O formulário já está aberto.");
                return;
            }
            else
            {
                Form5 tela = new Form5();
                tela.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form3>().Count() > 0)
            {
                MessageBox.Show("O formulário já está aberto.");
                return;
            }
            else
            {
                Form3 tela = new Form3();
                tela.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel3.Visible = true;
            panel8.Visible = false;
            panel7.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel2.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel7.Visible = true;
            panel8.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel1.Visible = false;
            panel6.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel8.Visible = true;
            panel7.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel1.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form8>().Count() > 0)
            {
                MessageBox.Show("O formulário já está aberto.");
                return;
            }
            else
            {
                Form8 tela = new Form8();
                tela.Show();
            }
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form6>().Count() > 0)
            {
                MessageBox.Show("O formulário já está aberto.");
                return;
            }
            else
            {
                Form6 tela = new Form6();
                tela.Show();
            }
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form7>().Count() > 0)
            {
                MessageBox.Show("O formulário já está aberto.");
                return;
            }
            else
            {
                Form7 tela = new Form7();
                tela.Show();
            }
        }
    }
}
