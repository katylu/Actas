Imports ClasesProgramaMateria.Util

Public Class Departamento
    'Atributos 
    Private id_Departamento As Integer
    Private Descripcion As String
    Private id_facultad As Integer

    Public Property pId_Departamento As Integer
        Get
            Return id_Departamento
        End Get
        Set(value As Integer)
            id_Departamento = value
        End Set
    End Property

    Public Property pDescripcion As String
        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property

    Public Property pId_facultad As Integer
        Get
            Return id_facultad
        End Get
        Set(value As Integer)
            id_facultad = value
        End Set
    End Property




    'Metodos de la clase
    Public Sub InsertarDepartamento()
        gDatos.Ejecutar("spInsertarDepartamento", Me.Descripcion, Me.id_facultad)
    End Sub
    Public Sub ActualizarDepartamento()
        gDatos.Ejecutar("spActualizarDepartamento", Me.id_Departamento, Me.Descripcion, Me.id_facultad)
    End Sub
    Public Sub Eliminar()
        gDatos.Ejecutar("spEliminarDepartamento", Me.id_Departamento)
    End Sub
    Public Function RecuperarDepartamento() As DataTable
        Dim dtIngrediente As New DataTable
        dtIngrediente = gDatos.TraerDataTable("spConsultarDepartamento", 0)
        Return dtIngrediente
    End Function
    Public Function RecuperarDepartamento(vCodDepartamento As Integer) As Departamento
        Dim dtDepartamento As New DataTable
        dtDepartamento = gDatos.TraerDataTable("spConsultarDepartamento", vCodDepartamento)
        If dtDepartamento.Rows.Count > 0 Then
            Dim vDepartamento As New Departamento
            With vDepartamento
                .id_Departamento = dtDepartamento.Rows(0).Item("id_Departamento")
                .Descripcion = dtDepartamento.Rows(0).Item("descripcion")
                .id_facultad = dtDepartamento.Rows(0).Item("id_facultad")

            End With
            Return vDepartamento
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function RecuperarDepartamentoPorMateria(id As Integer) As DataTable
        Dim dtDepartamento As New DataTable
        dtDepartamento = gDatos.TraerDataTable("spConsultarDepartamentoPorMateria", id)
        Return dtDepartamento
    End Function
End Class
