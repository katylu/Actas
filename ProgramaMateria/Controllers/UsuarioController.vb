Imports System.Web.Mvc
Imports ClasesProgramaMateria

Namespace Controllers
    Public Class UsuarioController
        Inherits Controller

        ' GET: Usuario
        Function Index() As ActionResult
            Dim dtUsuario As New DataTable
            dtUsuario = Usuario.RecuperarRegistrosUsuario
            ViewData("usuario") = dtUsuario.AsEnumerable
            Return View()
        End Function

        Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost()>
        Function Create(form As FormCollection) As ActionResult
            'Creamos el objeto de la clase categoria
            Dim vUsuario As New Usuario
            'Asginamos en cada propiedad los datos ingresados desde la vista
            With vUsuario
                .pusuario = form("txtUsuario")
                .pcontraseña = form("txtContraseña")
                .pnombre_usuario = form("txtNombreUsuario")
                .papellido_usuario = form("txtApellidoUsuario")
                .pcorreo = form("txtCorreo")
                .pfecha_nacimiento = form("dateFechaNacimiento")
                .Insertar() 'Llamamos al metodo para guardar el registro
            End With
            Return RedirectToAction("Index")

        End Function

        Function Edit(id As Integer) As ActionResult
            Dim vUsuario As New Usuario
            vUsuario = vUsuario.RecuperarRegistro(id)
            Return View(vUsuario)
        End Function

        <HttpPost()>
        Function Edit(form As FormCollection) As ActionResult
            'Creamos el objeto de la clase categoria
            Dim vUsuario As New Usuario
            'Asginamos en cada propiedad los datos ingresados desde la vista
            With vUsuario
                .pid_usuario = form("txtId_usuario")
                .pusuario = form("txtUsuario")
                .pcontraseña = form("txtContraseña")
                .pnombre_usuario = form("txtNombreUsuario")
                .papellido_usuario = form("txtApellidoUsuario")
                .pcorreo = form("txtcorreo")
                .pfecha_nacimiento = form("dateFechaNacimiento")
                .Actualizar() 'Llamamos al metodo para actualizar el registro
            End With
            'Retornar a la acción index del controlador
            Return RedirectToAction("Index")
        End Function

        Function Eliminar(id As Integer) As ActionResult
            Dim vUsuario As New Usuario
            vUsuario.pid_usuario = id
            vUsuario.Eliminar()
            'Retornar a la acción index del controlador
            Return RedirectToAction("Index")
        End Function
    End Class
End Namespace