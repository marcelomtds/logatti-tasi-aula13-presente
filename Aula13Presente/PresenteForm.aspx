﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PresenteForm.aspx.cs" Inherits="Aula13Presente.PresenteForm" %>

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
                <div class="col-4">
                    <div class="form-group">
                        <asp:Label ID="lblTipo" runat="server" Text="*Tipo:"></asp:Label>
                        <asp:DropDownList class="form-control" ID="ddlTipo" runat="server"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="row">
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
            </div>
            <div class="row">
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
                        <asp:BoundField DataField="Tamanho" HeaderText="Tamanho" />
                        <asp:BoundField DataField="Cor" HeaderText="Cor" />
                        <asp:BoundField DataField="Preco" HeaderText="Preço" />
                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                        <asp:BoundField DataField="Marca" HeaderText="Marca" />
                        <asp:BoundField DataField="Finalidade" HeaderText="Finalidade" />
                        <asp:BoundField DataField="Fornecedor" HeaderText="Fornecedor" />
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
