<%@ Page Title="" Language="C#" MasterPageFile="~/Phonetoys2.Master" AutoEventWireup="true" CodeBehind="MinSida.aspx.cs" Inherits="PhoneToys.MinSida" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="row-vanster" style="border: 1px solid black">
            <div class="large-6 medium-6 small-6 column">
                <asp:Label runat="server" Text="Dina Uppgifter"></asp:Label>

                <asp:Label runat="server" Text=""></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="row-hoger" style="border: 1px solid black">
                <div class="large-6 medium-6 small-6 column">
                    <asp:Label ID="Label1" runat="server" Text="Dina Uppgifter"></asp:Label>

                </div>
            </div>
        </div>
    </div>
    <%--<div class="row">
        <div class="row-hoger" style="border: 1px solid black">
            <div class="large-6 medium-6 small-6 column">
                <asp:Label ID="Label2" runat="server" Text="Dina Uppgifter"></asp:Label>

            </div>
        </div>
    </div>--%>
</asp:Content>
