<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PresenteForm.aspx.cs" Inherits="Aula13Presente.PresenteForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="css/bootstrap.css">
    <title>Gerenciamento de Presentes</title>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <a class="navbar-brand" href="#">Navbar</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarColor01">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item active">
                    <a class="nav-link" href="./TipoForm.aspx">Tipo <span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Features</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Pricing</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">About</a>
                </li>
            </ul>
        </div>
    </nav>
    <div class="container">
        <div class="row">
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </div>
        <form id="presenteForm" runat="server">
            <div class="row">
                <div class="col-2">
                    <div class="form-group">
                        <asp:Label ID="lblId" runat="server" Text="ID:"></asp:Label>
                        <asp:TextBox class="form-control" ReadOnly="true" ID="txtId" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-4">
                    <div class="form-group">
                        <asp:Label ID="lblDescricao" runat="server" Text="*Descrição:"></asp:Label>
                        <asp:TextBox class="form-control" MaxLength="100" ID="txtDescricao" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-4">
                    <div class="form-group">
                        <asp:Label ID="lblTipo" runat="server" Text="*Tipo:"></asp:Label>
                        <asp:DropDownList class="form-control" ID="ddlTipo" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <div class="col-4">
                    <div class="form-group">
                        <asp:Label ID="lblMarca" runat="server" Text="*Marca:"></asp:Label>
                        <asp:DropDownList class="form-control" ID="ddlMarca" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <div class="col-4">
                    <div class="form-group">
                        <asp:Label ID="lblFinalidade" runat="server" Text="*Finalidade:"></asp:Label>
                        <asp:DropDownList class="form-control" ID="ddlFinalidade" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <div class="col-4">
                    <div class="form-group">
                        <asp:Label ID="lblFornecedor" runat="server" Text="*Fornecedor:"></asp:Label>
                        <asp:DropDownList class="form-control" ID="ddlFornecedor" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <div class="col-4">
                    <div class="form-group">
                        <asp:Label ID="lblCor" runat="server" Text="*Cor:"></asp:Label>
                        <asp:TextBox class="form-control" MaxLength="30" ID="txtCor" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-4">
                    <div class="form-group">
                        <asp:Label ID="lblTamanho" runat="server" Text="*Tamanho:"></asp:Label>
                        <asp:TextBox class="form-control" MaxLength="30" ID="txtTamanho" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-4">
                    <div class="form-group">
                        <asp:Label ID="lblPreco" runat="server" Text="*Preço:"></asp:Label>
                        <asp:TextBox class="form-control" MaxLength="8" ID="txtPreco" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-4">
                    <div class="form-group">
                        <asp:Button class="btn btn-success" ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                        <asp:Button class="btn btn-primary" ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                    </div>

                </div>
            </div>
            <div>
                <p>Presentes:</p>
                <asp:GridView ID="gvPresentes" runat="server"></asp:GridView>
            </div>
        </form>
    </div>
    <script>
        var table = document.getElementById("gvPresentes");
        table.classList.add("table");
        table.classList.add("table-striped");
        table.classList.add("table-dark");
    </script>
</body>
</html>
