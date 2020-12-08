@ModelType CRUD.TblCliente
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Regresar", "Index")
        </div>
    End Using
</div>
