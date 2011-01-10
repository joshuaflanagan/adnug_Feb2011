<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Edit.master" Inherits="System.Web.Mvc.ViewPage<MyMvcApp.Models.Patient>" %>
<%@ Import Namespace="MyMvcApp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Scripts" runat="server">
<script type="text/javascript">

</script>
</asp:Content>

<asp:Content ContentPlaceHolderID="Content" runat="server">
<h2>Editing a patient</h2>
<p>
    <%: Html.LabelFor(x => x.Name) %>
    <br />
    <%: Html.InputFor(x => x.Name)%>
</p>

<p>
    <%: Html.LabelFor(x => x.Birthday)%>
    <br />
    <%: Html.InputFor(x => x.Birthday)%>
</p>

<p>
    <%: Html.LabelFor(x => x.Hometown)%>
    <br />
    <%: Html.InputFor(x => x.Hometown)%>
</p>

<p>
    <%: Html.LabelFor(x => x.Anniversary)%>
    <br />
    <%: Html.InputFor(x => x.Anniversary)%>
</p>
</asp:Content>