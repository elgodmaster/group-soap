<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<AplicacionWebMVC.Models.Articulo>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Control de Almacen
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="color: #003399">Eliminación de Articulo</h2>

    <h3>¿Seguro(a) de eliminar este Articulo?</h3>
    <fieldset>
        <legend style="color: #993333">Campos</legend>
        
        <div class="display-label" style="color: #003399">Codigo:</div>
        <div class="display-field"><%: Model.Codigo %></div>
        
        <div class="display-label" style="color: #003399">Nombre:</div>
        <div class="display-field"><%: Model.Nombre %></div>
        
        <div class="display-label" style="color: #003399">Descripcion:</div>
        <div class="display-field"><%: Model.Descripcion %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Eliminar" style="font-weight: 700" /> |
		    <%: Html.ActionLink("Regresar a la Lista", "Index") %>
        </p>
    <% } %>

</asp:Content>

