
@Code
	ViewData("Title") = "Index"
	Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code




<title>Agregar Nueva Materia </title>


<div class="container">

	<h3>Agregar Nueva Materia</h3>
	<br>
	<form action="create" method="post" class="form-horizontal">

		<div class="form-group">
			<label for="txtFacultadID">Facultad</label>
			<select name="txtFacultadID" class="form-control col-md-3" id="cboFacultad" onchange="recuperar_carreras()">
				<option>Seleccione una Facultad</option>
				@For Each row In ViewData("facultades")
					@<option value="@row("id_facultad")">@row("descripcion")</option>
				Next
			</select>
		</div>

		<div class="form-group">
			<label for="txtCarreraID">Carrera</label>
			<select name="txtCarreraID" class="form-control col-md-3" id="cboCarrera" onchange="recuperar_materias()">
				<option>Seleccione una carrera</option>
			</select>
		</div>

		<div class="form-group">
			<label class="control-label col-xs-3">Código Materia</label>

			<input type="text" class="form-control col-md-3" placeholder="Código Materia" name="txtCodMateria" />

		</div>

		<div class="form-group">
			<label class="control-label col-xs-3">Materia</label>

			<input type="text" class="form-control col-md-3" placeholder="Materia" name="txtNombreMateria" />

		</div>

		<div class="form-group">
			<label for="txtPrerrequisito">Pre-Requisito</label>
			<select name="txtPrerrequisito" class="form-control col-md-3">
				<option>Seleccione Prerrequisito</option> 
				@For Each row In ViewData("materias")
					@<option value="@row("id_materia")">@row("nombre_materia")</option>
				Next
			</select>
		</div>

		<div class="form-group">
			<label class="control-label col-xs-3">Carga Horaria</label>

			<input type="text" class="form-control col-md-3" placeholder="Carga Horaria" name="intCargaHoraria" />

		</div>



		<div class="form-group">
			<label class="control-label col-xs-3">Cant. Crédito Práctica Asistida</label>

			<input type="number" class="form-control col-md-3" placeholder="Crédito Práctica Asistida" name="intCreditoPractica" />

		</div>

		<div class="form-group">
			<label class="control-label col-xs-3">Cant. Crédito Presencial</label>

			<input type="number" class="form-control col-md-3" placeholder="Crédito Presencial" name="intCreditoPresencial" />

		</div>

		<div class="form-group">
			<label for="intDepartamento">Departamento</label>
			<select name="intDepartamento" class="form-control col-md-3">
				@For Each row In ViewData("departamentos")
					@<option value="@row("id_Departamento")">@row("descripcion")</option>
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
					row += "<option value=\""+datos[i].id_carrera+"\">" + datos[i].descripcion + "</option>";
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
