Public Class Registro
    Public tipo As String
    Public modelo As String
    Public habitacion As String
    Public tarifa As Double
    Public idhabitacion As String
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ibj As New CmpHotelBeni.clientes
        ibj.conssultaporCI(TxtNDIn.Text, Db1.CLIENTESAD)
    End Sub

    Private Sub Registro_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            txtmodelo.Text = modelo
            txtplaca.Text = habitacion
            txttipo.Text = tipo
            txtHoras.Text = tarifa

        Catch ex As Exception

        End Try
    End Sub
    Public Sub lipiarRregistro()
        TxtNDIn.Clear()
        TxtNombre.Clear()
        TxtNacionalidad.Clear()
        txtmodelo.Clear()
        txtplaca.Clear()
        txttipo.Clear()
        txtHoras.Clear()
        txtTotal.Clear()



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Dim objAlquiler As New CmpHotelBeni.Alquileres
            txtTotal.Text = objAlquiler.calcularMotoAlquiler(tarifa, CInt(TextBox1.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim objAlquiler As New CmpHotelBeni.Alquileres
            objAlquiler.RegistrarAlquiler(DateTimePicker3.Value, DateTimePicker1.Value, DateTimePicker2.Value, txtHoras.Text, txtTotal.Text, idhabitacion, TxtNDIn.Text)
            MsgBox("Alquiler Registrado")
            lipiarRregistro()
            Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub CalcularHora()
        Try
            Dim totalTiempo As Integer
            totalTiempo = DateDiff(DateInterval.Hour, DateTimePicker1.Value, DateTimePicker2.Value)
            TextBox1.Text = totalTiempo.ToString

        Catch ex As Exception
            TextBox1.Text = "0"

        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        CalcularHora()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        CalcularHora()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim f As New SeleccionHabitacion
            f.ShowDialog()
            'formHIjo.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        lipiarRregistro()
        Me.Close()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        lipiarRregistro()
    End Sub
End Class