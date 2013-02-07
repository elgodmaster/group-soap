<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<AplicacionWebMVC.Models.Proveedor>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="color: #003399">Proveedores</h2>

    <table>
        <tr>
            <th>
                Codigo
            </th>
            <th>
                Nombre
            </th>
            <th>
                Ruc
            </th>
            <th>
                Direccion
            </th>
            <th>
                Telefono
            </th>
            <th>
                Fax
            </th>
            <th>
                Nombre Contacto
            </th>
            <th>
                Telefono Contacto
            </th>
            <td style="font-weight: bold; text-align:center">Acciones</td>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td style="text-align:center">
                <%: item.Codigo %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
            <td>
                <%: item.Ruc %>
            </td>
            <td>
                <%: item.Direccion %>
            </td>
            <td>
                <%: item.Telefono %>
            </td>
            <td>
                <%: item.Fax %>
            </td>
            <td>
                <%: item.NombreContacto %>
            </td>
            <td>
                <%: item.TelefonoContacto %>
            </td>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id = item.Codigo })%> |
                <%: Html.ActionLink("Detalle", "Details", new { id = item.Codigo })%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear", "Create") %>
    </p>

</asp:Content>

