Public Class frmAboutbox
    Const pgbInfo As Integer = 0
    Const pgbAlert As Integer = 1
    Const pgbError As Integer = 2
    Const pgbCritical As Integer = 3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("explorer https://github.com/510208/MD5Hashing ", vbNormalFocus)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frmLicense.Show()
        Me.Close()
    End Sub

    Private Sub frmAboutbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmAboutbox_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' 計算新的 txtLog 控制項的寬度
        Dim txtLogWidth As Integer = Me.ClientSize.Width - 24 ' 12 像素的邊距兩側

        ' 設定 txtLog 控制項的位置和大小
        txtLog.Location = New Point(12, txtLog.Location.Y)
        txtLog.Size = New Size(txtLogWidth, txtLog.Height)
        ' 設定 TextBox1 控制項的位置和大小
        TextBox1.Location = New Point(12, TextBox1.Location.Y)
        TextBox1.Size = New Size(txtLogWidth, TextBox1.Height)
    End Sub
End Class