<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSample.aspx.cs" Inherits="WebDisplay.frmSample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body >
    <form id="form1" runat="server" >
    <asp:ScriptManager ID="scripmanager1" runat="server"></asp:ScriptManager>
    <div >
       <asp:Literal ID="lit1" runat="server"></asp:Literal>
        <asp:Timer ID="TimerChangeContent" runat="server" OnTick="TimerChangeContent_Tick" Interval="10000">
        </asp:Timer>
    </div>
    </form>
</body>
</html>
