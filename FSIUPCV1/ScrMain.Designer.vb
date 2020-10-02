<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrMain
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
        Me.components = New System.ComponentModel.Container()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Barra = New System.Windows.Forms.TrackBar()
        Me.LblEdo = New System.Windows.Forms.Label()
        Me.TmrEvent = New System.Windows.Forms.Timer(Me.components)
        Me.LblCon = New System.Windows.Forms.Label()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'Barra
        '
        Me.Barra.BackColor = System.Drawing.Color.Black
        Me.Barra.LargeChange = 1
        Me.Barra.Location = New System.Drawing.Point(12, 12)
        Me.Barra.Maximum = 2
        Me.Barra.Minimum = 1
        Me.Barra.Name = "Barra"
        Me.Barra.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Barra.Size = New System.Drawing.Size(56, 104)
        Me.Barra.TabIndex = 0
        Me.Barra.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.Barra.Value = 1
        '
        'LblEdo
        '
        Me.LblEdo.AutoSize = True
        Me.LblEdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEdo.ForeColor = System.Drawing.Color.Crimson
        Me.LblEdo.Location = New System.Drawing.Point(134, 51)
        Me.LblEdo.Name = "LblEdo"
        Me.LblEdo.Size = New System.Drawing.Size(119, 22)
        Me.LblEdo.TabIndex = 1
        Me.LblEdo.Text = "Desconectado"
        '
        'TmrEvent
        '
        Me.TmrEvent.Interval = 50
        '
        'LblCon
        '
        Me.LblCon.AutoSize = True
        Me.LblCon.BackColor = System.Drawing.Color.Black
        Me.LblCon.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.LblCon.Location = New System.Drawing.Point(12, 153)
        Me.LblCon.Name = "LblCon"
        Me.LblCon.Size = New System.Drawing.Size(104, 20)
        Me.LblCon.TabIndex = 2
        Me.LblCon.Text = "Sin conexión"
        '
        'ScrMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(317, 289)
        Me.Controls.Add(Me.LblCon)
        Me.Controls.Add(Me.LblEdo)
        Me.Controls.Add(Me.Barra)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ScrMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Barra As TrackBar
    Friend WithEvents LblEdo As Label
    Friend WithEvents TmrEvent As Timer
    Friend WithEvents LblCon As Label
End Class
