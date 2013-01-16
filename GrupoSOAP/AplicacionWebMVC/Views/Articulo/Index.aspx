<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<AplicacionWebMVC.Models.Articulo>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Control Almacen
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="color: #003399">Articulos</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Codigo
            </th>
            <th>
                Nombre
            </th>
            <th>
                Descripcion
            </th>
            <th>
                Categoria
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id=item.Codigo })%> |
                <%: Html.ActionLink("Detalle", "Details", new {id=item.Codigo })%> |
                <%: Html.ActionLink("Eliminar", "Delete", new { id=item.Codigo })%>
            </td>
            <td>
                <%: item.Codigo %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
            <td>
                <%: item.Descripcion %>
            </td>
            <td>
                <%: item.Categorias.Codigo %> - <%: item.Categorias.Nombre %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear", "Create") %>
    </p>

</asp:Content>

