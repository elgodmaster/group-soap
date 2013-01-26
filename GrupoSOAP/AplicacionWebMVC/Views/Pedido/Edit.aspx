<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<AplicacionWebMVC.Models.Pedido>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Control Almacen
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="color: #003399">Edición de Articulo</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend style="color: #993333">Campos</legend>
            
            <div class="editor-label" style="color: #003399">
                <%: Html.LabelFor(model => model.NPedido) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.NPedido) %>
                <%: Html.ValidationMessageFor(model => model.NPedido) %>
            </div>
            
            <div class="editor-label" style="color: #003399">
                <%: Html.LabelFor(model => model.Usuario) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Usuario) %>
                <%: Html.ValidationMessageFor(model => model.Usuario) %>
            </div>
            
<%--            <div class="editor-label" style="color: #003399">
                <%: Html.LabelFor(model => model.FechaRegistro) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.FechaRegistro) %>
                <%: Html.ValidationMessageFor(model => model.FechaRegistro) %>
            </div>--%>
            
            <div class="editor-label" style="color: #003399">
                <%: Html.LabelFor(model => model.Prioridad) %>
            </div>
            <div class="editor-field" style="color: #003399">
                <%: Html.TextBoxFor(model => model.Prioridad) %>
                <%: Html.ValidationMessageFor(model => model.Prioridad) %>
            </div>
            
            <p>
                <input type="submit" value="Guardar" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar a la Lista", "Index")%>
    </div>

</asp:Content>

