Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class clientes
    Private Sub clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        nacio()


    End Sub
    Public Sub listar()
        Dim objDocente As New CmpHotelBeni.clientes
        objDocente.filtrar("", Db1.CLIENTESAD)
    End Sub

    Public Sub nacio()
        Dim objcli As New CmpHotelBeni.clientes
        objcli.nacionalidades(Db1.Nacionalidades)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim objC As New CmpHotelBeni.clientes
            If MsgBox("Esta seguro de eliminar al Cliente?", MsgBoxStyle.YesNo, "Confirmar eliminación") = MsgBoxResult.Yes Then
                objC.Eliminar(Dgv1.Item("DNIDataGridViewTextBoxColumn", Dgv1.CurrentRow.Index).Value)
                listar()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim objC As New CmpHotelBeni.clientes
            objC.Actualizar(NDItxt.Text, nomtxt.Text, aptxt.Text, amtxt.Text, teltxt.Text, dirctxt.Text, ComboBox2.SelectedValue)
            listar()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim objC As New CmpHotelBeni.clientes
            objC.Crear(NDItxt.Text, nomtxt.Text, aptxt.Text, amtxt.Text, teltxt.Text, dirctxt.Text, ComboBox2.SelectedValue)
            listar()
            limpiartxt()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub limpiartxt()
        NDItxt.Clear()
        nomtxt.Clear()
        aptxt.Clear()
        amtxt.Clear()
        teltxt.Clear()
        dirctxt.Clear()
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Try
            Dim NACCC As New CmpHotelBeni.clientes
            NACCC.filtrar(TextBox2.Text, Db1.CLIENTESAD)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv1.CellContentClick

    End Sub
End Class