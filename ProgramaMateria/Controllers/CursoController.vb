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
            Dim dtAlumnos As New DataTable
            dtAlumnos = Alumno.RecuperarAlumnosByCurso(form("intIdCurso"))

            'Guardamos el acta
            Dim vActa As New Acta
            With vActa
                .InsertarActa(form("fecha-examen"), form("intIdCurso"), form("tipo-examen"), form("estado"))
            End With

            For Each row As DataRow In dtAlumnos.Rows
                Dim puntos = "puntos-" + row("id_alumno").ToString
                Dim letras = "letras-" + row("id_alumno").ToString

                'Guardamos las notas de los alumnos
                With vActa
                    .InsertarActaAlumnos(form(puntos), form(letras), row("id_alumno"), form("intIdCurso"))
                End With

            Next row

            Return RedirectToAction("../Acta")
        End Function

    End Class
End Namespace