Imports System.Web.Mvc
Imports ClasesProgramaMateria

Namespace Controllers
    Public Class CarreraController
        Inherits Controller

        Function Index() As ActionResult
            Dim dtCarrera As New DataTable
            Dim vCarrera As New Carrera
            dtCarrera = vCarrera.RecuperarCarrera

            ViewData("carreras") = dtCarrera.AsEnumerable
            Return View()
        End Function



        Function Create() As ActionResult

            Dim vFacultad As New Facultad
            ViewData("facultades") = vFacultad.RecuperarFacultad.AsEnumerable


            Return View()
        End Function

        <HttpPost()>
        Function Create(form As FormCollection) As ActionResult
            'Creamos el objeto de la clase 
            Dim vCarrera As New Carrera
            'Asginamos en cada propiedad los datos ingresados desde la vista
            With vCarrera
                .pdescripcion = form("txtDescripcion")
                .pid_facultad = form("intIdFacultad")
                .InsertarCarrera() 'Llamamos al metodo para guardar el registro
            End With
            'Retornar a la acción index del controlador
            Return RedirectToAction("Index")
        End Function

        Function Edit(id As Integer) As ActionResult
            Dim vFacultad As New Facultad
            ViewData("facultades") = vFacultad.RecuperarFacultad.AsEnumerable


            Dim vCarrera As New Carrera
            vCarrera = vCarrera.RecuperarCarrera(id)
            Return View(vCarrera)
        End Function

        <HttpPost()>
        Function Edit(form As FormCollection) As ActionResult
            'Creamos el objeto de la clase
            Dim vCarrera As New Carrera
            'Asginamos en cada propiedad los datos ingresados desde la vista
            With vCarrera
                .pid_carrera = form("intIdCarrera")
                .pdescripcion = form("txtDescripcion")
                .pid_facultad = form("intIdFacultad")

                .ActualizarCarrera() 'Llamamos al metodo para actualizar el registro
            End With
            'Retornar a la acción index del controlador
            Return RedirectToAction("Index")
        End Function

        Function Delete(id As Integer) As ActionResult
            Dim vCarrera As New Carrera
            vCarrera.pid_carrera = id
            vCarrera.Eliminar()
            'Retornar a la acción index del controlador
            Return RedirectToAction("Index")
        End Function

        Function getCarrerasPorFacultadID(id As Integer) As JsonResult
            Dim dt As New DataTable
            dt = Carrera.RecuperarCarrerasPorFacultadID(id)
            Return Json(Newtonsoft.Json.JsonConvert.SerializeObject(dt))
        End Function

    End Class
End Namespace