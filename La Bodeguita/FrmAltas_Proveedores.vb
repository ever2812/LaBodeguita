Public Class FrmAltas_Proveedores
    Dim cosas As New Otros
    Dim fun As New Datos
    Dim consulta As String

    Private Sub FrmAltas_Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
        cosas.valida(Me.GroupBox1)
        Me.AcceptButton = BtnAceptar
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If cosas.revisa_todo1(Me.GroupBox1) Then
            If fun.revisar_datos(TxtNombre.Text, txtDireccion.Text, 1, 2, "select *from proveedores") = False Then
                consulta = "insert into proveedores(nombre,direccion,telefono,rfc,mail) values('" & TxtNombre.Text & "','" & txtDireccion.Text & "','" & TxtTelefono.Text & "','" & TxtRfc.Text & "','" & Txtmail.Text & "');"
                fun.ejecutar_consulta(consulta)
                cosas.limpiar(GroupBox1) : TxtNombre.Focus()
            Else
                cosas.aviso("El proveedor ya esta registrado")
                cosas.limpiar(GroupBox1)
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        If MessageBox.Show("Desea cancelar la operación?...", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.Yes Then
            cosas.limpiar(GroupBox1)
        End If
    End Sub
End Class