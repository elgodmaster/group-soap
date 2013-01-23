<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<AplicacionWebMVC.Models.Articulo>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Control de Almacen
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="color: #003399">Detalle Articulo</h2>

    <fieldset>
        <legend style="color: #800000">Campos</legend>
        
        <div class="display-label" style="color: #003399">Codigo:</div>
        <div class="display-field"><%: Model.Codigo %></div>
        
        <div class="display-label" style="color: #003399">Nombre:</div>
        <div class="display-field"><%: Model.Nombre %></div>
        
        <div class="display-label" style="color: #003399">Descripcion:</div>
        <div class="display-field"><%: Model.Descripcion %></div>

        <div class="display-label" style="color: #003399">Categoria:</div>
        <div class="display-field"><%: Model.Categoria.Codigo %> - <%: Model.Categoria.Nombre %> </div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "Edit", new { id=Model.Codigo }) %> |
        <%: Html.ActionLink("Regresar a la Lista", "Index") %>
    </p>

</asp:Content>

