<%@ Page Title="" Language="C#" MasterPageFile="~/Phonetoys2.Master" AutoEventWireup="true" CodeBehind="SagoUpload.aspx.cs" Inherits="PhoneToys.WebForm2" %>

<%@ Import Namespace="System.Data" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="Content/PhonetoysCSS.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <div class="uploadSagaContent">
        <div class="uploadSagaDiv">

            <asp:Label ID="Label2" runat="server" AssociatedControlID="besTB" Text="Beskrivning" ForeColor="Tomato"></asp:Label>
            <asp:TextBox runat="server" ID="besTB"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Längd" AssociatedControlID="LangdTB" ForeColor="Tomato"></asp:Label>
            <asp:TextBox runat="server" ID="LangdTB"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Pris" AssociatedControlID="PrisTB" ForeColor="Tomato"></asp:Label>
            <asp:TextBox runat="server" ID="PrisTB"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Välj fil" ForeColor="Tomato"></asp:Label>
            <asp:FileUpload runat="server" ID="minUpload" />

            <br />
            <asp:Button runat="server" ID="UploadBTN" OnClick="UploadBTN_Click" Text="Ladda Upp" />
             
        </div>
        <br />
        <br />

        <div class="sagorDivUploadPage">
            <asp:UpdatePanel runat="server" ID="sagoPanel">
                <ContentTemplate>
                    <asp:Repeater runat="server" ID="sagoGrid" OnItemCommand="sagoGrid_ItemCommand">
                        <HeaderTemplate>
                            <table border="0" width="400px">
                                <tr>
                                    <th align="left">Titel</th>
                                    <th align="left">Beskrivning</th>
                                    <th align="left">Pris</th>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <%--<%#Container.DataItem("Namn")%>
                        <%#Container.DataItem("Beskrivning") %>
                        <%#Container.DataItem("Namn") %>--%>
                                <td>
                                    <asp:Label runat="server" ID="namn" Text='<%#Eval("Namn") %>'></asp:Label></td>
                                <td>
                                    <asp:TextBox CssClass="descriptionTB" runat="server" TextMode="MultiLine" Enabled="false" Text='<%#Eval("Beskrivning") %>'></asp:TextBox></td>
                                <td><%#Eval("Pris") %></td>
                                <td>
                                    <asp:LinkButton CommandName="edit" runat="server" Text="Redigera"></asp:LinkButton></td>
                                <td class="uploadSagaRemoveBTN">
                                    <asp:LinkButton CssClass="uploadSagaRemoveBTN" CommandName="remove" runat="server" Text="Ta bort"></asp:LinkButton></td>
                            </tr>
                        </ItemTemplate>
                        <SeparatorTemplate>
                            <tr>
                                <td colspan="0">
                                    <hr />
                                </td>
                            </tr>
                        </SeparatorTemplate>
                        <FooterTemplate></table></FooterTemplate>
                    </asp:Repeater>
                </ContentTemplate>
                <%--<Triggers>
                <asp:AsyncPostBackTrigger ControlID="sagoPanel" />
            </Triggers>--%>
            </asp:UpdatePanel>

            <%--<asp:GridView runat="server" ID="sagoGrid" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Namn"></asp:BoundField>
                <asp:BoundField DataField="Langd"></asp:BoundField>
                <asp:BoundField DataField="Pris"></asp:BoundField>
                <asp:ButtonField ButtonType="Link" Text="Redigera"></asp:ButtonField>
                <asp:ButtonField ButtonType="Link" Text="Ta bort"></asp:ButtonField>
            </Columns>
        </asp:GridView>--%>
        </div>
    </div>
</asp:Content>
