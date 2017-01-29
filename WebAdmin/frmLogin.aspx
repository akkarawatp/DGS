<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="WebAdmin.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title>Welcome to - Digital Signage Web Administration</title>
        <meta name="description" content="" />
        <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1, maximum-scale=1" />
        <!-- build:css({.tmp,app}) styles/app.min.css -->
        <link rel="stylesheet" type="text/css" href="content/bootstrap.css" />
        <link rel="stylesheet" type="text/css" href="styles/app.css" />
        <!-- endbuild -->
    </head>
<body>
    <form id="form1" runat="server">
    <div class="app signin usersession">
        <div class="session-wrapper">
            <div class="page-height-o row-equal align-middle">
            <div class="column">
                <div class="card bg-white no-border">
                    <div class="card-block">
                        <div role="form" class="form-layout">
                        <div class="text-center m-b">
                            <h4 class="text-uppercase">Welcome To Digital Signage</h4>
                            <p>Sign In to Administrative Web</p>
                        </div>
                        <div class="form-inputs">
                            <label class="text-uppercase">User Name</label>
                            <asp:TextBox ID="txtUserName" runat="server" class="form-control input-lg" placeholder="User Name"  required></asp:TextBox>
                            <label class="text-uppercase">Password</label>
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" class="form-control input-lg" placeholder="Password" required></asp:TextBox>
                        </div>
                        <asp:button ID="btnLogin" runat="server"  class="btn btn-success btn-block btn-lg " Text="Sign In" OnClick="btnLogin_Click" />
                        </div>
                    </div>
                </div>
            </div>
            </div>
        </div>
        <!-- bottom footer -->
        
    </div>
    </form>
</body>
</html>
