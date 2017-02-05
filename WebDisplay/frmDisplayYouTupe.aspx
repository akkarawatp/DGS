<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDisplayYouTupe.aspx.cs" Inherits="WebDisplay.frmDisplayYouTupe" %>
<!DOCTYPE html >
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title>ASP.NET Embedded Video Player | YouTube DEMO</title>
    </head>

    <body>
        <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" updatemode="Conditional" >
            <ContentTemplate> 
                <div>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                </div>

                <asp:Button ID="Button1" runat="server" 
                Text="START AT 15 SEC" onclick="Button1_Click" />
                  
                <asp:Button ID="Button2" runat="server" 
                Text="START AT 60 SEC" onclick="Button2_Click" />
            
            </ContentTemplate>
          </asp:UpdatePanel>
          
        </form>
    </body>

</html>
