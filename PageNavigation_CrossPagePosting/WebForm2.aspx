<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="PageNavigation_CrossPagePosting.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                                    <table>
                <tr>
                    <td colspan="2">
                        <b>This is Webform 2</b>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Name:</b>
                    </td>
                    <td>
                        <asp:Label ID="lblName" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>
                            Email:
                        </b>
                    </td>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" ></asp:Label>
                    </td>
                </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:Label ID="lblStatus" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                </table>
        </div>
    </form>
</body>
</html>
