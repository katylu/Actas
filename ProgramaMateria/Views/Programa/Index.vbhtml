
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code

<title>Programas</title>


<div class="container">
    <h3>
        <a href="/Programa/Create" class="btn btn-primary">Nuevo Programa</a>
    </h3>
    <table class="table table-hover">
        <thead>
            <tr>
                <th>Estado</th>
                <th>Acciones</th>
            </tr>
        </thead>
        <tbody>
            @For Each row In ViewData("programas")
                @<tr>

                    
                    <td>@row("estado")</td>


                    <td>
                        <a href="/Programa/Edit/@row("id_programa")" class="btn btn-primary"><ion-icon name="open"></ion-icon>Editar</a>
                        <a href="javascript:EliminarRegistro(@row("id_programa"))" class="btn btn-primary"><ion-icon name="trash"></ion-icon>Eliminar</a>
                        <a href="/Programa/Visualizar/@row("id_programa")" class="btn btn-primary"><ion-icon name="open"></ion-icon>Visualizar</a>
                    </td>


                </tr>Next
        </tbody>
    </table>
</div>

<script type="text/javascript">
	function EliminarRegistro(id) {
		if (confirm('¿Desea eliminar el registro?')) {
			$.ajax({
				url: '/Programa/Eliminar',
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