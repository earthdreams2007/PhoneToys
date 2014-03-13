<%@ Page Title="" Language="C#" MasterPageFile="~/Phonetoys2.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PhonetoysWeb.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" href="Content/foundation.css" media="screen" />
    <link rel="stylesheet" href="Content/PhonetoysCSS.css" media="screen" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="row-vanster large-6">

            <div class=" large-6 medium-6 small-12">
                <asp:Label ID="Label10" CssClass="label" runat="server" Text="Användarnamn" ForeColor="Navy"></asp:Label><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="EmailTB" ValidationGroup="register" ErrorMessage="Epost krävs" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="UnameTB" placeholder="Användarnamn" runat="server"></asp:TextBox>
            </div>

            <div class=" large-6 medium-6 small-12">
                <asp:Label ID="Label1" CssClass="label" runat="server" Text="Epost" ForeColor="Navy"></asp:Label><asp:RequiredFieldValidator ID="fv1" runat="server" ControlToValidate="EmailTB" ValidationGroup="register" ErrorMessage="Epost krävs" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="EmailTB" placeholder="E-post" runat="server"></asp:TextBox>
            </div>

            <div class=" large-6 medium-6 small-12">
                <asp:Label ID="Label2" CssClass="label" runat="server" Text="Lösenord" ForeColor="Navy"></asp:Label><asp:RequiredFieldValidator ID="fv2" runat="server" ControlToValidate="PWTB" ValidationGroup="register" ErrorMessage="Lösenord krävs" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="PWTB" runat="server" placeholder="Lösenord" TextMode="Password"></asp:TextBox>
            </div>
            <div class=" large-6 medium-6 small-12">
                <asp:Label ID="Label3" CssClass="label" runat="server" Text="Upprepa lösenord" ForeColor="Navy"></asp:Label><asp:RequiredFieldValidator ID="fv3" runat="server" ControlToValidate="ConfPWTB" ValidationGroup="register" ErrorMessage="Vänligen upprepa lösenordet" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="ConfPWTB" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class=" large-6 medium-6 small-12">
                <asp:Label ID="Label4" CssClass="label" runat="server" Text="Förnamn" ForeColor="Navy"></asp:Label><asp:RequiredFieldValidator ID="fv4" runat="server" ControlToValidate="FnameTB" ValidationGroup="register" ErrorMessage="Förnamn krävs" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="FnameTB" runat="server"></asp:TextBox>
            </div>
            <div class=" large-6 medium-6 small-12">
                <asp:Label ID="Label5" CssClass="label" runat="server" Text="Efternamn" ForeColor="Navy"></asp:Label><asp:RequiredFieldValidator ID="fv5" runat="server" ControlToValidate="LnameTB" ValidationGroup="register" ErrorMessage="Efternamn krävs" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="LnameTB" runat="server"></asp:TextBox>
            </div>
            </div>
            <div class="row-hoger large-6">
            <div class=" large-6 medium-6 small-12">
                <asp:Label ID="Label6" CssClass="label" runat="server" Text="Adress" ForeColor="Navy"></asp:Label><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="AddressTB" ValidationGroup="register" ErrorMessage="Adress krävs" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="AddressTB" runat="server"></asp:TextBox>
            </div>
            <div class=" large-6 medium-6 small-12">
                <asp:Label ID="Label7" CssClass="label" runat="server" Text="Postnummer" ForeColor="Navy"></asp:Label><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ZipTB" ValidationGroup="register" ErrorMessage="Postnummer krävs" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="ZipTB" runat="server"></asp:TextBox>
            </div>

            <div class=" large-6 medium-6 small-12">
                <asp:Label ID="Label8" CssClass="label" runat="server" Text="Stad" ForeColor="Navy"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ValidationGroup="register" ControlToValidate="CityTB" ErrorMessage="Stad krävs" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:TextBox ID="CityTB" runat="server"></asp:TextBox>
            </div>


            <div class=" large-6 medium-6 small-12">
                <asp:Label ID="Label9" CssClass="label" runat="server" Text="Land" ForeColor="Navy"></asp:Label><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ValidationGroup="register" ControlToValidate="CountryDD" ErrorMessage="Vänligen välj land" ForeColor="Red">*</asp:RequiredFieldValidator>
                <%--<br />--%>
                <asp:DropDownList runat="server" ID="countryDD"></asp:DropDownList>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="register" />
                <asp:Button runat="server" CssClass="button radius large-4 medium-3 small-3" ID="registerBTN" Text="Register" ValidationGroup="register" OnClick="registerBTN_Click" />
            </div>
        </div>
    </div>
    <%--<div class="row">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="register" />
            <asp:Button runat="server" CssClass="button radius large-4 medium-3 small-3" ID="Button1" Text="Register" ValidationGroup="register" />
        </div>--%>
    <%-- </div>
    </div>--%>
</asp:Content>
