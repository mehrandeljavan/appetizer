<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="MultipleContentPlaceHolders.aspx.vb" Inherits="MultipleContentPlaceHolders" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>Using Multiple ContentPlaceHolder Controls</h2>
    <p>
        This demo illustrates how to define multiple ContentPlaceHolder controls in the master page.
    </p>
    <p>
        Specifically, the master page has two ContentPlaceHolders within the Web Form:
    </p>
    <ul>
        <li>MainContent</li>
        <li>LeftColumnContent</li>
    </ul>
    <p>
        The markup for these two ContentPlaceHolder controls are specified within separate Content
        controls from the content page.
    </p>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="LeftColumnContent" Runat="Server">
    <h3>Page-Specific Content</h3>
    <ul>
        <li>This content is defined in the content page.</li>
        <li>The master page has two regions in the Web Form that are editable on a
            page-by-page basis.</li>
    </ul>
</asp:Content>

