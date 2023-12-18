<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="COLLEGE SYSTEM.aspx.vb" Inherits="collegesyst.COLLEGE_SYSTEM" MasterPageFile="~/online.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color: #FFFFFF">
    
    </div>
    <table class="style1" 
        
        style="padding: 20px; margin: 0px 20px 20px 1px; background-color: #0099CC; height: 453px;">
        <tr>
            <td style="padding: 20px; margin: 20px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" BackColor="#CCCCCC" Font-Bold="True" 
                    Font-Size="XX-Large" Height="84px" PostBackUrl="~/Registration.aspx" 
                    Text="STUDENTS" Width="249px" />
            </td>
            <td style="padding: 20px; margin: 20px">
                <asp:Button ID="Button2" runat="server" BackColor="#CCCCCC" Font-Bold="True" 
                    Font-Size="XX-Large" ForeColor="Black" Height="84px" 
                    PostBackUrl="~/LICENSE.aspx" Text="LICENSE" Width="250px" />
            </td>
        </tr>
        <tr>
            <td style="padding: 20px; margin: 20px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button3" runat="server" BackColor="#CCCCCC" 
                    Font-Bold="True" Font-Size="XX-Large" Height="84px" PostBackUrl="~/Fees.aspx" 
                    Text="FINANCE" Width="249px" />
            </td>
            <td style="padding: 20px; margin: 20px">
                <asp:Button ID="Button4" runat="server" BackColor="#CCCCCC" Font-Bold="True" 
                    Font-Size="XX-Large" Height="84px" PostBackUrl="~/Resources.aspx" 
                    Text="RESOURCE" Width="249px" />
            </td>
        </tr>
        <tr>
            <td style="padding: 20px; margin: 20px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button5" runat="server" BackColor="#CCCCCC" Font-Bold="True" 
                    Font-Size="XX-Large" Height="84px" PostBackUrl="~/Instructor.aspx" Text="STAFF" 
                    Width="249px" />
            </td>
            <td style="padding: 20px; margin: 20px">
                <asp:Button ID="Button6" runat="server" BackColor="#CCCCCC" Font-Bold="True" 
                    Font-Size="XX-Large" Height="84px" PostBackUrl="~/Login.aspx" Text="EXIT" 
                    Width="249px" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </asp:content>
