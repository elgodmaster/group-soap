<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<AplicacionWebMVC.Models.Proveedor>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="color: #003399">Detalle Proveedor</h2>

    <fieldset>
        <legend style="color: #800000">Campos</legend>
        
        <div class="display-label">Codigo: </div>
        <div class="display-field"><%: Model.Codigo %></div>
        
        <div class="display-label">Nombre: </div>
        <div class="display-field"><%: Model.Nombre %></div>
        
        <div class="display-label">Ruc: </div>
        <div class="display-field"><%: Model.Ruc %></div>
        
        <div class="display-label">Dirección:</div>
        <div class="display-field"><%: Model.Direccion %></div>
        
        <div class="display-label">Teléfono: </div>
        <div class="display-field"><%: Model.Telefono %></div>
        
        <div class="display-label">Fax: </div>
        <div class="display-field"><%: Model.Fax %></div>

        <div class="display-label">Nombre Contacto: </div>
        <div class="display-field"><%: Model.NombreContacto %></div>
        
        <div class="display-label">Teléfono Contacto: </div>
        <div class="display-field"><%: Model.TelefonoContacto %></div>

    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "Edit", new { id=Model.Codigo }) %> |
        <%: Html.ActionLink("Regresar a la Lista", "Index") %>
    </p>

</asp:Content>

