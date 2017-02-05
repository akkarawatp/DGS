<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDisplayTemplate1.aspx.cs" Inherits="WebDisplay.frmDisplayTemplate1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="height:100%;" >
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
    <link href="VideoJS/video-js.css" rel="stylesheet">

    <!-- If you'd like to support IE8 -->
    <script src="VideoJS/videojs-ie8.min.js"></script>
</head>
<body >
    <form id="form1" runat="server" >
        <asp:ScriptManager ID="scripmanager1" runat="server"></asp:ScriptManager>
        <div style="overflow:hidden;position:absolute;">
            <table cellpadding="0" cellspacing="0" style="height:100%;width:100%;" >     
                <tr>
                    <td style="width:50%">
                        <asp:Literal ID="litContent1" runat="server"></asp:Literal>
                    </td>
                    <td style="width:50%">
                        <asp:Literal ID="litContent2" runat="server"></asp:Literal>
                    </td>
                </tr>  
            </table>
            <script src="VideoJS/video.js"></script>
        </div>
    </form>
    
</body>
</html>
