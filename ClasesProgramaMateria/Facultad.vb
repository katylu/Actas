Imports ClasesProgramaMateria.Util

Public Class Facultad

    Private id_facultad As Integer
    Private descripcion As String
    Private sigla As String

    Public Property pid_facultad As Integer
        Get
            Return id_facultad
        End Get
        Set(value As Integer)
            id_facultad = value
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

    Public Property psigla As String
        Get
            Return sigla
        End Get
        Set(value As String)
            sigla = value
        End Set
    End Property


    'Metodos

    Public Sub InsertarFacultad()
        gDatos.Ejecutar("spInsertarFacultad", Me.descripcion, Me.sigla)
    End Sub
    Public Sub ActualizarFacultad()
        gDatos.Ejecutar("spActualizarFacultad", Me.id_facultad, Me.descripcion, Me.sigla)
    End Sub
    Public Sub Eliminar()
        gDatos.Ejecutar("spEliminarFacultad", Me.id_facultad)
    End Sub

    Public Function RecuperarFacultad() As DataTable
        Dim dtFacultad As New DataTable
        dtFacultad = gDatos.TraerDataTable("spConsultarFacultad", 0)
        Return dtFacultad
    End Function

    Public Function RecuperarFacultad(vCodFacultad As Integer) As Facultad
        Dim dtFacultad As New DataTable
        dtFacultad = gDatos.TraerDataTable("spConsultarFacultad", vCodFacultad)
        If dtFacultad.Rows.Count > 0 Then
            Dim vFacultad As New Facultad
            With vFacultad
                .id_facultad = dtFacultad.Rows(0).Item("id_facultad")
                .descripcion = dtFacultad.Rows(0).Item("descripcion")
                .sigla = IIf(dtFacultad.Rows(0).IsNull(2), "", dtFacultad.Rows(0).Item("sigla")) 'asi tratamos los valores que pueden ser nulos en la bd

            End With
            Return vFacultad
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function RecuperarRegistrosFacultad() As DataTable
        Try
            Dim dtFacultad As New Data.DataTable("Facultad")
            dtFacultad = gDatos.TraerDataTable("spConsultarFacultad", 0)
            Return dtFacultad
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
