
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code




<title>Cursos del Sistema</title>

 
    <div class="container">
        <h3>
            <a href="/Curso/Create" class="btn btn-primary">Curso</a>
        </h3>
        <table class="table table-hover">

			<tr>
				<th>Nro Curso</th>
				<th>Materia</th>
				<th>Profesor Nombre</th>
				<th>Profesor Apellido</th>
				<th>Semestre</th>
				<th>Turno</th>
				<th>Aula</th>
				<th>Seccion</th>
				<th>Acta</th>
				<td></td>
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
						<a href="/Curso/Acta/@item("id_curso")" class="btn btn-primary"><ion-icon name="clipboard"></ion-icon>Agregar</a>
					</td>

				</tr>
            Next
        </table>

    </div>
    <script src="/scripts/jquery-3.3.1.min.js"></script>
    <script src="/js/bootstrap.min.js"></script>

   
