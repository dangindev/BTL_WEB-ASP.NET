<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="Inspire.WebForm1" %>
 <%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="ndcontent">
              <h4>Chọn bản tin: </h4>
              <asp:DropDownList ID="drBanTin" runat="server" Height="33px" Width="600px"></asp:DropDownList>
              <h4>Tiêu đề bản tin:</h4>
              <asp:TextBox ID="txtTieuDe" runat="server" Height="31px" Width="818px"></asp:TextBox>
              <h4>Nội dung bản tin:</h4>
              <CKEditor:CKEditorControl ID="txtNoiDung" runat="server"></CKEditor:CKEditorControl>
              <br />
              <br />
\
           </div>
              
   
</asp:Content>
