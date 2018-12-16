Imports ClasesProgramaMateria.Util

Public Class Materia
    'Atributos 
    Private id_materia As Integer
    Private cod_materia As String
    Private nombre_materia As String
    Private departamento As String
    Private carrera As String

    Public Property pid_materia As Integer
        Get
            Return id_materia
        End Get
        Set(value As Integer)
            id_materia = value
        End Set
    End Property

    Public Property pcod_materia As String
        Get
            Return cod_materia
        End Get
        Set(value As String)
            cod_materia = value
        End Set
    End Property

    Public Property pnombre_materia As String
        Get
            Return nombre_materia
        End Get
        Set(value As String)
            nombre_materia = value
        End Set
    End Property

    Public Property pdepartamento As String
        Get
            Return departamento
        End Get
        Set(value As String)
            departamento = value
        End Set
    End Property

    Public Property pcarrera As String
        Get
            Return carrera
        End Get
        Set(value As String)
            carrera = value
        End Set
    End Property

    Public Shared Function RecuperarRegistroMateria() As DataTable
        Try
            Dim dtMateria As New Data.DataTable("Materia")
            dtMateria = gDatos.TraerDataTable("spListarMateria")
            Return dtMateria
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class

