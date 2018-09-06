<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="app_menu.ascx.cs" Inherits="appetizer.app_menu" %>
 <nav class="navbar navbar-inverse  navbar-fixed-top">
      <%= GetDossierInfo() %>
                <% if (!String.IsNullOrEmpty(get_login_name()))
                 { %>
    <div style="z-index:10000;direction:rtl;position:absolute; left:5px">
          <table style="width: 100%; grid-cell:none">
              <tr>
                  <td><asp:Label runat="server" ID="lblClasse">&nbsp;کلاسه پرونده:</asp:Label></td>
                  <td><asp:TextBox ID="txtClasse" runat="server"></asp:TextBox></td>
                  <td><asp:Button ID="btnHeaderSearchDossierByClasse" runat="server" Text="جستجو" CssClass="btn btn-default" OnClick="btnHeaderSearchDossierByClasse_Click"/></td>
                  <td><asp:DropDownList ID="HeaderDeclarationList"   runat="server">
                          <asp:ListItem Value="-1">انتخاب نشده</asp:ListItem>
                      </asp:DropDownList>
                  </td>
                  <td><asp:Button ID="btnHeaderSelectDeclaration" runat="server" Text="انتخاب" CssClass="btn btn-default" OnClick="btnHeaderSelectDeclaration_Click"/></td>
                  <td>&nbsp;</td>
              </tr>
          </table>
      </div>     <%--   <%= get_search_bar_menu() %>--%>
              <% } %>
     <br />
     <br />
  <div class="container-fluid">
    <div class="navbar-header">
      <a class="navbar-brand glyphicon glyphicon-plane" href="/Index.aspx">Appetizer</a>
    </div>
      <div style="direction:rtl;">
          <ul class="nav navbar-nav navbar-right">
              <li><a href="/Forms/EditDead.aspx">مشخصات متوفی</a></li>
              <% if (!String.IsNullOrEmpty(get_login_name()))
                 { %>
             <%= get_dynamic_menu() %>
              <% } %>
          </ul>
          <ul class="nav navbar-nav  navbar-left">
              <% if (!String.IsNullOrEmpty(get_login_name()))
                 { %>
              <li><a href="#"><span class="glyphicon glyphicon-user"></span>&nbsp;<%= get_login_name() %></a></li>
              <% } %>
              <% if (String.IsNullOrEmpty(get_login_name()))
                 { %>
              <li><a href="/Login.aspx"><span class="glyphicon glyphicon-log-in"></span>&nbsp;ورود</a></li>
              <% } %>
              <% else
                 { %>
              <li><a href="/Login.aspx?logout=1"><span class="glyphicon glyphicon-log-out"></span>&nbsp;خروج</a></li>
              <% } %>
          </ul>
      </div>
      <script type="text/javascript">
          if (location.pathname.match(/Login.aspx/i)) $('a[href="/Login.aspx"]').parent().addClass('active');
          if (location.pathname.match(/Forms\/EditDead.aspx/i)) $('a[href="/Forms/EditDead.aspx"]').parent().addClass('active');
          if (location.pathname.match(/Index.aspx/i)) $('a[href="/Index.aspx"]').parent().addClass('active');
          if (location.pathname.match(/Forms\/HeirCombination.aspx/i)) $('a[href="/Forms/HeirCombination.aspx"]').parent().addClass('active');
          if (location.pathname.match(/Forms\/SelectCurrentDossier.aspx/i)) $('a[href="/Forms/SelectCurrentDossier.aspx"]').parent().addClass('active');
          if (location.pathname.match(/Forms\/DossierUserAssignment.aspx/i)) $('a[href="/Forms/DossierUserAssignment.aspx"]').parent().addClass('active');
          if (location.pathname.match(/Forms\/BankAccounts.aspx/i)) $('a[href="/Forms/BankAccounts.aspx"]').parent().addClass('active');
          if (location.pathname.match(/Forms\/PrintPages.aspx/i)) $('a[href="/Forms/PrintPages.aspx"]').parent().addClass('active');
      </script>
  </div>
</nav>
