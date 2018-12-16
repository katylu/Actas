
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code




<title>Cursos del Sistema</title>

 
    <div class="container">
        <h3>
            <a href="/Curso/Create" class="btn btn-primary">Nuevo Curso</a>
        </h3>
        <table class="table table-hover">

			<tr>
				<td>Nro Curso</td>
				<td>Materia</td>
				<td>Profesor Nombre</td>
				<td>Profesor Apellido</td>
				<td>Semestre</td>
				<td>Turno</td>
				<td>Aula</td>
				<td>Seccion</td>
				<td>Acciones</td>
			</tr>

            @For Each item In ViewData("curso")

                @<tr>
					<td>@item("nro_curso")</td>
					<td>@item("materia")</td>
					<td>@item("nombre")</td>
					<td>@item("apellido")</td>
					<td>@item("semestre")</td>
					<td>@item("turno")</td>
					<td>@item("aula")</td>
					<td>@item("seccion")</td>

	<td>
		<a href="/Materia/Edit/@item("id_curso")" class="btn btn-primary">Modificar</a>
		<a href="javascript:Eliminar(@item("id_curso"))" class="btn btn-primary">Eliminar</a>
	</td>


</tr>
            Next
        </table>

    </div>
    <script src="/scripts/jquery-3.3.1.min.js"></script>
    <script src="/js/bootstrap.min.js"></script>

   
