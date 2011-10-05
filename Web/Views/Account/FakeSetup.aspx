<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcValidation.Web.Models.Login.FakeSetupViewModel>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
    <h2>Fake Setup</h2>

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
