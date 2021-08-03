<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="WebFormsVazio.Lista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/css/page.css" rel="stylesheet" />
    <link href="Content/css/style.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="animes">
        <h1>Animes</h1>
        <br>
        <thead>
            <tr>
                <th>ID</th>
                <th>Nome</th>
                <th>Gêneros</th>
                <th>Quant. Temporadas</th>
                <th>Quant. Episódios</th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>
</asp:Content>
