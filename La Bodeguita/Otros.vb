Option Explicit Off
Imports LibPrintTicket
Imports System.Net
Imports System.IO
Imports System.Windows.Forms
Imports System.Globalization

Public Class Otros
    Dim lee As StreamReader
    Dim server As String
    Dim taman As Decimal


    Public Function revisa_configuracion() As Boolean
        If (File.Exists(Application.StartupPath.ToString() & "/conf/si.txt")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub asing_tooltip(ByVal control As Windows.Forms.Control, ByVal leyenda As String)
        Dim tul As New ToolTip
        tul.UseAnimation = True
        tul.UseFading = True
        tul.SetToolTip(control, leyenda)
    End Sub

    'Obtiene el numero de caja configurado
    Public Function no_caja() As String
        Dim lector As New StreamReader(Application.StartupPath.ToString() & "\conf\num_caja.lbd")
        Dim micaja As String = lector.ReadLine()
        lector.Close()
        Return micaja
    End Function

    Public Function impresora() As String
        Dim lee = New StreamReader(".\conf\imp.lbd")
        Dim imp As String = lee.ReadLine()
        Me.taman = Convert.ToDecimal(lee.ReadLine())
        lee.Close()
        Return imp
    End Function

    Public Function tam_fuente() As Decimal
        Return taman
    End Function

    Public Function rev_server() As Boolean
        'revisar si existe el archivo de configuracion del servidor
        If File.Exists(".\conf\ip.lbd") Then
            lee = New StreamReader(".\conf\ip.lbd")
            server = lee.ReadLine()
            lee.Close()


            'revisar si la maquina esta conectada a alguna red disponible

            'If My.Computer.Network.Ping(server) Then
            '    resp = True
            'Else
            '    aviso("No se puede establecer la conexion con el servidor, configure la ip nuevamente")
            '    resp = False
            'End If

        End If
        Return True
    End Function

    Public Sub m_form(ByVal formulario As Form)
        formulario.MdiParent = FrmPrincipal
        formulario.FormBorderStyle = FormBorderStyle.FixedDialog
        formulario.MaximizeBox = False
        formulario.MinimizeBox = False
        formulario.StartPosition = FormStartPosition.CenterScreen
        formulario.Show()
    End Sub

    Public Function limpiar(ByVal contenedor As Object)
        Dim control As Control
        For Each control In contenedor.controls
            If TypeOf (control) Is TextBox Then
                control.Text = ""
                control.BackColor = Color.White
            End If
        Next
        Return Nothing
    End Function

    Public Sub valida(ByRef contenedor As Object)
        'estilo_boton(contenedor)
        For Each texto As Control In contenedor.Controls
            If TypeOf (texto) Is TextBox Then
                tultip(texto)
                If texto.Tag.ToString = "decimales" Then
                    AddHandler texto.KeyPress, AddressOf decimales
                ElseIf texto.Tag.ToString = "enteros" Then
                    AddHandler texto.KeyPress, AddressOf enteros
                ElseIf texto.Tag.ToString = "cadena" Then
                    AddHandler texto.KeyPress, AddressOf cadena
                End If
            End If
            If TypeOf (texto) Is Button Then
                texto.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            End If
        Next
    End Sub

    Public Sub decimales(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim cc As CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.ToString = cc.NumberFormat.NumberDecimalSeparator.ToString() Then
            Dim cas As TextBox
            cas = sender
            If cas.Text.Contains(".") Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If


    End Sub

    Public Function enteros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        Dim tec As Char = e.KeyChar
        If Char.IsDigit(tec) Or Char.IsControl(tec) Then
            e.Handled = False            
        Else
            e.Handled = True
        End If
    End Function

    Public Function cadena(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        e.Handled = False
    End Function

    'aplica el tooltip a los textbox
    Public Sub tultip(ByRef texto As TextBox)
        Dim tol As New ToolTip
        tol.UseFading = True
        Select Case texto.Tag.ToString()
            Case "decimales"
                tol.ToolTipTitle = "Este campo solo acepta números decimales"
                tol.SetToolTip(texto, "Ejemplo. 13.56, 90.89...")
            Case "enteros"
                tol.ToolTipTitle = "Este campo solo acepta números enteros"
                tol.SetToolTip(texto, "Ejemplo: 2, 13, 27...")
            Case "cadena"
                tol.ToolTipTitle = "Este campo acepta cualquier tipo de caracter"
                tol.SetToolTip(texto, "Ejemplo: H0l@ Mund0")
        End Select
    End Sub

    Public Function revisar(ByVal caja As TextBox) As Boolean
        If caja.Text = Nothing Then
            Return False
        Else
            caja.Text = Trim(caja.Text)
            Dim BANDERA As Integer = 0
            Dim arr As Char() = caja.Text.ToArray()
            For Each tec As Char In arr
                If tec <> " " Then
                    BANDERA = 1
                End If
            Next
            If BANDERA = 0 Then
                Return False
            End If
            Return True
        End If
    End Function

    Public Function revisa_todo1(ByVal content As Object) As Boolean
        Dim resp As Boolean = True
        For Each control As Control In content.Controls
            If TypeOf (control) Is TextBox Then
                If control.Text = "" Then
                    control.BackColor = Color.LightSalmon
                    resp = False
                Else
                    control.BackColor = Color.White
                End If
            End If
            If TypeOf (control) Is Button Then
                control.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            End If
        Next
        If resp = False Then
            aviso("Revise los campos marcados...")
        End If
        Return resp
    End Function

    Public Function cantidad_kg(ByVal cantidad As String)

        Dim cant As Decimal

        If cantidad.Contains("/") Then
            If cantidad.Length > 4 Then
                cant = compuesto(cantidad)
            ElseIf cantidad.Length = 3 Then
                cant = fracciones(cantidad)
            End If
        Else
            cant = Convert.ToDecimal(cantidad)
        End If
        Return cant
    End Function

    Private Function fracciones(ByVal cantidad As String)
        Dim t As Decimal
        Select Case cantidad
            Case "1/4"
                t = 0.25
            Case "1/2"
                t = 0.5
            Case "3/4"
                t = 0.75
        End Select
        Return t
    End Function

    Private Function compuesto(ByVal cantidad As String)
        Dim cn As Decimal
        cn += Convert.ToDecimal(Mid(cantidad, 1, 1))
        cn += fracciones(Mid(cantidad, 3, 3))
        Return cn
    End Function

    Public Function boton_pic(ByVal ptb As PictureBox, ByVal img As String)
        ptb.Image = Image.FromFile(img)
        ptb.Cursor = Cursors.Hand
        Return Nothing
    End Function

    Public Function boton_pic2(ByVal ptb As PictureBox, ByVal img As String)
        ptb.SizeMode = PictureBoxSizeMode.StretchImage
        ptb.Image = Image.FromFile(img)
        Return Nothing
    End Function

    Public Function aviso(ByVal msj As String)
        MessageBox.Show(msj, "¡ A T E N C I Ó N !",MessageBoxButtons.OK,MessageBoxIcon.Stop)
        Return Nothing
    End Function

    Public Function revisa_principal(ByVal frm As Form)
        'recorre los formularios hijos en el formulario principal
        For Each Form1 In frm.MdiChildren
            If FrmVenta_Granel.Visible = True Then
                FrmVenta_Granel.Close()
            End If
            Form1.Close()
        Next
        Return Nothing
    End Function



    Public Function int_decimal(ByVal cantidad As String) As String
        Dim cant1 As String = ""
        Dim cant2 As String = ""
        Dim cantidad_ As String = ""

        cant1 = Mid(cantidad, 1, cantidad.Length - 3)
        cant2 = Mid(cantidad, cantidad.Length - 2, 3)

        If cant2 <> ".00" Then
            cantidad_ = cant1 & cant2
        Else
            cantidad_ = cant1
        End If
        Return cantidad_
    End Function

End Class
