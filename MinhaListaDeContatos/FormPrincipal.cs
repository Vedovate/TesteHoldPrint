using Dapper;
using MinhaListaDeContatos.Models;
using MinhaListaDeContatos.Services;
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
    public partial class FormPrincipal : Form
    {
        static string StConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Lvedo\\OneDrive\\Área de Trabalho\\MinhaListaDeContatos\\MinhaListaDeContatos\\BD.mdf\";Integrated Security=True";
        Contato contatoSelecionado = new Contato();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro Cadastro = new FormCadastro();
            Cadastro.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(StConexao))
            {
                connection.Open();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT [Contato].[IdContato], Nome, Telefone, Email, Logradouro, Numero, Bairro, CEP, Cidade, Estado, Pais " +
                    "FROM Contato INNER JOIN Endereco ON [Contato].[IdContato] = [Endereco].[IdContato]", connection))
                {
                    using (DataTable dataTable = new DataTable())
                    {
                        dataAdapter.Fill(dataTable);

                        gvListaContatos.DataSource = dataTable;
                    }
                }
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            FormPrincipal_Load(null, EventArgs.Empty);
            //this.Hide();
            //FormPrincipal main = new FormPrincipal();
            //main.Show();
        }

        private void gvListaContatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvListaContatos_SelectionChanged(object sender, EventArgs e)
        {

            contatoSelecionado.IdContato = (int)gvListaContatos.CurrentRow.Cells[0].Value;
            contatoSelecionado.Nome = gvListaContatos.CurrentRow.Cells[1].Value.ToString();
            contatoSelecionado.Telefone = gvListaContatos.CurrentRow.Cells[2].Value.ToString();
            contatoSelecionado.Email = gvListaContatos.CurrentRow.Cells[3].Value.ToString();
            contatoSelecionado.Endereco.Logradouro = gvListaContatos.CurrentRow.Cells[4].Value.ToString();
            contatoSelecionado.Endereco.Numero = gvListaContatos.CurrentRow.Cells[5].Value.ToString();
            contatoSelecionado.Endereco.Bairro = gvListaContatos.CurrentRow.Cells[6].Value.ToString();
            contatoSelecionado.Endereco.CEP = gvListaContatos.CurrentRow.Cells[7].Value.ToString();
            contatoSelecionado.Endereco.Cidade = gvListaContatos.CurrentRow.Cells[8].Value.ToString();
            contatoSelecionado.Endereco.Estado = gvListaContatos.CurrentRow.Cells[9].Value.ToString();
            contatoSelecionado.Endereco.Pais = gvListaContatos.CurrentRow.Cells[10].Value.ToString();

        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(StConexao))
            {
                connection.Open();

                connection.Execute("DELETE FROM [Endereco] WHERE [Endereco].[IdContato] = @id", new
                {
                    id = contatoSelecionado.IdContato,
                });
                connection.Execute("DELETE FROM [Contato] WHERE [Contato].[IdContato] = @id", new
                {
                    id = contatoSelecionado.IdContato,
                });
                FormPrincipal_Load(null, EventArgs.Empty);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAtualizarContato formAtualizarContato = new FormAtualizarContato(contatoSelecionado);
            formAtualizarContato.Show();
        }

        private void FormPrincipal_Activated(object sender, EventArgs e)
        {
            FormPrincipal_Load(null, EventArgs.Empty);
        }

        private void btEmail_Click(object sender, EventArgs e)
        {
            EmailService.EnviaEmail(EmailService.MontarEmail(contatoSelecionado));
            var result = MessageBox.Show("Email enviado!",
                                 "Email enviado!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.None);
        }
    }
}
