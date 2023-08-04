using MySql.Data.MySqlClient;
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
            Conexao conexao = new Conexao();
            conexao.AbrirConexao();

            InitializeComponent();
            panel3.Visible = true;
            panel8.Visible = false;
            panel7.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            dataGridView2.Rows.Add(null, 1, "Banana", 1000);
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

        private void button6_Click(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int quantidade = 0;
            double valoruni = 0;
            double total = 0;

            if (int.TryParse(textBox1.Text, out quantidade) && double.TryParse(textBox2.Text, out valoruni))
            {
                total = quantidade * valoruni;
                textBox5.Text = total.ToString();
            }
            else
            {
                // Se a conversão falhar, pode exibir uma mensagem de erro ou fazer qualquer tratamento apropriado.
                // Por exemplo, poderia limpar o textBox5.Text.
                textBox5.Text = "";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int quantidade = 0;
            double valoruni = 0;
            double total = 0;

            if (int.TryParse(textBox1.Text, out quantidade) && double.TryParse(textBox2.Text, out valoruni))
            {
                total = quantidade * valoruni;
                textBox5.Text = total.ToString();
            }
            else
            {
                // Se a conversão falhar, pode exibir uma mensagem de erro ou fazer qualquer tratamento apropriado.
                // Por exemplo, poderia limpar o textBox5.Text.
                textBox5.Text = "";
            }
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void textBox2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Digite o Nome!");
            }
            else if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Digite a Quantidade!");
            }
            else if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Digite o Valor Unitário!");
            }
            else
            {
                string nomeProduto = textBox3.Text;
                int quantidadeProduto = Int32.Parse(textBox1.Text);
                double valorProduto = Double.Parse(textBox5.Text);

                bool produtoExistente = false;
                int rowIndex = -1;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells["Column2"].Value.ToString() == nomeProduto)
                    {
                        produtoExistente = true;
                        rowIndex = i;
                        break;
                    }
                }

                if (produtoExistente)
                {
                    int quantidadeAtual = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Column1"].Value);
                    double valorAtual = Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells["Column3"].Value);
                    dataGridView1.Rows[rowIndex].Cells["Column1"].Value = quantidadeAtual + quantidadeProduto;
                    dataGridView1.Rows[rowIndex].Cells["Column3"].Value = valorAtual + valorProduto;
                }
                else
                {
                    dataGridView1.Rows.Add(null, nomeProduto, quantidadeProduto, valorProduto);
                }

                AtualizarLabel19();
                textBox3.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox5.Text = "";
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["Column4"].Index && e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                AtualizarLabel19();
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Column5"].Index && e.RowIndex >= 0)
            {
                // Obter os valores do produto selecionado no dataGridView2
                string nomeProduto = dataGridView2.Rows[e.RowIndex].Cells["Column7"].Value.ToString();
                int quantidadeProduto = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["Column6"].Value);
                double valorProduto = Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells["Column8"].Value);

                // Verificar se já existe o mesmo produto no dataGridView1
                bool produtoExistente = false;
                int rowIndex = -1;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells["Column2"].Value.ToString() == nomeProduto)
                    {
                        produtoExistente = true;
                        rowIndex = i;
                        break;
                    }
                }

                // Se o produto já existe, somar os valores de quantidade e valor
                if (produtoExistente)
                {
                    int quantidadeAtual = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Column1"].Value);
                    double valorAtual = Convert.ToDouble(dataGridView1.Rows[rowIndex].Cells["Column3"].Value);
                    dataGridView1.Rows[rowIndex].Cells["Column1"].Value = quantidadeAtual + quantidadeProduto;
                    dataGridView1.Rows[rowIndex].Cells["Column3"].Value = valorAtual + valorProduto;
                }
                else // Caso contrário, adicionar o produto ao dataGridView1
                {
                    dataGridView1.Rows.Add(null, nomeProduto, quantidadeProduto, valorProduto);
                    
                }
            }
            AtualizarLabel19();
        }

        private double SomarValoresColumn3(DataGridView dataGridView)
        {
            double soma = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Verifica se a célula não está vazia e é um valor numérico válido
                if (row.Cells["Column3"].Value != null && double.TryParse(row.Cells["Column3"].Value.ToString(), out double valor))
                {
                    soma += valor;
                }
            }

            return soma;
        }

        private void AtualizarLabel19()
        {
            double somaColumn3 = SomarValoresColumn3(dataGridView1);
            label19.Text = (somaColumn3+"R$");
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
