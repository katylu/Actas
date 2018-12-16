
Imports ClasesProgramaMateria.Util

Public Class Carrera

    Private id_carrera As Integer
    Private descripcion As String
    Private id_facultad As Integer

    Public Property pid_carrera As Integer
        Get
            Return id_carrera
        End Get
        Set(value As Integer)
            id_carrera = value
        End Set
    End Property

    Public Property pdescripcion As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    Public Property pid_facultad As Integer
        Get
            Return id_facultad
        End Get
        Set(value As Integer)
            id_facultad = value
        End Set
    End Property


    'Metodos

    Public Sub InsertarCarrera()
        gDatos.Ejecutar("spInsertarCarrera", Me.descripcion, Me.id_facultad)
    End Sub
    Public Sub ActualizarCarrera()
        gDatos.Ejecutar("spActualizarCarrera", Me.id_carrera, Me.descripcion, Me.id_facultad)
    End Sub
    Public Sub Eliminar()
        gDatos.Ejecutar("spEliminarCarrera", Me.id_carrera)
    End Sub

    Public Function RecuperarCarrera() As DataTable
        Dim dtCarrera As New DataTable
        dtCarrera = gDatos.TraerDataTable("spConsultarCarrera", 0)
        Return dtCarrera
    End Function

    Public Function RecuperarCarrera(vCodCarrera As Integer) As Carrera
        Dim dtCarrera As New DataTable
        dtCarrera = gDatos.TraerDataTable("spConsultarCarrera", vCodCarrera)
        If dtCarrera.Rows.Count > 0 Then
            Dim vCarrera As New Carrera
            With vCarrera
                .id_carrera = dtCarrera.Rows(0).Item("id_carrera")
                .descripcion = dtCarrera.Rows(0).Item("descripcion")
                .id_facultad = dtCarrera.Rows(0).Item("id_facultad")

            End With
            Return vCarrera
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function RecuperarCarrerasPorFacultadID(id As Integer) As DataTable
        Dim dtCarrera As New DataTable
        dtCarrera = gDatos.TraerDataTable("spListarCarreraPorFacultad", id)
        Return dtCarrera
    End Function

End Class
