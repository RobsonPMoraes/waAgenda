﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagePrincipal.Master" AutoEventWireup="true" CodeBehind="Contatos.aspx.cs" Inherits="waAgenda.Contatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Inserir novo usuário"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label>
    <br />
    <asp:TextBox ID="txbNome" runat="server" Width="400px"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="E-mail"></asp:Label>
    <br />
    <asp:TextBox ID="txbEmail" runat="server" Width="400px"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Telefone"></asp:Label>
    <br />
    <asp:TextBox ID="txbTelefone" runat="server" Width="267px"></asp:TextBox>
&nbsp;&nbsp;
    <asp:Button ID="btInserir" runat="server" Height="30px" OnClick="Button1_Click" Text="Inserir" Width="120px" />
    <br />
    <asp:Label ID="lListaContatos" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Lista de Contatos"></asp:Label>
<br />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSourceContatos" ForeColor="#333333" GridLines="None" Height="203px" Width="707px">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
        <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
        <asp:BoundField DataField="telefone" HeaderText="telefone" SortExpression="telefone" />
    </Columns>
    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
    <SortedAscendingCellStyle BackColor="#FDF5AC" />
    <SortedAscendingHeaderStyle BackColor="#4D0000" />
    <SortedDescendingCellStyle BackColor="#FCF6C0" />
    <SortedDescendingHeaderStyle BackColor="#820000" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSourceContatos" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Contato] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Contato] ([nome], [email], [telefone]) VALUES (@nome, @email, @telefone)" SelectCommand="SELECT * FROM [Contato]" UpdateCommand="UPDATE [Contato] SET [nome] = @nome, [email] = @email, [telefone] = @telefone WHERE [Id] = @Id">
    <DeleteParameters>
        <asp:Parameter Name="Id" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="nome" Type="String" />
        <asp:Parameter Name="email" Type="String" />
        <asp:Parameter Name="telefone" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="nome" Type="String" />
        <asp:Parameter Name="email" Type="String" />
        <asp:Parameter Name="telefone" Type="String" />
        <asp:Parameter Name="Id" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>
