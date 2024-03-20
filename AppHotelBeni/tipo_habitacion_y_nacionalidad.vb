Public Class tipo_habitacion_y_nacionalidad
    Private Sub tipo_habitacion_y_nacionalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        listar1()

    End Sub

    Private Sub editarN_Click(sender As Object, e As EventArgs) Handles editarN.Click
        Try
            Dim objDocente As New CmpHotelBeni.tipo_y_nacionalidad
            objDocente.Actualizar(txtn.Text, idn.Text)
            listar()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub agregarN_Click(sender As Object, e As EventArgs) Handles agregarN.Click
        Try
            Dim objDocente As New CmpHotelBeni.tipo_y_nacionalidad
            objDocente.Crear(txtn.Text)
            listar()
            limpiarna()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub listar()
        Dim objDocente As New CmpHotelBeni.tipo_y_nacionalidad
        objDocente.Filtrar(" ", Db1.Nacionalidades)
    End Sub
    Private Sub filn_TextChanged(sender As Object, e As EventArgs) Handles filn.TextChanged
        Try
            Dim NACCC As New CmpHotelBeni.tipo_y_nacionalidad
            NACCC.BUSCAR(filn.Text, Db1.Nacionalidades)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub EliminarN_Click(sender As Object, e As EventArgs) Handles EliminarN.Click

        Try
            Dim objDocente As New CmpHotelBeni.tipo_y_nacionalidad
            If MsgBox("Esta seguro de eliminar Nacionalidad?", MsgBoxStyle.YesNo, "Confirmar eliminación") = MsgBoxResult.Yes Then
                objDocente.Eliminar(Dgv1.Item("NacionalidadID", Dgv1.CurrentRow.Index).Value)
                listar()

            End If
        Catch ex As Exception

        End Try
    End Sub

    'tipo de habitacion 

    Public Sub listar1()
        Dim objDocente As New CmpHotelBeni.tipo_y_nacionalidad
        objDocente.Filtrar1(" ", Db1.TiposHabita)
    End Sub
    Private Sub filA_TextChanged(sender As Object, e As EventArgs) Handles filA.TextChanged
        Try
            Dim NACCC As New CmpHotelBeni.tipo_y_nacionalidad
            NACCC.BUSCAR1(filA.Text, Db1.TiposHabita)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub editarA_Click(sender As Object, e As EventArgs) Handles editarA.Click
        Try
            Dim objDocente As New CmpHotelBeni.tipo_y_nacionalidad
            objDocente.Actualizar1(txtA.Text, idA.Text)
            listar1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub agregarA_Click(sender As Object, e As EventArgs) Handles agregarA.Click
        Try
            Dim objDocente As New CmpHotelBeni.tipo_y_nacionalidad
            objDocente.Crear1(txtA.Text)
            listar1()
            limpiartxt()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub limpiartxt()
        txtA.Clear()
    End Sub
    Public Sub limpiarna()
        txtn.Clear()
    End Sub

    Private Sub eliminarA_Click(sender As Object, e As EventArgs) Handles eliminarA.Click
        Try
            Dim objDocente As New CmpHotelBeni.tipo_y_nacionalidad
            If MsgBox("Esta seguro de eliminar Tipo de habitacion?", MsgBoxStyle.YesNo, "Confirmar eliminación") = MsgBoxResult.Yes Then
                objDocente.Eliminar1(DataGridView1.Item("TipoID", DataGridView1.CurrentRow.Index).Value)
                listar1()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class