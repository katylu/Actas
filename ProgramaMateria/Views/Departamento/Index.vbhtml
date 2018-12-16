@Code
	ViewData("Title") = "Index"
	Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code

<title>Departamentos Académicos</title>


<div class="container">
	<h3>
		<a href="/Departamento/Create" class="btn btn-primary">Nuevo Departamento</a>
	</h3>
	<table class="table table-hover">
		<thead>
			<tr>
				<th>Departamento</th>
				
				<th>Facultad</th>

				<th>Acciones</th>
			</tr>
		</thead>
		<tbody>
			@For Each row In ViewData("departamentos")
				@<tr>
					
					<td>@row("descripcion")</td>
					<td>@row("nombre_facultad")</td>


					<td>
						<a href="/Departamento/Edit/@row("id_departamento")" class="btn btn-primary"><ion-icon name="open"></ion-icon>Editar</a>
						<a href="javascript:EliminarRegistro(@row("id_departamento"))" class="btn btn-primary"><ion-icon name="trash"></ion-icon>Eliminar</a>
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