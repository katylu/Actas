
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code

<title>Facultades de la UAA</title>


<div class="container">
	<h3>
		<a href="/Facultad/Create" class="btn btn-primary">Nueva Facultad</a>
	</h3>
	<table class="table table-hover">
		<thead>
			<tr>
				<th>Facultad</th>
				<th>Sigla</th>
			
				<th>Acciones</th>
			</tr>
		</thead>
		<tbody>
			@For Each row In ViewData("facultades")
				@<tr>
					
					<td>@row("descripcion")</td>
					<td>@row("sigla")</td>


					<td>
						<a href="/Facultad/Edit/@row("id_facultad")" class="btn btn-primary"><ion-icon name="open"></ion-icon>Editar</a>
						<a href="javascript:EliminarRegistro(@row("id_facultad"))" class="btn btn-primary"><ion-icon name="trash"></ion-icon>Eliminar</a>
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
				url: '/Facultad/Delete',
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