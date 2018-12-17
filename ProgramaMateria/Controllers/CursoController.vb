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

        Function Acta(id As Integer) As ActionResult
            Dim vAlumnos As New DataTable
            vAlumnos = Alumno.RecuperarAlumnosByCurso(id)
            ViewData("alumnos") = vAlumnos.AsEnumerable

            Dim vCurso As New Curso
            vCurso = vCurso.RecuperarCurso(id)
            Return View(vCurso)
        End Function

        <HttpPost()>
        Function Acta(form As FormCollection) As ActionResult

            System.Diagnostics.Debug.WriteLine(form)
            Return RedirectToAction("Index")
        End Function

    End Class
End Namespace