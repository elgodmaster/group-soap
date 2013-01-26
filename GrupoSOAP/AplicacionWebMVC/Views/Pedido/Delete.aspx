<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<AplicacionWebMVC.Models.Pedido>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Control de Almacen
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="color: #003399">Eliminación de Pedido</h2>

    <h3>¿Seguro(a) de eliminar este Pedido?</h3>
    <fieldset>
        <legend style="color: #993333">Campos</legend>
        
        <div class="display-label" style="color: #003399">NPedido</div>
        <div class="display-field"><%: Model.NPedido %></div>
        
        <div class="display-label" style="color: #003399">Usuario</div>
        <div class="display-field"><%: Model.Usuario %></div>
        
        <div class="display-label" style="color: #003399">FechaRegistro</div>
        <div class="display-field"><%: Model.FechaRegistro %></div>
        
        <div class="display-label" style="color: #003399">Prioridad</div>
        <div class="display-field"><%: Model.Prioridad %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Eliminar" /> |
		    <%: Html.ActionLink("Regresar a la Lista", "Index")%>
        </p>
    <% } %>

</asp:Content>

