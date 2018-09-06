<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="appetizer.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" style="direction:rtl;" CssClass="jumbotron">
        <br />
        <br />
        <div style="width:300px;" class="center-block">
            <h2 class="form-signin-heading">ورود به سیستم</h2>
        <asp:Label ID="lblUserName" runat="server" Text="نام کاربری:"></asp:Label><asp:TextBox ID="txtUserName" CssClass="form-control" runat="server" placeholder="نام کاربری"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="alert-danger" ErrorMessage="وارد کردن نام کاربری الزامی است" ControlToValidate="txtUserName"></asp:RequiredFieldValidator><br />
        <asp:Label ID="lblPassword" runat="server" Text="کلمه عبور:"></asp:Label><asp:TextBox ID="txtPasswod" CssClass="form-control" runat="server" TextMode="Password" placeholder="پسورد"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="alert-danger" ErrorMessage="وارد کردن پسورد الزامی است" ControlToValidate="txtPasswod"></asp:RequiredFieldValidator><br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-lg btn-primary btn-block" Text="ورود" OnClick="btnSubmit_Click" />

        </div>
    </asp:Panel>
</asp:Content>
