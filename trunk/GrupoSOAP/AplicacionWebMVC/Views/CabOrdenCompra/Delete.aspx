<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<AplicacionWebMVC.Models.CabOrdenCompra>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Delete</h2>

    <h3>Are you sure you want to delete this?</h3>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">codigo_oc</div>
        <div class="display-field"><%: Model.codigo_oc %></div>
        
        <div class="display-label">fecha</div>
        <div class="display-field"><%: String.Format("{0:g}", Model.fecha) %></div>
        
        <div class="display-label">proveedor</div>
        <div class="display-field"><%: Model.proveedor %></div>
        
        <div class="display-label">observacion</div>
        <div class="display-field"><%: Model.observacion %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Delete" /> |
		    <%: Html.ActionLink("Back to List", "Index") %>
        </p>
    <% } %>

</asp:Content>

