Imports System.Web.Mvc
Imports ClasesProgramaMateria

Namespace Controllers
    Public Class AlumnoController
        Inherits Controller

        ' Obtenemos 
        Function Index() As ActionResult
            Dim dtAlumno As New DataTable
            dtAlumno = Alumno.RecuperarRegistroAlumno
            ViewData("alumno") = dtAlumno.AsEnumerable
            Return View()
        End Function



    End Class
End Namespace