<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PresenteForm.aspx.cs" Inherits="Aula13Presente.PresenteForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Presente</title>
    <style type="text/css">
        div {
            margin-top: 10px;
        }

        span {
            display: block;
        }
    </style>
</head>
<body>
    <div>
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
    </div>
    <form id="presenteForm" runat="server">
        <div>
            <asp:Label ID="lblId" runat="server" Text="ID:"></asp:Label>
            <asp:TextBox ReadOnly="true" ID="txtId" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblDescricao" runat="server" Text="*Descrição:"></asp:Label>
            <asp:TextBox MaxLength="100" ID="txtDescricao" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblTipo" runat="server" Text="*Tipo:"></asp:Label>
            <asp:TextBox MaxLength="100" ID="txtTipo" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblMarca" runat="server" Text="*Marca:"></asp:Label>
            <asp:TextBox MaxLength="100" ID="txtMarca" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblFinalidade" runat="server" Text="*Finalidade:"></asp:Label>
            <asp:TextBox MaxLength="100" ID="txtFinalidade" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblCor" runat="server" Text="*Cor:"></asp:Label>
            <asp:TextBox MaxLength="30" ID="txtCor" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblTamanho" runat="server" Text="*Tamanho:"></asp:Label>
            <asp:TextBox MaxLength="30" ID="txtTamanho" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblPreco" runat="server" Text="*Preço:"></asp:Label>
            <asp:TextBox MaxLength="8" ID="txtPreco" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblNomeFornecedor" runat="server" Text="*Nome do Fornecedor:"></asp:Label>
            <asp:TextBox MaxLength="100" ID="txtNomeFornecedor" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
        </div>
        <div>
            <p>Presentes:</p>
            <asp:GridView ID="gvPresentes" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
