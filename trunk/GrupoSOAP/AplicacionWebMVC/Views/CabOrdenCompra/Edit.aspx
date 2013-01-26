<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<AplicacionWebMVC.Models.CabOrdenCompra>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.codigo_oc) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.codigo_oc) %>
                <%: Html.ValidationMessageFor(model => model.codigo_oc) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.fecha) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.fecha, String.Format("{0:g}", Model.fecha)) %>
                <%: Html.ValidationMessageFor(model => model.fecha) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.proveedor) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.proveedor) %>
                <%: Html.ValidationMessageFor(model => model.proveedor) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.observacion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.observacion) %>
                <%: Html.ValidationMessageFor(model => model.observacion) %>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

