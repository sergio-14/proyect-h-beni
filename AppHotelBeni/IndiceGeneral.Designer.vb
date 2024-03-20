<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IndiceGeneral
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Db1 = New CmpHotelBeni.DB()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FinalizarAlquilerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TXTDNI = New System.Windows.Forms.TextBox()
        Me.TXTPLACA = New System.Windows.Forms.TextBox()
        Me.xdni = New System.Windows.Forms.RadioButton()
        Me.BTXPLACA = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txttotal = New System.Windows.Forms.TextBox()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Dgv1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AlquilerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadHoras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NDI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoPaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoMaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NacionalidadID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nacionalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.habitacionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.habitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Db1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Db1
        '
        Me.Db1.DataSetName = "DB"
        Me.Db1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FinalizarAlquilerToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(162, 26)
        '
        'FinalizarAlquilerToolStripMenuItem
        '
        Me.FinalizarAlquilerToolStripMenuItem.Name = "FinalizarAlquilerToolStripMenuItem"
        Me.FinalizarAlquilerToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.FinalizarAlquilerToolStripMenuItem.Text = "Finalizar Alquiler"
        '
        'TXTDNI
        '
        Me.TXTDNI.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TXTDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDNI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTDNI.Location = New System.Drawing.Point(1113, 114)
        Me.TXTDNI.Name = "TXTDNI"
        Me.TXTDNI.Size = New System.Drawing.Size(100, 22)
        Me.TXTDNI.TabIndex = 90
        Me.TXTDNI.Visible = False
        '
        'TXTPLACA
        '
        Me.TXTPLACA.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TXTPLACA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTPLACA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPLACA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPLACA.Location = New System.Drawing.Point(1113, 92)
        Me.TXTPLACA.Name = "TXTPLACA"
        Me.TXTPLACA.Size = New System.Drawing.Size(100, 22)
        Me.TXTPLACA.TabIndex = 89
        Me.TXTPLACA.Visible = False
        '
        'xdni
        '
        Me.xdni.AutoSize = True
        Me.xdni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xdni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.xdni.Location = New System.Drawing.Point(1035, 114)
        Me.xdni.Name = "xdni"
        Me.xdni.Size = New System.Drawing.Size(72, 20)
        Me.xdni.TabIndex = 88
        Me.xdni.TabStop = True
        Me.xdni.Text = "X DNI :"
        Me.xdni.UseVisualStyleBackColor = True
        '
        'BTXPLACA
        '
        Me.BTXPLACA.AutoSize = True
        Me.BTXPLACA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTXPLACA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTXPLACA.Location = New System.Drawing.Point(1013, 92)
        Me.BTXPLACA.Name = "BTXPLACA"
        Me.BTXPLACA.Size = New System.Drawing.Size(94, 20)
        Me.BTXPLACA.TabIndex = 87
        Me.BTXPLACA.TabStop = True
        Me.BTXPLACA.Text = "X PLACA :"
        Me.BTXPLACA.UseVisualStyleBackColor = True
        Me.BTXPLACA.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(318, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 25)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "A:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(917, 523)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 18)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "TOTAL GENERADO:"
        '
        'Txttotal
        '
        Me.Txttotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txttotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Txttotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Txttotal.Location = New System.Drawing.Point(1082, 523)
        Me.Txttotal.Name = "Txttotal"
        Me.Txttotal.ReadOnly = True
        Me.Txttotal.Size = New System.Drawing.Size(130, 31)
        Me.Txttotal.TabIndex = 84
        Me.Txttotal.UseWaitCursor = True
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker4.Location = New System.Drawing.Point(358, 119)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(280, 24)
        Me.DateTimePicker4.TabIndex = 83
        Me.DateTimePicker4.Value = New Date(2023, 5, 4, 19, 5, 0, 0)
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Location = New System.Drawing.Point(29, 119)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(283, 24)
        Me.DateTimePicker3.TabIndex = 82
        Me.DateTimePicker3.Value = New Date(2023, 5, 4, 19, 5, 0, 0)
        '
        'Dgv1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv1.AutoGenerateColumns = False
        Me.Dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(29, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv1.ColumnHeadersHeight = 30
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AlquilerID, Me.Fecha, Me.HoraInicio, Me.HoraFin, Me.CantidadHoras, Me.NDI, Me.Nombres, Me.ApellidoPaterno, Me.ApellidoMaterno, Me.NacionalidadID, Me.Nacionalidad, Me.habitacionID, Me.habitacion, Me.Modelo, Me.Tipo, Me.TipoID, Me.Monto, Me.Estado})
        Me.Dgv1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Dgv1.DataMember = "AlquileresBB"
        Me.Dgv1.DataSource = Me.Db1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(37, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv1.EnableHeadersVisualStyles = False
        Me.Dgv1.GridColor = System.Drawing.Color.Gray
        Me.Dgv1.Location = New System.Drawing.Point(29, 158)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.ReadOnly = True
        Me.Dgv1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Teal
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Dgv1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Dgv1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv1.Size = New System.Drawing.Size(1184, 337)
        Me.Dgv1.TabIndex = 91
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Showcard Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(248, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(692, 46)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "INDICE DE HUESPEDES REGISTRADOS"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 30)
        Me.Button2.TabIndex = 100
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AlquilerID
        '
        Me.AlquilerID.DataPropertyName = "AlquilerID"
        Me.AlquilerID.HeaderText = "AlquilerID"
        Me.AlquilerID.Name = "AlquilerID"
        Me.AlquilerID.ReadOnly = True
        Me.AlquilerID.Visible = False
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'HoraInicio
        '
        Me.HoraInicio.DataPropertyName = "HoraInicio"
        Me.HoraInicio.HeaderText = "HoraInicio"
        Me.HoraInicio.Name = "HoraInicio"
        Me.HoraInicio.ReadOnly = True
        Me.HoraInicio.Visible = False
        '
        'HoraFin
        '
        Me.HoraFin.DataPropertyName = "HoraFin"
        Me.HoraFin.HeaderText = "HoraFin"
        Me.HoraFin.Name = "HoraFin"
        Me.HoraFin.ReadOnly = True
        Me.HoraFin.Visible = False
        '
        'CantidadHoras
        '
        Me.CantidadHoras.DataPropertyName = "CantidadHoras"
        Me.CantidadHoras.HeaderText = "CantidadHoras"
        Me.CantidadHoras.Name = "CantidadHoras"
        Me.CantidadHoras.ReadOnly = True
        Me.CantidadHoras.Visible = False
        '
        'NDI
        '
        Me.NDI.DataPropertyName = "NDI"
        Me.NDI.HeaderText = "NDI"
        Me.NDI.Name = "NDI"
        Me.NDI.ReadOnly = True
        '
        'Nombres
        '
        Me.Nombres.DataPropertyName = "Nombres"
        Me.Nombres.HeaderText = "Nombres"
        Me.Nombres.Name = "Nombres"
        Me.Nombres.ReadOnly = True
        '
        'ApellidoPaterno
        '
        Me.ApellidoPaterno.DataPropertyName = "ApellidoPaterno"
        Me.ApellidoPaterno.HeaderText = "ApellidoPaterno"
        Me.ApellidoPaterno.Name = "ApellidoPaterno"
        Me.ApellidoPaterno.ReadOnly = True
        '
        'ApellidoMaterno
        '
        Me.ApellidoMaterno.DataPropertyName = "ApellidoMaterno"
        Me.ApellidoMaterno.HeaderText = "ApellidoMaterno"
        Me.ApellidoMaterno.Name = "ApellidoMaterno"
        Me.ApellidoMaterno.ReadOnly = True
        Me.ApellidoMaterno.Visible = False
        '
        'NacionalidadID
        '
        Me.NacionalidadID.DataPropertyName = "NacionalidadID"
        Me.NacionalidadID.HeaderText = "NacionalidadID"
        Me.NacionalidadID.Name = "NacionalidadID"
        Me.NacionalidadID.ReadOnly = True
        Me.NacionalidadID.Visible = False
        '
        'Nacionalidad
        '
        Me.Nacionalidad.DataPropertyName = "Nacionalidad"
        Me.Nacionalidad.HeaderText = "Nacionalidad"
        Me.Nacionalidad.Name = "Nacionalidad"
        Me.Nacionalidad.ReadOnly = True
        Me.Nacionalidad.Visible = False
        '
        'habitacionID
        '
        Me.habitacionID.DataPropertyName = "habitacionID"
        Me.habitacionID.HeaderText = "habitacionID"
        Me.habitacionID.Name = "habitacionID"
        Me.habitacionID.ReadOnly = True
        Me.habitacionID.Visible = False
        '
        'habitacion
        '
        Me.habitacion.DataPropertyName = "habitacion"
        Me.habitacion.HeaderText = "habitacion"
        Me.habitacion.Name = "habitacion"
        Me.habitacion.ReadOnly = True
        '
        'Modelo
        '
        Me.Modelo.DataPropertyName = "Modelo"
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        Me.Modelo.Visible = False
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Visible = False
        '
        'TipoID
        '
        Me.TipoID.DataPropertyName = "TipoID"
        Me.TipoID.HeaderText = "TipoID"
        Me.TipoID.Name = "TipoID"
        Me.TipoID.ReadOnly = True
        Me.TipoID.Visible = False
        '
        'Monto
        '
        Me.Monto.DataPropertyName = "Monto"
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'IndiceGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1258, 592)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Dgv1)
        Me.Controls.Add(Me.TXTDNI)
        Me.Controls.Add(Me.TXTPLACA)
        Me.Controls.Add(Me.xdni)
        Me.Controls.Add(Me.BTXPLACA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txttotal)
        Me.Controls.Add(Me.DateTimePicker4)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IndiceGeneral"
        CType(Me.Db1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db1 As CmpHotelBeni.DB
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FinalizarAlquilerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TXTDNI As TextBox
    Friend WithEvents TXTPLACA As TextBox
    Friend WithEvents xdni As RadioButton
    Friend WithEvents BTXPLACA As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txttotal As TextBox
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents Dgv1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents AlquilerID As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents HoraInicio As DataGridViewTextBoxColumn
    Friend WithEvents HoraFin As DataGridViewTextBoxColumn
    Friend WithEvents CantidadHoras As DataGridViewTextBoxColumn
    Friend WithEvents NDI As DataGridViewTextBoxColumn
    Friend WithEvents Nombres As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoPaterno As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoMaterno As DataGridViewTextBoxColumn
    Friend WithEvents NacionalidadID As DataGridViewTextBoxColumn
    Friend WithEvents Nacionalidad As DataGridViewTextBoxColumn
    Friend WithEvents habitacionID As DataGridViewTextBoxColumn
    Friend WithEvents habitacion As DataGridViewTextBoxColumn
    Friend WithEvents Modelo As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents TipoID As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class
