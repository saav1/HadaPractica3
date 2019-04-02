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
        &nbsp;NIF:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="textBoxNIF" runat="server" Height="22px" Width="461px"></asp:TextBox>
        <br />
        <br />
        &nbsp;NOMBRE:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="textBoxNombre" runat="server" Height="22px" Width="461px"></asp:TextBox>
        <br />
        <br />
        &nbsp;APELLIDOS&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="textBoxApellidos" runat="server" Height="22px" Width="461px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="button1" runat="server" Text="Leer" OnClick ="leer"/>
&nbsp;
        <asp:Button ID="button2" runat="server" Text="Leer Primero" OnClick ="leerPrimero"/>
&nbsp;
        <asp:Button ID="button3" runat="server" Text="Leer Anterior" OnClick ="leerAnterior"/>
&nbsp;
        <asp:Button ID="button4" runat="server" Text="Leer Siguiente" OnClick ="leerSiguiente"/>
&nbsp;
        <asp:Button ID="button5" runat="server" Text="Crear" OnClick ="crear"/>
&nbsp;
        <asp:Button ID="button6" runat="server" Text="Actualizar" OnClick ="actualizar"/>
&nbsp;
        


</asp:Content>