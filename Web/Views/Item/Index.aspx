<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ItemViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

    <ul class="itemlist">
    <% for (var i = 0; i < Model.Items.Length; i++ )
       {%>
    
        <li>
            <ul>
                <li class="itemName"><%=Html.DisplayFor(item => item.Items[i].Name)%></li>
                <li class="itemDescription"><%=Html.DisplayFor(item => item.Items[i].Description)%></li>
                <li class="itemBorrowedTo"><%=Html.DisplayFor(item => item.Items[i].Loaner)%></li>
                <li class="actions"><%=Html.ActionLink("Edit", "Edit", new { id = Model.Items[i].Name })%></li>
            </ul>
        </li>
    
    <% } %>

    </ul>

    <p>
        <%= Html.ActionLink("Create New", "Create")%>
    </p>

</asp:Content>

