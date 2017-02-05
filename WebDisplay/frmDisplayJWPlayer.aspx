<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDisplayJWPlayer.aspx.cs" Inherits="WebDisplay.frmDisplayJWPlayer" %>

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
            <div id="mediaplayer1">JW Player goes here</div>
            <script type="text/javascript" src="JWPlayer/jwplayer.js"></script>
	
            <script type="text/javascript">
		
                jwplayer("mediaplayer1").setup({
                    flashplayer: "JWPlayer/player.swf",
                    file: "https://tescolotuslc.com/learningcenterstaging/storage/document/2017/01/25/08/4611/20170125-083104.doc1mp4.mp4",
                     image: "preview.jpg",
                     autostart: true,
                     //modes: [
                     //    {
                     //        type: "html5",
                     //        config: {
                     //            file: "https://tescolotuslc.com/learningcenterstaging/storage/document/2017/01/25/08/4611/20170125-083104.doc1mp4.mp4"
                     //        }
                     //    }
                     //]
                });
	
            </script>
        
        </div>
    </form>
</body>
</html>
