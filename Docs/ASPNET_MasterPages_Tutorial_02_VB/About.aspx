<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="About.aspx.vb" Inherits="About" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>
        About the Author</h2>
                    <p>
                        Hello! My name is Scott Mitchell, and I am the editor, founder, and primary 
                        contributor to <a href="http://www.4guysfromrolla.com/">4GuysFromRolla.com</a>. 
        In addition to founding 4GuysFromRolla.com, I also created
        <a href="http://www.aspfaqs.com/">ASPFAQs.com</a> and
        <a href="http://www.aspmessageboard.com/">ASPMessageboard.com</a>. I work as a 
        freelance writer, trainer, and consultant from San Diego, California.</p>
    <p>
        My primary experience lies in Web development with Microsoft technologies.</p>
</asp:Content>

<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="LeftColumnContent">

    <h3>Scott's Links</h3>
    <ul>
        <li><a href="http://scottonwriting.net/sowblog/">Scott's Blog</a></li>
        <li><a href="http://www.4guysfromrolla.com/ScottMitchell.shtml">Scott's Resume</a></li>
        <li><a href="mailto:mitchell@4guysfromrolla.com">Email Scott</a></li>
    </ul>
</asp:Content>