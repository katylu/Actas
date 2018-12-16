Imports ClasesProgramaMateria.Util

Public Class Curso
    'Atributos 
    Private id_curso As Integer
    Private nro_curso As Integer
    Private materia As String
    Private profesor As String
    Private semestre As String
    Private turno As String
    Private aula As String
    Private seccion As String

    Public Property pid_curso As Integer
        Get
            Return id_curso
        End Get
        Set(value As Integer)
            id_curso = value
        End Set
    End Property

    Public Property pnro_curso As Integer
        Get
            Return nro_curso
        End Get
        Set(value As Integer)
            nro_curso = value
        End Set
    End Property

    Public Property pmateria As String
        Get
            Return materia
        End Get
        Set(value As String)
            materia = value
        End Set
    End Property

    Public Property pprofesor As String
        Get
            Return profesor
        End Get
        Set(value As String)
            profesor = value
        End Set
    End Property

    Public Property psemestre As String
        Get
            Return psemestre
        End Get
        Set(value As String)
            psemestre = value
        End Set
    End Property

    Public Property pturno As String
        Get
            Return turno
        End Get
        Set(value As String)
            turno = value
        End Set
    End Property

    Public Property paula As String
        Get
            Return aula
        End Get
        Set(value As String)
            aula = value
        End Set
    End Property

    Public Property pseccion As String
        Get
            Return seccion
        End Get
        Set(value As String)
            seccion = value
        End Set
    End Property


    Public Shared Function RecuperarRegistroCurso() As DataTable
        Try
            Dim dtCurso As New Data.DataTable("Curso")
            dtCurso = gDatos.TraerDataTable("spListarCurso")
            Return dtCurso
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class

