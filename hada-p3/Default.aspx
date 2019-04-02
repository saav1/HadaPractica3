<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="hada_p3.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID ="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>Página de usuario</h3>
        
    <asp:Button ID="title" runat="server" BackColor="#66CCFF" Font-Bold="True" Font-Size="XX-Large" Height="137px" Text="HADA P3 - CURSO 18/19" Width="641px" />
        <br />
        <br />
        PÁGINA DE USUARIO<br />
        <br />
        &nbsp;NIF<br />
        <asp:TextBox ID="textBoxNIF" runat="server" Height="22px" Width="461px"></asp:TextBox>
        <br />
        &nbsp;NOMBRE<br />
        <asp:TextBox ID="textBoxNombre" runat="server" Height="22px" Width="461px"></asp:TextBox>
        <br />
        &nbsp;APELLIDOS<br />
        <asp:TextBox ID="textBoxApellidos" runat="server" Height="22px" Width="461px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="buttonLeer" runat="server" Text="Leer" />
&nbsp;
        <asp:Button ID="buttonLeerPrimero" runat="server" Text="Leer Primero" />
&nbsp;
        <asp:Button ID="buttonLeerAnterior" runat="server" Text="Leer Anterior" />
&nbsp;
        <asp:Button ID="buttonLeerSiguiente" runat="server" Text="Leer Siguiente" />
&nbsp;
        <asp:Button ID="buttonCrear" runat="server" Text="Crear" />
&nbsp;
        <asp:Button ID="buttonActualizar" runat="server" Text="Actualizar" />
&nbsp;
        <asp:Button ID="buttonBorrar" runat="server" Text="Borrar" />
&nbsp;


</asp:Content>