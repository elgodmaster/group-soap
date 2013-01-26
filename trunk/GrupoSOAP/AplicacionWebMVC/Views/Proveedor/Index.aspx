<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<AplicacionWebMVC.Models.Proveedor>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="color: #003399">Proveedores</h2>

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
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id = item.Codigo })%> |
                <%: Html.ActionLink("Details", "Details", new { id = item.Codigo })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id = item.Codigo })%>
            </td>
            <td>
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
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

