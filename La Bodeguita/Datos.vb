Imports MySQLDriverCS
Imports System.Net
Imports System.IO
Imports System.Data


Public Class Datos
    Dim dr As MySQLDataReader
    Dim comando As New MySQLCommand
    Dim conexion As MySQLConnection
    Dim ip As String
    Dim frm As New Otros
    Dim lee As StreamReader
    Dim datos(3) As String
    Dim adap As MySQLDataAdapter
    Dim mitds As DataSet


    Public Function conexion_() As MySQLConnection
        Dim conexion1 = New MySQLConnection(New MySQLConnectionString(gen_ip(0), gen_ip(1), gen_ip(2), gen_ip(3)).AsString)
        MessageBox.Show(conexion1.ConnectionString.ToString())
        Return conexion1
    End Function

    Public Function ejecutar_consulta(ByVal consulta As String)
        'Los parámetros de la sobrecarga con más parámetros son:   
        conexion = conexion_()
        Dim comando As New MySQLCommand(consulta, conexion)
        Try
            conexion.Open()
            comando.CommandType = CommandType.Text
            comando.ExecuteNonQuery()
            conexion.Close()
        Catch e As MySQLException
            MsgBox(e.ToString)
            '           frm.aviso(e.ToString)
        End Try
        Return Nothing
    End Function


    Public Function leer_datos(ByVal consulta As String)
        conexion = conexion_()
        Dim comando As New MySQLCommand(consulta, conexion)
        Try
            conexion.Open()
            comando.CommandType = CommandType.Text
            dr = comando.ExecuteReader()
            conexion.Close()
        Catch ex As MySQLException
            'frm.aviso(ex.ToString)
            MessageBox.Show(ex.ToString())
        End Try
        Return dr
    End Function


    Public Function revisar_datos(ByVal dato1 As String, ByVal dato2 As String, ByVal i1 As Integer, ByVal i2 As Integer, ByVal consulta As String) As Boolean

        Dim respuesta As Boolean = False
        Dim tabla As DataTable = r_datos(consulta)
        Dim fila As DataRow

        If (tabla.Rows.Count > 0) Then
            For Each fila In tabla.Rows
                If (fila(i1).ToString() = dato1 And fila(i2).ToString() = dato2) Then
                    respuesta = True : Exit For
                End If
            Next
        End If

        Return respuesta
    End Function

    Public Function prueba_con(ByVal ip As String, ByVal bd As String, ByVal usr As String, ByVal pswd As String) As Boolean
        Dim resp As Boolean = False
        conexion = New MySQLConnection(New MySQLConnectionString(ip, bd, usr, pswd, 3306).AsString)
        Try
            conexion.Open()
            resp = True
            conexion.Close()
            Exit Try
        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function

    Public Function gen_ip() As Array
        Dim dts(3) As String
        Dim th As Integer = 0
        Dim linea As String = ""
        If File.Exists(".\conf\ip.lbd") Then
            lee = New StreamReader(".\conf\ip.lbd")
            dts(0) = lee.ReadLine()
            dts(1) = lee.ReadLine()
            dts(2) = lee.ReadLine()
            dts(3) = lee.ReadLine()
            lee.Close()
        End If
        Return dts
    End Function

    Public Function revisa_consulta(ByVal consulta As String) As Boolean
        Dim resp As Boolean = True
        Dim i As Integer = 0
        dr = leer_datos(consulta)
        While dr.Read
            i += 1
        End While
        If i > 1 Then
            resp = True
        Else
            resp = False
        End If
        Return resp
    End Function


    ''Regresa un datatable como contenedor de tados para llenar todo tipo de tablas
    Public Function r_datos(ByVal cons As String) As DataTable
        Dim tbl As DataTable = Nothing
        Dim tl As DataTable
        ''establecer los datos para conexion, el adaptador  y el dataset
        conexion = conexion_()
        adap = New MySQLDataAdapter(cons, conexion)
        mitds = New DataSet
        ''abrir la conexion y llenar el dataset
        Try
            conexion.Open()
            adap.Fill(mitds, "tble")
            conexion.Close()
            Exit Try
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try       
        ''vaciar el contenido de la o las tablas en tl
        For Each tl In mitds.Tables()
            tbl = tl
        Next
        Return tbl
    End Function

    Public Function revisa_consulta2(ByVal consulta As String) As Boolean
        Return False
    End Function

End Class
