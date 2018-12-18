﻿
Imports ClasesProgramaMateria.Util

Public Class ActaAlumno

    'Atributos 
    Private id_acta As Integer
    Private id_curso As Integer
    Private tipo As String
    Private fecha_examen As Date
    Private curso As String
    Private materia As String
    Private carrera As String
    Private turno As String

    Private nro_curso As Integer
    Private profesor As String
    Private semestre As String
    Private aula As String
    Private seccion As String
    Private departamento As String
    Private facultad As String
    Private estado As String



    Public Property pid_acta As Integer
        Get
            Return id_acta
        End Get
        Set(value As Integer)
            id_acta = value
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

    Public Property ptipo As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property

    Public Property pfecha_examen As Date
        Get
            Return fecha_examen
        End Get
        Set(value As Date)
            fecha_examen = value
        End Set
    End Property

    Public Property pcurso As String
        Get
            Return curso
        End Get
        Set(value As String)
            curso = value
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

    Public Property pcarrera As String
        Get
            Return carrera
        End Get
        Set(value As String)
            carrera = value
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

    Public Property pnro_curso As Integer
        Get
            Return nro_curso
        End Get
        Set(value As Integer)
            nro_curso = value
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

    Public Property pestado As String
        Get
            Return estado
        End Get
        Set(value As String)
            estado = value
        End Set
    End Property

    'Metodos
    Public Shared Function RecuperarRegistroActa() As DataTable
        Try
            Dim dtActa As New DataTable
            dtActa = gDatos.TraerDataTable("spListarActa", 0)
            Return dtActa
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function RecuperarAlumnosByActa(id As Integer) As DataTable
        Try
            Dim dtActaAlumno As New DataTable
            dtActaAlumno = gDatos.TraerDataTable("spListarActaAlumno", id)
            Return dtActaAlumno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub InsertarActa(fecha As Date, curso As Integer, tipo As String, estado As String)
        gDatos.Ejecutar("spInsertarActa", fecha, curso, tipo, estado)
    End Sub

    Public Sub InsertarActaAlumnos(nota As String, letras As String, alumno As Integer, curso As Integer)
        gDatos.Ejecutar("spInsertarActaAlumno", nota, letras, alumno, curso)
    End Sub


End Class