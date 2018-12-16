Imports ClasesProgramaMateria.Util

Public Class Alumno

    'Atributos 
    Private id_alumno As Integer
    Private ci_alumno As String
    Private nombre As String
    Private apellido As String
    Private id_curso As Integer

    Public Property pid_alumno As Integer
        Get
            Return id_alumno
        End Get
        Set(value As Integer)
            id_alumno = value
        End Set
    End Property

    Public Property pci_alumno As String
        Get
            Return ci_alumno
        End Get
        Set(value As String)
            ci_alumno = value
        End Set
    End Property

    Public Property pnombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property papellido As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public Property pid_curso As Integer
        Get
            Return id_curso
        End Get
        Set(value As Integer)
            id_curso = value
        End Set
    End Property




    'Metodos de la clase

    Public Shared Function RecuperarRegistroAlumno() As DataTable
        Try
            Dim dtAlumno As New Data.DataTable("Alumno")
            dtAlumno = gDatos.TraerDataTable("spListarAlumno")
            Return dtAlumno
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class


