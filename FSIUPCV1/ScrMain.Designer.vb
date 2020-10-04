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
        Me.PnlEdo = New System.Windows.Forms.Panel()
        Me.Barra = New System.Windows.Forms.TrackBar()
        Me.LblCon = New System.Windows.Forms.Label()
        Me.LblEdo = New System.Windows.Forms.Label()
        Me.TmrEvent = New System.Windows.Forms.Timer(Me.components)
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.PnlAP = New System.Windows.Forms.Panel()
        Me.SwPause = New Bunifu.Framework.UI.BunifuSwitch()
        Me.LblPause = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblAp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SwAvionics = New Bunifu.Framework.UI.BunifuSwitch()
        Me.PnlOffset = New System.Windows.Forms.Panel()
        Me.LblGnd = New System.Windows.Forms.Label()
        Me.LblHdg = New System.Windows.Forms.Label()
        Me.LblVS = New System.Windows.Forms.Label()
        Me.LblAirSpeed = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPress = New System.Windows.Forms.TextBox()
        Me.ChkPress = New System.Windows.Forms.CheckBox()
        Me.PnlEdo.SuspendLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTop.SuspendLayout()
        Me.PnlAP.SuspendLayout()
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
        'PnlEdo
        '
        Me.PnlEdo.Controls.Add(Me.Barra)
        Me.PnlEdo.Controls.Add(Me.LblCon)
        Me.PnlEdo.Controls.Add(Me.LblEdo)
        Me.PnlEdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlEdo.Location = New System.Drawing.Point(0, 0)
        Me.PnlEdo.Name = "PnlEdo"
        Me.PnlEdo.Size = New System.Drawing.Size(308, 92)
        Me.PnlEdo.TabIndex = 0
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
        'PnlTop
        '
        Me.PnlTop.Controls.Add(Me.PnlAP)
        Me.PnlTop.Controls.Add(Me.PnlOffset)
        Me.PnlTop.Controls.Add(Me.PnlEdo)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(1024, 92)
        Me.PnlTop.TabIndex = 3
        '
        'PnlAP
        '
        Me.PnlAP.Controls.Add(Me.ChkPress)
        Me.PnlAP.Controls.Add(Me.TxtPress)
        Me.PnlAP.Controls.Add(Me.Label2)
        Me.PnlAP.Controls.Add(Me.SwPause)
        Me.PnlAP.Controls.Add(Me.LblPause)
        Me.PnlAP.Controls.Add(Me.Label3)
        Me.PnlAP.Controls.Add(Me.LblAp)
        Me.PnlAP.Controls.Add(Me.Label1)
        Me.PnlAP.Controls.Add(Me.SwAvionics)
        Me.PnlAP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlAP.Location = New System.Drawing.Point(582, 0)
        Me.PnlAP.Name = "PnlAP"
        Me.PnlAP.Size = New System.Drawing.Size(442, 92)
        Me.PnlAP.TabIndex = 2
        '
        'SwPause
        '
        Me.SwPause.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SwPause.BorderRadius = 5
        Me.SwPause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SwPause.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SwPause.Location = New System.Drawing.Point(80, 40)
        Me.SwPause.Margin = New System.Windows.Forms.Padding(6)
        Me.SwPause.Name = "SwPause"
        Me.SwPause.Oncolor = System.Drawing.Color.Red
        Me.SwPause.Onoffcolor = System.Drawing.Color.GreenYellow
        Me.SwPause.Size = New System.Drawing.Size(0, 0)
        Me.SwPause.TabIndex = 5
        Me.SwPause.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SwPause.Value = False
        '
        'LblPause
        '
        Me.LblPause.AutoSize = True
        Me.LblPause.ForeColor = System.Drawing.Color.GreenYellow
        Me.LblPause.Location = New System.Drawing.Point(143, 40)
        Me.LblPause.Name = "LblPause"
        Me.LblPause.Size = New System.Drawing.Size(85, 20)
        Me.LblPause.TabIndex = 4
        Me.LblPause.Text = "Sin Pausa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Location = New System.Drawing.Point(6, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Game"
        '
        'LblAp
        '
        Me.LblAp.AutoSize = True
        Me.LblAp.ForeColor = System.Drawing.Color.Red
        Me.LblAp.Location = New System.Drawing.Point(143, 9)
        Me.LblAp.Name = "LblAp"
        Me.LblAp.Size = New System.Drawing.Size(141, 20)
        Me.LblAp.TabIndex = 2
        Me.LblAp.Text = "AUTOPILOT OFF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Avionics"
        '
        'SwAvionics
        '
        Me.SwAvionics.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SwAvionics.BorderRadius = 5
        Me.SwAvionics.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SwAvionics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SwAvionics.Location = New System.Drawing.Point(80, 10)
        Me.SwAvionics.Margin = New System.Windows.Forms.Padding(5)
        Me.SwAvionics.Name = "SwAvionics"
        Me.SwAvionics.Oncolor = System.Drawing.Color.GreenYellow
        Me.SwAvionics.Onoffcolor = System.Drawing.Color.Red
        Me.SwAvionics.Size = New System.Drawing.Size(0, 0)
        Me.SwAvionics.TabIndex = 0
        Me.SwAvionics.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SwAvionics.Value = False
        '
        'PnlOffset
        '
        Me.PnlOffset.Controls.Add(Me.LblGnd)
        Me.PnlOffset.Controls.Add(Me.LblHdg)
        Me.PnlOffset.Controls.Add(Me.LblVS)
        Me.PnlOffset.Controls.Add(Me.LblAirSpeed)
        Me.PnlOffset.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlOffset.Location = New System.Drawing.Point(308, 0)
        Me.PnlOffset.Name = "PnlOffset"
        Me.PnlOffset.Size = New System.Drawing.Size(274, 92)
        Me.PnlOffset.TabIndex = 1
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
        'LblHdg
        '
        Me.LblHdg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblHdg.AutoSize = True
        Me.LblHdg.BackColor = System.Drawing.Color.Black
        Me.LblHdg.Font = New System.Drawing.Font("MS Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHdg.ForeColor = System.Drawing.Color.Yellow
        Me.LblHdg.Location = New System.Drawing.Point(235, 9)
        Me.LblHdg.Name = "LblHdg"
        Me.LblHdg.Size = New System.Drawing.Size(36, 24)
        Me.LblHdg.TabIndex = 3
        Me.LblHdg.Text = "--"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(6, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Altimeter Pressure (hPa)"
        '
        'TxtPress
        '
        Me.TxtPress.Location = New System.Drawing.Point(225, 67)
        Me.TxtPress.Name = "TxtPress"
        Me.TxtPress.Size = New System.Drawing.Size(71, 27)
        Me.TxtPress.TabIndex = 7
        '
        'ChkPress
        '
        Me.ChkPress.Appearance = System.Windows.Forms.Appearance.Button
        Me.ChkPress.AutoSize = True
        Me.ChkPress.ForeColor = System.Drawing.Color.Firebrick
        Me.ChkPress.Location = New System.Drawing.Point(313, 65)
        Me.ChkPress.Name = "ChkPress"
        Me.ChkPress.Size = New System.Drawing.Size(117, 30)
        Me.ChkPress.TabIndex = 8
        Me.ChkPress.Text = "Set Pressure"
        Me.ChkPress.UseVisualStyleBackColor = True
        '
        'ScrMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1024, 100)
        Me.Controls.Add(Me.PnlTop)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ScrMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.TopMost = True
        Me.PnlEdo.ResumeLayout(False)
        Me.PnlEdo.PerformLayout()
        CType(Me.Barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTop.ResumeLayout(False)
        Me.PnlAP.ResumeLayout(False)
        Me.PnlAP.PerformLayout()
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
    Friend WithEvents PnlAP As Panel
    Friend WithEvents SwAvionics As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label1 As Label
    Friend WithEvents LblAp As Label
    Friend WithEvents SwPause As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents LblPause As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPress As TextBox
    Friend WithEvents ChkPress As CheckBox
End Class
