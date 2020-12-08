@ModelType IEnumerable(Of CRUD.TblEmpleados)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Nuevo Registro", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nombres)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Apellidos)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Nombres)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Apellidos)
        </td>
        <td>
            @Html.ActionLink("Editar", "Edit", New With {.id = item.ID}) |
            @Html.ActionLink("Detalles", "Details", New With {.id = item.ID}) |
            @Html.ActionLink("Eliminar", "Delete", New With {.id = item.ID})
        </td>
    </tr>
Next

</table>
