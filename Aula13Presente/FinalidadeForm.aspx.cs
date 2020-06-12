using System;
using System.Drawing;
using System.Web.UI.WebControls;
using Domain;
using Persistence;
using Util;

namespace Aula13Presente
{
    public partial class FinalidadeForm : System.Web.UI.Page
    {
        FinalidadePersistence finalidadePersistence = new FinalidadePersistence();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGridView();
                txtDescricao.Focus();
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
                    Finalidade finalidade = new Finalidade()
                    {
                        Descricao = txtDescricao.Text,
                        Origem = txtOrigem.Text
                    };
                    finalidadePersistence.Create(finalidade);
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
            gvResult.DataSource = finalidadePersistence.FindAll();
            gvResult.DataBind();
        }
        private bool IsInvalidForm()
        {
            return string.IsNullOrWhiteSpace(txtDescricao.Text) ||
                   string.IsNullOrWhiteSpace(txtOrigem.Text);
        }
        private void ClearForm()
        {
            txtDescricao.Text = String.Empty;
            txtOrigem.Text = String.Empty;
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