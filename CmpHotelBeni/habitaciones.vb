Public Class habitaciones
    Public Sub BUSCAR(cli As String, ds As DB.habitacionesDataTable)
        Dim adap As New DBTableAdapters.habitacionesTableAdapter
        adap.FILTRAR(ds, cli)
    End Sub
    Public Sub Filtrar(nom As String, ds As DB.habitacioneBDataTable)
        Try
            Dim adap As New DBTableAdapters.habitacioneBTableAdapter
            adap.Fill(ds)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub filtrar1(cli As String, ds As DB.habitacioneBDataTable)
        Dim adap As New DBTableAdapters.habitacioneBTableAdapter
        adap.ConsultHabitacion(ds, cli)
    End Sub
    Public Sub Eliminar(ID As String)
        Try
            Dim ada As New DBTableAdapters.habitacionesTableAdapter
            ada.ELIMINAR(ID)
            MsgBox("Se ha eliminado la habitacion: " & ID)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Actualizar(NDI As String, nom As String, tipo As String, modelo As String, detall As String, tarifa As String, Est As String, foto As Byte())
        Try
            Dim ada As New DBTableAdapters.habitacionesTableAdapter
            ada.ACTUALIZAR(nom, tipo, modelo, detall, tarifa, Est, foto, NDI)
            MsgBox("Datos Actualizados!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Crear(nom As String, tipo As String, modelo As String, detall As String, tarifa As String, Est As String, foto As Byte())
        Try
            Dim ru As New DBTableAdapters.habitacionesTableAdapter
            ru.INSERTAR(nom, tipo, modelo, detall, tarifa, "DISPONIBLE", foto)
            MsgBox("Se ha registrado la habitacion correctamente!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Combobox
    End Sub

    Public Sub tipomoto(ds As DB.TiposHabitaDataTable)
        Dim adap As New DBTableAdapters.TiposHabitaTableAdapter
        adap.Fill(ds)
    End Sub
    Public Sub consultarmotosDisponibles(Tipo As String, ds As DB.habitacionesDataTable)
        Try
            Dim adap As New DBTableAdapters.habitacionesTableAdapter
            adap.ConsultarDisponibles(ds, Tipo)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub mostrarmoto(ds As DB.habitacioneBDataTable)
        Dim adap As New DBTableAdapters.habitacioneBTableAdapter
        adap.Fill(ds)
    End Sub

End Class
