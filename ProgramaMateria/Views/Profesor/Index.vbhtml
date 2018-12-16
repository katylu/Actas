@Code
	ViewData("Title") = "Index"
	Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code

<title>Profesores - UAA</title>


<div class="container">
	<h3>
		<a href="/Profesor/Create" class="btn btn-primary">Profesor</a>
	</h3>
	<table class="table table-hover">
		<thead>
			<tr>

				<th>Cédula</th>
				<th>Nombre</th>
				<th>Apellido</th>
				<th>Curso</th>
				<th>Facultad</th>
			</tr>
		</thead>
		<tbody>
			@For Each row In ViewData("profesor")
				@<tr>

	<td>@row("ci_profesor")</td>
	<td>@row("nombre")</td>
	<td>@row("apellido")</td>

	<td></td>
	<td></td>




</tr>
			Next
		</tbody>
	</table>
</div>
