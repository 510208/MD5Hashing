
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms.Clipboard


Public Class Form1

    Function md5(ByVal file_name As String)
        Dim hash = md5.Create()
        Dim hashValue() As Byte
        Dim fileStream As FileStream = File.OpenRead(file_name)
        fileStream.Position = 0
        hashValue = hash.ComputeHash(fileStream)
        Dim hash_hex = PrintByteArray(hashValue)
        fileStream.Close()
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
        Exit Sub
Error_Proc:
        lblPath.Text = "讀取過程發生錯誤，因此無法讀出MD5，錯誤內容如下：" & Err.Description
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
        If lblPath.Text = lblPathSec.Text Then
            Label2.Text = "檔案完整性無誤"
            PictureBox1.Image = My.Resources.check
        Else
            Label2.Text = "檔案驗證過程有誤，請注意！"
            PictureBox1.Image = My.Resources._error
        End If
        Exit Sub
Error_Proc:
        lblPath.Text = "讀取過程發生錯誤，因此無法讀出MD5，錯誤內容如下：" & Err.Description
        Exit Sub
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If lblmd5.Text = txtMD5Hash.Text Then
            Label2.Text = "檔案完整性無誤"
            PictureBox1.Image = My.Resources.check
        Else
            Label2.Text = "檔案驗證過程有誤，請注意！"
            PictureBox1.Image = My.Resources._error
        End If
    End Sub

    Private Sub txtMD5Hash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMD5Hash.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If lblmd5.Text = txtMD5Hash.Text Then
                Label2.Text = "檔案完整性無誤"
                PictureBox1.Image = My.Resources.check
            Else
                Label2.Text = "檔案驗證過程有誤，請注意！"
                PictureBox1.Image = My.Resources._error
            End If
        End If
    End Sub
End Class
