
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code




<title>Materias del Sistema</title>

 
    <div class="container">
        <h3>
            <a href="/Materia/Create" class="btn btn-primary">Materias</a>
        </h3>
        <table class="table table-hover">

			<tr>
				<th>Codigo de Materia</th>
				<th>Materia</th>
				<th>Departamento</th>
				<th>Carrera</th>
				<td></td>
			</tr>

            @For Each item In ViewData("materia")

                @<tr>
                    <td>@item("cod_materia")</td>
                    <td>@item("nombre_materia")</td>
                    <td>@item("departamento")</td>
                    <td>@item("carrera")</td>

					

                </tr>
            Next
        </table>

    </div>
    <script src="/scripts/jquery-3.3.1.min.js"></script>
    <script src="/js/bootstrap.min.js"></script>

   
