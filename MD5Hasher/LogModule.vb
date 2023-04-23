Module LogModule

    ' Define constants for different log appearances
    Const pgbInfo As Integer = 0
    Const pgbAlert As Integer = 1
    Const pgbError As Integer = 2
    Const pgbCritical As Integer = 3

    ' Define the Logging function
    Public Sub Log(ByVal LogText As String, Optional ByVal LogApperance As Integer = pgbInfo)

        ' Check if LogApperance is a valid value
        If LogApperance < pgbInfo Or LogApperance > pgbCritical Then
            Exit Sub
        End If

        ' Get the current time
        Dim currentTime As String = "[" & DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt") & "]"

        ' Determine the log appearance string based on the LogApperance value
        Dim logAppearanceString As String = "Info"

        Select Case LogApperance
            Case pgbInfo
                logAppearanceString = "Info"
            Case pgbAlert
                logAppearanceString = "Alert"
            Case pgbError
                logAppearanceString = "Error"
            Case pgbCritical
                logAppearanceString = "Critical"
            Case ""
                logAppearanceString = "Info"

        End Select

        ' Format the log message
        Dim logMessage As String = currentTime & "[" & logAppearanceString & "]" & ":" & LogText & Environment.NewLine

        ' Write the log message to the txtLog control on frmAboutBox
        frmAboutbox.txtLog.AppendText(logMessage)

    End Sub

End Module
