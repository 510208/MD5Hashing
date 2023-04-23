Imports Microsoft.Win32
Imports System.IO


Public Class frmLicense
    Const pgbInfo As Integer = 0
    Const pgbAlert As Integer = 1
    Const pgbError As Integer = 2
    Const pgbCritical As Integer = 3
    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        ' 創建RegistryKey對象，指定根鍵為HKEY_CURRENT_USER
        Dim regKey As RegistryKey = Registry.CurrentUser
        ' 打開SOFTWARE/MD5Hasher鍵
        Dim md5Key As RegistryKey = regKey.OpenSubKey("SOFTWARE\MD5Hasher", True)

        ' 如果鍵不存在，則創建它
        If md5Key Is Nothing Then
            md5Key = regKey.CreateSubKey("SOFTWARE\MD5Hasher")
        End If

        ' 設置Accepted值為True
        md5Key.SetValue("Accepted", True)

        ' 關閉鍵
        md5Key.Close()
        regKey.Close()
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub frmLicense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = frmMain.Icon
        ' 載入GNU.rtf檔案
        Dim filePath As String = "GNU.rtf"
        If File.Exists(filePath) Then
            RichTextBox1.LoadFile(filePath, RichTextBoxStreamType.RichText)
        Else
            MessageBox.Show("File not found: " & filePath)
        End If
    End Sub

    Private Sub btnDeclined_Click(sender As Object, e As EventArgs) Handles btnDeclined.Click
        On Error GoTo exitIng
        Dim keyName As String = "Software\MD5Hasher"
        Using regKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(keyName, True)
            If regKey IsNot Nothing Then
                regKey.DeleteSubKeyTree(keyName)
            End If
        End Using
        End
exitIng:
        Log(Err.Description, pgbError)
        End
    End Sub
End Class