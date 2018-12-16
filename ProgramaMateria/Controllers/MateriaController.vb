Imports System.Web.Mvc
Imports ClasesProgramaMateria

Namespace Controllers
    Public Class MateriaController
        Inherits Controller

        ' Obtenemos 
        Function Index() As ActionResult
            Dim dtMateria As New DataTable
            dtMateria = Materia.RecuperarRegistroMateria
            ViewData("materia") = dtMateria.AsEnumerable
            Return View()
        End Function

    End Class
End Namespace