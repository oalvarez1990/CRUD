@ModelType IEnumerable(Of CRUD.TblCliente)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.ID_Cliente)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nombre_Cliente)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Direccion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Pais)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FechaPedido)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ID_Cliente)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Nombre_Cliente)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Direccion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Pais)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FechaPedido)
        </td>
        <td>
            @Html.ActionLink("Editar", "Edit", New With {.id = item.Cupo}) |
            @Html.ActionLink("Detalles", "Details", New With {.id = item.Cupo}) |
            @Html.ActionLink("Eliminar", "Delete", New With {.id = item.Cupo})
        </td>
    </tr>
Next

</table>
