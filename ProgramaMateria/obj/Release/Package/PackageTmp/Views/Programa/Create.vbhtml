@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code
@*<!DOCTYPE html>*@



<script src="~/ckeditor1/ckeditor.js"></script>

<script src="~/ckeditor1/samples/js/sample.js"></script>
<link href="~/ckeditor1/samples/css/samples.css" rel="stylesheet" />
<form action="Create" method="post">

    <label>Programa de la Materia</label><br />
   
    <table align="center" style="width:80%">
        <tr>
            <td>
              <textarea name="programa" id="editor1"></textarea>
                <br />
                <textarea name="estado"></textarea>
            </td>
            </tr>
        </table>
                <input type="submit" Class="btn btn-primary" value="Guardar" /><br />
                <input type="reset" Class="btn btn-info" value="Cancelar" />
                <script>
                  CKEDITOR.replace( 'editor1' );
                </script>
</form>