'Imports
Imports FSUIPC

Public Class ScrMain

#Region "Variables"

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

        End If

        'Método de estado de la conexión
        SetConexEdo()

    End Sub

#End Region

End Class
