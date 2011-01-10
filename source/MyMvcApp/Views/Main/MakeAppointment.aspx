<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<MyMvcApp.Models.Appointment>" MasterPageFile="~/Views/Shared/Edit.master" %>
<%@ Import Namespace="MyMvcApp" %>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="Content">
<h2>Making an appointment</h2>

<p>
    <%: Html.LabelFor(x => x.Patient) %>
    <br />
    <%: Html.InputFor(x => x.Patient)%>
</p>

<p>
    <%: Html.LabelFor(x => x.CoverageDate)%>
    <br />
    <%: Html.InputFor(x => x.CoverageDate)%>
</p>

<p>
    <%: Html.LabelFor(x => x.Physician)%>
    <br />
    <%: Html.InputFor(x => x.Physician)%>
</p>

<p>
    <%: Html.LabelFor(x => x.StartTime)%>
    <br />
    <%: Html.InputFor(x => x.StartTime)%>
</p>

<p>
    <%: Html.LabelFor(x => x.EndTime)%>
    <br />
    <%: Html.InputFor(x => x.EndTime)%>
</p>
</asp:Content>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="Scripts"></asp:Content>
