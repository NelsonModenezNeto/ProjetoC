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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Digite o Nome!");
            }
            else if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Digite a Idade!");
            }
            else if (!int.TryParse(textBox3.Text, out int idade))
            {
                MessageBox.Show("Digite Uma Idade Válida!");
            }
            else if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Digite o Salário!");
            }
            else if (!double.TryParse(textBox2.Text, out double salario))
            {
                MessageBox.Show("Digite um Salário Válido!");
            }
            else if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("Digite o Cargo!");
            }
            else if (int.Parse(textBox3.Text) > 100 || int.Parse(textBox3.Text) < 12)
            {
                MessageBox.Show("Digite Uma Idade Válida de 12 Até 100 Anos!");
            }
            else
            {
                String nome = textBox1.Text;
                String cargo = textBox4.Text;

                Conexao conexao = new Conexao();
                conexao.AbrirConexao();

                string consulta = "INSERT INTO Funcionario (Nome, Idade, Salario, Cargo) VALUES ('" + nome + "', " + idade + ", " + salario + ", '" + cargo + "')";
                conexao.ExecutarQuery(consulta);

                conexao.FecharConexao();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("Funcionário Cadastrado Com Sucesso!");
            }
        }


        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
