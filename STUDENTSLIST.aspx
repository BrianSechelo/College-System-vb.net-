<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="STUDENTSLIST.aspx.vb" Inherits="collegesyst.STUDENTSLIST" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Select1
        {
            width: 144px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <div style="height: 374px">
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
            <AlternatingItemTemplate>
                <tr style="background-color:#FFF8DC;">
                    <td>
                        <asp:Label ID="FirstnameLabel" runat="server" Text='<%# Eval("Firstname") %>' />
                    </td>
                    <td>
                        <asp:Label ID="SecondnameLabel" runat="server" 
                            Text='<%# Eval("Secondname") %>' />
                    </td>
                    <td>
                        <asp:Label ID="RegnoLabel" runat="server" Text='<%# Eval("Regno") %>' />
                    </td>
                    <td>
                        <asp:Label ID="mobilenoLabel" runat="server" Text='<%# Eval("mobileno") %>' />
                    </td>
                    <td>
                        <asp:Label ID="idnoLabel" runat="server" Text='<%# Eval("idno") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CoursetypeLabel" runat="server" 
                            Text='<%# Eval("Coursetype") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="background-color:#008A8C;color: #FFFFFF;">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" 
                            Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                            Text="Cancel" />
                    </td>
                    <td>
                        <asp:TextBox ID="FirstnameTextBox" runat="server" 
                            Text='<%# Bind("Firstname") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="SecondnameTextBox" runat="server" 
                            Text='<%# Bind("Secondname") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="RegnoTextBox" runat="server" Text='<%# Bind("Regno") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="mobilenoTextBox" runat="server" 
                            Text='<%# Bind("mobileno") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="idnoTextBox" runat="server" Text='<%# Bind("idno") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="CoursetypeTextBox" runat="server" 
                            Text='<%# Bind("Coursetype") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" 
                    style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>
                            No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" 
                            Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                            Text="Clear" />
                    </td>
                    <td>
                        <asp:TextBox ID="FirstnameTextBox" runat="server" 
                            Text='<%# Bind("Firstname") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="SecondnameTextBox" runat="server" 
                            Text='<%# Bind("Secondname") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="RegnoTextBox" runat="server" Text='<%# Bind("Regno") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="mobilenoTextBox" runat="server" 
                            Text='<%# Bind("mobileno") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="idnoTextBox" runat="server" Text='<%# Bind("idno") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="CoursetypeTextBox" runat="server" 
                            Text='<%# Bind("Coursetype") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="background-color:#DCDCDC;color: #000000;">
                    <td>
                        <asp:Label ID="FirstnameLabel" runat="server" Text='<%# Eval("Firstname") %>' />
                    </td>
                    <td>
                        <asp:Label ID="SecondnameLabel" runat="server" 
                            Text='<%# Eval("Secondname") %>' />
                    </td>
                    <td>
                        <asp:Label ID="RegnoLabel" runat="server" Text='<%# Eval("Regno") %>' />
                    </td>
                    <td>
                        <asp:Label ID="mobilenoLabel" runat="server" Text='<%# Eval("mobileno") %>' />
                    </td>
                    <td>
                        <asp:Label ID="idnoLabel" runat="server" Text='<%# Eval("idno") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CoursetypeLabel" runat="server" 
                            Text='<%# Eval("Coursetype") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table ID="itemPlaceholderContainer" runat="server" border="1" 
                                style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                    <th runat="server">
                                        Firstname</th>
                                    <th runat="server">
                                        Secondname</th>
                                    <th runat="server">
                                        Regno</th>
                                    <th runat="server">
                                        mobileno</th>
                                    <th runat="server">
                                        idno</th>
                                    <th runat="server">
                                        Coursetype</th>
                                </tr>
                                <tr ID="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" 
                            style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                                        ShowLastPageButton="True" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                    <td>
                        <asp:Label ID="FirstnameLabel" runat="server" Text='<%# Eval("Firstname") %>' />
                    </td>
                    <td>
                        <asp:Label ID="SecondnameLabel" runat="server" 
                            Text='<%# Eval("Secondname") %>' />
                    </td>
                    <td>
                        <asp:Label ID="RegnoLabel" runat="server" Text='<%# Eval("Regno") %>' />
                    </td>
                    <td>
                        <asp:Label ID="mobilenoLabel" runat="server" Text='<%# Eval("mobileno") %>' />
                    </td>
                    <td>
                        <asp:Label ID="idnoLabel" runat="server" Text='<%# Eval("idno") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CoursetypeLabel" runat="server" 
                            Text='<%# Eval("Coursetype") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:DrivingConnectionString %>" 
            SelectCommand="SELECT * FROM [student]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
