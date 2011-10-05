<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcValidation.Web.Models.Login.EnterGuestLoginViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	EnterGuestLogin
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>EnterGuestLogin</h2>

    <% using (Html.BeginForm()) {%>
        <%= Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.DisplayName) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.DisplayName) %>
                <%= Html.ValidationMessageFor(model => model.DisplayName) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.VerificationCode) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.VerificationCode) %>
                <%= Html.ValidationMessageFor(model => model.VerificationCode) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

</asp:Content>

