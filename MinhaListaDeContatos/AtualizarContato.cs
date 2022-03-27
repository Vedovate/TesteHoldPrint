using Dapper;
using MinhaListaDeContatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaListaDeContatos
{
    public partial class FormAtualizarContato : Form
    {
        Contato contato;
        static string StConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Lvedo\\OneDrive\\Área de Trabalho\\MinhaListaDeContatos\\MinhaListaDeContatos\\BD.mdf\";Integrated Security=True";


        public FormAtualizarContato(Contato contato)
        {
            InitializeComponent();

            this.contato = contato;

            txNome.Text = contato.Nome;
            txTelefone.Text = contato.Telefone;
            txEmail.Text = contato.Email;
            txLogradouro.Text = contato.Endereco.Logradouro;
            txNumero.Text = contato.Endereco.Numero;
            txBairro.Text = contato.Endereco.Bairro;
            txCep.Text = contato.Endereco.CEP;
            txCidade.Text = contato.Endereco.Cidade;
            txEstado.Text = contato.Endereco.Estado;
        }

        private void btCancelarContato_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvarContato_Click(object sender, EventArgs e)
        {
            try
            {
                if (txNome.Text == "")
                {
                    var result = MessageBox.Show("Insira um nome!",
                                     "Nenhem nome digitado",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation);
                    return;
                }

                using (var connection = new SqlConnection(StConexao))
                {
                    connection.Open();

                    connection.Execute("UPDATE [Contato] SET [Nome] = @nome, [Email] = @email, [Telefone] = @telefone WHERE [IdContato] = @id", new
                    {
                        nome = txNome.Text,
                        email = txEmail.Text,
                        telefone = txTelefone.Text,
                        id = contato.IdContato,
                    });

                    connection.Execute("UPDATE [Endereco] SET [CEP] = @CEP, [Logradouro] = @Logradouro,[Numero] = @Numero," +
                        "[Bairro] = @Bairro,[Cidade] = @Cidade,[Estado] = @Estado WHERE [IdContato] = @id", new
                        {
                            CEP = txCep.Text.Replace("-", ""),
                            Logradouro = txLogradouro.Text,
                            Numero = txNumero.Text,
                            Cidade = txCidade.Text,
                            Bairro = txBairro.Text,
                            Estado = txEstado.Text,
                            id = contato.IdContato,
                        });
                };
                this.Close();

            }
            catch
            {
                MessageBox.Show("Algo deu errado!",
                                     "Algo deu errado",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation);
            }
        }

        private void btCep_Click(object sender, EventArgs e)
        {
            try
            {
                var endCadastro = Endereco.GetEndereco(txCep.Text.Replace("-", ""));
                txLogradouro.Text = endCadastro.Logradouro;
                txBairro.Text = endCadastro.Bairro;
                txCidade.Text = endCadastro.Cidade;
                txEstado.Text = endCadastro.Estado;
            }
            catch
            {
                var result = MessageBox.Show("Cep Inválido!",
                                 "Cep Inválido",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
            }
        }
    }
}
