'Imports
Imports FSUIPC

Public Class ScrMain

#Region "Variables"

    ''' <summary>
    ''' Los offsets son variables y como tales se declaran al principio de la clase,
    ''' pero nunca dentro de métodos.
    ''' El tipo y tamaño del offset debe dde coincidir al tipo de dato almacenado en el.
    ''' Para más información del tipo buscar en Basic Concepts de la UserGuide.PDF
    ''' </summary>

    Private airspeed As New Offset(Of UInteger)(&H2BC)                      ' 4-byte offset - Unsigned integer 
    Private verticalSpeed As New Offset(Of Integer)(&H2C8)                  ' 4-byte offset - Signed integer 
    Private compass As Offset(Of Double) = New Offset(Of Double)(&H2CC)     ' 8 byte offset - double (FLOAT64)
    Private onGround As New Offset(Of UShort)(&H366)                        ' 2-byte offset - Unsigned short
    Private aircraftType As New Offset(Of String)(&H3160, 24)               ' 24 byte offset - String

#End Region

#Region "Funciones"

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Se encarga de mostrar el estado necesario del texto
    ''' </summary>
    Private Sub SetConexEdo()

        'Actualiza las etiquetas de acuerdo al estado de la conexión
        If FSUIPCConnection.IsOpen Then

            'Open
            LblEdo.ForeColor = Color.GreenYellow
            LblEdo.Text = "Conectado"
            LblCon.Text = "Conectado: " & FSUIPCConnection.FlightSimVersionConnected.ToString()
            LblCon.ForeColor = Color.DeepSkyBlue

        Else

            'Close
            LblEdo.ForeColor = Color.Red
            LblEdo.Text = "Desconectado"
            LblCon.Text = "Sin conexión"

        End If

    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Evalúa el valor de la barra para decidir conectar / desconectar
    ''' Realiza las validaciones necesarias para abrir / cerrar la conexión
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Barra_ValueChanged(sender As Object, e As EventArgs) Handles Barra.ValueChanged

        If Barra.Value > 1 Then

            'Validación
            If FSUIPCConnection.IsOpen Then

                'Conexión previa abierta - Cerrar
                TmrEvent.Stop()
                FSUIPCConnection.Close()

            Else

                'Estado
                LblEdo.ForeColor = Color.YellowGreen
                LblEdo.Text = "Iniciando conexión..."

                'Control de Errores
                Try

                    'Open
                    FSUIPCConnection.Open()

                Catch ex As FSUIPCException

                    'Error
                    MsgBox("Fallo de conexión..." & vbCrLf & vbCrLf & ex.Message)

                End Try

                'Validación
                If FSUIPCConnection.IsOpen Then

                    'Conexión abierta, iniciar el timer
                    TmrEvent.Start()

                End If

            End If

        Else

            'Validación
            If FSUIPCConnection.IsOpen Then

                'Conexión previa abierta - Cerrar
                TmrEvent.Stop()
                FSUIPCConnection.Close()

            End If

        End If

            'Método de estado de la conexión
            SetConexEdo()

    End Sub

    ''' <summary>
    ''' Obtiene los datos del FSUIPC por medio de la propiedad Process()
    ''' Mediante la propiedad Value se accede a los datos del offset
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TmrEvent_Tick(sender As Object, e As EventArgs) Handles TmrEvent.Tick

        'Propiedad Process()
        FSUIPCConnection.Process()

        ' --------------------
        ' AIRSPEED
        ' --------------------
        ' FSUIPC Documentation says this offset is 4 bytes (UInteger) and holds the speed as knots * 128
        ' So we need to convert back to knots by / 128
        ' Offset is 'UInteger' so cast to double for conversion.

        Dim airspeedKnots As Double = CDbl(airspeed.Value) / 128.0

        ' Now the airspeed is in knots display in the text box with rounding to 2 dp.
        LblAirSpeed.Text = airspeedKnots.ToString("F2") & " Knots"

        ' --------------------
        ' VERTICAL SPEED
        ' --------------------
        ' FSUIPC Documentation says this offset is 4 bytes, signed (Integer) and holds the speed as metres/second * 256
        ' We need to convert back to metres/second by / 256
        ' Offset is 'Integer' so cast to double for conversion.

        Dim vSpeedMPS As Double = CDbl(verticalSpeed.Value) / 256.0

        ' If you want to display as feet/minute a further conversion is required:
        Dim vSpeedFPM As Double = vSpeedMPS * 60.0 * 3.28084

        ' Display one of these on the form (this time rounded to 0dp)
        ' this.txtVerticalSpeed.Text = verticalSpeedMPS.ToString("F0");
        LblVS.Text = vSpeedFPM.ToString("F0") & " Ft/min"

        ' --------------------
        ' COMPASS HEADING
        ' --------------------
        ' FSUIPC Documentation says this offset is 8 bytes and holds a FLOAT64 (Double). The value is in degrees.
        ' No conversion needed for this offset - Display directly on the form - rounded to 1dp.
        LblHdg.Text = compass.Value.ToString("F1") & " Ø"

        ' --------------------
        ' ON GROUND
        ' --------------------
        ' FSUIPC Documentation says this offset is 2 bytes (UShort). The value is either 1 (On ground) or 0 (Not on ground).
        ' Create a string to display, based on the value
        Dim onGroundText As String = If(onGround.Value > 0, "Yes", "No")
        ' Display the text
        LblGnd.Text = onGroundText & " " & aircraftType.Value

        ' --------------------
        ' Aircraft Type
        ' --------------------
        ' FSUIPC Documentation says this offset is 24 bytes long and holds a string.
        ' We use the string value directly to display on the form
        'Me.txtAircraftType.Text = aircraftType.Value

    End Sub

#End Region

End Class
