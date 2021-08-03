<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="WebFormsVazio.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/css/style.css" rel="stylesheet" />
    <link href="Content/css/page.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main>
        <div id="tela-cadastro">
            <div class="form-item">
                <label for="id">ID:<br></label><input type="number" name="id" id="id">
            </div>
            <div class="form-item">
                <label for="nome">Nome:<br></label><input type="text" name="nome" id="nome">
            </div>
            <div class="form-item">
                <label for="genero">Gênero:<br></label><input type="text" name="genero" id="genero">
            </div>
            <div class="form-item">
                <label for="qtTp">Quantidade de temporadas:<br></label><input type="number" name="qtTp" id="qtTp">
            </div>
            <div class="form-item">
                <label for="qtEp">Quantidade de eposídios:<br></label><input type="number" name="qtEp" id="qtEp">
            </div>
            <button id="salvar" onclick="salvar()">Salvar</button>
        </div>
    </main>
</asp:Content>
