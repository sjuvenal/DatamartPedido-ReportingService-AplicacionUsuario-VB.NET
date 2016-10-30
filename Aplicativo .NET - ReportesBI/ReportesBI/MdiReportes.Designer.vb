<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MdiReportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdiReportes))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TipoPrendaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClaseMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoPrendaMenuItem, Me.ClaseMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(609, 40)
        Me.MenuStrip1.TabIndex = 40
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TipoPrendaMenuItem
        '
        Me.TipoPrendaMenuItem.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoPrendaMenuItem.Image = CType(resources.GetObject("TipoPrendaMenuItem.Image"), System.Drawing.Image)
        Me.TipoPrendaMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TipoPrendaMenuItem.Name = "TipoPrendaMenuItem"
        Me.TipoPrendaMenuItem.Size = New System.Drawing.Size(93, 36)
        Me.TipoPrendaMenuItem.Text = "Cliente"
        '
        'ClaseMenuItem
        '
        Me.ClaseMenuItem.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClaseMenuItem.Image = CType(resources.GetObject("ClaseMenuItem.Image"), System.Drawing.Image)
        Me.ClaseMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClaseMenuItem.Name = "ClaseMenuItem"
        Me.ClaseMenuItem.Size = New System.Drawing.Size(103, 36)
        Me.ClaseMenuItem.Text = "Producto"
        '
        'MdiReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 401)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MdiReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MdiReportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TipoPrendaMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClaseMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
