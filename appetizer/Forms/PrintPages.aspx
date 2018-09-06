<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="PrintPages.aspx.cs" Inherits="appetizer.Forms.PrintPages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <link href="../Content/css/print.css" rel="stylesheet" />
   <script type="text/javascript">
       function printForm() {
           var prtContent = document.getElementById("PrintMe");
           var WinPrint = window.open('', '', 'letf=0,top=0,width=800,height=900,toolbar=0,scrollbars=0,status=0');
           var finalTagWithCSS = "<html><head><link href=\"../Content/css/print.css\" rel=\"stylesheet\" /></head><body>" + prtContent.outerHTML + "</body></html>";
           WinPrint.document.write(finalTagWithCSS);
           WinPrint.document.close();
           WinPrint.focus();
           WinPrint.print();
           WinPrint.close();

       }
   </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="Panel1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="چاپ!" OnClientClick="printForm();" />
        <div id="PrintMe">
            <%= get_multi_page_html()%>
        </div>
    </asp:Panel>
</asp:Content>
