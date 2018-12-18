Imports System.Web.Mvc
Imports ClasesProgramaMateria
Namespace Controllers
    Public Class ActaController
        Inherits Controller


        Function Index() As ActionResult
            Dim dtActa As New DataTable
            dtActa = Acta.RecuperarRegistroActa()
            ViewData("acta") = dtActa.AsEnumerable
            Return View()
        End Function

        Function Curso(id As Integer) As ActionResult
            Dim dtActa As New DataTable
            dtActa = Acta.RecuperarRegistroActaByCurso(id)
            ViewData("acta") = dtActa.AsEnumerable
            Return View()
        End Function

        Function Edit(id As Integer) As ActionResult
            Dim vActaAlumnos As New DataTable
            vActaAlumnos = ActaAlumno.RecuperarAlumnosByActa(id)
            ViewData("alumnos") = vActaAlumnos.AsEnumerable

            Dim vActa As New Acta
            vActa = vActa.RecuperarActa(id)
            Return View(vActa)
        End Function

        <HttpPost()>
        Function Edit(form As FormCollection) As ActionResult
            Dim dtAlumnos As New DataTable
            dtAlumnos = Alumno.RecuperarAlumnosByCurso(form("intIdCurso"))

            'Actualizamos el acta
            Dim vActa As New Acta
            With vActa
                .ActualizarActa(form("intIdActa"), form("estado"))
            End With

            For Each row As DataRow In dtAlumnos.Rows
                Dim id = "id-" + row("id_alumno").ToString
                Dim puntos = "puntos-" + row("id_alumno").ToString
                Dim letras = "letras-" + row("id_alumno").ToString

                'Guardamos las notas de los alumnos
                With vActa
                    .ActualizarActaAlumno(form(id), form(puntos), form(letras))
                End With

            Next row

            Return RedirectToAction("Index")
        End Function

    End Class
End Namespace