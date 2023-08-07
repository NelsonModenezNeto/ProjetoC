using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ee
{
    public partial class Form6 : Form
    {
        public Form6()
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
                MessageBox.Show("Digite o Email!");
            }
            else if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Digite a Senha!");
            }
            else if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("Digite a Senha Novamente!");
            }
            else if (Int32.Parse(textBox2.Text) != Int32.Parse(textBox4.Text))
            {
                MessageBox.Show("Senhas Diferentes");
            }
            else{ 
                String nome = textBox1.Text;
                String email = textBox3.Text;
                int senha = Int32.Parse(textBox4.Text);



                Conexao conexao = new Conexao();
                conexao.AbrirConexao();

                string consulta = "INSERT INTO Usuario (nome, email, senha) VALUES ('" + nome + "', '" + email + "', " + senha + ")";
                conexao.ExecutarQuery(consulta);

                conexao.FecharConexao();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("Usuário Cadastrado Com Sucesso!");
            }         
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
