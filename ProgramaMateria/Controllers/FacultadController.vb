Imports System.Web.Mvc
Imports ClasesProgramaMateria


Namespace Controllers

    Public Class FacultadController
        Inherits Controller

        ' GET: Departamento
        Function Index() As ActionResult
            Dim dtFacultad As New DataTable
            Dim vFacultad As New Facultad
            dtFacultad = vFacultad.RecuperarFacultad

            ViewData("facultades") = dtFacultad.AsEnumerable
            Return View()
        End Function
        Function Create() As ActionResult
            Return View()
        End Function
        <HttpPost()>
        Function Create(form As FormCollection) As ActionResult
            'Creamos el objeto de la clase departamento
            Dim vFacultad As New Facultad
            'Asginamos en cada propiedad los datos ingresados desde la vista
            With vFacultad
                .pdescripcion = form("txtDescripcion")
                .psigla = form("txtSigla")
                .InsertarFacultad() 'Llamamos al metodo para guardar el registro
            End With
            'Retornar a la acción index del controlador
            Return RedirectToAction("Index")
        End Function

        Function Edit(id As Integer) As ActionResult
            Dim vFacultad As New Facultad
            vFacultad = vFacultad.RecuperarFacultad(id)
            Return View(vFacultad)
        End Function

        <HttpPost()>
        Function Edit(form As FormCollection) As ActionResult
            'Creamos el objeto de la clase ingrediente
            Dim vFacultad As New Facultad
            'Asginamos en cada propiedad los datos ingresados desde la vista
            With vFacultad
                .pid_facultad = form("intIdFacultad")
                .pdescripcion = form("txtDescripcion")
                .psigla = form("txtSigla")

                .ActualizarFacultad() 'Llamamos al metodo para actualizar el registro
            End With
            'Retornar a la acción index del controlador
            Return RedirectToAction("Index")
        End Function

        Function Delete(id As Integer) As ActionResult
            Dim vFacultad As New Facultad
            vFacultad.pid_facultad = id
            vFacultad.Eliminar()
            'Retornar a la acción index del controlador
            Return RedirectToAction("Index")
        End Function



    End Class

End Namespace