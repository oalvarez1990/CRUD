@ModelType CRUD.TblEmpleados
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>TblEmpleados</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nombres)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nombres)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Apellidos)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Apellidos)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
