
@Code
	ViewData("Title") = "Index"
	Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code

<!DOCTYPE html>

<div class="container col-md-8 col-lg-12">
	<h1>Nuevo Departamento</h1>
	<form action="Create" method="post">

		<div class="form-group">
			<label for="txtDescripcion">Nombre</label>
			<input type="text" class="form-control col-md-3" required name="txtDescripcion">
		</div>

		<div class="form-group">
			<label for="intIdFacultad">Facultad</label>
			<select name="intIdFacultad" class="form-control col-md-3">
				@For Each row In ViewData("facultades")

					@<option value="@row("id_facultad")">@row("descripcion")</option>
				Next
			</select>
		</div>

		<div Class="form-group">
			<input type="submit" Class="btn btn-primary" value="Guardar" />
			<input type="reset" Class="btn btn-info" value="Cancelar" />
		</div>
	</form>
</div>
