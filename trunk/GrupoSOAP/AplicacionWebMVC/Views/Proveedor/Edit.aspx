<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<AplicacionWebMVC.Models.Proveedor>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="color: #003399">Editar Proveedor</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend style="color: #800000">Campos</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Codigo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Codigo) %>
                <%: Html.ValidationMessageFor(model => model.Codigo) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Nombre) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Nombre) %>
                <%: Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Ruc) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Ruc) %>
                <%: Html.ValidationMessageFor(model => model.Ruc) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Direccion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Direccion) %>
                <%: Html.ValidationMessageFor(model => model.Direccion) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Telefono) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Telefono) %>
                <%: Html.ValidationMessageFor(model => model.Telefono) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Fax) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Fax) %>
                <%: Html.ValidationMessageFor(model => model.Fax) %>
            </div>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.NombreContacto) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.NombreContacto) %>
                <%: Html.ValidationMessageFor(model => model.NombreContacto) %>
            </div>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.TelefonoContacto) %>
            </div>            
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.TelefonoContacto) %>
                <%: Html.ValidationMessageFor(model => model.TelefonoContacto) %>
            </div>            
            <p>
                <input type="submit" value="Guardar" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar a la Lista", "Index") %>
    </div>

</asp:Content>

