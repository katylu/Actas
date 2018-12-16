@Code
	ViewData("Title") = "Index"
	Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code



<title>Modificar Materia</title>



<div class="container">

	<h2>Modificación de Usuario</h2>

	<form action="edit" method="post" class="form-horizontal">
		<input type="hidden" name="txtId_materia" value="@Model.pid_materia" />

		<div class="form-group">
			<label for="txtFacultadID">Facultad</label>
			<select name="txtFacultadID" class="form-control col-md-3" id="cboFacultad" onchange="recuperar_carreras()">
				<option>Seleccione una Facultad</option>
				@For Each row In ViewData("facultades")
					@<option value="@row("id_facultad")" @IIf(Model.pid_facultad = row("id_facultad"), "Selected", "")>@row("descripcion")</option>
				Next
			</select>
		</div>

		<div class="form-group">
			<label for="txtCarreraID">Carrera</label>
			<select name="txtCarreraID" class="form-control col-md-3" id="cboCarrera" onchange="recuperar_materias()">
				<option>Seleccione una Facultad</option>
				@For Each row In ViewData("carreras")
					@<option value="@row("id_carrera")" @IIf(Model.pid_carrera = row("id_carrera"), "Selected", "")>@row("descripcion")</option>
				Next
			</select>
		</div>

		<div class="form-group">
			<label class="control-label col-xs-3">Código Materia</label>

			<input type="text" class="form-control col-md-3" placeholder="Código Materia" name="txtCodMateria" value="@Model.pcod_materia" />

		</div>

		<div class="form-group">
			<label class="control-label col-xs-3">Materia</label>

			<input type="text" class="form-control col-md-3" placeholder="Materia" name="txtNombreMateria" value="@Model.pnombre_materia" />

		</div>

		<div class="form-group">
			<label for="txtPrerrequisito">Pre-Requisito</label>
			<select name="txtPrerrequisito" class="form-control col-md-3">
				<option>Seleccione Prerrequisito</option>
				@For Each row In ViewData("materias")
					@<option value="@row("id_materia")" @IIf(Model.pid_carrera = row("id_carrera"), "Selected", "")>@row("nombre_materia")</option>
				Next
			</select>
		</div>

		<div class="form-group">
			<label class="control-label col-xs-3">Carga Horaria</label>

			<input type="text" class="form-control col-md-3" placeholder="Carga Horaria" name="intCargaHoraria" value="@Model.pcarga_horaria" />

		</div>



		<div class="form-group">
			<label class="control-label col-xs-3">Cant. Crédito Práctica Asistida</label>

			<input type="number" class="form-control col-md-3" placeholder="Crédito Práctica Asistida" name="intCreditoPractica" value="@Model.pcredito_practica" />

		</div>

		<div class="form-group">
			<label class="control-label col-xs-3">Cant. Crédito Presencial</label>

			<input type="number" class="form-control col-md-3" placeholder="Crédito Presencial" name="intCreditoPresencial" value="@Model.pcredito_presencial" />

		</div>

		<div class="form-group">
			<label for="intDepartamento">Departamento</label>
			<select name="intDepartamento" class="form-control col-md-3">
				@For Each row In ViewData("departamentos")
					@<option value="@row("id_Departamento")" @IIf(Model.pid_Departamento = row("id_Departamento"), "Selected", "")>@row("descripcion")</option>
				Next
			</select>
		</div>


		<div class="form-group">
			<div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
				<button type="submit" class="btn btn-success"> Guardar </button>
				<button type="reset" class="btn btn-primary"> Restablecer </button>
			</div>
		</div>


	</form>
</div>

<script type="text/javascript">
	//Función para recuperar la lista de ingredientes por producto seleccionado
	function recuperar_carreras() {
		var parametro = {
			//obtiene el id del combo de facultad
			id: $("#cboFacultad").val()
		};
		$.ajax({
			type: "POST",
			url: '../../Carrera/getCarrerasPorFacultadID',
			data: parametro,
			dataType: "json",
			success: function (msg) {
				var datos = jQuery.parseJSON(msg);

				var row = "";
				for (i = 0; i < datos.length; i++) {
					//genera a mano cada linea
					row += "<option value=\"" + datos[i].id_carrera + "\">" + datos[i].descripcion + "</option>";
				}
				//las lineas generadas inserta en el combo de carrera
				$("#cboCarrera").html(row);
			},
			error: function () {
				alert("se ha producido un error cargar lsd materias.");
			}
		});
	}

</script>

<script src="~/scripts/jquery-3.3.1.min.js"></script>
<script src="~/js/bootstrap.min.js"></script>
