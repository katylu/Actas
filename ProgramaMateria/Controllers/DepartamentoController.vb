Imports System.Web.Mvc
Imports ClasesProgramaMateria


Namespace Controllers

    Public Class DepartamentoController
        Inherits Controller

        ' GET: Departamento
        Function Index() As ActionResult
            Dim dtDepartamento As New DataTable
            Dim vDepartamento As New Departamento
            dtDepartamento = vDepartamento.RecuperarDepartamento

            ViewData("departamentos") = dtDepartamento.AsEnumerable
            Return View()
        End Function
        Function Create() As ActionResult

            Dim vFacultad As New Facultad
            ViewData("facultades") = vFacultad.RecuperarFacultad.AsEnumerable

            Return View()
        End Function
        <HttpPost()>
        Function Create(form As FormCollection) As ActionResult
            'Creamos el objeto de la clase departamento
            Dim vDepartamento As New Departamento
            'Asginamos en cada propiedad los datos ingresados desde la vista
            With vDepartamento
                .pDescripcion = form("txtDescripcion")
                .pId_facultad = form("intIdFacultad")
                .InsertarDepartamento() 'Llamamos al metodo para guardar el registro
            End With
            'Retornar a la acción index del controlador
            Return RedirectToAction("Index")
        End Function

        Function Edit(id As Integer) As ActionResult

            Dim vFacultad As New Facultad
            ViewData("facultades") = vFacultad.RecuperarFacultad.AsEnumerable

            Dim vDepartamento As New Departamento
            vDepartamento = vDepartamento.RecuperarDepartamento(id)
            Return View(vDepartamento)
        End Function

        <HttpPost()>
        Function Edit(form As FormCollection) As ActionResult
            'Creamos el objeto de la clase ingrediente
            Dim vDepartamento As New Departamento
            'Asginamos en cada propiedad los datos ingresados desde la vista
            With vDepartamento
                .pId_Departamento = form("intIdDepartamento")
                .pDescripcion = form("txtDescripcion")
                .pId_facultad = form("intIdFacultad")

                .ActualizarDepartamento() 'Llamamos al metodo para actualizar el registro
            End With
            'Retornar a la acción index del controlador
            Return RedirectToAction("Index")
        End Function

        Function Delete(id As Integer) As ActionResult
            Dim vDepartamento As New Departamento
            vDepartamento.pId_Departamento = id
            vDepartamento.Eliminar()
            'Retornar a la acción index del controlador
            Return RedirectToAction("Index")
        End Function


        Function getDepartamentoPorMateria(id As Integer) As JsonResult
            Dim dt As New DataTable
            dt = Departamento.RecuperarDepartamentoPorMateria(id)
            Return Json(Newtonsoft.Json.JsonConvert.SerializeObject(dt))
        End Function
    End Class

End Namespace