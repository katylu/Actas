Imports System.Web.Mvc
Imports ClasesProgramaMateria
Imports System.Net
Namespace Controllers
    Public Class ProgramaController
        Inherits Controller

        ' GET: Programa
        Function Index() As ActionResult
            Dim dtPrograma As New DataTable
            dtPrograma = Programa.RecuperarRegistroPrograma
            ViewData("programas") = dtPrograma.AsEnumerable
            Return View()
        End Function

        Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost(), ValidateInput(False)>
        Function Create(form As FormCollection) As ActionResult

            'Creamos el objeto de la clase categoria
            Dim Programa As New Programa
            'Asginamos en cada propiedad los datos ingresados desde la vista
            With Programa
                .pprograma = form("programa")
                .pestado = form("estado")
                .Insertar()
            End With
            Return RedirectToAction("Index")


        End Function

        Function Edit(id As Integer) As ActionResult
            Dim vPrograma As New Programa
            vPrograma = vPrograma.RecuperarRegistroPrograma(id)
            Return View(vPrograma)
        End Function

        <HttpPost(), ValidateInput(False)>
        Function Edit(form As FormCollection) As ActionResult
            'Creamos el objeto de la clase ingrediente
            Dim vPrograma As New Programa
            'Asginamos en cada propiedad los datos ingresados desde la vista
            With vPrograma
                .pprograma = form("programa")

                .pestado = form("estado")
                .ActualizarPrograma() 'Llamamos al metodo para actualizar el registro
            End With
            'Retornar a la acción index del controlador
            Return RedirectToAction("Index")
        End Function

        Function Visualizar(id As Integer) As ActionResult
            Dim vPrograma As New Programa
            vPrograma = vPrograma.RecuperarRegistroPrograma(id)
            Return View(vPrograma)
        End Function

        Function Eliminar(id As Integer) As ActionResult
            Dim vPrograma As New Programa
            vPrograma.pid_programa = id
            vPrograma.Eliminar()
            'Retornar a la acción index del controlador
            Return RedirectToAction("Index")
        End Function

    End Class
End Namespace