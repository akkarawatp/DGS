<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCFileUpload.ascx.cs" Inherits="WebAdmin.UserControls.UCFileUpload" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div class="box-body">
            <table width="100%" cellpadding="0" cellspacing="0" bgcolor="#FFFFFF" style="border:0px solid #efefef;">
                <tr>
                    <td style="width:120px">
                        <asp:FileUpload ID="ful" ClientIDMode="Static" runat="server" Style="display: none;" onchange="uploadFile();return false;" />
                        <a href="#" onclick="return ClickUploadFile();" style="width:100px" class="btn btn-primary btn-block btn-flat">
                            <span>Choose File</span>
                        </a>
                    </td>
                    <td style="width:300px;vertical-align:bottom;">
                        <progress id="progressBar" value="0" max="100" style="width: 290px;height:30px"></progress>
                    </td>
                    
                    <td><asp:Button ID="btnUpload" runat="server" Class="button" Text="Upload" OnClick="btnUpload_Click" /></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <h4 id="status"  style="width:100%;"></h4>
                        <p id="loaded_n_total"></p>
                    </td>
                </tr>
            </table>

            <asp:TextBox ID="txtFileFilter" runat="server" style="display:none" ></asp:TextBox>
        </div>

        <script type="text/javascript">
            function ClickUploadFile() {
                $('#ful').click();
                return false;
            }
            function uploadFile() {

                var FileFilter = document.getElementById('<%= txtFileFilter.ClientID %>').value;

                var file = $("#ful").prop("files")[0];
                //alert(file.name+" | "+file.size+" | "+file.type);
                var formdata = new FormData();
                formdata.append("ful", file);
                formdata.append("FileFilter", FileFilter);
                var ajax = new XMLHttpRequest();
                ajax.upload.addEventListener("progress", progressHandler, false);
                ajax.addEventListener("load", completeHandler, false);
                ajax.addEventListener("error", errorHandler, false);
                ajax.addEventListener("abort", abortHandler, false);
                ajax.open("POST", "UserControls/RenderFileUpload.aspx");
                ajax.send(formdata);
            }
            function progressHandler(event) {

                $("#loaded_n_total").innerHTML = "Uploaded " + event.loaded + " bytes of " + event.total;
                var percent = (event.loaded / event.total) * 100;

                //$("#progressBar").value = Math.round(percent);
                document.getElementById("progressBar").value = Math.round(percent);
                document.getElementById("status").innerHTML = Math.round(percent) + "% uploaded... please wait";
            }
            function completeHandler(event) {
                var tmp = event.target.responseText.split("|");
                if (tmp[0] == "true") {
                    //alert("Upload Complete");
                    document.getElementById("status").innerHTML = tmp[1];  //FileName
                    document.getElementById("progressBar").value = 0;
                } else {
                    document.getElementById("status").innerHTML = "";
                    document.getElementById("progressBar").value = 0;
                    alert("Upload Fail !!!" + tmp[1]);
                }
            }
            function errorHandler(event) {
                $("#status").innerHTML = "Upload Failed";
            }
            function abortHandler(event) {
                $("#status").innerHTML = "Upload Aborted";
            }
        </script>
    </ContentTemplate>
</asp:UpdatePanel>