<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LBNombrePack = New System.Windows.Forms.Label()
        Me.LBCantidadInventario = New System.Windows.Forms.Label()
        Me.TBNombrePack = New System.Windows.Forms.TextBox()
        Me.TBCInventario = New System.Windows.Forms.TextBox()
        Me.GPIngresos = New System.Windows.Forms.GroupBox()
        Me.TBCDeseada = New System.Windows.Forms.TextBox()
        Me.LBCantidadDeseada = New System.Windows.Forms.Label()
        Me.GPProductos = New System.Windows.Forms.GroupBox()
        Me.RBBaterias = New System.Windows.Forms.RadioButton()
        Me.RBGalletas = New System.Windows.Forms.RadioButton()
        Me.RBFritura = New System.Windows.Forms.RadioButton()
        Me.RBJugos = New System.Windows.Forms.RadioButton()
        Me.TSMenu = New System.Windows.Forms.ToolStrip()
        Me.TSAceptar = New System.Windows.Forms.ToolStripLabel()
        Me.TSData = New System.Windows.Forms.ToolStripLabel()
        Me.TSVectores = New System.Windows.Forms.ToolStripLabel()
        Me.TSSalir = New System.Windows.Forms.ToolStripLabel()
        Me.DTResultados = New System.Windows.Forms.DataGridView()
        Me.DTNombrePack = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTPacks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTSobrante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPIngresos.SuspendLayout()
        Me.GPProductos.SuspendLayout()
        Me.TSMenu.SuspendLayout()
        CType(Me.DTResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBNombrePack
        '
        Me.LBNombrePack.AutoSize = True
        Me.LBNombrePack.Location = New System.Drawing.Point(78, 54)
        Me.LBNombrePack.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBNombrePack.Name = "LBNombrePack"
        Me.LBNombrePack.Size = New System.Drawing.Size(133, 17)
        Me.LBNombrePack.TabIndex = 0
        Me.LBNombrePack.Text = "Nombre del Pack"
        '
        'LBCantidadInventario
        '
        Me.LBCantidadInventario.AutoSize = True
        Me.LBCantidadInventario.Location = New System.Drawing.Point(19, 95)
        Me.LBCantidadInventario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBCantidadInventario.Name = "LBCantidadInventario"
        Me.LBCantidadInventario.Size = New System.Drawing.Size(192, 17)
        Me.LBCantidadInventario.TabIndex = 1
        Me.LBCantidadInventario.Text = "Cantidad en el Inventario"
        '
        'TBNombrePack
        '
        Me.TBNombrePack.Location = New System.Drawing.Point(218, 46)
        Me.TBNombrePack.Name = "TBNombrePack"
        Me.TBNombrePack.Size = New System.Drawing.Size(198, 25)
        Me.TBNombrePack.TabIndex = 2
        '
        'TBCInventario
        '
        Me.TBCInventario.Location = New System.Drawing.Point(218, 87)
        Me.TBCInventario.Name = "TBCInventario"
        Me.TBCInventario.Size = New System.Drawing.Size(198, 25)
        Me.TBCInventario.TabIndex = 3
        Me.TBCInventario.Text = "0"
        '
        'GPIngresos
        '
        Me.GPIngresos.Controls.Add(Me.TBCDeseada)
        Me.GPIngresos.Controls.Add(Me.LBCantidadDeseada)
        Me.GPIngresos.Controls.Add(Me.TBCInventario)
        Me.GPIngresos.Controls.Add(Me.LBCantidadInventario)
        Me.GPIngresos.Controls.Add(Me.TBNombrePack)
        Me.GPIngresos.Controls.Add(Me.LBNombrePack)
        Me.GPIngresos.Location = New System.Drawing.Point(53, 47)
        Me.GPIngresos.Name = "GPIngresos"
        Me.GPIngresos.Size = New System.Drawing.Size(440, 174)
        Me.GPIngresos.TabIndex = 4
        Me.GPIngresos.TabStop = False
        Me.GPIngresos.Text = "Datos del Producto"
        '
        'TBCDeseada
        '
        Me.TBCDeseada.Location = New System.Drawing.Point(218, 125)
        Me.TBCDeseada.Name = "TBCDeseada"
        Me.TBCDeseada.Size = New System.Drawing.Size(198, 25)
        Me.TBCDeseada.TabIndex = 5
        Me.TBCDeseada.Text = "0"
        '
        'LBCantidadDeseada
        '
        Me.LBCantidadDeseada.AutoSize = True
        Me.LBCantidadDeseada.Location = New System.Drawing.Point(71, 133)
        Me.LBCantidadDeseada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBCantidadDeseada.Name = "LBCantidadDeseada"
        Me.LBCantidadDeseada.Size = New System.Drawing.Size(140, 17)
        Me.LBCantidadDeseada.TabIndex = 4
        Me.LBCantidadDeseada.Text = "Cantidad Deseada"
        '
        'GPProductos
        '
        Me.GPProductos.Controls.Add(Me.RBBaterias)
        Me.GPProductos.Controls.Add(Me.RBGalletas)
        Me.GPProductos.Controls.Add(Me.RBFritura)
        Me.GPProductos.Controls.Add(Me.RBJugos)
        Me.GPProductos.Location = New System.Drawing.Point(529, 47)
        Me.GPProductos.Name = "GPProductos"
        Me.GPProductos.Size = New System.Drawing.Size(218, 174)
        Me.GPProductos.TabIndex = 5
        Me.GPProductos.TabStop = False
        Me.GPProductos.Text = "Productos"
        '
        'RBBaterias
        '
        Me.RBBaterias.AutoSize = True
        Me.RBBaterias.Location = New System.Drawing.Point(53, 115)
        Me.RBBaterias.Name = "RBBaterias"
        Me.RBBaterias.Size = New System.Drawing.Size(88, 21)
        Me.RBBaterias.TabIndex = 3
        Me.RBBaterias.TabStop = True
        Me.RBBaterias.Text = "Baterias"
        Me.RBBaterias.UseVisualStyleBackColor = True
        '
        'RBGalletas
        '
        Me.RBGalletas.AutoSize = True
        Me.RBGalletas.Location = New System.Drawing.Point(53, 88)
        Me.RBGalletas.Name = "RBGalletas"
        Me.RBGalletas.Size = New System.Drawing.Size(87, 21)
        Me.RBGalletas.TabIndex = 2
        Me.RBGalletas.TabStop = True
        Me.RBGalletas.Text = "Galletas"
        Me.RBGalletas.UseVisualStyleBackColor = True
        '
        'RBFritura
        '
        Me.RBFritura.AutoSize = True
        Me.RBFritura.Location = New System.Drawing.Point(53, 61)
        Me.RBFritura.Name = "RBFritura"
        Me.RBFritura.Size = New System.Drawing.Size(76, 21)
        Me.RBFritura.TabIndex = 1
        Me.RBFritura.TabStop = True
        Me.RBFritura.Text = "Fritura"
        Me.RBFritura.UseVisualStyleBackColor = True
        '
        'RBJugos
        '
        Me.RBJugos.AutoSize = True
        Me.RBJugos.Location = New System.Drawing.Point(53, 34)
        Me.RBJugos.Name = "RBJugos"
        Me.RBJugos.Size = New System.Drawing.Size(68, 21)
        Me.RBJugos.TabIndex = 0
        Me.RBJugos.TabStop = True
        Me.RBJugos.Text = "Jugos"
        Me.RBJugos.UseVisualStyleBackColor = True
        '
        'TSMenu
        '
        Me.TSMenu.BackColor = System.Drawing.Color.DarkKhaki
        Me.TSMenu.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSAceptar, Me.TSData, Me.TSVectores, Me.TSSalir})
        Me.TSMenu.Location = New System.Drawing.Point(0, 0)
        Me.TSMenu.Name = "TSMenu"
        Me.TSMenu.Size = New System.Drawing.Size(822, 25)
        Me.TSMenu.TabIndex = 6
        Me.TSMenu.Text = "ToolStrip1"
        '
        'TSAceptar
        '
        Me.TSAceptar.Name = "TSAceptar"
        Me.TSAceptar.Size = New System.Drawing.Size(64, 22)
        Me.TSAceptar.Text = "Aceptar"
        '
        'TSData
        '
        Me.TSData.Name = "TSData"
        Me.TSData.Size = New System.Drawing.Size(163, 22)
        Me.TSData.Text = "Limpiar DataGridView"
        '
        'TSVectores
        '
        Me.TSVectores.Name = "TSVectores"
        Me.TSVectores.Size = New System.Drawing.Size(126, 22)
        Me.TSVectores.Text = "Limpiar Vectores"
        '
        'TSSalir
        '
        Me.TSSalir.Name = "TSSalir"
        Me.TSSalir.Size = New System.Drawing.Size(39, 22)
        Me.TSSalir.Text = "Salir"
        '
        'DTResultados
        '
        Me.DTResultados.BackgroundColor = System.Drawing.Color.OliveDrab
        Me.DTResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DTNombrePack, Me.DTProducto, Me.DTPacks, Me.DTSobrante, Me.DTSubtotal, Me.DTDescuento, Me.DTTotal})
        Me.DTResultados.Location = New System.Drawing.Point(15, 262)
        Me.DTResultados.Name = "DTResultados"
        Me.DTResultados.Size = New System.Drawing.Size(768, 278)
        Me.DTResultados.TabIndex = 7
        '
        'DTNombrePack
        '
        Me.DTNombrePack.HeaderText = "Nombre del Pack"
        Me.DTNombrePack.Name = "DTNombrePack"
        Me.DTNombrePack.Width = 150
        '
        'DTProducto
        '
        Me.DTProducto.HeaderText = "Producto"
        Me.DTProducto.Name = "DTProducto"
        Me.DTProducto.Width = 125
        '
        'DTPacks
        '
        Me.DTPacks.HeaderText = "No. de Packs"
        Me.DTPacks.Name = "DTPacks"
        Me.DTPacks.Width = 75
        '
        'DTSobrante
        '
        Me.DTSobrante.HeaderText = "Productos Sobrantes"
        Me.DTSobrante.Name = "DTSobrante"
        '
        'DTSubtotal
        '
        Me.DTSubtotal.HeaderText = "Subtotal"
        Me.DTSubtotal.Name = "DTSubtotal"
        '
        'DTDescuento
        '
        Me.DTDescuento.HeaderText = "Descuento"
        Me.DTDescuento.Name = "DTDescuento"
        '
        'DTTotal
        '
        Me.DTTotal.HeaderText = "Total"
        Me.DTTotal.Name = "DTTotal"
        Me.DTTotal.Width = 75
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(822, 552)
        Me.Controls.Add(Me.DTResultados)
        Me.Controls.Add(Me.TSMenu)
        Me.Controls.Add(Me.GPProductos)
        Me.Controls.Add(Me.GPIngresos)
        Me.Font = New System.Drawing.Font("HP Simplified Hans", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUPERMERCADO EL BUENO"
        Me.GPIngresos.ResumeLayout(False)
        Me.GPIngresos.PerformLayout()
        Me.GPProductos.ResumeLayout(False)
        Me.GPProductos.PerformLayout()
        Me.TSMenu.ResumeLayout(False)
        Me.TSMenu.PerformLayout()
        CType(Me.DTResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBNombrePack As Label
    Friend WithEvents LBCantidadInventario As Label
    Friend WithEvents TBNombrePack As TextBox
    Friend WithEvents TBCInventario As TextBox
    Friend WithEvents GPIngresos As GroupBox
    Friend WithEvents TBCDeseada As TextBox
    Friend WithEvents LBCantidadDeseada As Label
    Friend WithEvents GPProductos As GroupBox
    Friend WithEvents RBBaterias As RadioButton
    Friend WithEvents RBGalletas As RadioButton
    Friend WithEvents RBFritura As RadioButton
    Friend WithEvents RBJugos As RadioButton
    Friend WithEvents TSMenu As ToolStrip
    Friend WithEvents TSAceptar As ToolStripLabel
    Friend WithEvents TSData As ToolStripLabel
    Friend WithEvents TSVectores As ToolStripLabel
    Friend WithEvents TSSalir As ToolStripLabel
    Friend WithEvents DTResultados As DataGridView
    Friend WithEvents DTNombrePack As DataGridViewTextBoxColumn
    Friend WithEvents DTProducto As DataGridViewTextBoxColumn
    Friend WithEvents DTPacks As DataGridViewTextBoxColumn
    Friend WithEvents DTSobrante As DataGridViewTextBoxColumn
    Friend WithEvents DTSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents DTDescuento As DataGridViewTextBoxColumn
    Friend WithEvents DTTotal As DataGridViewTextBoxColumn
End Class
