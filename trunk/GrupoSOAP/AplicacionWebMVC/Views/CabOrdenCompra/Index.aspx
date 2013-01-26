<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<AplicacionWebMVC.Models.CabOrdenCompra>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

    <table>
        <tr>
            <th></th>
            <th>
                codigo_oc
            </th>
            <th>
                fecha
            </th>
            <th>
                proveedor
            </th>
            <th>
                observacion
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                <%: Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%> |
                <%: Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ })%>
            </td>
            <td>
                <%: item.codigo_oc %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.fecha) %>
            </td>
            <td>
                <%: item.proveedor %>
            </td>
            <td>
                <%: item.observacion %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

