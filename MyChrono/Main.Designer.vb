<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.INICIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DETENERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EstiloDeVentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjustableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NingunoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiempreVisibleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VersionOne = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.VersionOne.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label1.Font = New System.Drawing.Font("Edo SZ", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(534, 105)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "00:00:00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INICIARToolStripMenuItem, Me.DETENERToolStripMenuItem, Me.ToolStripMenuItem3, Me.NuevoToolStripMenuItem, Me.ToolStripMenuItem2, Me.EstiloDeVentanaToolStripMenuItem, Me.SiempreVisibleToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(194, 176)
        '
        'INICIARToolStripMenuItem
        '
        Me.INICIARToolStripMenuItem.Name = "INICIARToolStripMenuItem"
        Me.INICIARToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.INICIARToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.INICIARToolStripMenuItem.Text = "INICIAR"
        '
        'DETENERToolStripMenuItem
        '
        Me.DETENERToolStripMenuItem.Name = "DETENERToolStripMenuItem"
        Me.DETENERToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.DETENERToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.DETENERToolStripMenuItem.Text = "DETENER"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(190, 6)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(190, 6)
        '
        'EstiloDeVentanaToolStripMenuItem
        '
        Me.EstiloDeVentanaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjustableToolStripMenuItem, Me.NingunoToolStripMenuItem})
        Me.EstiloDeVentanaToolStripMenuItem.Name = "EstiloDeVentanaToolStripMenuItem"
        Me.EstiloDeVentanaToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.EstiloDeVentanaToolStripMenuItem.Text = "Estilo de ventana"
        '
        'AjustableToolStripMenuItem
        '
        Me.AjustableToolStripMenuItem.Checked = True
        Me.AjustableToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AjustableToolStripMenuItem.Name = "AjustableToolStripMenuItem"
        Me.AjustableToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AjustableToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AjustableToolStripMenuItem.Text = "Ajustable"
        '
        'NingunoToolStripMenuItem
        '
        Me.NingunoToolStripMenuItem.Name = "NingunoToolStripMenuItem"
        Me.NingunoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NingunoToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.NingunoToolStripMenuItem.Text = "Ninguno"
        '
        'SiempreVisibleToolStripMenuItem
        '
        Me.SiempreVisibleToolStripMenuItem.Name = "SiempreVisibleToolStripMenuItem"
        Me.SiempreVisibleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.SiempreVisibleToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.SiempreVisibleToolStripMenuItem.Text = "Siempre visible"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuenteToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'FuenteToolStripMenuItem
        '
        Me.FuenteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.FuenteToolStripMenuItem.Name = "FuenteToolStripMenuItem"
        Me.FuenteToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.FuenteToolStripMenuItem.Text = "Fuente"
        '
        'TipoToolStripMenuItem
        '
        Me.TipoToolStripMenuItem.Name = "TipoToolStripMenuItem"
        Me.TipoToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.TipoToolStripMenuItem.Text = "Tipo"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(190, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(12, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(520, 27)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "00/00/0000 00:00:00"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label2.Font = New System.Drawing.Font("Edo SZ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(448, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 107)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ".000"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'VersionOne
        '
        Me.VersionOne.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.VersionOne.Controls.Add(Me.Label2)
        Me.VersionOne.Controls.Add(Me.Label1)
        Me.VersionOne.Location = New System.Drawing.Point(2, 2)
        Me.VersionOne.Name = "VersionOne"
        Me.VersionOne.Size = New System.Drawing.Size(540, 105)
        Me.VersionOne.TabIndex = 3
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 156)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.VersionOne)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Da' Chrono's StopWatch"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.VersionOne.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents EstiloDeVentanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NingunoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjustableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INICIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DETENERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SiempreVisibleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionOne As Panel
End Class
