<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="EditDead.aspx.cs" Inherits="appetizer.Forms.EditDead" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Style="direction: rtl;">
        <br />
        <br />
        
        <table class="auto-style1">
            <tr>
                <td style="width: 50%">
                    <asp:Label ID="lblDeadNationalCode" runat="server"> <%= get_caption("Dead","NationalCode") %></asp:Label>
                    <asp:TextBox ID="txtDeadNationalCode" runat="server"></asp:TextBox>
                </td>
                <td style="width: 50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 50%">
                    <asp:Label ID="lblDeadName" runat="server"> <%= get_caption("Dead","Name") %></asp:Label>
                    <asp:TextBox ID="txtDeadName" runat="server"></asp:TextBox>
                </td>
                <td style="width: 50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 50%">
                    <asp:Label ID="lblDeadGender" runat="server"> <%= get_caption("Dead","GenderID") %></asp:Label>
                    <asp:DropDownList ID="cboDeadGender" runat="server" CssClass="btn btn-default dropdown-toggle btn-select1" Width="100%"> </asp:DropDownList>

                </td>
                <td style="width: 50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 50%">&nbsp;</td>
                <td style="width: 50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 50%">&nbsp;</td>
                <td style="width: 50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 50%">&nbsp;</td>
                <td style="width: 50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 50%">&nbsp;</td>
                <td style="width: 50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 50%">&nbsp;</td>
                <td style="width: 50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 50%">&nbsp;</td>
                <td style="width: 50%">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 50%">&nbsp;</td>
                <td style="width: 50%">
                    <asp:Button ID="btnSaveDead" runat="server" Text="ذخیره" OnClick="btnSaveDead_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
