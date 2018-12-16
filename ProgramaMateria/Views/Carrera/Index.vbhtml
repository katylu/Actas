
@Code
	ViewData("Title") = "Index"
	Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code

<title>Materias del Sistema</title>


<div class="container">
	<h3>
		<a href="/Carrera/Create" class="btn btn-primary">Nueva Carrera</a>
	</h3>
	<table class="table table-hover">
		<thead>
			<tr>
				<th>Id Carrera</th>
				<th>Carrera</th>
				<th>Facultad</th>

				<th>Acciones</th>
			</tr>
		</thead>
		<tbody>
			@For Each row In ViewData("carreras")
				@<tr>
					<td>@row("id_carrera")</td>
					<td>@row("descripcion")</td>
					<td>@row("nombre_facultad")</td>


					<td>
						<a href="/Carrera/Edit/@row("id_carrera")" class="btn btn-primary"><ion-icon name="open"></ion-icon>Editar</a>
						<a href="javascript:EliminarRegistro(@row("id_carrera"))" class="btn btn-primary"><ion-icon name="trash"></ion-icon>Eliminar</a>
					</td>


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