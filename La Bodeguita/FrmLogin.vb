Imports System.IO
Public Class FrmLogin
    Public consulta As String
    Public fun As New Datos
    Public cosas As New Otros

    Public funciones As New Datos
    Public funciones2 As Otros


    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.AcceptButton = btnIngregresar
        Me.Icon = New Icon(Application.StartupPath.ToString() & "\img\home1.ico")
        If Revisa_configuracion() = False Then
            MessageBox.Show("Por única ocasión debe usar 'Admin' como nombre de usuario y contraseña, despues de ingresar deberá configurar el servidor de información e ingresar con su respectivo usuario")
            Me.txtUsuario.Text = "Admin"
            Me.txtPasswd.Text = "Admin"
        End If


    End Sub

    Private Sub BtnAcceso1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngregresar.Click
        If txtUsuario.Text <> "" Then
            If txtPasswd.Text <> "" Then
                If Revisa_configuracion() = True Then
                    consulta = "select usuario,contra,tipo_usuario,Id_empleado,nombre,apellidos from empleados"
                    Dim tbl As DataTable = funciones.r_datos(consulta)
                    Dim fila As DataRow
                    Dim b As Boolean = False

                    If (tbl.Rows.Count > 0) Then
                        For Each fila In tbl.Rows
                            Try
                                If (fila(0).ToString = txtUsuario.Text And fila(1).ToString = txtPasswd.Text) Then
                                    FrmPrincipal.usuario = txtPasswd.Text
                                    FrmPrincipal.tipo_u = fila(2).ToString()
                                    FrmPrincipal.id_usuario = fila(3).ToString()
                                    FrmPrincipal.Icon = New Icon(Application.StartupPath.ToString() & "\img\home1.ico")
                                    FrmPrincipal.Show()
                                    pss = 1
                                    txtPasswd.Clear()
                                    txtUsuario.Clear()
                                    Me.Hide()
                                    b = True
                                End If
                            Catch ex As Exception

                            End Try


                        Next
                        If b = False Then
                            MessageBox.Show("Datos incorrectos, intente nuevamente")
                            txtPasswd.Clear()
                            txtUsuario.Clear()
                            txtUsuario.Focus()
                        End If
                    End If
                Else
                    FrmPrincipal.usuario = txtUsuario.Text
                    FrmPrincipal.tipo_u = "Administrador"
                    FrmPrincipal.id_usuario = "1"
                    FrmPrincipal.Show()

                    txtPasswd.Clear()
                    txtUsuario.Clear()
                    Me.Hide()
                End If

            Else
                MessageBox.Show("Debe escribir su contraseña para poder acceder", "Abarrotes La Bodeguita")
            End If
        Else
            MessageBox.Show("Debe escribir su usuario para poder acceder", "Abarrotes La Bodeguita")
        End If
    End Sub

    Private Sub BtnCancel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel2.Click
        Me.Close()
    End Sub


    Public Function Revisa_configuracion() As Boolean
        If (File.Exists(Application.StartupPath.ToString() & "/conf/si.txt")) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
