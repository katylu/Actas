
@Code
	ViewData("Title") = "Index"
	Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code



<!DOCTYPE html>

<div class="container col-md-8 col-lg-12">
	<h1>Editar Facultad</h1>
	<form action="Edit" method="post">

		<input type="hidden" name="intIdFacultad" value="@Model.pid_facultad" />

		<div class="form-group">
			<label for="txtDescripcion">Nombre</label>
			<input type="text" class="form-control col-md-3" required name="txtDescripcion" value="@Model.pdescripcion">
		</div>

		<div class="form-group">
			<label for="txtSigla">Sigla</label>
			<input type="text" class="form-control col-md-3" required name="txtSigla" value="@Model.psigla">
		</div>

		

		<div Class="form-group">
			<input type="submit" Class="btn btn-primary" value="Guardar" />
			<input type="reset" Class="btn btn-info" value="Cancelar" />
		</div>
	</form>
</div>