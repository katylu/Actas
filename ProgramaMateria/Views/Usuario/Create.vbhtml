
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code


    <title>Agregar Nuevo Usuario </title>


    <div class="container">

        <h2>Agregar Nuevo Usuario</h2>

        <form action="create" method="post" class="form-horizontal">
            <div class="form-group">
                <label class="control-label col-xs-3">Usuario</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <input type="text" class="form-control" placeholder="Usuario" name="txtUsuario" />
                </div>
            </div>


            <div class="form-group">
                <label class="control-label col-xs-3">Contraseña</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <input type="text" class="form-control" placeholder="Contraseña" name="txtContraseña" />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-xs-3">Nombre</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <input type="text" class="form-control" placeholder="Nombre" name="txtNombreUsuario" />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-xs-3">Apellido</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <input type="text" class="form-control" placeholder="Apellido" name="txtApellidoUsuario" />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-xs-3">Correo</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <input type="text" class="form-control" placeholder="Correo" name="txtCorreo" />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-xs-3">Fecha de Nacimiento</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <input type="date" class="form-control" placeholder="Fecha de Nacimiento" name="dateFechaNacimiento" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <button type="submit" class="btn btn-success"> Guardar </button>
                    <button type="reset" class="btn btn-primary"> Restablecer </button>
                </div>
            </div>


        </form>
    </div>

    <script src="~/scripts/jquery-3.3.1.min.js"></script>
    <script src="~/js/bootstrap.min.js"></script>
