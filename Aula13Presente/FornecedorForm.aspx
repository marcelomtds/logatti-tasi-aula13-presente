<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FornecedorForm.aspx.cs" Inherits="Aula13Presente.FornecedorForm" %>

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
                <div class="col-3">
                    <div class="form-group">
                        <asp:Label ID="lblCnpj" runat="server" Text="*CNPJ:"></asp:Label>
                        <asp:TextBox class="form-control" MaxLength="15" ID="txtCnpj" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-7">
                    <div class="form-group">
                        <asp:Label ID="lblNome" runat="server" Text="*Nome:"></asp:Label>
                        <asp:TextBox class="form-control" MaxLength="100" ID="txtNome" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-3">
                    <div class="form-group">
                        <asp:Label ID="lblTelefone" runat="server" Text="*Telefone:"></asp:Label>
                        <asp:TextBox class="form-control" MaxLength="15" ID="txtTelefone" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-9">
                    <div class="form-group">
                        <asp:Label ID="lblEmail" runat="server" Text="*E-mail:"></asp:Label>
                        <asp:TextBox class="form-control" MaxLength="50" ID="txtEmail" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-4">
                    <div class="form-group">
                        <asp:Label ID="lblLogradouro" runat="server" Text="*Logradouro:"></asp:Label>
                        <asp:TextBox class="form-control" MaxLength="100" ID="txtLogradouro" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-2">
                    <div class="form-group">
                        <asp:Label ID="lblNumero" runat="server" Text="*Número:"></asp:Label>
                        <asp:TextBox class="form-control" MaxLength="10" ID="txtNumero" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-3">
                    <div class="form-group">
                        <asp:Label ID="lblCidade" runat="server" Text="*Cidade:"></asp:Label>
                        <asp:TextBox class="form-control" MaxLength="50" ID="txtCidade" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-3">
                    <div class="form-group">
                        <asp:Label ID="lblEstado" runat="server" Text="*Estado:"></asp:Label>
                        <asp:TextBox class="form-control" MaxLength="50" ID="txtEstado" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-3">
                    <div class="form-group">
                        <asp:Label ID="lblAgencia" runat="server" Text="*Agência:"></asp:Label>
                        <asp:TextBox class="form-control" MaxLength="10" ID="txtAgencia" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-3">
                    <div class="form-group">
                        <asp:Label ID="lblContaCorrente" runat="server" Text="*Conta Corrente:"></asp:Label>
                        <asp:TextBox class="form-control" MaxLength="10" ID="txtContaCorrente" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-6">
                    <div class="form-group">
                        <asp:Label ID="lblbanco" runat="server" Text="*Banco:"></asp:Label>
                        <asp:TextBox class="form-control" MaxLength="50" ID="txtBanco" runat="server"></asp:TextBox>
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
                        <asp:BoundField DataField="Cnpj" HeaderText="CNPJ" />
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Email" HeaderText="E-mail" />
                        <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                        <asp:BoundField DataField="Logradouro" HeaderText="Logradouro" />
                        <asp:BoundField DataField="Numero" HeaderText="Número" />
                        <asp:BoundField DataField="Cidade" HeaderText="Cidade" />
                        <asp:BoundField DataField="Estado" HeaderText="Estado" />
                        <asp:BoundField DataField="Agencia" HeaderText="Agência" />
                        <asp:BoundField DataField="ContaCorrente" HeaderText="Conta Corrente" />
                        <asp:BoundField DataField="Banco" HeaderText="Banco" />
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
