<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="BankAccounts.aspx.cs" Inherits="appetizer.Forms.BankAccounts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Style="direction: rtl;">
        <br />
        <br />
        <asp:Panel runat="server" ID="BankAccountDetails" Style="text-align: right; direction: rtl;">
            <asp:Button runat="server" Text="Insert" ID="AddButton" CausesValidation="True" OnClick="AddButton_Click" />
            <asp:FormView Style="width: 80%; margin: 10px; direction: rtl;" ID="FormView" runat="server" DataSourceID="ObjectDataSource2" EnableModelValidation="True" Width="326px" OnItemInserting="FormView_ItemInserting" >
                <EditItemTemplate>
                    <table style="width: 100%; margin: 10px; direction: rtl;">
                        <tr>
                            <td style="width: 50%; margin: 10px; padding:10px;">&nbsp;
                    <%= get_caption("BankDeposit","BankTypeID") %>:<br />
                                <asp:DropDownList SelectedValue='<%# Bind("BankTypeID") %>'
                                    ID="BankTypeIDTextBox"
                                    runat="server"
                                    DataTextField="Title"
                                    DataValueField="BankTypeID"
                                    DataSourceID="BankTypeDataSource" /><br />
                                <%= get_caption("BankDeposit","BankCategoryID") %>:<br />
                                <asp:DropDownList SelectedValue='<%# Bind("BankCategoryID") %>'
                                    ID="ddlStrategies"
                                    runat="server"
                                    DataTextField="Title"
                                    DataValueField="BankCategoryID"
                                    DataSourceID="BankCategoryDataSource" /><br />
                                <%= get_caption("BankDeposit","BankID") %>:<br />
                                <asp:DropDownList SelectedValue='<%# Bind("BankID") %>'
                                    ID="BankIDTextBox"
                                    runat="server"
                                    DataTextField="Title"
                                    DataValueField="BankID"
                                    DataSourceID="BankDataSource" /><br />

                                <%= get_caption("BankDeposit","BankAccountTypeID") %>:<br />
                                <asp:DropDownList SelectedValue='<%# Bind("BankAccountTypeID") %>'
                                    ID="BankAccountTypeIDTextBox"
                                    runat="server"
                                    DataTextField="Title"
                                    DataValueField="BankAccountTypeID"
                                    DataSourceID="BankAccountTypeDataSource" /><br />
                                <%= get_caption("BankDeposit","Branch") %>:
                    <asp:TextBox Text='<%# Bind("Branch") %>' runat="server" ID="BranchTextBox" /><br />
                                <%= get_caption("BankDeposit","City") %>:
                    <asp:TextBox Text='<%# Bind("City") %>' runat="server" ID="CityTextBox" /><br />
                                <%= get_caption("BankDeposit","AccountNumber") %>:
                    <asp:TextBox Text='<%# Bind("AccountNumber") %>' runat="server" ID="AccountNumberTextBox" /><br />
                                <%= get_caption("BankDeposit","CurrencyDeposit") %>:
                    <asp:TextBox Text='<%# Bind("CurrencyDeposit") %>' runat="server" ID="CurrencyDepositTextBox" /><br />
                                <%= get_caption("BankDeposit","DeclarationID") %>:
                    <asp:TextBox Text='<%# Bind("DeclarationID") %>' runat="server" ID="DeclarationIDTextBox" /><br />
                                <%--<%= get_caption("BankDeposit","HeritageID") %>:--%>
                                <asp:TextBox Text='<%# Bind("HeritageID") %>' runat="server" Visible='<%# get_visible("BankDeposit","BankID") %>' ID="HeritageIDTextBox" />
                                <%= get_caption("BankDeposit","StageTitle") %>:
                    <asp:TextBox Text='<%# Bind("StageTitle") %>' runat="server" ID="StageTitleTextBox" /><br />
                                <%= get_caption("BankDeposit","RegisterInformationID") %>:
                    <asp:TextBox Text='<%# Bind("RegisterInformationID") %>' runat="server" ID="RegisterInformationIDTextBox" /><br />
                            </td>
                            <td style="width: 50%; margin: 10px;">
                                 <%= get_caption("BankDeposit","AdjustmentID") %>:
                   <asp:TextBox Text='<%# Bind("AdjustmentID") %>' runat="server" ID="AdjustmentIDTextBox" /><br />
                                <%= get_caption("BankDeposit","CommissionAdjustmentID") %>:
                    <asp:TextBox Text='<%# Bind("CommissionAdjustmentID") %>' runat="server" ID="CommissionAdjustmentIDTextBox" /><br />
                                <%= get_caption("BankDeposit","PreviousOwner") %>:
                    <asp:TextBox Text='<%# Bind("PreviousOwner") %>' runat="server" ID="PreviousOwnerTextBox" /><br />
                                <%= get_caption("BankDeposit","Comment") %>:
                    <asp:TextBox Text='<%# Bind("Comment") %>' runat="server" ID="CommentTextBox" /><br />
                                <%= get_caption("BankDeposit","Sixth") %>:
                    <asp:TextBox Text='<%# Bind("Sixth") %>' runat="server" ID="SixthTextBox" /><br />
                                <%= get_caption("BankDeposit","Stage") %>:
                    <asp:TextBox Text='<%# Bind("Stage") %>' runat="server" ID="StageTextBox" /><br />
                                <%= get_caption("BankDeposit","Value1") %>:
                    <asp:TextBox Text='<%# Bind("Value1") %>' runat="server" ID="Value1TextBox" /><br />
                                <%= get_caption("BankDeposit","Value2") %>:
                    <asp:TextBox Text='<%# Bind("Value2") %>' runat="server" ID="Value2TextBox" /><br />
                                <%= get_caption("BankDeposit","DeadIsOwner") %>:
                    <asp:CheckBox Checked='<%# Bind("DeadIsOwner") %>' runat="server" ID="DeadIsOwnerCheckBox" /><br />
                                <%= get_caption("BankDeposit","IsDiagonesed") %>:
                    <asp:CheckBox Checked='<%# Bind("IsDiagonesed") %>' runat="server" ID="IsDiagonesedCheckBox" /><br />

                            </td>
                            <td>&nbsp;</td>
                        </tr>

                    </table>
                    <asp:Button runat="server" Text="ذخیره" CommandName="Update" ID="UpdateButton" CausesValidation="True" />&nbsp;<asp:Button runat="server" Text="انصراف" CommandName="Cancel" ID="UpdateCancelButton" CausesValidation="False" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    <table style="width: 100%;">
                        <tr>
                            <td style="width: 50%;">&nbsp;
                    <%= get_caption("BankDeposit","AdjustmentID") %>:
                    <asp:TextBox Text='<%# Bind("AdjustmentID") %>' runat="server" ID="AdjustmentIDTextBox" /><br />
                                <%= get_caption("BankDeposit","CommissionAdjustmentID") %>:
                    <asp:TextBox Text='<%# Bind("CommissionAdjustmentID") %>' runat="server" ID="CommissionAdjustmentIDTextBox" /><br />
                                <%= get_caption("BankDeposit","PreviousOwner") %>:
                    <asp:TextBox Text='<%# Bind("PreviousOwner") %>' runat="server" ID="PreviousOwnerTextBox" /><br />
                                <%= get_caption("BankDeposit","Comment") %>:
                    <asp:TextBox Text='<%# Bind("Comment") %>' runat="server" ID="CommentTextBox" /><br />
                                <%= get_caption("BankDeposit","Sixth") %>:
                    <asp:TextBox Text='<%# Bind("Sixth") %>' runat="server" ID="SixthTextBox" /><br />
                                <%= get_caption("BankDeposit","Stage") %>:
                    <asp:TextBox Text='<%# Bind("Stage") %>' runat="server" ID="StageTextBox" /><br />
                                <%= get_caption("BankDeposit","Value1") %>:
                    <asp:TextBox Text='<%# Bind("Value1") %>' runat="server" ID="Value1TextBox" /><br />
                                <%= get_caption("BankDeposit","Value2") %>:
                    <asp:TextBox Text='<%# Bind("Value2") %>' runat="server" ID="Value2TextBox" /><br />
                                <%= get_caption("BankDeposit","DeadIsOwner") %>:
                    <asp:CheckBox Checked='<%# Bind("DeadIsOwner") %>' runat="server" ID="DeadIsOwnerCheckBox" /><br />
                                <%= get_caption("BankDeposit","IsDiagonesed") %>:
                    <asp:CheckBox Checked='<%# Bind("IsDiagonesed") %>' runat="server" ID="IsDiagonesedCheckBox" /><br />
                            </td>
                            <td style="width: 50%;">&nbsp;
                    <%= get_caption("BankDeposit","BankTypeID") %>:
                     <asp:DropDownList SelectedValue='<%# Bind("BankTypeID") %>'
                         ID="BankTypeIDTextBox"
                         runat="server"
                         DataTextField="Title"
                         DataValueField="BankTypeID"
                         DataSourceID="BankTypeDataSource" />
                                <%= get_caption("BankDeposit","BankCategoryID") %>:
                    <asp:DropDownList SelectedValue='<%# Bind("BankCategoryID") %>'
                        ID="ddlStrategies"
                        runat="server"
                        DataTextField="Title"
                        DataValueField="BankCategoryID"
                        DataSourceID="BankCategoryDataSource" />
                                <%= get_caption("BankDeposit","BankID") %>:
                    <asp:DropDownList SelectedValue='<%# Bind("BankID") %>'
                        ID="BankIDTextBox"
                        runat="server"
                        DataTextField="Title"
                        DataValueField="BankID"
                        DataSourceID="BankDataSource" />
                                <%= get_caption("BankDeposit","BankAccountTypeID") %>::
                    <asp:DropDownList SelectedValue='<%# Bind("BankAccountTypeID") %>'
                        ID="BankAccountTypeIDTextBox"
                        runat="server"
                        DataTextField="Title"
                        DataValueField="BankAccountTypeID"
                        DataSourceID="BankAccountTypeDataSource" />
                                <%= get_caption("BankDeposit","Branch") %>:
                    <asp:TextBox Text='<%# Bind("Branch") %>' runat="server" ID="BranchTextBox" /><br />
                                <%= get_caption("BankDeposit","City") %>:
                    <asp:TextBox Text='<%# Bind("City") %>' runat="server" ID="CityTextBox" /><br />
                                <%= get_caption("BankDeposit","AccountNumber") %>:
                    <asp:TextBox Text='<%# Bind("AccountNumber") %>' runat="server" ID="AccountNumberTextBox" /><br />
                                <%= get_caption("BankDeposit","CurrencyDeposit") %>:
                    <asp:TextBox Text='<%# Bind("CurrencyDeposit") %>' runat="server" ID="CurrencyDepositTextBox" /><br />
                                <%= get_caption("BankDeposit","DeclarationID") %>:
                    <asp:TextBox Text='<%# Bind("DeclarationID") %>' runat="server" ID="DeclarationIDTextBox" /><br />
                                <%--<%= get_caption("BankDeposit","HeritageID") %>:--%>
                                <asp:TextBox Text='<%# Bind("HeritageID") %>' runat="server" Visible='<%# get_visible("BankDeposit","BankID") %>' ID="HeritageIDTextBox" />
                                <% if (get_visible("BankDeposit", "BankID")) { %>
                                   <br />
                                <% } %>
                                <%= get_caption("BankDeposit","StageTitle") %>:
                    <asp:TextBox Text='<%# Bind("StageTitle") %>' runat="server" ID="StageTitleTextBox" /><br />
                                <%= get_caption("BankDeposit","RegisterInformationID") %>:
                    <asp:TextBox Text='<%# Bind("RegisterInformationID") %>' runat="server" ID="RegisterInformationIDTextBox" /><br />
                            </td>
                            <td>&nbsp;

                            </td>
                        </tr>

                    </table>
                    <asp:Button runat="server" Text="ذخیره جدید" CommandName="Insert" ID="InsertButton" CausesValidation="True" />&nbsp;<asp:Button runat="server" Text="انصراف" CommandName="Cancel" ID="InsertCancelButton" OnCommand="Insert_Command" CausesValidation="False" />
                </InsertItemTemplate>
                <ItemTemplate>
                    <table style="width: 100%;">
                        <tr>
                            <td style="width: 50%;">&nbsp;
                    <%= get_caption("BankDeposit","BankIDTitle") %>:
                    <asp:Label Text='<%# Bind("BankIDTitle") %>' runat="server" ID="BankIDTitleLabel" /><br />
                                <%= get_caption("BankDeposit","BankAccountTypeIDTitle") %>:
                    <asp:Label Text='<%# Bind("BankAccountTypeIDTitle") %>' runat="server" ID="BankAccountTypeIDTitleLabel" /><br />
                                <%= get_caption("BankDeposit","BankCategoryIDTitle") %>:
                    <asp:Label Text='<%# Bind("BankCategoryIDTitle") %>' runat="server" ID="BankCategoryIDTitleLabel" /><br />
                                <%= get_caption("BankDeposit","BankTypeIDTitle") %>:
                    <asp:Label Text='<%# Bind("BankTypeIDTitle") %>' runat="server" ID="BankTypeIDTitleLabel" /><br />
                                <%= get_caption("BankDeposit","Branch") %>:
                    <asp:Label Text='<%# Bind("Branch") %>' runat="server" ID="BranchLabel" /><br />
                                <%= get_caption("BankDeposit","City") %>:
                    <asp:Label Text='<%# Bind("City") %>' runat="server" ID="CityLabel" /><br />
                                <%= get_caption("BankDeposit","AccountNumber") %>:
                    <asp:Label Text='<%# Bind("AccountNumber") %>' runat="server" ID="AccountNumberLabel" /><br />
                                <%= get_caption("BankDeposit","CurrencyDeposit") %>:
                    <asp:Label Text='<%# Bind("CurrencyDeposit") %>' runat="server" ID="CurrencyDepositLabel" /><br />
                                <%= get_caption("BankDeposit","DeclarationID") %>:
                    <asp:Label Text='<%# Bind("DeclarationID") %>' runat="server" ID="DeclarationIDLabel" /><br />
                                <%--<%= get_caption("BankDeposit","HeritageID") %>:--%>
                                <asp:Label Text='<%# Bind("HeritageID") %>' runat="server" Visible='<%# get_visible("BankDeposit","BankID") %>' ID="HeritageIDLabel" />
                                <%= get_caption("BankDeposit","StageTitle") %>:
                    <asp:Label Text='<%# Bind("StageTitle") %>' runat="server" ID="StageTitleLabel" /><br />
                                <%= get_caption("BankDeposit","RegisterInformationID") %>:
                    <asp:Label Text='<%# Bind("RegisterInformationID") %>' runat="server" ID="RegisterInformationIDLabel" /><br />
                            </td>
                            <td style="width: 50%;">&nbsp;
                    <%= get_caption("BankDeposit","AdjustmentID") %>:
                    <asp:Label Text='<%# Bind("AdjustmentID") %>' runat="server" ID="AdjustmentIDLabel" /><br />
                                <%= get_caption("BankDeposit","CommissionAdjustmentID") %>:
                    <asp:Label Text='<%# Bind("CommissionAdjustmentID") %>' runat="server" ID="CommissionAdjustmentIDLabel" /><br />
                                <%= get_caption("BankDeposit","PreviousOwner") %>:
                    <asp:Label Text='<%# Bind("PreviousOwner") %>' runat="server" ID="PreviousOwnerLabel" /><br />
                                <%= get_caption("BankDeposit","Comment") %>:
                    <asp:Label Text='<%# Bind("Comment") %>' runat="server" ID="CommentLabel" /><br />
                                <%= get_caption("BankDeposit","Sixth") %>:
                    <asp:Label Text='<%# Bind("Sixth") %>' runat="server" ID="SixthLabel" /><br />
                                <%= get_caption("BankDeposit","Stage") %>:
                    <asp:Label Text='<%# Bind("Stage") %>' runat="server" ID="StageLabel" /><br />
                                <%= get_caption("BankDeposit","Value1") %>:
                    <asp:Label Text='<%# Bind("Value1") %>' runat="server" ID="Value1Label" /><br />
                                <%= get_caption("BankDeposit","Value2") %>:
                    <asp:Label Text='<%# Bind("Value2") %>' runat="server" ID="Value2Label" /><br />
                                <%= get_caption("BankDeposit","DeadIsOwner") %>:
                    <asp:CheckBox Checked='<%# Bind("DeadIsOwner") %>' runat="server" ID="DeadIsOwnerCheckBox" Enabled="false" /><br />
                                <%= get_caption("BankDeposit","IsDiagonesed") %>:
                    <asp:CheckBox Checked='<%# Bind("IsDiagonesed") %>' runat="server" ID="IsDiagonesedCheckBox" Enabled="false" /><br />

                            </td>
                            <td>&nbsp;</td>
                        </tr>

                    </table>
                    <asp:Button runat="server" Text="ویرایش" CommandName="Edit" ID="EditButton" CausesValidation="False" />
                </ItemTemplate>
            </asp:FormView>
        </asp:Panel>
        <asp:Panel runat="server" ID="BankDepositGridPanel">
        </asp:Panel>
        <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" SelectMethod="GetBankDeposits" TypeName="appetizer.CommonPage" DataObjectTypeName="Taxer.Models.BankDeposit" UpdateMethod="UpdateBankDeposit" InsertMethod="InsertBankDeposit">
            <SelectParameters>
                <asp:SessionParameter SessionField="CurrentDeclaration" Name="Declaration" Type="Object"></asp:SessionParameter>
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="HeritageID" DataSourceID="ObjectDataSource1" EnableModelValidation="True" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand" PageSize="5">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="BankIDTitle" HeaderText="BankIDTitle" SortExpression="BankIDTitle" />
                <asp:BoundField DataField="BankAccountTypeIDTitle" HeaderText="BankAccountTypeIDTitle" SortExpression="BankAccountTypeIDTitle" />
                <asp:BoundField DataField="BankCategoryIDTitle" HeaderText="BankCategoryIDTitle" SortExpression="BankCategoryIDTitle" />
                <asp:BoundField DataField="BankTypeIDTitle" HeaderText="BankTypeIDTitle" SortExpression="BankTypeIDTitle" />
                <asp:BoundField DataField="HeritageID" HeaderText="HeritageID" SortExpression="HeritageID" />
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" CausesValidation="False" CommandArgument='<%# Bind("HeritageID") %>' CommandName="Select" Text="انتخاب" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:GridView>
        <asp:ObjectDataSource runat="server" ID="ObjectDataSource2" SelectMethod="GetSelectedBankDeposit" TypeName="appetizer.Forms.BankAccounts" DataObjectTypeName="Taxer.Models.BankDeposit" UpdateMethod="UpdateBankDeposit" InsertMethod="InsertBankDeposit" OnInserting="ObjectDataSource2_Inserting">

        </asp:ObjectDataSource>
        <asp:ObjectDataSource runat="server" ID="BankTypeDataSource" SelectMethod="GetListAll" TypeName="Taxer.Models.BankTypeHandler"></asp:ObjectDataSource>
        <asp:ObjectDataSource runat="server" ID="BankCategoryDataSource" SelectMethod="GetListAll" TypeName="Taxer.Models.BankCategoryHandler"></asp:ObjectDataSource>
        <asp:ObjectDataSource runat="server" ID="BankDataSource" SelectMethod="GetListAll" TypeName="Taxer.Models.BankHandler"></asp:ObjectDataSource>
        <asp:ObjectDataSource runat="server" ID="BankAccountTypeDataSource" SelectMethod="GetListAll" TypeName="Taxer.Models.BankAccountTypeHandler"></asp:ObjectDataSource>
    </asp:Panel>
</asp:Content>
