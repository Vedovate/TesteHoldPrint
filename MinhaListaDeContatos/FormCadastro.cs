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
    public partial class FormCadastro : Form
    {

        static string StConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Lvedo\\OneDrive\\Área de Trabalho\\MinhaListaDeContatos\\MinhaListaDeContatos\\BD.mdf\";Integrated Security=True";


        public FormCadastro()
        {
            InitializeComponent();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

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

        private void btCancelarContato_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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

                    connection.Execute("INSERT INTO [Contato]([Nome],[Email],[Telefone]) VALUES (@nome,@email,@telefone)", new
                    {
                        nome = txNome.Text,
                        email = txEmail.Text,
                        telefone = txTelefone.Text
                    });

                    connection.Execute("INSERT INTO [Endereco]([CEP],[Logradouro],[Numero],[Bairro],[Cidade],[Estado],[IdContato]) VALUES (@CEP,@Logradouro,@Numero,@Bairro,@Cidade,@Estado,@@IDENTITY)", new
                    {
                        CEP = txCep.Text.Replace("-", ""),
                        Logradouro = txLogradouro.Text,
                        Numero = txNumero.Text,
                        Cidade = txCidade.Text,
                        Bairro = txBairro.Text,
                        Estado = txEstado.Text,
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
    }
}
