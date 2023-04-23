
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms.Clipboard
Imports System.String
Imports Microsoft.Win32


Public Class frmMain
    Const pgbInfo As Integer = 0
    Const pgbAlert As Integer = 1
    Const pgbError As Integer = 2
    Const pgbCritical As Integer = 3
    Function md5(ByVal file_name As String)
        Dim hash = md5.Create()
        Dim hashValue() As Byte
        Dim fileStream As FileStream = File.OpenRead(file_name)
        fileStream.Position = 0
        hashValue = hash.ComputeHash(fileStream)
        Dim hash_hex = PrintByteArray(hashValue)
        fileStream.Close()
        Log(hash_hex, pgbInfo)
        Return hash_hex
    End Function

    Public Function PrintByteArray(ByVal array() As Byte)
        Dim hex_value As String = ""
        Dim i As Integer
        For i = 0 To array.Length - 1
            hex_value += array(i).ToString("X2")
        Next i
        Return hex_value.ToLower
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click

        Dim md5code As String

        OpenFileDialog1.ShowDialog()

        ' MD5
        Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
        On Error GoTo Error_Proc
        Dim f As FileStream = New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        f = New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        md5.ComputeHash(f)
        Dim ObjFSO As Object = CreateObject("Scripting.FileSystemObject")
        Dim objFile = ObjFSO.GetFile(OpenFileDialog1.FileName)

        Dim hash As Byte() = md5.Hash
        Dim buff As StringBuilder = New StringBuilder
        Dim hashByte As Byte
        For Each hashByte In hash
            buff.Append(String.Format("{0:X1}", hashByte))
        Next

        Dim g As FileStream = New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        g = New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        md5code = buff.ToString()
        lblmd5.Text = md5code
        lblPath.Text = "檔案路徑：" & OpenFileDialog1.FileName()
        txtMD5Hash.Text = ""
        lblPathSec.Text = "檔案路徑：(N/A)"
        lblMD5Sec.Text = "(N/A)"
        PictureBox1.Image = My.Resources.question
        Label2.Text = "尚未驗證"
        Log(OpenFileDialog1.FileName & Space(5) & md5code, pgbInfo)
        Exit Sub
Error_Proc:
        lblPath.Text = "讀取過程發生錯誤，因此無法讀出MD5，錯誤內容如下：" & Err.Description
        Log(Err.Description, pgbError)
        Exit Sub
    End Sub

    Private Sub btnCpoyMD5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCpoyMD5.Click
        Clipboard.SetText(lblmd5.Text)
    End Sub

    Private Sub btnPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtMD5Hash.Text = Clipboard.GetText()
    End Sub

    Private Sub btnCheckFileSec_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckFileSec.Click
        Dim md5code As String

        OpenFileDialog1.ShowDialog()

        ' MD5
        Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
        On Error GoTo Error_Proc
        Dim f As FileStream = New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        f = New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        md5.ComputeHash(f)
        Dim ObjFSO As Object = CreateObject("Scripting.FileSystemObject")
        Dim objFile = ObjFSO.GetFile(OpenFileDialog1.FileName)

        Dim hash As Byte() = md5.Hash
        Dim buff As StringBuilder = New StringBuilder
        Dim hashByte As Byte
        For Each hashByte In hash
            buff.Append(String.Format("{0:X1}", hashByte))
        Next

        Dim g As FileStream = New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        g = New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        md5code = buff.ToString()
        lblmd5.Text = md5code
        lblPathSec.Text = "檔案路徑：" & OpenFileDialog1.FileName()
        lblMD5Sec.Text = md5code
        If lblmd5.Text = lblMD5Sec.Text Then
            Label2.Text = "檔案完整性無誤"
            PictureBox1.Image = My.Resources.check
        Else
            Label2.Text = "檔案驗證過程有誤，請注意！"
            PictureBox1.Image = My.Resources.errorImg
        End If
        Exit Sub
Error_Proc:
        lblPath.Text = "讀取過程發生錯誤，因此無法讀出MD5，錯誤內容如下：" & Err.Description
        Log(Err.Description, pgbError)
        Exit Sub
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim md5Yes As String
        md5Yes = txtMD5Hash.Text
        md5Yes = md5Yes.ToUpper()
        txtMD5Hash.Text = md5Yes
        If lblmd5.Text = md5Yes Then
            Label2.Text = "檔案完整性無誤"
            PictureBox1.Image = My.Resources.check
        Else
            Label2.Text = "檔案驗證過程有誤，請注意！"
            PictureBox1.Image = My.Resources.errorImg
        End If
    End Sub

    Private Sub txtMD5Hash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMD5Hash.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If lblmd5.Text = txtMD5Hash.Text Then
                Label2.Text = "檔案完整性無誤"
                PictureBox1.Image = My.Resources.check
            Else
                Label2.Text = "檔案驗證過程有誤，請注意！"
                PictureBox1.Image = My.Resources.errorImg
            End If
        End If
    End Sub

    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' 創建RegistryKey對象，指定根鍵為HKEY_CURRENT_USER
        Dim regKey As RegistryKey = Registry.CurrentUser

        ' 打開SOFTWARE/MD5Hasher鍵
        Dim md5Key As RegistryKey = regKey.OpenSubKey("SOFTWARE\MD5Hasher")

        ' 如果鍵不存在，則創建它
        If md5Key Is Nothing Then
            md5Key = regKey.CreateSubKey("SOFTWARE\MD5Hasher")
        End If

        ' 檢查"Accepted"鍵值是否已存在
        If md5Key.GetValue("Accepted") IsNot Nothing Then
            ' 如果存在，就退出if
            Return
        End If

        ' 顯示Form3
        Dim f3 As New frmLicense()
        f3.Show()

        ' 設置Accepted值為True
        md5Key.SetValue("Accepted", True)

        ' 關閉鍵
        md5Key.Close()
        regKey.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log("MD5Hasher v" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision, pgbInfo)
        Me.Text = "MD5Hasher v" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAboutbox.Show()
    End Sub
End Class
