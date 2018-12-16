Imports ClasesProgramaMateria.Util
Public Class Login

    Private id_usuario As Integer
    Private usuario As String
    Private contraseña As String
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

    Public Property pcontraseña As String
        Get
            Return contraseña
        End Get
        Set(value As String)
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

    Public Sub Loguear()
        Try
            gDatos.Ejecutar("sp_Login", Me.usuario, Me.contraseña)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function RecuperarLogin() As DataTable
        Dim dtLogin As New DataTable
        dtLogin = gDatos.TraerDataTable("spLOGEO", Me.usuario, Me.contraseña)
        Return dtLogin
    End Function
    Public Function RecuperarLogin(vCodLogin As Integer) As Login
        Dim dtLogin As New DataTable
        dtLogin = gDatos.TraerDataTable("spLOGEO", Me.usuario, Me.contraseña)
        If dtLogin.Rows.Count > 0 Then
            Dim vLogin As New Login
            With vLogin
                .pnombre_usuario = dtLogin.Rows(0).Item("nombre_usuario")
            End With
            pnombre_usuario = dtLogin.Rows(0).Item("nombre_usuario")
            Return vLogin
        Else
            Return Nothing
        End If
    End Function

End Class
