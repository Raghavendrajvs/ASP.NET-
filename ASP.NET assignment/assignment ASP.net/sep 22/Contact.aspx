<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="sep_22.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        1st & 2nd Floor, MJR Arcade, Khanamet, Gurukul Society<br />
        Landmark: Near Meridian School<br />
        Madhapur, Hyderabad – 500081 <br />
        <abbr title="Phone">P:</abbr>
       +91–40–67333777 / 67333733
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:info@acuvate.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:info@acuvate.com">Marketing@example.com</a>
    </address>
</asp:Content>
