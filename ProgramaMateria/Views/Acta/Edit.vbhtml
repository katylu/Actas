
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code



<!DOCTYPE html>

<div class="container col-md-8 col-lg-12">
    <center><h1>Informe de evaluación academica</h1></center>
    <br />

    <form action="Acta" method="post">

        <input type="hidden" name="intIdActa" value="@Model.pid_acta" />
        <input type="hidden" name="intIdCurso" value="@Model.pid_curso" />
        <!-- CURSO y DEPARTAMENTO-->
        <div class="row">
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-4">
                        <label>Curso:</label>
                    </div>
                    <div class="col-md-8">
                        <span class="head-acta">@Model.pnro_curso</span>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-4">
                        <label>Departamento:</label>
                    </div>
                    <div class="col-md-8">
                        <span class="head-acta">@Model.pdepartamento</span>
                    </div>
                </div>
            </div>
        </div>

        <!-- CARRERA y PROFESOR-->
        <div class="row">
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-4">
                        <label>Carrera:</label>
                    </div>
                    <div class="col-md-8">
                        <span class="head-acta">@Model.pcarrera</span>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-4">
                        <label>Profesor:</label>
                    </div>
                    <div class="col-md-8">
                        <span class="head-acta">@Model.pprofesor</span>
                    </div>
                </div>
            </div>
        </div>

        <!-- MATERIA y SEMESTRE-->
        <div class="row">
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-4">
                        <label>Materia:</label>
                    </div>
                    <div class="col-md-8">
                        <span class="head-acta">@Model.pmateria</span>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-4">
                        <label>Semestre:</label>
                    </div>
                    <div class="col-md-8">
                        <span class="head-acta">@Model.psemestre</span>
                    </div>
                </div>
            </div>
        </div>

        <!-- TURNO y AULA-->
        <div class="row">
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-4">
                        <label>Turno:</label>
                    </div>
                    <div class="col-md-8">
                        <span class="head-acta">@Model.pturno</span>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-4">
                        <label>Aula:</label>
                    </div>
                    <div class="col-md-8">
                        <span class="head-acta">@Model.paula</span>
                    </div>
                </div>
            </div>
        </div>

        <!-- FECHA y TIPO-->
        <div class="row">
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-4">
                        <label>Fecha:</label>
                    </div>
                    <div class="col-md-8">
                        <input type="text" disabled class="form-control" name="fecha-examen" id="fecha-examen" value="@Model.pfecha_examen" />
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-4">
                        <label>Tipo de Examen:</label>
                    </div>
                    <div class="col-md-8">

                        <input type="text" disabled class="form-control" name="tipo" id="tipo" value="@Model.ptipo" />
                    </div>
                </div>
            </div>
        </div>

        <!-- ESTADO y-->
        <div class="row">
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-4">
                        <label>Estado:</label>
                    </div>
                    <div class="col-md-8">
                        <select class="form-control" name="estado">
                            <option>PENDIENTE</option>
                            <option>FINALIZADO</option>
                        </select>
                    </div>
                </div>
            </div>
        </div>

        <hr />

        <center><h3>Alumnos</h3></center>

        <div class="row">
            <div class="col-md-1">
                <b>CI</b>
            </div>
            <div class="col-md-3">
                <b>Nombre</b>
            </div>
            <div class="col-md-3">
                <b>Apellido</b>
            </div>
            <div class="col-md-1">
                <b>Puntos</b>
            </div>
            <div class="col-md-4">
                <b>En letras</b>
            </div>
        </div>
        <br />

        @For Each item In ViewData("alumnos")
            @<div class="row">
                <input type="hidden" value="@item("id_acta_alumno")" name="id-@item("id_alumno")" />
                <div class="col-md-1">
                    @item("ci_alumno")
                </div>
                <div class="col-md-3">
                    @item("nombre")
                </div>
                <div class="col-md-3">
                    @item("apellido")
                </div>
                <div class="col-md-1">
                    <input type="text" class="form-control" name="puntos-@item("id_alumno")" value="@item("nota")" />
                </div>
                <div class="col-md-4">
                    <input type="text" class="form-control" name="letras-@item("id_alumno")" value="@item("letras")" />
                </div>
            </div>
        Next

             <div class="print">
                 <br />
                 <br />
                 <br />
                 <br />
                 <span>______________________</span>
                 <br />
                 <span>@Model.pprofesor</span>
                 <br />
                 <span>Profesor/a</span>
             </div>

             <div Class="form-group">

                 @if Model.pestado = "PENDIENTE" Then
                     @<input type="submit" Class="btn btn-primary no-print" value="Guardar Cambios" />
                 Else
                     @<input type="submit" Class="btn btn-primary no-print" value="Imprimir" onClick="window.print()" />
                 End If

                 <a href="/Acta/Curso/@Model.pid_curso" class="btn btn-info no-print"><ion-icon name="clipboard"></ion-icon>Atras</a>
             </div>
    </form>
</div>
<script type="text/javascript">
    Date.prototype.toDateInputValue = (function () {
        var local = new Date(this);
        local.setMinutes(this.getMinutes() - this.getTimezoneOffset());
        return local.toJSON().slice(0, 10);
    });

    $(document).ready(function () {
        $('#fecha-examen').val(new Date().toDateInputValue());
    });
</script>