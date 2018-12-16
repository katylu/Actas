Imports ClasesProgramaMateria.Util

Public Class Profesor
    'Atributos 
    Private id_profesor As Integer
    Private ci_profesor As String
    Private nombre As String
    Private apellido As String
    Private id_curso As Integer

    Public Property pid_profesor As Integer
        Get
            Return id_profesor
        End Get
        Set(value As Integer)
            id_profesor = value
        End Set
    End Property

    Public Property pci_profesor As String
        Get
            Return ci_profesor
        End Get
        Set(value As String)
            ci_profesor = value
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

    Public Shared Function RecuperarRegistroProfesor() As DataTable
        Try
            Dim dtProfesor As New Data.DataTable("Profesor")
            dtProfesor = gDatos.TraerDataTable("spListarProfesor")
            Return dtProfesor
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class


