Imports ClasesProgramaMateria.Util

Public Class Usuario
    'Atributos 
    Private id_usuario As Integer
    Private usuario As String
    Private contraseña As Integer
    Private nombre_usuario As String
    Private apellido_usuario As String
    Private correo As String
    Private fecha_nacimiento As Date

    Public Property pid_usuario As Integer
        Get
            Return id_usuario
        End Get
        Set(value As Integer)
            id_usuario = value
        End Set
    End Property

    Public Property pusuario As String
        Get
            Return usuario
        End Get
        Set(value As String)
            usuario = value
        End Set
    End Property

    Public Property pcontraseña As Integer
        Get
            Return contraseña
        End Get
        Set(value As Integer)
            contraseña = value
        End Set
    End Property

    Public Property pnombre_usuario As String
        Get
            Return nombre_usuario
        End Get
        Set(value As String)
            nombre_usuario = value
        End Set
    End Property

    Public Property papellido_usuario As String
        Get
            Return apellido_usuario
        End Get
        Set(value As String)
            apellido_usuario = value
        End Set
    End Property

    Public Property pcorreo As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    Public Property pfecha_nacimiento As Date
        Get
            Return fecha_nacimiento
        End Get
        Set(value As Date)
            fecha_nacimiento = value
        End Set
    End Property

    'Metodos de la clase
    Public Sub Insertar()
        Try
            gDatos.Ejecutar("spInsertarUsuario", Me.usuario, Me.contraseña, Me.nombre_usuario, Me.apellido_usuario, Me.correo, Me.fecha_nacimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar()
        Try
            gDatos.Ejecutar("spActualizarUsuario", Me.id_usuario, Me.usuario, Me.contraseña, Me.nombre_usuario, Me.apellido_usuario, Me.correo, Me.fecha_nacimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar()
        Try
            gDatos.Ejecutar("spEliminarUsuario", Me.id_usuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function RecuperarRegistro(ByVal vCodigo As Integer) As Usuario
        Try
            Dim dtUsuario As New Data.DataTable("Usuario")
            dtUsuario = gDatos.TraerDataTable("spConsultarUsuario", vCodigo)
            If dtUsuario.Rows.Count > 0 Then
                Dim vUsuario As New Usuario
                vUsuario.pid_usuario = dtUsuario.Rows(0).Item("id_usuario")
                vUsuario.pusuario = dtUsuario.Rows(0).Item("usuario")
                vUsuario.pcontraseña = dtUsuario.Rows(0).Item("contraseña")
                vUsuario.pnombre_usuario = dtUsuario.Rows(0).Item("nombre_usuario")
                vUsuario.papellido_usuario = dtUsuario.Rows(0).Item("apellido_usuario")
                vUsuario.pcorreo = dtUsuario.Rows(0).Item("correo")
                vUsuario.pfecha_nacimiento = dtUsuario.Rows(0).Item("fecha_nacimiento")

                Return vUsuario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function RecuperarRegistrosUsuario() As DataTable
        Try
            Dim dtUsuario As New Data.DataTable("Usuario")
            dtUsuario = gDatos.TraerDataTable("spListarUsuario")
            Return dtUsuario
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class

