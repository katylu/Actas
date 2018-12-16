Imports System.Web.Mvc
Imports ClasesProgramaMateria

Namespace Controllers
    Public Class ProfesorController
        Inherits Controller

        ' Obtenemos 
        Function Index() As ActionResult
            Dim dtProfesor As New DataTable
            dtProfesor = Profesor.RecuperarRegistroProfesor
            ViewData("profesor") = dtProfesor.AsEnumerable
            Return View()
        End Function



    End Class
End Namespace