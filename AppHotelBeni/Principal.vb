Public Class Principal
    Public tipo As String
    Public modelo As String
    Public habitacion As String
    Public tarifa As Double
    Public idhabitacion As String

#Region "principal"

    Private Sub openChildForm(Formhijo As Object)
        If (Panelchil.Controls.Count > 0) Then
            Panelchil.Controls.RemoveAt(0)
        End If
        Dim fh As Form
        fh = Formhijo
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Panelchil.Controls.Add(fh)
        Panelchil.Tag = fh
        fh.Show()
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openChildForm(New clientes)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openChildForm(New tipo_habitacion_y_nacionalidad)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        openChildForm(New IndiceGeneral)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        openChildForm(New habitaciones)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' openChildForm(New Registro)
        Try
            'openChildForm()
            Registro.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub fecha_hora_Tick(sender As Object, e As EventArgs) Handles fecha_hora.Tick
        Label1.Text = DateTime.Now.ToLongTimeString()
        Label2.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Panelchil.Visible Then
            Panelchil.Visible = False
        Else
            Panelchil.Visible = True
        End If

    End Sub

    Private Sub Panelchil_Paint(sender As Object, e As PaintEventArgs) Handles Panelchil.Paint

    End Sub
#End Region
End Class