<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="HeirCombination.aspx.cs" Inherits="appetizer.Forms.HeirCombination" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" BorderStyle="Inset" BorderColor="Green">
        <br />
        <table style="width: 100%">
            <tr>
                <td style="width: 30%; vertical-align:top;">
                    <%GetHeirNodesCaption(); %>
                    <asp:TreeView ID="tvControl" ShowLines="true" SelectedNodeStyle-BackColor="Black" SelectedNodeStyle-ForeColor="White" runat="server" OnSelectedNodeChanged="tvControl_SelectedNodeChanged">
                        <DataBindings>
                            <asp:TreeNodeBinding DataMember="System.Data.DataRowView"
                                TextField="FullName" ValueField="HeirID" />
                        </DataBindings>
                    </asp:TreeView>
                </td>
                <td style="width: 70%;">
                    <table style="width: 100%; direction: rtl; text-align:left;">
                        <tr>
                             <td>
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                                    <asp:ListItem Value="1">طبقه اول</asp:ListItem>
                                    <asp:ListItem Value="2">طبقه دوم</asp:ListItem>
                                    <asp:ListItem Value="3">طبقه سوم</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                           <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td><br /></td>
                        </tr>
                    </table>
                    <table style="width: 100%; direction: rtl">
                        <tr>
                            <td style="text-align:left;direction:rtl; padding-left:5px;">
                                <%= get_caption("Heir", "Name")%>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="HeirName"></asp:TextBox>

                            </td>

                        </tr>
                        <tr>
                            <td style="text-align:left;direction:rtl; padding-left:5px;">
                                <%= get_caption("Heir", "Family")%>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="HeirFamily"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:left;direction:rtl; padding-left:5px;">
                                <%= get_caption("Heir", "NationalCode")%>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="HeirNationalCode"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:left;direction:rtl; padding-left:5px;">
                                <%= get_caption("Heir", "GenderID")%>
                            </td>
                            <td>
                                <asp:DropDownList ID="HeirGender" runat="server" CssClass="btn btn-default dropdown-toggle btn-select1" Width="100%" AppendDataBoundItems="True">
                                    <asp:ListItem Value="-1">انتخاب نشده</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:left;direction:rtl; padding-left:5px;">
                                <%= get_caption("Heir", "RelationID")%>
                            </td>
                            <td>
                                <asp:DropDownList ID="HeirRelation" runat="server" CssClass="btn btn-default dropdown-toggle btn-select1" Width="100%" AppendDataBoundItems="True">
                                    <asp:ListItem Value="-1">انتخاب نشده</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:left;direction:rtl; padding-left:5px;">
                                <%= get_caption("Heir", "PhysicalStateID")%>
                            </td>
                            <td>
                                <asp:DropDownList ID="HeirPhysicalState" runat="server" CssClass="btn btn-default dropdown-toggle btn-select1" Width="100%" AppendDataBoundItems="True">
                                    <asp:ListItem Value="-1">انتخاب نشده</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:left;direction:rtl; padding-left:5px;">
                                <%= get_caption("Heir", "EducationStateID")%>
                            </td>
                            <td>
                                <asp:DropDownList ID="HeirEducationState" runat="server" CssClass="btn btn-default dropdown-toggle btn-select1" Width="100%" AppendDataBoundItems="True">
                                    <asp:ListItem Value="-1">انتخاب نشده</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:left;direction:rtl; padding-left:5px;">
                                <%= get_caption("Heir", "MarriageID")%>
                            </td>
                            <td>
                                <asp:DropDownList ID="HeirMarriage" runat="server" CssClass="btn btn-default dropdown-toggle btn-select1" Width="100%" AppendDataBoundItems="True">
                                    <asp:ListItem Value="-1">انتخاب نشده</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td><br /></td>
                            <td><br /></td>
                        </tr>
                        <tr style="text-align: left;">
                            <td>

                            </td>
                            <td style="text-align: left;margin:5px;">
                                <asp:Button runat="server" ID="btnDeleteHeir" Text="حذف شود" Style="float: left;padding:5px" OnClick="btnDeleteHeir_Click" ForeColor="Red" />
                                <asp:Button runat="server" ID="btnAddHeir" Text="اضافه شود" Style="float: left;padding:5px" OnClick="btnAddHeir_Click" />

                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
