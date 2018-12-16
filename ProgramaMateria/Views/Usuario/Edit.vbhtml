@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Plantilla/Admin.vbhtml"
End Code



    <title>Modificar Usuario</title>



    <div class="container">

        <h2>Modificación de Usuario</h2>

        <form action="edit" method="post" class="form-horizontal">
            <input type="hidden" name="txtId_usuario" value="@Model.pid_usuario" />

            <div class="form-group">
                <label class="control-label col-xs-3">Usuario</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <input type="text" class="form-control" placeholder="Contraseña" name="txtUsuario" value="@Model.pusuario" />
                </div>
            </div>


            <div class="form-group">
                <label class="control-label col-xs-3">Contraseña</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <input type="text" class="form-control" placeholder="Contraseña" name="txtContraseña" value="@Model.pcontraseña" />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-xs-3">Nombre</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <input type="text" class="form-control" placeholder="Nombre" name="txtNombreUsuario" value="@Model.pnombre_usuario" />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-xs-3">Apellido</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <input type="text" class="form-control" placeholder="Apellido" name="txtApellidoUsuario" value="@Model.papellido_usuario" />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-xs-3">Correo</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <input type="text" class="form-control" placeholder="Correo" name="txtCorreo" value="@Model.pcorreo" />
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-xs-3">Fecha de Nacimiento</label>
                <div class="col-xs-9 col-sm-4 col-md-9 col-lg-4">
                    <input type="text" class="form-control" placeholder="Fecha de Nacimiento" name="dateFechaNacimiento" value="@Model.pfecha_nacimiento" />
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
