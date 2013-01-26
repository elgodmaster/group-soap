<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<AplicacionWebMVC.Models.Pedido>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Control Almacen
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="color: #003399">Detalle Pedido</h2>

    <fieldset>
        <legend style="color: #800000">Campos</legend>
        
        <div class="display-label" style="color: #003399">Nro Pedido:</div>
        <div class="display-field"><%: Model.NPedido %></div>
        
        <div class="display-label" style="color: #003399">Usuario:</div>
        <div class="display-field"><%: Model.Usuario %></div>
        
        <div class="display-label" style="color: #003399">FechaRegistro:</div>
        <div class="display-field"><%: Model.FechaRegistro %></div>
        
        <div class="display-label">Prioridad</div>
        <div class="display-field"><%: Model.Prioridad %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "Edit", new { id=Model.NPedido })%> |
        <%: Html.ActionLink("Regresar a la Lista", "Index") %>
    </p>

</asp:Content>

