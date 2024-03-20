Public Class IndiceGeneral
    Public Sub listar()
        Dim objDocente As New CmpHotelBeni.Alquileres
        objDocente.Filtrar(Db1.AlquileresBB)
    End Sub

    Private Sub IndiceGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker3.Value = Date.Now
        DateTimePicker4.Value = Date.Now
        mostrar()
    End Sub
    Public Sub mostrar()
        Try
            Dim OBF As New CmpHotelBeni.Alquileres
            OBF.buscarfecha(DateTimePicker3.Value, DateTimePicker4.Value, Db1.AlquileresBB)
            Txttotal.Text = OBF.TotalPeriodo(DateTimePicker3.Value, DateTimePicker4.Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        mostrar()

    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker4.ValueChanged
        mostrar()
    End Sub

    Private Sub IndiceGeneral_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        mostrar()
    End Sub

    Private Sub BTXPLACA_CheckedChanged(sender As Object, e As EventArgs) Handles BTXPLACA.CheckedChanged
        Try
            If BTXPLACA.Checked = True Then
                TXTPLACA.Visible = True
                TXTPLACA.Focus()
            Else
                TXTPLACA.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub xdni_CheckedChanged(sender As Object, e As EventArgs) Handles xdni.CheckedChanged
        Try
            If xdni.Checked = True Then
                TXTDNI.Visible = True
                TXTPLACA.Visible = False
                TXTDNI.Focus()
            Else
                TXTDNI.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXTDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTDNI.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                ' MsgBox("debe realizar la consulta por DNI")
                Dim OBF As New CmpHotelBeni.Alquileres
                OBF.Consultar(DateTimePicker3.Value, DateTimePicker4.Value, Db1.AlquileresBB, TXTDNI.Text)


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXTPLACA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPLACA.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                MsgBox("debe realizar la consulta por PLACA")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FinalizarAlquilerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalizarAlquilerToolStripMenuItem.Click
        Try
            Dim OBF As New CmpHotelBeni.Alquileres

            Dim alqID As String
            Dim habID As String
            alqID = Dgv1.Item("AlquilerID", Dgv1.CurrentRow.Index).Value
            habID = Dgv1.Item("habitacionID", Dgv1.CurrentRow.Index).Value


            If MsgBox(" Desea finalizar el alquiler?", vbYesNo, "Finalizar Alquiler") = MsgBoxResult.Yes Then
                OBF.FinalizarAlquiler(alqID, habID)
                MsgBox("Alquiler Finalizado")
            End If
            listar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXTPLACA_TextChanged(sender As Object, e As EventArgs) Handles TXTPLACA.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Txttotal_TextChanged(sender As Object, e As EventArgs) Handles Txttotal.TextChanged

    End Sub

    Private Sub TXTDNI_TextChanged(sender As Object, e As EventArgs) Handles TXTDNI.TextChanged

    End Sub
End Class