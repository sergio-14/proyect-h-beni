Public Class Alquileres
    Public Sub Filtrar(ds As DB.AlquileresBBDataTable)
        Try
            Dim adap As New DBTableAdapters.AlquileresBBTableAdapter
            adap.Fill(ds)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub buscarfecha(fi As Date, ff As Date, ds As DB.AlquileresBBDataTable)
        Dim adap As New DBTableAdapters.AlquileresBBTableAdapter
        adap.ConsultarFecha(ds, fi, ff)
    End Sub
    Public Function TotalPeriodo(fi As Date, ff As Date) As Double
        Try
            Dim adap As New DBTableAdapters.PeriodoTableAdapter
            Dim ds As New DB.PeriodoDataTable
            adap.PeriodoTotal(ds, fi, ff)
            Return ds.Item(0).TotalPeriodo
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function calcularMotoAlquiler(tarifa As Double, horas As Integer) As Double
        Try
            Return tarifa * horas
        Catch ex As Exception
            Return 0
            'si es menor a 0 *1
        End Try
    End Function
    Public Sub RegistrarAlquiler(fecha As Date, hi As String, hf As String, cant As Integer, monto As Double, idmoto As String, ndi As String)
        Try
            Dim adap As New DBTableAdapters.AlquileresTableAdapter
            adap.Insert(fecha, hi, hf, cant, "EN ALQUILER", monto, ndi, idmoto)
            Dim adapm As New DBTableAdapters.habitacionesTableAdapter
            adapm.Alquilar(idmoto)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Consultar(fi As Date, ff As Date, ds As DB.AlquileresBBDataTable, DNI As String)
        Try
            Dim adap As New DBTableAdapters.AlquileresBBTableAdapter
            adap.PORNDI(ds, fi, ff, DNI)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub FinalizarAlquiler(alquilerID As String, habitacionID As String)
        Try
            Dim adapm As New DBTableAdapters.habitacionesTableAdapter
            Dim adapal As New DBTableAdapters.AlquileresTableAdapter
            adapal.Devolver(alquilerID)
            adapm.Devolver(habitacionID)
        Catch ex As Exception

        End Try
    End Sub

End Class
