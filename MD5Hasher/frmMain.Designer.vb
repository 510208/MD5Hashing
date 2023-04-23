<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.lblmd5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabCheck = New System.Windows.Forms.TabControl()
        Me.tabFromFile = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMD5Sec = New System.Windows.Forms.Label()
        Me.lblPathSec = New System.Windows.Forms.Label()
        Me.btnCheckFileSec = New System.Windows.Forms.Button()
        Me.tabFromText = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMD5Hash = New System.Windows.Forms.TextBox()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCpoyMD5 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.tabCheck.SuspendLayout()
        Me.tabFromFile.SuspendLayout()
        Me.tabFromText.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(329, 23)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(104, 23)
        Me.btnOpenFile.TabIndex = 1
        Me.btnOpenFile.Text = "開啟舊檔(&O)"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'lblmd5
        '
        Me.lblmd5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmd5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblmd5.Location = New System.Drawing.Point(85, 27)
        Me.lblmd5.Name = "lblmd5"
        Me.lblmd5.Size = New System.Drawing.Size(238, 16)
        Me.lblmd5.TabIndex = 2
        Me.lblmd5.Text = "(N/A)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MD5 Hash："
        '
        'lblPath
        '
        Me.lblPath.Location = New System.Drawing.Point(12, 9)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(351, 18)
        Me.lblPath.TabIndex = 4
        Me.lblPath.Text = "檔案路徑：(N/A)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tabCheck)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 142)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "驗證檔案完整性："
        '
        'tabCheck
        '
        Me.tabCheck.Controls.Add(Me.tabFromFile)
        Me.tabCheck.Controls.Add(Me.tabFromText)
        Me.tabCheck.Location = New System.Drawing.Point(12, 21)
        Me.tabCheck.Name = "tabCheck"
        Me.tabCheck.SelectedIndex = 0
        Me.tabCheck.Size = New System.Drawing.Size(401, 100)
        Me.tabCheck.TabIndex = 9
        '
        'tabFromFile
        '
        Me.tabFromFile.Controls.Add(Me.Label3)
        Me.tabFromFile.Controls.Add(Me.lblMD5Sec)
        Me.tabFromFile.Controls.Add(Me.lblPathSec)
        Me.tabFromFile.Controls.Add(Me.btnCheckFileSec)
        Me.tabFromFile.Location = New System.Drawing.Point(4, 22)
        Me.tabFromFile.Name = "tabFromFile"
        Me.tabFromFile.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFromFile.Size = New System.Drawing.Size(393, 74)
        Me.tabFromFile.TabIndex = 0
        Me.tabFromFile.Text = "從檔案驗證"
        Me.tabFromFile.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "MD5 Hash："
        '
        'lblMD5Sec
        '
        Me.lblMD5Sec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMD5Sec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblMD5Sec.Location = New System.Drawing.Point(79, 29)
        Me.lblMD5Sec.Name = "lblMD5Sec"
        Me.lblMD5Sec.Size = New System.Drawing.Size(308, 16)
        Me.lblMD5Sec.TabIndex = 6
        Me.lblMD5Sec.Text = "(N/A)"
        '
        'lblPathSec
        '
        Me.lblPathSec.Location = New System.Drawing.Point(6, 11)
        Me.lblPathSec.Name = "lblPathSec"
        Me.lblPathSec.Size = New System.Drawing.Size(271, 18)
        Me.lblPathSec.TabIndex = 5
        Me.lblPathSec.Text = "檔案路徑：(N/A)"
        '
        'btnCheckFileSec
        '
        Me.btnCheckFileSec.Location = New System.Drawing.Point(283, 6)
        Me.btnCheckFileSec.Name = "btnCheckFileSec"
        Me.btnCheckFileSec.Size = New System.Drawing.Size(104, 23)
        Me.btnCheckFileSec.TabIndex = 2
        Me.btnCheckFileSec.Text = "開啟舊檔(&O)"
        Me.btnCheckFileSec.UseVisualStyleBackColor = True
        '
        'tabFromText
        '
        Me.tabFromText.Controls.Add(Me.Button1)
        Me.tabFromText.Controls.Add(Me.Label4)
        Me.tabFromText.Controls.Add(Me.txtMD5Hash)
        Me.tabFromText.Controls.Add(Me.btnPaste)
        Me.tabFromText.Location = New System.Drawing.Point(4, 22)
        Me.tabFromText.Name = "tabFromText"
        Me.tabFromText.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFromText.Size = New System.Drawing.Size(393, 74)
        Me.tabFromText.TabIndex = 1
        Me.tabFromText.Text = "從文字驗證"
        Me.tabFromText.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(283, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "驗證完整性(&O)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 12)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "檔案原始MD5值(&O)："
        '
        'txtMD5Hash
        '
        Me.txtMD5Hash.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtMD5Hash.Location = New System.Drawing.Point(129, 6)
        Me.txtMD5Hash.Name = "txtMD5Hash"
        Me.txtMD5Hash.Size = New System.Drawing.Size(233, 22)
        Me.txtMD5Hash.TabIndex = 0
        '
        'btnPaste
        '
        Me.btnPaste.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.copy19
        Me.btnPaste.Location = New System.Drawing.Point(368, 6)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(19, 19)
        Me.btnPaste.TabIndex = 6
        Me.btnPaste.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 30)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "尚未驗證"
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(358, 261)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 10
        Me.btnAbout.Text = "關於(&A)"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.question
        Me.PictureBox1.Location = New System.Drawing.Point(14, 234)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnCpoyMD5
        '
        Me.btnCpoyMD5.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.copy
        Me.btnCpoyMD5.Location = New System.Drawing.Point(405, 52)
        Me.btnCpoyMD5.Name = "btnCpoyMD5"
        Me.btnCpoyMD5.Size = New System.Drawing.Size(28, 28)
        Me.btnCpoyMD5.TabIndex = 5
        Me.btnCpoyMD5.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.Hasher64
        Me.PictureBox2.Location = New System.Drawing.Point(369, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 296)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCpoyMD5)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblmd5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "MD5Hasher"
        Me.GroupBox1.ResumeLayout(False)
        Me.tabCheck.ResumeLayout(False)
        Me.tabFromFile.ResumeLayout(False)
        Me.tabFromFile.PerformLayout()
        Me.tabFromText.ResumeLayout(False)
        Me.tabFromText.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents lblmd5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPath As System.Windows.Forms.Label
    Friend WithEvents btnCpoyMD5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tabCheck As System.Windows.Forms.TabControl
    Friend WithEvents tabFromFile As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMD5Sec As System.Windows.Forms.Label
    Friend WithEvents lblPathSec As System.Windows.Forms.Label
    Friend WithEvents btnCheckFileSec As System.Windows.Forms.Button
    Friend WithEvents tabFromText As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnPaste As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMD5Hash As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
