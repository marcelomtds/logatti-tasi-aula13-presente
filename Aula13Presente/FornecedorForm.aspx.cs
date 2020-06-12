using System;
using System.Drawing;
using Domain;
using Persistence;
using Util;

namespace Aula13Presente
{
    public partial class FornecedorForm : System.Web.UI.Page
    {
        FornecedorPersistence fornecedorPersistence = new FornecedorPersistence();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGridView();
                txtCnpj.Focus();
            }
        }
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IsInvalidForm())
            {
                SendMessage(Message.MSG_REQUIRED_FIELDS, Color.Red);
            }
            else
            {
                try
                {
                    Fornecedor fornecedor = new Fornecedor()
                    {
                        Nome = txtNome.Text,
                        Telefone = txtTelefone.Text,
                        Cidade = txtCidade.Text,
                        Estado = txtEstado.Text,
                        Logradouro = txtLogradouro.Text,
                        Numero = txtNumero.Text,
                        Cnpj = txtCnpj.Text,
                        Email = txtEmail.Text,
                        ContaCorrente = txtContaCorrente.Text,
                        Agencia = txtAgencia.Text,
                        Banco = txtBanco.Text
                    };
                    fornecedorPersistence.Create(fornecedor);
                    SendMessage(Message.MSG_CREATION_SUCCESS, Color.Green);
                    LoadGridView();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    SendMessage($"{Message.MSG_ERROR} {ex.Message}", Color.Red);
                }
            }
        }
        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            ClearForm();
            SendMessage(String.Empty, Color.Empty);
        }
        private void LoadGridView()
        {
            gvResult.DataSource = fornecedorPersistence.FindAll();
            gvResult.DataBind();
        }
        private bool IsInvalidForm()
        {
            return string.IsNullOrWhiteSpace(txtNome.Text) ||
                   string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                   string.IsNullOrWhiteSpace(txtCidade.Text) ||
                   string.IsNullOrWhiteSpace(txtEstado.Text) ||
                   string.IsNullOrWhiteSpace(txtLogradouro.Text) ||
                   string.IsNullOrWhiteSpace(txtNumero.Text) ||
                   string.IsNullOrWhiteSpace(txtCnpj.Text) ||
                   string.IsNullOrWhiteSpace(txtEmail.Text) ||
                   string.IsNullOrWhiteSpace(txtContaCorrente.Text) ||
                   string.IsNullOrWhiteSpace(txtAgencia.Text) ||
                   string.IsNullOrWhiteSpace(txtBanco.Text);
        }
        private void ClearForm()
        {
            txtNome.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtCidade.Text = String.Empty;
            txtEstado.Text = String.Empty;
            txtLogradouro.Text = String.Empty;
            txtNumero.Text = String.Empty;
            txtCnpj.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtContaCorrente.Text = String.Empty;
            txtAgencia.Text = String.Empty;
            txtBanco.Text = String.Empty;
            txtCnpj.Focus();
        }
        private void SendMessage(string message, Color color)
        {
            lblMensagem.Text = message;
            lblMensagem.ForeColor = color;
            lblMensagem.Font.Bold = true;
        }
    }
}