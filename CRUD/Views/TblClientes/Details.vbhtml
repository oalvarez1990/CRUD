@ModelType CRUD.TblCliente
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>TblCliente</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.ID_Cliente)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ID_Cliente)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Nombre_Cliente)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nombre_Cliente)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Direccion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Direccion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Pais)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Pais)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FechaPedido)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FechaPedido)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Editar", "Edit", New With {.id = Model.Cupo}) |
    @Html.ActionLink("Regresar", "Index")
</p>
