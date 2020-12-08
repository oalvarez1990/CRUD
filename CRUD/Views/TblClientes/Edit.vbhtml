@ModelType CRUD.TblCliente
@Code
    ViewData("Title") = "Edit"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>TblCliente</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        <div class="form-group">
            @Html.LabelFor(Function(model) model.ID_Cliente, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ID_Cliente, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.ID_Cliente, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Nombre_Cliente, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Nombre_Cliente, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.Nombre_Cliente, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Direccion, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Direccion, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.Direccion, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Pais, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Pais, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.Pais, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.FechaPedido, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.FechaPedido, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.FechaPedido, "", New With { .class = "text-danger" })
            </div>
        </div>

        @Html.HiddenFor(Function(model) model.Cupo)

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Regresar", "Index")
</div>
