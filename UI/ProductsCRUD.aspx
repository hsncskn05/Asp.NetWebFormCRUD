﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsCRUD.aspx.cs" Inherits="UI.ProductsCRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged" ></asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text="Ürün Adı"></asp:Label>
        <asp:TextBox ID="txtProduct" runat="server"></asp:TextBox>
         <asp:Label ID="Label2" runat="server" Text="Discontinued"></asp:Label>
        <asp:TextBox ID="txtDiscontinued" runat="server"></asp:TextBox><br />
       
        <asp:Button ID="btnAdd" runat="server" Text="Ekle" OnClick="btnAdd_Click" />
        <asp:Button ID="btnRemove" runat="server" Text="Sil" OnClick="btnRemove_Click"  />
        <asp:Button ID="btnUpdate" runat="server" Text="Güncelle" OnClick="btnUpdate_Click"  />
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>

    </div>
    </form>
</body>
</html>
