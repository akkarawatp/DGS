<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDisplayVideoJS.aspx.cs" Inherits="WebDisplay.frmDisplayVideoJS" %>

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
    <link href="VideoJS/video-js.css" rel="stylesheet">

    <!-- If you'd like to support IE8 -->
    <script src="VideoJS/videojs-ie8.min.js"></script>
</head>
<body>
    <form id="form1" runat="server" >
        <asp:ScriptManager ID="scripmanager1" runat="server"></asp:ScriptManager>
        <div style="overflow:hidden;position:absolute;">
            <video id="my-video" class="video-js" style="width:100%;height:100%"
                poster="MY_VIDEO_POSTER.jpg"  data-setup='{"controls": true, "autoplay": true, "preload": "auto" }'>
                <source src="http://103.253.72.88/AppSignage/SignageVDO/video.mp4" type='video/mp4' />
                <p class="vjs-no-js">
                  To view this video please enable JavaScript, and consider upgrading to a web browser that
                  <a href="http://videojs.com/html5-video-support/" target="_blank">supports HTML5 video</a>
                </p>
              </video>

              <script src="VideoJS/video.js"></script>
        
        </div>
    </form>
</body>
</html>
