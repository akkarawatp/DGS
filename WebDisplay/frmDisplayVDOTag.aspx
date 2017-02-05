<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDisplayVDOTag.aspx.cs" Inherits="WebDisplay.frmDisplayVDOTag" %>

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
            <embed src='http://192.168.203.1/VDO/Tesco.mp4' width='100%' height='680px' control="false" />
        
        </div>
    </form>
</body>
</html>
