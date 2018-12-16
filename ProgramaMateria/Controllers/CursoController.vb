Imports System.Web.Mvc
Imports ClasesProgramaMateria

Namespace Controllers
    Public Class CursoController
        Inherits Controller

        ' Obtenemos 
        Function Index() As ActionResult
            Dim dtCurso As New DataTable
            dtCurso = Curso.RecuperarRegistroCurso
            ViewData("curso") = dtCurso.AsEnumerable
            Return View()
        End Function

    End Class
End Namespace