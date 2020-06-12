<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TipoForm.aspx.cs" Inherits="Aula13Presente.TipoForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="css/bootstrap.css">
    <title>Sistema de Presentes</title>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
        <a class="navbar-brand" style="color: white;">Menu</a>
        <div class="collapse navbar-collapse" id="navbarColor02">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item active">
                    <a class="nav-link" href="./PresenteForm.aspx">Presente</a>
                </li>
                <li class="nav-item active">
                    <a class="nav-link" href="./TipoForm.aspx">Tipo</a>
                </li>
                <li class="nav-item active">
                    <a class="nav-link" href="./MarcaForm.aspx">Marca</a>
                </li>
                <li class="nav-item active">
                    <a class="nav-link" href="./FinalidadeForm.aspx">Finalidade</a>
                </li>
                <li class="nav-item active">
                    <a class="nav-link" href="./FornecedorForm.aspx">Fornecedor</a>
                </li>
            </ul>
        </div>
    </nav>
    <div class="container" style="margin-top: 15px;">
        <form id="form" runat="server">
            <div class="row">
                <div class="col-12">
                    <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-2">
                    <div class="form-group">
                        <asp:Label ID="lblId" runat="server" Text="ID:"></asp:Label>
                        <asp:TextBox class="form-control" ReadOnly="true" ID="txtId" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-6">
                    <div class="form-group">
                        <asp:Label ID="lblDescricao" runat="server" Text="*Descrição:"></asp:Label>
                        <asp:TextBox class="form-control" MaxLength="100" ID="txtDescricao" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-12">
                    <div class="form-group">
                        <asp:Button class="btn btn-success" ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                        <asp:Button class="btn btn-primary" ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                    </div>

                </div>
            </div>
            <div class="table-responsive">
                <asp:GridView ID="gvResult" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="ID" />
                        <asp:BoundField DataField="Descricao" HeaderText="Descrição" />
                    </Columns>
                </asp:GridView>
            </div>
        </form>
    </div>
    <script>
        var table = document.getElementById("gvResult");
        table.classList.add("table");
        table.classList.add("table-hover");
    </script>
</body>
</html>
