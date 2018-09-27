<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDescription.aspx.cs" Inherits="Shopping_cart.ProductDescription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 550px;
        }
        .auto-style2 {
            height: 422px;
            position: relative;
            left: 454px;
            top: 17px;
            width: 295px;
        }
        .auto-style3 {
            position: relative;
            left: 48px;
            top: -401px;
            width: 355px;
            height: 465px;
        }
        .auto-style4 {
            position: relative;
            left: 36px;
            top: 37px;
            height: 62px;
            width: 236px;
        }
        .auto-style5 {
            position: relative;
            left: 50px;
            top: 67px;
            height: 36px;
            width: 181px;
        }
        .auto-style6 {
            position: relative;
            left: 48px;
            top: 120px;
            height: 143px;
            width: 202px;
        }
    </style>
</head>
<body style="height: 462px">
    <form id="form1" runat="server">
        <div>
        </div>
        <div class="auto-style1">
            <div class="auto-style2">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style4"></asp:TextBox>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style5"></asp:TextBox>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style6"></asp:TextBox>
            </div>
            <asp:Image ID="Image1" runat="server" CssClass="auto-style3" />
            
        </div>
    </form>
</body>
</html>
