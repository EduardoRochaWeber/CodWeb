<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="WebFormsVazio.Lista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/css/page.css" rel="stylesheet" />
    <link href="Content/css/style.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
       <h1>Animes</h1>
    <br />
    <asp:GridView ID="dgvAnimes" runat="server" CssClass="tabela" ShowHeaderWhenEmpty="true" CellSpacing="-1"></asp:GridView>
</asp:Content>
