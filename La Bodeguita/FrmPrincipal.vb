Imports System.Windows.Forms
Imports System.IO


Public Class FrmPrincipal
    Public formulario As Form
    Public ancho As Integer
    Public efectos As New Otros
    Public usuario, tipo_u As String
    Public id_usuario As Integer
    Public lee As StreamReader
    Public escribe As StreamWriter

    Private Sub FrmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "ABARROTES LA BODEGUITA" & "              BIENVENIDO: [ " & Me.usuario & " ]              CAJA: [ " & efectos.no_caja() & " ]"
        Me.WindowState = FormWindowState.Maximized
        If efectos.revisa_configuracion() = False Then
            efectos.m_form(FrmConfigura_server)
        End If
        Asigna_img_menu(Me.Menu_Principal)

    End Sub

    Private Sub Asigna_img_menu(ByRef menu1 As MenuStrip)

        For Each men As ToolStripMenuItem In menu1.Items
            men.Image = Image.FromFile(".\img\menu7.png")
            Asinga_img2(men)

        Next

    End Sub

    Private Sub Asinga_img2(ByRef strip1 As ToolStripMenuItem)
        For Each menu4 As ToolStripMenuItem In strip1.DropDownItems
            menu4.Image = Image.FromFile(".\img\ir1.png")
            If menu4.DropDownItems.Count > 0 Then
                Asinga_img2(menu4)

            End If
        Next

    End Sub

    Private Sub Menu_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Salir.Click
        Me.Close()
    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticulosToolStripMenuItem.Click

        MessageBox.Show("abriendo articulos")
        If revisa_us() Then
            efectos.m_form(FrmAltas_Articulos)
        Else
            efectos.aviso("Necesita iniciar sesión")
        End If
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        If revisa_us() Then
            efectos.m_form(FrmAltas_Proveedores)
        Else
            efectos.aviso("Necesita iniciar sesión")
        End If
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        If revisa_us() Then
            efectos.m_form(FrmAlta_Empleados)
        Else
            efectos.aviso("Necesita iniciar sesión")
        End If
    End Sub

    Private Sub ArticulosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticulosToolStripMenuItem1.Click
        If revisa_us() Then
            efectos.m_form(FrmCat_Articulo)
        Else
            efectos.aviso("Necesita iniciar sesión")
        End If
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        If revisa_us() Then
            efectos.m_form(FrmCat_proveedores)
        Else
            efectos.aviso("Necesita iniciar sesión")
        End If
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem.Click
        If revisa_us() Then
            efectos.m_form(FrmCat_Empleados)
        Else
            efectos.aviso("Necesita iniciar sesión")
        End If
    End Sub

    Private Sub Menu_Ventas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Ventas.Click
        If revisa_us() Then
            FrmVentas.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog

            FrmVentas.MdiParent = Me
            FrmVentas.MaximizeBox = False
            FrmVentas.MinimizeBox = False
            FrmVentas.Show()
        Else
            efectos.aviso("Necesita iniciar sesión")
        End If
    End Sub

    Private Sub NormalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalesToolStripMenuItem.Click
        If revisa_us() Then
            efectos.m_form(FrmInventario_Normal)
        Else
            efectos.aviso("Necesita iniciar sesión")
        End If
    End Sub

    Private Sub GranelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GranelToolStripMenuItem.Click
        If revisa_us() Then
            efectos.m_form(FrmInventario_Granel)
        Else
            efectos.aviso("Necesita iniciar sesión")
        End If
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Text = "Abarrotes La Bodeguita"
        usuario = ""
        tipo_u = ""
        id_usuario = 0
        efectos.revisa_principal(Me)
    End Sub

    Public Function Revisa_us() As Boolean
        Dim rep As Boolean
        If usuario <> "" And tipo_u <> "" Then
            rep = True
        Else
            rep = False
        End If
        Return rep
    End Function

    Private Sub FrmPrincipal_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate
        For Each frm As Form In My.Application.OpenForms
          

        Next
        
    End Sub

    Private Sub AgotadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgotadosToolStripMenuItem.Click
        If revisa_us() Then
            efectos.m_form(frmagotados)
        Else
            efectos.aviso("Necesita iniciar sesión")
        End If
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        'pendiente
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        'todavia falta
    End Sub

    Private Sub ServidorDeInformaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServidorDeInformaciónToolStripMenuItem.Click
        If usuario <> "" Then
            If tipo_u = "Administrador" Then
                efectos.m_form(FrmConfigura_server)
            Else
                efectos.aviso("Necesita privilegios de Administrador")
            End If
        Else
            efectos.aviso("Necesita iniciar sesión")
        End If
    End Sub

    Private Sub ImpresorasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImpresorasToolStripMenuItem.Click
        If usuario <> "" Then
            If tipo_u = "Administrador" Then
                efectos.m_form(FrmConf_Impresora)
            Else
                efectos.aviso("Necesita privilegios de Administrador")
            End If
        Else
            efectos.aviso("Necesita iniciar sesión")
        End If
    End Sub

    Private Sub VentaDiariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentaDiariaToolStripMenuItem.Click
        If revisa_us() Then
            If tipo_u = "Administrador" Then
                efectos.m_form(FrmReportes)
            Else
                efectos.aviso("Necesita tener privilegios de administrador")
            End If
        Else
            efectos.aviso("Necesita iniciar sesión")
        End If
    End Sub

    Private Sub DineroEnCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DineroEnCajaToolStripMenuItem.Click
        If revisa_us() And tipo_u = "Administrador" Then
            efectos.m_form(FrmEnCaja)
        Else
            efectos.aviso("Necesita iniciar sesión")
        End If
    End Sub

    Private Sub RetirarEfectivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetirarEfectivoToolStripMenuItem.Click
        If revisa_us() And tipo_u = "Administrador" Then
            efectos.m_form(FrmRetiros)
        Else
            efectos.aviso("Necesita Iniciar Sesión")
        End If
    End Sub

    Private Sub ReporteDiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDiarioToolStripMenuItem.Click
        If revisa_us() And tipo_u = "Administrador" Then
            efectos.m_form(FrmDiario)
        Else
            efectos.aviso("Necesita Iniciar Sesión")
        End If
    End Sub

    Private Sub Regresa_inicio()
        For Each frm As System.Windows.Forms.Form In Application.OpenForms
            MessageBox.Show(frm.Name)
            If frm.Name = "presentación.vb" Then

            End If
        Next
    End Sub
End Class
