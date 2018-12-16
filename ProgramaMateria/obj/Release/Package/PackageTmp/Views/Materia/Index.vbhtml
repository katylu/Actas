
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code




<title>Materias del Sistema</title>

 
    <div class="container">
        <h3>
            <a href="/Materia/Create" class="btn btn-primary">Nueva Materia</a>
        </h3>
        <table class="table table-hover">

			<tr>
				<td>Codigo de Materia</td>
				<td>Materia</td>
				<td>Departamento</td>
				<td>Carrera</td>
				<td>Acciones</td>
			</tr>

            @For Each item In ViewData("materia")

                @<tr>
                    <td>@item("cod_materia")</td>
                    <td>@item("nombre_materia")</td>
                    <td>@item("departamento")</td>
                    <td>@item("carrera")</td>

					<td>
						<a href="/Materia/Edit/@item("id_Materia")" class="btn btn-primary">Modificar</a>
						<a href="/Materia/Edit/@item("id_Materia")" class="btn btn-info">Documento</a>
						<a href="javascript:Eliminar(@item("id_materia"))" class="btn btn-primary">Eliminar</a>
					</td>


                </tr>
            Next
        </table>

    </div>
    <script src="/scripts/jquery-3.3.1.min.js"></script>
    <script src="/js/bootstrap.min.js"></script>

   
