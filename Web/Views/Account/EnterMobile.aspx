<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcValidation.Web.Models.Login.EnterMobileViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	EnterMobile
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>EnterMobile</h2>

    <% using (Html.BeginForm()) {%>
        <%= Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.MobilePhoneNumber) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.MobilePhoneNumber) %>
                <%= Html.ValidationMessageFor(model => model.MobilePhoneNumber) %>
            </div>
            
            <p>
                <input type="submit" value="Next" />
            </p>
        </fieldset>

    <% } %>

</asp:Content>

