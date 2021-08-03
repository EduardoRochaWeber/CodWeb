<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="WebFormsVazio.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/css/style.css" rel="stylesheet" />
    <link href="Content/css/page.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
        <div id="tela-cadastro">
            <div class="form-item" id="Id">
                <label for="id">ID:<br></label><asp:TextBox ID="txtId" runat="server" CssClass="id"></asp:TextBox>
            </div>
            <div class="form-item" id="Nome">
                <label for="nome">Nome:<br></label><asp:TextBox ID="txtNome" runat="server" CssClass="nome"></asp:TextBox>
            </div>
            <div class="form-item" id="Genero">
                <label for="genero">Gênero:<br></label><asp:TextBox ID="txtGenero" runat="server" CssClass="genero"></asp:TextBox>
            </div>
            <div class="form-item" id="QtTp">
                <label for="qtTp">Quantidade de temporadas:<br></label><asp:TextBox ID="txtQtTp" runat="server" CssClass="qtTp"></asp:TextBox>
            </div>
            <div class="form-item" id="QtEp">
                <label for="qtEp">Quantidade de eposídios:<br></label><asp:TextBox ID="txtQtEp" runat="server" CssClass="qtEp"></asp:TextBox>
            </div>
            <div class="form-item" id="Salvar">
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="botao-principal" OnClick="btnSalvar_Click"/>
            </div>
        </div>
</asp:Content>
