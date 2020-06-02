using System;
using System.Drawing;
using Domain;
using Persistence;

namespace Aula13Presente
{
    public partial class PresenteForm : System.Web.UI.Page
    {
        PresentePersistence presentePersistence = new PresentePersistence();
        private static readonly string MSG_REQUIRED_FIELDS = "Campos obrigatórios não preenchidos.";
        private static readonly string MSG_CREATION_SUCCESS = "Presente salvo com sucesso.";
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGridView();
            txtDescricao.Focus();
        }
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IsInvalidForm())
            {
                SendMessage(MSG_REQUIRED_FIELDS, Color.Red);
            }
            else
            {
                try
                {
                    Presente presente = new Presente()
                    {
                        Descricao = txtDescricao.Text,
                        Tipo = txtTipo.Text,
                        Marca = txtMarca.Text,
                        Finalidade = txtFinalidade.Text,
                        Cor = txtCor.Text,
                        Tamanho = txtTamanho.Text,
                        Preco = decimal.Parse(txtPreco.Text),
                        NomeFornecedor = txtNomeFornecedor.Text
                    };
                    presentePersistence.Create(presente);
                    SendMessage(MSG_CREATION_SUCCESS, Color.Green);
                    LoadGridView();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    SendMessage($"Ocorreu um Erro: {ex.Message}", Color.Red);
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
            gvPresentes.DataSource = presentePersistence.FindAll();
            gvPresentes.DataBind();
        }
        private bool IsInvalidForm()
        {
            return string.IsNullOrWhiteSpace(txtDescricao.Text)
                || string.IsNullOrWhiteSpace(txtTipo.Text)
                || string.IsNullOrWhiteSpace(txtMarca.Text)
                || string.IsNullOrWhiteSpace(txtFinalidade.Text)
                || string.IsNullOrWhiteSpace(txtCor.Text)
                || string.IsNullOrWhiteSpace(txtTamanho.Text)
                || string.IsNullOrWhiteSpace(txtPreco.Text)
                || string.IsNullOrWhiteSpace(txtNomeFornecedor.Text);
        }
        private void ClearForm()
        {
            txtDescricao.Text = String.Empty;
            txtTipo.Text = String.Empty;
            txtMarca.Text = String.Empty;
            txtFinalidade.Text = String.Empty;
            txtCor.Text = String.Empty;
            txtTamanho.Text = String.Empty;
            txtPreco.Text = String.Empty;
            txtNomeFornecedor.Text = String.Empty;
            txtDescricao.Focus();
        }
        private void SendMessage(string message, Color color)
        {
            lblMensagem.Text = message;
            lblMensagem.ForeColor = color;
            lblMensagem.Font.Bold = true;
        }
    }
}