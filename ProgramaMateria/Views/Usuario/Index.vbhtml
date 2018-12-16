
@Code
	ViewData("Title") = "Index"
	Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code


<!DOCTYPE html>

<html>
<head>
	<meta name="viewport" content="width=device-width" />
	<title>Usuarios del Sistema</title>

	<link href="~/css/bootstrap.min.css" rel="stylesheet" media="screen" />


</head>
<body>
	<div class="container">
		<h3>
			<a href="/Usuario/Create" class="btn btn-primary">Nuevo Usuario</a>
		</h3>
		<table class="table table-hover">

			<tr>
				<td>Usuario</td>
				<td>Contraseña</td>
				<td>Nombre</td>
				<td>Apellido</td>
				<td>Correo</td>
				<td>Fecha de Nacimiento</td>
				<td>Acciones</td>
			</tr>

			@For Each item In ViewData("usuario")

				@<tr>
					<td>@item("usuario")</td>
					<td>@item("contraseña")</td>
					<td>@item("nombre_usuario")</td>
					<td>@item("apellido_usuario")</td>
					<td>@item("correo")</td>
					<td>@item("fecha_nacimiento")</td>



					<td>
						<a href="/Usuario/Edit/@item("id_usuario")" class="btn btn-primary">Modificar</a>
						<a href="javascript:Eliminar(@item("id_usuario"))" class="btn btn-primary">Eliminar</a>
					</td>


				</tr>
			Next
		</table>

	</div>
	<script src="/scripts/jquery-3.3.1.min.js"></script>
	<script src="/js/bootstrap.min.js"></script>

	<script type="text/javascript">
		function Eliminar(id) {
			if (confirm('Desea eliminar a este usuario?')) {

				var parametro = {
					id: id

				};
				$.ajax({
					url: '/Usuario/Eliminar',
					data: parametro,
					type: 'post',
					cache: false,
					success: function (retorno) {
						location.reload();
					},
					error: function () {
						alert('Se ha producido un error.');
					}
				});
			}
		}


	</script>
</body>
</html>
