<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDisplayWithIFrame.aspx.cs" Inherits="WebDisplay.frmDisplayWithIFrame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body, html{
            height:100%;
            margin:0 0 0 0;
            vertical-align:top;
        }
        div{height:100%;width:100%;}

    </style>
</head>
<body>
    <form id="form1" runat="server" >
        <asp:ScriptManager ID="scripmanager1" runat="server"></asp:ScriptManager>
        <div style="overflow:hidden;position:absolute;">
            <iframe src="http://localhost/VDO/VDO.avi" style="width:100%;height:100%">
            </iframe>
        </div>
    </form>
</body>
</html>
