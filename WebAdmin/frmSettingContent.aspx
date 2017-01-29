<%@ Page Title="Setting Content" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmSettingContent.aspx.cs" Inherits="WebAdmin.frmSettingContent" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<%@ Register src="UserControls/UCFileUpload.ascx" tagname="UCFileUpload" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- page stylesheets -->
    
    <!-- end page stylesheets -->

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-title">
        <div class="title">Master Data > Setting Content</div>
    </div>

    <asp:UpdatePanel ID="udpList" runat="server">
        <ContentTemplate>
        <asp:Panel ID="pnlList" runat="server" CssClass="card bg-white" Visible="True">
            <div class="card-header">
                Found : <asp:Label ID="lblTotalList" runat="server"></asp:Label> Content(s)
            </div>
            <div class="card-block">
                <div class="no-more-tables">
                <table class="table table-bordered m-b-0">
                  <thead>
                    <tr>
                      <th>Content Name</th>
                      <th>File Type</th>
                      <th>Duration</th>
                      <th id="ColEdit" runat="server">Edit</th>
                      <th id="ColDelete" runat="server">Delete</th>
                    </tr>                
                  </thead>
                  <tbody>
            <asp:Repeater ID="rptList" runat="server">
                <ItemTemplate>
                    <tr>                 
                      <td data-title="Content Name" class="text-primary" id="td" runat="server"><i class="icon-control-play"></i> <asp:Label ID="lblContentName" runat="server"></asp:Label></td>
                      <td data-title="File Type" class="text-primary"><asp:Label ID="lblFileType" runat="server"></asp:Label></td>
                      <td data-title="Duration" class="text-primary"><asp:Label ID="lblDuration" runat="server"></asp:Label></td>                  
                      <td data-title="Edit" class="numeric" id="ColEdit" runat="server"><asp:Button CssClass="btn btn-success" ID="btnEdit" runat="server" Text="Edit" CommandName="Edit" /></td>
                      <td data-title="Delete" class="numeric" id="ColDelete" runat="server"><asp:Button CssClass="btn btn-danger" ID="btnDelete" runat="server" Text="Delete" CommandName="Delete" /></td>
                      <ajaxToolkit:ConfirmButtonExtender ID="cfmDelete" runat="server" TargetControlID="btnDelete" />
                    </tr> 
                </ItemTemplate>
            </asp:Repeater>               
                  </tbody>
                </table>
                </div>
            
                <div class="row m-t">
                    <asp:LinkButton CssClass="btn btn-primary btn-icon loading-demo mr5 btn-shadow" ID="btnAdd" runat="server">
                      <i class="fa fa-plus-circle"></i>
                      <span>Add new content</span>
                    </asp:LinkButton>
                </div>
              </div>
        </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>




    <asp:UpdatePanel ID="udpEdit" runat="server">
        <ContentTemplate>
            <asp:Panel ID="pnlEdit" runat="server"  CssClass="card bg-white">
                <div class="card-header">
                    <asp:Label ID="lblEditMode" runat="server"></asp:Label> Content
                </div>
                <div class="card-block">
                    <div class="row m-a-0">
                      <div class="col-lg-12 form-horizontal">
                          <h4 class="card-title">Content Info</h4>
                           <div class="form-group">
                            <label class="col-sm-2 control-label">Content Name</label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtContentName"  runat="server"  CssClass="form-control"  placeholder=""></asp:TextBox>
                            </div>    
                                                                  
                          </div>
                          <div class="form-group">
                            
                            <label class="col-sm-2 control-label">Select File</label>
                            <div class="col-sm-4">
                                <uc1:UCFileUpload ID="UCFileUpload1" runat="server" FileFilter="pdf,avi,mp4" />
                            </div>   
                            <label class="col-sm-2 control-label">File Type</label>
                            <div class="col-sm-4">
                                <asp:Label ID="lblFileType" runat="server"></asp:Label>
                            </div>                                    
                          </div>
                          <div class="form-group">
                            <label class="col-sm-2 control-label">Duration </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtCompanyName" runat="server"  CssClass="form-control" ></asp:TextBox>
                            </div>                                       
                          </div>

                  
                          <div class="form-group" style="margin-left:-5px;">
                                <h4 class="card-title col-sm-2 control-label" style="text-align:left;">Active Status </h4>  
                                <label class="col-sm-10 cb-checkbox cb-md">
                                    <asp:CheckBox ID="chkActive" runat="server"/>
                                </label>
                          </div>
                          <div class="form-group" style="text-align:right">
                                <asp:LinkButton CssClass="btn btn-success btn-icon loading-demo mr5 btn-shadow" ID="btnSave" runat="server">
                                  <i class="fa fa-save"></i>
                                  <span>Save</span>
                                </asp:LinkButton>
                                <asp:LinkButton CssClass="btn btn-warning btn-icon loading-demo mr5 btn-shadow" ID="btnBack" runat="server">
                                  <i class="fa fa-rotate-left"></i>
                                  <span>Cancel</span>
                                </asp:LinkButton>
                          </div>
                      </div>
                    </div>
                </div>
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptContainer" runat="server">
</asp:Content>
