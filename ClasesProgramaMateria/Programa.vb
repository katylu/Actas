Imports ClasesProgramaMateria.Util

Public Class Programa
    Private id_programa As Integer
    Private programa As String
    Private estado As String

    Public Property pid_programa As Integer
        Get
            Return id_programa
        End Get
        Set(value As Integer)
            id_programa = value
        End Set
    End Property


    Public Property pprograma As String
        Get
            Return programa
        End Get
        Set(value As String)
            programa = value
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

    Public Sub Insertar()
        Try
            gDatos.Ejecutar("spInsertarPrograma", Me.programa, Me.estado)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ActualizarPrograma()
        gDatos.Ejecutar("spActualizarPrograma", Me.id_programa, Me.programa, Me.estado)
    End Sub

    Public Sub Eliminar()
        Try
            gDatos.Ejecutar("spEliminarPrograma", Me.id_programa)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Function RecuperarRegistroPrograma(ByVal vCodigo As Integer) As Programa
        Try
            Dim dtPrograma As New Data.DataTable("Programa")
            dtPrograma = gDatos.TraerDataTable("spConsultarPrograma", vCodigo)
            If dtPrograma.Rows.Count > 0 Then
                Dim vPrograma As New Programa
                vPrograma.pid_programa = dtPrograma.Rows(0).Item("id_Programa")
                vPrograma.pprograma = dtPrograma.Rows(0).Item("programa")
                vPrograma.pestado = dtPrograma.Rows(0).Item("estado")

                Return vPrograma
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function RecuperarRegistroPrograma() As DataTable
        Try
            Dim dtPrograma As New Data.DataTable("Programa")
            dtPrograma = gDatos.TraerDataTable("spListarPrograma")
            Return dtPrograma
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class