using System;
using System.Drawing;
using Domain;
using Persistence;

namespace Aula13Presente
{
    public partial class PresenteForm : System.Web.UI.Page
    {
        PresentePersistence presentePersistence = new PresentePersistence();
        TipoPersistence tipoPersistence = new TipoPersistence();
        MarcaPersistence marcaPersistence = new MarcaPersistence();
        FinalidadePersistence finalidadePersistence = new FinalidadePersistence();
        FornecedorPersistence fornecedorPersistence = new FornecedorPersistence();
        private static readonly string MSG_REQUIRED_FIELDS = "Campos obrigatórios não preenchidos.";
        private static readonly string MSG_CREATION_SUCCESS = "Presente salvo com sucesso.";
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGridView();
            LoadCombos();
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
                    Tipo tipo = new Tipo()
                    {
                        Id = int.Parse(ddlTipo.SelectedValue)
                    };
                    Marca marca = new Marca()
                    {
                        Id = int.Parse(ddlMarca.SelectedValue)
                    };
                    Finalidade finalidade = new Finalidade()
                    {
                        Id = int.Parse(ddlFinalidade.SelectedValue)
                    };
                    Fornecedor fornecedor = new Fornecedor()
                    {
                        Id = int.Parse(ddlFornecedor.SelectedValue)
                    };
                    Presente presente = new Presente()
                    {
                        Descricao = txtDescricao.Text,
                        Tipo = tipo,
                        Marca = marca,
                        Finalidade = finalidade,
                        Cor = txtCor.Text,
                        Tamanho = decimal.Parse(txtTamanho.Text),
                        Preco = decimal.Parse(txtPreco.Text),
                        Fornecedor = fornecedor
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
                || string.IsNullOrWhiteSpace(ddlTipo.SelectedValue)
                || string.IsNullOrWhiteSpace(ddlMarca.SelectedValue)
                || string.IsNullOrWhiteSpace(ddlFinalidade.SelectedValue)
                || string.IsNullOrWhiteSpace(txtCor.Text)
                || string.IsNullOrWhiteSpace(txtTamanho.Text)
                || string.IsNullOrWhiteSpace(txtPreco.Text)
                || string.IsNullOrWhiteSpace(ddlFornecedor.SelectedValue);
        }
        private void ClearForm()
        {
            txtDescricao.Text = String.Empty;
            ddlTipo.SelectedValue = null;
            ddlMarca.SelectedValue = null;
            ddlFinalidade.SelectedValue = null;
            txtCor.Text = String.Empty;
            txtTamanho.Text = String.Empty;
            txtPreco.Text = String.Empty;
            ddlFornecedor.SelectedValue = null;
            txtDescricao.Focus();
        }
        private void SendMessage(string message, Color color)
        {
            lblMensagem.Text = message;
            lblMensagem.ForeColor = color;
            lblMensagem.Font.Bold = true;
        }
        private void LoadCombos()
        {
            ddlTipo.DataSource = tipoPersistence.FindAll();
            ddlTipo.DataTextField = "descricao";
            ddlTipo.DataValueField = "Id";
            ddlTipo.DataBind();

            ddlMarca.DataSource = marcaPersistence.FindAll();
            ddlMarca.DataTextField = "descricao";
            ddlMarca.DataValueField = "Id";
            ddlMarca.DataBind();

            ddlFinalidade.DataSource = finalidadePersistence.FindAll();
            ddlFinalidade.DataTextField = "descricao";
            ddlFinalidade.DataValueField = "Id";
            ddlFinalidade.DataBind();

            ddlFornecedor.DataSource = fornecedorPersistence.FindAll();
            ddlFornecedor.DataTextField = "nome";
            ddlFornecedor.DataValueField = "Id";
            ddlFornecedor.DataBind();
        }
    }
}