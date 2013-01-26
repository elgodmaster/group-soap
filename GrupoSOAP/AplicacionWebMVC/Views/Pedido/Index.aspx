<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<AplicacionWebMVC.Models.Pedido>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Control Almacen
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="color: #003399">Pedidos</h2>

    <table>
        <tr>
            <th></th>
            <th>
                NPedido
            </th>
            <th>
                Usuario
            </th>
            <th>
                FechaRegistro
            </th>
            <th>
                Prioridad
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new {  id=item.NPedido }) %> |
                <%: Html.ActionLink("Detalles", "Details", new { id = item.NPedido })%> |
                <%: Html.ActionLink("Eliminar", "Delete", new { id = item.NPedido })%>
            </td>
            <td>
                <%: item.NPedido %>
            </td>
            <td>
                <%: item.Usuario %>
            </td>
            <td>
                <%: item.FechaRegistro %>
            </td>
            <td>
                <%: item.Prioridad %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear", "Create") %>
    </p>

</asp:Content>

