Imports System.IO
Imports MySQLDriverCS
Imports System.Drawing.Printing

Public Class FrmConfigura_server
    Dim lee As StreamReader
    Dim escribe As StreamWriter
    Dim fun As New Datos
    Dim cos As New Otros

    Private Sub FrmConfigura_server_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load                
        cos.valida(Me.GroupBox1)
    End Sub

    Private Sub TxtIp1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIp1.TextChanged
        If TxtIp1.Text.Length = 3 Then
            TxtIp2.Focus()
        End If
    End Sub

    Private Sub TxtIp2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIp2.TextChanged
        If TxtIp2.Text.Length = 3 Then
            TxtIp3.Focus()
        End If
    End Sub

    Private Sub TxtIp3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIp3.TextChanged
        If TxtIp3.Text.Length = 3 Then
            TxtIp4.Focus()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If TxtIp1.Text <> "" And TxtIp2.Text <> "" And TxtIp3.Text <> "" And TxtIp4.Text <> "" And TxtBd.Text <> "" And TxtUsr.Text <> "" Then
            escribe = New StreamWriter(Application.StartupPath & "\conf\ip.lbd", False)
            escribe.WriteLine(TxtIp1.Text & "." & TxtIp2.Text & "." & TxtIp3.Text & "." & TxtIp4.Text)
            escribe.WriteLine(TxtBd.Text)
            escribe.WriteLine(TxtUsr.Text)
            escribe.WriteLine(TxtPswd.Text)
            escribe.Close()
            escribe = New StreamWriter(Application.StartupPath.ToString() & "\conf\conf.lbd", True)
            escribe.Write("1")
            escribe.Close()
            cos.limpiar(GroupBox1)
        Else
            cos.aviso("Debe ingresar la ip y datos para la conexion de la base de datos...")
        End If
    End Sub

    Private Sub btnPrueba_Click(sender As Object, e As EventArgs) Handles btnPrueba.Click
        If cos.revisar(TxtIp1) And cos.revisar(TxtIp2) And cos.revisar(TxtIp3) And cos.revisar(TxtIp4) Then
            Dim ip As String = TxtIp1.Text & "." & TxtIp2.Text & "." & TxtIp3.Text & "." & TxtIp4.Text
            If cos.revisar(TxtBd) And cos.revisar(TxtUsr) Then
                If fun.prueba_con(ip, TxtBd.Text, TxtUsr.Text, TxtPswd.Text) Then
                    cos.aviso("Conexion correcta")
                Else
                    cos.limpiar(GroupBox1)
                    cos.aviso("Error al tratar de conectar")
                End If
            Else
                cos.aviso("Revise los demas datos")
            End If

        Else
            cos.aviso("Revise la ip proporcionada")
        End If
    End Sub
End Class