<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebCalculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
         <div class="calc">
            <table>
                <tr>
                    <td colspan="4">
                        <asp:TextBox id="tbInput" Text="0" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                       <asp:TextBox id="tbResult" Text="0" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button Text="CE" runat="server" OnClick="CE_Click" />
                    </td>
                    <td>
                        <asp:Button Text="C" runat="server" OnClick="C_Click"/>
                    </td>
                    <td>
                        <asp:Button Text="←" runat="server" OnClick="Del_Click"/>
                    </td>
                    <td>
                        <asp:Button Text="/" runat="server" OnClick="Operator_Click"  />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button Text="7" runat="server" OnClick="Number_Click" />
                    </td>
                    <td>
                        <asp:Button Text="8" runat="server" OnClick="Number_Click" />
                    </td>
                    <td>
                        <asp:Button Text="9" runat="server" OnClick="Number_Click" />
                    </td>
                    <td>
                        <asp:Button Text="*" runat="server"  OnClick="Operator_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button Text="4" runat="server" OnClick="Number_Click"/>
                    </td>
                    <td>
                        <asp:Button Text="5" runat="server" OnClick="Number_Click"/>
                    </td>
                    <td>
                        <asp:Button Text="6" runat="server" OnClick="Number_Click"/>
                    </td>
                    <td>
                        <asp:Button Text="-" runat="server"  OnClick="Operator_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button Text="1" runat="server" OnClick="Number_Click"/>
                    </td>
                    <td>
                        <asp:Button Text="2" runat="server" OnClick="Number_Click"/>
                    </td>
                    <td>
                        <asp:Button Text="3" runat="server" OnClick="Number_Click" />
                    </td>
                    <td>
                        <asp:Button Text="+" runat="server" OnClick="Operator_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button Text="±" runat="server" OnClick="Sign_Click"/>
                    </td>
                    <td>
                        <asp:Button Text="0" runat="server" OnClick="Number_Click"/>
                    </td>
                    <td>
                        <asp:Button Text="," runat="server"  OnClick="Number_Click" />
                    </td>
                    <td>
                        <asp:Button Text="=" runat="server" OnClick="Operator_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
