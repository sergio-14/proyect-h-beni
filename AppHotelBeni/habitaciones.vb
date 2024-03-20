Imports System.IO
Imports System.Runtime.Remoting.Contexts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class habitaciones
    Private Sub habitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostact()
        nacio()
        listar()

    End Sub
    Public Sub listar()
        Dim objDocente As New CmpHotelBeni.habitaciones
        objDocente.Filtrar(" ", Db1.habitacioneB)
    End Sub
    Public Sub nacio()
        Dim objcli As New CmpHotelBeni.habitaciones
        objcli.tipomoto(Db1.TiposHabita)
    End Sub
    Public Sub mostact()
        Dim cli As New CmpHotelBeni.habitaciones
        cli.mostrarmoto(Db1.habitacioneB)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ms As New MemoryStream
            Me.PictureBox1.Image.Save(ms, Me.PictureBox1.Image.RawFormat)
            Dim obj As New CmpHotelBeni.habitaciones
            obj.Crear(nomtxt.Text, ComboBox2.SelectedValue, modtxt.Text, dettxt.Text, taritxt.Text, esttxt.Text, ms.GetBuffer)
            listar()
            limpiartxt()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub limpiartxt()

        nomtxt.Clear()
        modtxt.Clear()
        dettxt.Clear()
        taritxt.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenFileDialog1.Filter = "JPG|*.jpg"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.PictureBox1.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try

            Dim objDocente As New CmpHotelBeni.habitaciones
            If MsgBox("Esta seguro de eliminar la habitacion?", MsgBoxStyle.YesNo, "Confirmar eliminación") = MsgBoxResult.Yes Then
                objDocente.Eliminar(Dgv1.Item("HabitacionIDDataGridViewTextBoxColumn", Dgv1.CurrentRow.Index).Value)
                listar()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim ms As New MemoryStream
            Me.PictureBox1.Image.Save(ms, Me.PictureBox1.Image.RawFormat)
            Dim objDocente As New CmpHotelBeni.habitaciones
            objDocente.Actualizar(idctxt.Text, nomtxt.Text, ComboBox2.SelectedValue, modtxt.Text, dettxt.Text, taritxt.Text, esttxt.Text, MS.GetBuffer)
            listar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Try
            Dim NACCC As New CmpHotelBeni.habitaciones
            NACCC.filtrar1(TextBox2.Text, Db1.habitacioneB)
        Catch ex As Exception

        End Try
    End Sub
End Class