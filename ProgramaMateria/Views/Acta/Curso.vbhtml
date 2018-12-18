
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code




<title>Actas del Sistema</title>

 
    <div class="container">
        <table class="table table-hover">

            <tr>
                <th>Nro Curso</th>
                <th>Materia</th>
                <th>Profesor Nombre</th>
                <th>Profesor Apellido</th>
                <th>Semestre</th>
                <th>Turno</th>
                <th>Fecha Examen</th>
                <th>Fecha Acta</th>
                <th>Estado</th>
                <th>Tipo</th>
                <td></td>
            </tr>

            @For Each item In ViewData("acta")

                @<tr>
                    <td>@item("nro_curso")</td>
                    <td>@item("materia")</td>
                    <td>@item("nombre")</td>
                    <td>@item("apellido")</td>
                    <td>@item("semestre")</td>
                    <td>@item("turno")</td>
                    <td>@item("fecha_examen")</td>
                    <td>@item("fecha_acta")</td>
                    <td>@item("estado")</td>
                    <td>@item("tipo")</td>
                    <td>

                        @if item("estado") = "PENDIENTE" Then
                            @<a href="/Acta/Edit/" + item("id_acta") Class="btn btn-primary"><ion-icon name="clipboard"></ion-icon>Editar</a>
                        Else
                            @<a href="/Acta/Edit/" + item("id_acta") Class="btn btn-primary"><ion-icon name="clipboard"></ion-icon>Imprimir</a>
                        End If

                    </td>

                </tr>
            Next
        </table>

    </div>
    <script src="/scripts/jquery-3.3.1.min.js"></script>
    <script src="/js/bootstrap.min.js"></script>

   
