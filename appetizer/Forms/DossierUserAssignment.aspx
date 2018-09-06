<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="DossierUserAssignment.aspx.cs" Inherits="appetizer.Forms.DossierUserAssignment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" Style="direction: rtl; text-align: right;" runat="server">
        <asp:Panel ID="Panel2" runat="server">
            <table style="width: 100%;">
                <tr>
                    <td>&nbsp;شماره ملی</td>
                    <td>&nbsp;<asp:TextBox ID="txtNationalCode" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;نام</td>
                    <td>&nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;نام خانوادگی</td>
                    <td>&nbsp;<asp:TextBox ID="txtFamily" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;<asp:Button ID="btnSearch" runat="server" Text="جستجو" OnClick="btnSearch_Click" /></td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel runat="server" ID="BankDepositGridPanel">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand" DataKeyNames="DossierID" AllowPaging="True" PageSize="5">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775"></AlternatingRowStyle>
                <Columns>
                    <asp:BoundField DataField="NationalCode" HeaderText="NationalCode" SortExpression="NationalCode"></asp:BoundField>
                    <asp:BoundField DataField="FullName" HeaderText="FullName" SortExpression="FullName"></asp:BoundField>
                    <asp:BoundField DataField="DeathDate" HeaderText="DeathDate" SortExpression="DeathDate"></asp:BoundField>
                    <asp:BoundField DataField="CertificateNumber" HeaderText="CertificateNumber" SortExpression="CertificateNumber"></asp:BoundField>
                    <asp:BoundField DataField="DossierID" HeaderText="DossierID" SortExpression="DossierID"></asp:BoundField>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="Button1" runat="server" CausesValidation="False" CommandArgument='<%# Bind("DossierID") %>' CommandName="Select" Text="انتخاب" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#999999"></EditRowStyle>

                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></FooterStyle>

                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></HeaderStyle>

                <PagerStyle HorizontalAlign="Center" BackColor="#284775" ForeColor="White"></PagerStyle>

                <RowStyle BackColor="#F7F6F3" ForeColor="#333333"></RowStyle>

                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>
            </asp:GridView>
        </asp:Panel>
        <asp:Panel ID="PanelAddUser" runat="server">
            <table style="width: 100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;انتخاب کاربر</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;
                        <asp:DropDownList ID="UserList" runat="server" AppendDataBoundItems="True">
                            <asp:ListItem Value="-1">انتخاب نشده</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;
                        <asp:Button ID="btnSelectDeclaration" runat="server" Text="اضافه کردن کاربر" OnClick="btnAddUser_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="PanelDossierUsers" runat="server">
            <asp:GridView ID="GridView2" runat="server" DataSourceID="ObjectDataSourceDossierUsers" EnableModelValidation="True" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="UserNationalCode" ForeColor="Black" GridLines="None" OnRowCommand="GridView2_RowCommand">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:BoundField DataField="UserNationalCode" HeaderText="UserNationalCode" SortExpression="UserNationalCode"></asp:BoundField>
                    <asp:BoundField DataField="DossierID" HeaderText="DossierID" SortExpression="DossierID"></asp:BoundField>
                    <asp:BoundField DataField="UserFullName" HeaderText="UserFullName" SortExpression="UserFullName"></asp:BoundField>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="UserDeleteButton" runat="server" CausesValidation="False" CommandName="DeleteUser" CommandArgument='<%# Bind("UserNationalCode") %>' Text="حذف"></asp:Button>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            </asp:GridView>
        </asp:Panel>
        <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="SearchDossier" TypeName="appetizer.Forms.DossierUserAssignment" DataObjectTypeName="Taxer.Models.Dead"></asp:ObjectDataSource>
        <asp:ObjectDataSource runat="server" ID="ObjectDataSourceDossierUsers" SelectMethod="GetDossierUsers" TypeName="appetizer.Forms.DossierUserAssignment"></asp:ObjectDataSource>
    </asp:Panel>
</asp:Content>
