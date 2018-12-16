Imports System.Web.Mvc
Imports ClasesProgramaMateria

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            'Establecer la conexión a la base de datos
            'Util.inicializaSesion("M203-06", "Restaurante", "sa", "@lumno123")
            Util.inicializaSesion(ConfigurationManager.AppSettings("server"), ConfigurationManager.AppSettings("db"), ConfigurationManager.AppSettings("user"), ConfigurationManager.AppSettings("password"))
            Return View()
        End Function


        Function Login() As ActionResult
            ' Util.inicializaSesion(ConfigurationManager.AppSettings("server"), ConfigurationManager.AppSettings("db"), ConfigurationManager.AppSettings("user"), ConfigurationManager.AppSettings("password"))
            Return View()
        End Function

        <HttpPost()>
        Function Login(form As FormCollection) As ActionResult
            Dim vLogin As New Login
            With vLogin
                .pusuario = form("txtusuario")
                .pcontraseña = form("txtcontraseña")
                .Loguear()

            End With
            Return RedirectToAction("Index")
        End Function

        'Function Edit(id As Integer) As ActionResult
        '    Dim vFacultad As New Facultad
        '    vFacultad = vFacultad.RecuperarFacultad(id)
        '    Return View(vFacultad)
        'End Function

        '<HttpPost()>
        'Function Edit(form As FormCollection) As ActionResult
        '    'Creamos el objeto de la clase ingrediente
        '    Dim vFacultad As New Facultad
        '    'Asginamos en cada propiedad los datos ingresados desde la vista
        '    With vFacultad
        '        .pid_facultad = form("intIdFacultad")
        '        .pdescripcion = form("txtDescripcion")
        '        .psigla = form("txtSigla")

        '        .ActualizarFacultad() 'Llamamos al metodo para actualizar el registro
        '    End With
        '    'Retornar a la acción index del controlador
        '    Return RedirectToAction("Index")
        'End Function

        'Function Delete(id As Integer) As ActionResult
        '    Dim vFacultad As New Facultad
        '    vFacultad.pid_facultad = id
        '    vFacultad.Eliminar()
        '    'Retornar a la acción index del controlador
        '    Return RedirectToAction("Index")
        'End Function


    End Class
End Namespace