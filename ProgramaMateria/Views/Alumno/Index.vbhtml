
@Code
	ViewData("Title") = "Index"
	Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code

<title>Materias del Sistema</title>


<div class="container">
	<h3>
		<a href="/Alumno/Create" class="btn btn-primary">Alumnos</a>
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
			@For Each row In ViewData("alumno")
				@<tr>
	
	<td>@row("ci_alumno")</td>
	<td>@row("nombre")</td>
	<td>@row("apellido")</td>
	
	<td>@row("id_curso")</td>


	


</tr>
			Next
		</tbody>
	</table>
</div>

<script type="text/javascript">
	function EliminarRegistro(id) {
		if (confirm('¿Desea eliminar el registro?')) {
			$.ajax({
				url: '/Carrera/Delete',
				data: {
					id: id
				},
				type: 'GET',
				dateType: 'JSON',
				success: function (retorno) {
					location.reload();

				},
				error: function () {
					alert("se ha producido un error.");
				},
				alert: function () {
					alert(retorno);
				},
			})
		}
	}
</script>