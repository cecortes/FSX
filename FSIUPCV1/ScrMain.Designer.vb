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
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PnlEdo = New System.Windows.Forms.Panel()
        Me.LblAirSpeed = New System.Windows.Forms.Label()
        Me.LblVS = New System.Windows.Forms.Label()
        Me.PnlOffset = New System.Windows.Forms.Panel()
        Me.LblHdg = New System.Windows.Forms.Label()
        Me.LblGnd = New System.Windows.Forms.Label()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTop.SuspendLayout()
        Me.PnlEdo.SuspendLayout()
        Me.PnlOffset.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.PnlEdo
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
        Me.Barra.Size = New System.Drawing.Size(56, 79)
        Me.Barra.TabIndex = 0
        Me.Barra.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.Barra.Value = 1
        '
        'LblEdo
        '
        Me.LblEdo.AutoSize = True
        Me.LblEdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEdo.ForeColor = System.Drawing.Color.Crimson
        Me.LblEdo.Location = New System.Drawing.Point(74, 9)
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
        Me.LblCon.Location = New System.Drawing.Point(74, 59)
        Me.LblCon.Name = "LblCon"
        Me.LblCon.Size = New System.Drawing.Size(104, 20)
        Me.LblCon.TabIndex = 2
        Me.LblCon.Text = "Sin conexión"
        '
        'PnlTop
        '
        Me.PnlTop.Controls.Add(Me.PnlOffset)
        Me.PnlTop.Controls.Add(Me.PnlEdo)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(700, 92)
        Me.PnlTop.TabIndex = 3
        '
        'PnlEdo
        '
        Me.PnlEdo.Controls.Add(Me.Barra)
        Me.PnlEdo.Controls.Add(Me.LblCon)
        Me.PnlEdo.Controls.Add(Me.LblEdo)
        Me.PnlEdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlEdo.Location = New System.Drawing.Point(0, 0)
        Me.PnlEdo.Name = "PnlEdo"
        Me.PnlEdo.Size = New System.Drawing.Size(350, 92)
        Me.PnlEdo.TabIndex = 0
        '
        'LblAirSpeed
        '
        Me.LblAirSpeed.AutoSize = True
        Me.LblAirSpeed.BackColor = System.Drawing.Color.Black
        Me.LblAirSpeed.Font = New System.Drawing.Font("MS Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAirSpeed.ForeColor = System.Drawing.Color.Orange
        Me.LblAirSpeed.Location = New System.Drawing.Point(6, 9)
        Me.LblAirSpeed.Name = "LblAirSpeed"
        Me.LblAirSpeed.Size = New System.Drawing.Size(36, 24)
        Me.LblAirSpeed.TabIndex = 1
        Me.LblAirSpeed.Text = "--"
        '
        'LblVS
        '
        Me.LblVS.AutoSize = True
        Me.LblVS.BackColor = System.Drawing.Color.Black
        Me.LblVS.Font = New System.Drawing.Font("MS Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVS.ForeColor = System.Drawing.Color.Gold
        Me.LblVS.Location = New System.Drawing.Point(6, 55)
        Me.LblVS.Name = "LblVS"
        Me.LblVS.Size = New System.Drawing.Size(36, 24)
        Me.LblVS.TabIndex = 2
        Me.LblVS.Text = "--"
        '
        'PnlOffset
        '
        Me.PnlOffset.Controls.Add(Me.LblGnd)
        Me.PnlOffset.Controls.Add(Me.LblHdg)
        Me.PnlOffset.Controls.Add(Me.LblVS)
        Me.PnlOffset.Controls.Add(Me.LblAirSpeed)
        Me.PnlOffset.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlOffset.Location = New System.Drawing.Point(350, 0)
        Me.PnlOffset.Name = "PnlOffset"
        Me.PnlOffset.Size = New System.Drawing.Size(320, 92)
        Me.PnlOffset.TabIndex = 1
        '
        'LblHdg
        '
        Me.LblHdg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblHdg.AutoSize = True
        Me.LblHdg.BackColor = System.Drawing.Color.Black
        Me.LblHdg.Font = New System.Drawing.Font("MS Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHdg.ForeColor = System.Drawing.Color.Yellow
        Me.LblHdg.Location = New System.Drawing.Point(281, 9)
        Me.LblHdg.Name = "LblHdg"
        Me.LblHdg.Size = New System.Drawing.Size(36, 24)
        Me.LblHdg.TabIndex = 3
        Me.LblHdg.Text = "--"
        '
        'LblGnd
        '
        Me.LblGnd.AutoSize = True
        Me.LblGnd.BackColor = System.Drawing.Color.Black
        Me.LblGnd.Font = New System.Drawing.Font("MS Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGnd.ForeColor = System.Drawing.Color.GreenYellow
        Me.LblGnd.Location = New System.Drawing.Point(153, 55)
        Me.LblGnd.Name = "LblGnd"
        Me.LblGnd.Size = New System.Drawing.Size(36, 24)
        Me.LblGnd.TabIndex = 4
        Me.LblGnd.Text = "--"
        '
        'ScrMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(700, 100)
        Me.Controls.Add(Me.PnlTop)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ScrMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTop.ResumeLayout(False)
        Me.PnlEdo.ResumeLayout(False)
        Me.PnlEdo.PerformLayout()
        Me.PnlOffset.ResumeLayout(False)
        Me.PnlOffset.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Barra As TrackBar
    Friend WithEvents LblEdo As Label
    Friend WithEvents TmrEvent As Timer
    Friend WithEvents LblCon As Label
    Friend WithEvents PnlTop As Panel
    Friend WithEvents PnlEdo As Panel
    Friend WithEvents LblAirSpeed As Label
    Friend WithEvents LblVS As Label
    Friend WithEvents PnlOffset As Panel
    Friend WithEvents LblHdg As Label
    Friend WithEvents LblGnd As Label
End Class
