<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLicense
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
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnDeclined = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAccept
        '
        Me.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAccept.Location = New System.Drawing.Point(80, 290)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(83, 23)
        Me.btnAccept.TabIndex = 0
        Me.btnAccept.Text = "我同意(&A)"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnDeclined
        '
        Me.btnDeclined.Location = New System.Drawing.Point(169, 290)
        Me.btnDeclined.Name = "btnDeclined"
        Me.btnDeclined.Size = New System.Drawing.Size(83, 23)
        Me.btnDeclined.TabIndex = 1
        Me.btnDeclined.Text = "我拒絕(&D)"
        Me.btnDeclined.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 25)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(307, 259)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "請詳細閱讀以下條款："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLicense
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(331, 325)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnDeclined)
        Me.Controls.Add(Me.btnAccept)
        Me.Name = "frmLicense"
        Me.Text = "GNU License v3.0"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents btnDeclined As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
