Public Class tipo_y_nacionalidad
    Public Sub BUSCAR(cli As String, ds As DB.NacionalidadesDataTable)
        Dim adap As New DBTableAdapters.NacionalidadesTableAdapter
        adap.FilTRAR(ds, cli)
    End Sub
    Public Sub Filtrar(nom As String, ds As DB.NacionalidadesDataTable)
        Try
            Dim adap As New DBTableAdapters.NacionalidadesTableAdapter
            adap.Fill(ds)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Eliminar(NacionalidadID As String)
        Try
            Dim ada As New DBTableAdapters.NacionalidadesTableAdapter
            ada.ELIMINAR(NacionalidadID)
            MsgBox("Se ha eliminado al cliente con ci: " & NacionalidadID)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Actualizar(nomr As String, NacionalidadID As String)
        Try
            Dim ada As New DBTableAdapters.NacionalidadesTableAdapter
            ada.ACTUALIZAR(nomr, NacionalidadID)
            MsgBox("Datos Actualizados!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Crear(NacionalidadID As String)
        Try
            Dim ada As New DBTableAdapters.NacionalidadesTableAdapter
            ada.INSERTAR(NacionalidadID)
            MsgBox("Se ha registrado una Nacionalidad!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'TIPO HAITACION

    Public Sub BUSCAR1(cli As String, ds As DB.TiposHabitaDataTable)
        Dim adap As New DBTableAdapters.TiposHabitaTableAdapter
        adap.FILTRAR(ds, cli)
    End Sub
    Public Sub Filtrar1(nom As String, ds As DB.TiposHabitaDataTable)
        Try
            Dim adap As New DBTableAdapters.TiposHabitaTableAdapter
            adap.Fill(ds)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Eliminar1(NacionalidadID As String)
        Try
            Dim ada As New DBTableAdapters.TiposHabitaTableAdapter
            ada.ELIMINAR(NacionalidadID)
            MsgBox("Se ha eliminado el tipo de habitacion: " & NacionalidadID)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Actualizar1(nom As String, TIP As String)
        Try
            Dim ada As New DBTableAdapters.TiposHabitaTableAdapter
            ada.ACTUALIZAR(nom, TIP)
            MsgBox("Datos Actualizados!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Crear1(TIP As String)
        Try
            Dim ada As New DBTableAdapters.TiposHabitaTableAdapter
            ada.INSERTAR(TIP)
            MsgBox("Se ha registrado un tipo de habitacion!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
