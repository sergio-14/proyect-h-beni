Public Class clientes
    Public Sub conssultaporCI(NdI As String, ds As DB.CLIENTESADDataTable)
        Dim adap As New DBTableAdapters.CLIENTESADTableAdapter
        adap.ConsultarXci(ds, NdI)
    End Sub


    Public Sub filtrar(cli As String, ds As DB.CLIENTESADDataTable)
        Dim adap As New DBTableAdapters.CLIENTESADTableAdapter
        adap.SeleccionarCliente(ds, cli)
    End Sub
    Public Sub Filtrar1(nom As String, ds As DB.ClientesDataTable)
        Try
            Dim adap As New DBTableAdapters.ClientesTableAdapter
            adap.Fill(ds)
            ' Dim adap As New DBTableAdapters.Clientes1DataTable
            ' adap.Fill(ds)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Eliminar(NDI As String)
        Try
            Dim adap As New DBTableAdapters.ClientesTableAdapter
            adap.ELIMINAR(NDI)
            MsgBox("Se ha eliminado al cliente con DNI: " & NDI)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Actualizar(NDI As String, nom As String, ap As String, am As String, tel As String, dirc As String, nacid As String)
        Try
            Dim adap As New DBTableAdapters.ClientesTableAdapter
            adap.ACTUALIZAR(nom, ap, am, tel, dirc, nacid, NDI)
            MsgBox("Datos Actualizados!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Crear(NDI As String, nom As String, ap As String, am As String, tel As String, dirc As String, nacid As String)
        Try
            Dim adap As New DBTableAdapters.ClientesTableAdapter
            adap.INSERTAR(NDI, nom, ap, am, tel, dirc, nacid)
            MsgBox("Se ha registrado al Cliente!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Combobox
    End Sub
    Public Sub nacionalidades(ds As DB.NacionalidadesDataTable)
        Dim adap As New DBTableAdapters.NacionalidadesTableAdapter
        adap.Fill(ds)
    End Sub
End Class
