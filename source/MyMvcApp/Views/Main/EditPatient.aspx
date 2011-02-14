<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Edit.master" Inherits="System.Web.Mvc.ViewPage<MyMvcApp.Controllers.EditPatientModel>" %>
<%@ Import Namespace="MyMvcApp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Scripts" runat="server">
<script type="text/javascript">

</script>
</asp:Content>

<asp:Content ContentPlaceHolderID="Content" runat="server">
<h2>Editing a patient</h2>
<p>
    <%: Html.LabelFor(x => x.Patient.Name) %>
    <br />
    <%: Html.InputFor(x => x.Patient.Name)%>
</p>

<p>
    <%: Html.LabelFor(x => x.Patient.Birthday)%>
    <br />
    <%: Html.InputFor(x => x.Patient.Birthday)%>
</p>

<p>
    <%: Html.LabelFor(x => x.Patient.Hometown)%>
    <br />
    <%: Html.InputFor(x => x.Patient.Hometown)%>
</p>

<p>
    <%: Html.LabelFor(x => x.Patient.Anniversary)%>
    <br />
    <%: Html.InputFor(x => x.Patient.Anniversary)%>
</p>
</asp:Content>