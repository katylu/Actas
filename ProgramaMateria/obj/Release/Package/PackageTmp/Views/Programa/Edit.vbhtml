
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code



<!DOCTYPE html>
<script src="~/ckeditor1/ckeditor.js"></script>

<script src="~/ckeditor1/samples/js/sample.js"></script>
<link href="~/ckeditor1/samples/css/samples.css" rel="stylesheet" />
<div class="container col-md-8 col-lg-12">
    <h1>Editar Programa</h1>
    <form action="Edit" method="post">

        <input type="hidden" name="id_programa" value="@Model.pid_programa" />

        <table align="center" style="width:80%">
            <tr>
                <td>
                    <textarea name="programa" id="editor1">@Model.pprograma</textarea>
                    <br />
                    <textarea name="estado"></textarea>
                </td>
            </tr>
        </table>

        <div Class="form-group">
            <input type="submit" Class="btn btn-primary" value="Guardar" />
            <input type="reset" Class="btn btn-info" value="Cancelar" />
        </div>

    </form>
</div>
<script>
    CKEDITOR.replace('editor1');
</script>