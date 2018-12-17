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
    Private departamento As String
    Private facultad As String
    Private carrera As String

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
            Return semestre
        End Get
        Set(value As String)
            semestre = value
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

    Public Property pdepartamento As String
        Get
            Return departamento
        End Get
        Set(value As String)
            departamento = value
        End Set
    End Property

    Public Property pfacultad As String
        Get
            Return facultad
        End Get
        Set(value As String)
            facultad = value
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

    Public Shared Function RecuperarRegistroCurso() As DataTable
        Try
            Dim dtCurso As New Data.DataTable("Curso")
            dtCurso = gDatos.TraerDataTable("spListarCurso")
            Return dtCurso
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RecuperarCurso(vCodCurso As Integer) As Curso
        Dim dtCurso As New DataTable
        dtCurso = gDatos.TraerDataTable("spConsultarCurso", vCodCurso)
        If dtCurso.Rows.Count > 0 Then
            Dim vCurso As New Curso
            With vCurso
                .id_curso = dtCurso.Rows(0).Item("id_curso")
                .nro_curso = dtCurso.Rows(0).Item("nro_curso")
                .aula = dtCurso.Rows(0).Item("aula")
                .materia = dtCurso.Rows(0).Item("materia")
                .profesor = dtCurso.Rows(0).Item("nombre") + " " + dtCurso.Rows(0).Item("apellido")
                .seccion = dtCurso.Rows(0).Item("seccion")
                .turno = dtCurso.Rows(0).Item("turno")
                .semestre = dtCurso.Rows(0).Item("semestre")
                .departamento = dtCurso.Rows(0).Item("departamento")
                .facultad = dtCurso.Rows(0).Item("facultad")
                .carrera = dtCurso.Rows(0).Item("carrera")
            End With
            Return vCurso
        Else
            Return Nothing
        End If
    End Function
End Class

