<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="PhoneToys.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<asp:ListView runat="server" ID="ListViewAdmin">
 <LayoutTemplate>
     <asp:PlaceHolder runat="server" ID="groupPlaceholder">

     </asp:PlaceHolder>

 </LayoutTemplate>
<GroupTemplate>
    <div class="large-8" ID="itemPlaceholder" runat="server">
        <div class="row">



        </div>


    </div>

</GroupTemplate>
<ItemTemplate>


</ItemTemplate>

</asp:ListView>
</asp:Content>

