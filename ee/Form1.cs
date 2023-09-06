﻿using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private void gradiente1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Select();
        }

        private string nomeUsuario; // Variável para armazenar o nome do usuário

        private string RetornarUsuario(string nome)
        {
            nomeUsuario = nome; // Armazena o nome do usuário na variável
            return nome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool finde = false;
            try
            {

                Conexao conexao = new Conexao();
                conexao.AbrirConexao();

                string consulta = "SELECT Nome, Senha FROM Usuario"; // Sua consulta SQL aqui
                conexao.ExecutarQuery(consulta);

                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                {
                    adapter.SelectCommand = new MySqlCommand(consulta, conexao.RetornarConexao());
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Obtém os valores da linha
                        string Nome = row["Nome"].ToString();
                        string Senha = row["Senha"].ToString();

                        if (Nome == textBox3.Text && Senha == textBox2.Text)
                        {
                            RetornarUsuario(Nome);
                            finde = true;
                        }

                    }
                }
                conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar o grid: {ex.Message}");
            }

            if (finde == true)
            {
                // Fechar o Form1
                this.Hide(); // Oculta o Form1

                // Criar e exibir o Form2
                Form2 form2 = new Form2();
                form2.SetNomeUsuario(nomeUsuario.ToUpper()); // Chama o método para definir o nome de usuário no Form2
                form2.Show();
            }

            else
            {
                MessageBox.Show("Usuário ou Senha Incorreto");
            }
        }
    }
}
