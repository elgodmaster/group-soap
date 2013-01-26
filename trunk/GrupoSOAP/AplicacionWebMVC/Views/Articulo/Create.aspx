<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<AplicacionWebMVC.Models.Articulo>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Control de Almacen
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="color: #003399">Creación de Articulo</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend style="color: #993333">Campos</legend>
            
            <div class="editor-label" style="color: #003399">
                <%: Html.LabelFor(model => model.Codigo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Codigo) %>
                <%: Html.ValidationMessageFor(model => model.Codigo) %>
            </div>
            
            <div class="editor-label" style="color: #003399">
                <%: Html.LabelFor(model => model.Nombre) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Nombre) %>
                <%: Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
            <div class="editor-label" style="color: #003399">
                <%: Html.LabelFor(model => model.Descripcion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Descripcion) %>
                <%: Html.ValidationMessageFor(model => model.Descripcion) %>
            </div>

               <div class="editor-label" style="color: #003399">
                Categoria
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Categoria.Codigo) %>
                <%: Html.ValidationMessageFor(model => model.Categoria.Codigo) %>
            </div>
            
            <p>
                <input type="submit" value="Crear" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar a la Lista", "Index") %>
    </div>

</asp:Content>

