Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SeleccionHabitacion
    Dim tipo As String
    Dim modelo As String
    Dim habitacion As String
    Dim tarifa As Double

    Dim idhabitacion As String
    Private Sub SeleccionHabitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nacio1()
    End Sub
    Public Sub nacio1()
        Dim objcli As New CmpHotelBeni.habitaciones
        objcli.tipomoto(Db1.TiposHabita)
        'objcli.mostrarmoto(Bd1.Motos)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            Dim objcli As New CmpHotelBeni.habitaciones
            objcli.consultarmotosDisponibles(ComboBox2.SelectedValue, Db1.habitaciones)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub mostrarmoto(f As Registro)
        Try
            f.modelo = modelo
            f.habitacion = habitacion
            f.tipo = tipo
            f.tarifa = tarifa

            f.idhabitacion = idhabitacion


        Catch ex As Exception

        End Try

    End Sub

    Private Sub Dgv1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv1.CellDoubleClick
        Try
            tipo = ComboBox2.Text
            modelo = Dgv1.Item("ModeloDataGridViewTextBoxColumn", Dgv1.CurrentRow.Index).Value
            habitacion = Dgv1.Item("HabitacionDataGridViewTextBoxColumn", Dgv1.CurrentRow.Index).Value
            tarifa = Dgv1.Item("TarifaDataGridViewTextBoxColumn", Dgv1.CurrentRow.Index).Value
            idhabitacion = Dgv1.Item("HabitacionIDDataGridViewTextBoxColumn", Dgv1.CurrentRow.Index).Value
            mostrarmoto(Registro)
            Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv1.CellContentClick

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class