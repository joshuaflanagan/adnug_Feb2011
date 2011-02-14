<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<MyMvcApp.Controllers.MakeAppointmentModel>" MasterPageFile="~/Views/Shared/Edit.master" %>
<%@ Import Namespace="MyMvcApp" %>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="Content">
<h2>Making an appointment</h2>

<p>
    <%: Html.LabelFor(x => x.Appointment.Patient) %>
    <br />
    <%: Html.InputFor(x => x.Appointment.Patient)%>
</p>

<p>
    <%: Html.LabelFor(x => x.Appointment.CoverageDate)%>
    <br />
    <%: Html.InputFor(x => x.Appointment.CoverageDate)%>
</p>

<p>
    <%: Html.LabelFor(x => x.Appointment.Physician)%>
    <br />
    <%: Html.InputFor(x => x.Appointment.Physician)%>
</p>

<p>
    <%: Html.LabelFor(x => x.Appointment.StartTime)%>
    <br />
    <%: Html.InputFor(x => x.Appointment.StartTime)%>
</p>

<p>
    <%: Html.LabelFor(x => x.Appointment.EndTime)%>
    <br />
    <%: Html.InputFor(x => x.Appointment.EndTime)%>
</p>
</asp:Content>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="Scripts"></asp:Content>
