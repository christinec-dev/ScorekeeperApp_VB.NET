<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IdTxt = New System.Windows.Forms.TextBox()
        Me.LSTTxtBx = New System.Windows.Forms.TextBox()
        Me.HSTTxtBx = New System.Windows.Forms.TextBox()
        Me.AvgTxtBx = New System.Windows.Forms.TextBox()
        Me.ScoreTxt = New System.Windows.Forms.TextBox()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.listBox2 = New System.Windows.Forms.ListBox()
        Me.CompBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.AddIdBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.AddScoreBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sample ID (012-345)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(381, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sample Score (50) 0-100"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(287, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Average Score"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(292, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Highest Score"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(292, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Lowest Score"
        '
        'IdTxt
        '
        Me.IdTxt.Location = New System.Drawing.Point(88, 63)
        Me.IdTxt.Name = "IdTxt"
        Me.IdTxt.Size = New System.Drawing.Size(234, 22)
        Me.IdTxt.TabIndex = 5
        '
        'LSTTxtBx
        '
        Me.LSTTxtBx.Location = New System.Drawing.Point(408, 323)
        Me.LSTTxtBx.Name = "LSTTxtBx"
        Me.LSTTxtBx.Size = New System.Drawing.Size(203, 22)
        Me.LSTTxtBx.TabIndex = 6
        '
        'HSTTxtBx
        '
        Me.HSTTxtBx.Location = New System.Drawing.Point(408, 295)
        Me.HSTTxtBx.Name = "HSTTxtBx"
        Me.HSTTxtBx.Size = New System.Drawing.Size(203, 22)
        Me.HSTTxtBx.TabIndex = 7
        '
        'AvgTxtBx
        '
        Me.AvgTxtBx.Location = New System.Drawing.Point(408, 267)
        Me.AvgTxtBx.Name = "AvgTxtBx"
        Me.AvgTxtBx.Size = New System.Drawing.Size(203, 22)
        Me.AvgTxtBx.TabIndex = 8
        '
        'ScoreTxt
        '
        Me.ScoreTxt.Location = New System.Drawing.Point(384, 63)
        Me.ScoreTxt.Name = "ScoreTxt"
        Me.ScoreTxt.Size = New System.Drawing.Size(227, 22)
        Me.ScoreTxt.TabIndex = 9
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 16
        Me.listBox1.Location = New System.Drawing.Point(88, 124)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(234, 132)
        Me.listBox1.TabIndex = 10
        '
        'listBox2
        '
        Me.listBox2.FormattingEnabled = True
        Me.listBox2.ItemHeight = 16
        Me.listBox2.Location = New System.Drawing.Point(384, 124)
        Me.listBox2.Name = "listBox2"
        Me.listBox2.Size = New System.Drawing.Size(227, 132)
        Me.listBox2.TabIndex = 11
        '
        'CompBtn
        '
        Me.CompBtn.Location = New System.Drawing.Point(88, 262)
        Me.CompBtn.Name = "CompBtn"
        Me.CompBtn.Size = New System.Drawing.Size(193, 83)
        Me.CompBtn.TabIndex = 12
        Me.CompBtn.Text = "Computation"
        Me.CompBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(164, 391)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(158, 27)
        Me.ClearBtn.TabIndex = 13
        Me.ClearBtn.Text = "CLEAR"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'AddIdBtn
        '
        Me.AddIdBtn.Location = New System.Drawing.Point(88, 91)
        Me.AddIdBtn.Name = "AddIdBtn"
        Me.AddIdBtn.Size = New System.Drawing.Size(234, 27)
        Me.AddIdBtn.TabIndex = 14
        Me.AddIdBtn.Text = "ADD ID"
        Me.AddIdBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(384, 391)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(158, 27)
        Me.ExitBtn.TabIndex = 15
        Me.ExitBtn.Text = "EXIT"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'AddScoreBtn
        '
        Me.AddScoreBtn.Location = New System.Drawing.Point(384, 91)
        Me.AddScoreBtn.Name = "AddScoreBtn"
        Me.AddScoreBtn.Size = New System.Drawing.Size(227, 27)
        Me.AddScoreBtn.TabIndex = 16
        Me.AddScoreBtn.Text = "ADD SCORE"
        Me.AddScoreBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AddScoreBtn)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.AddIdBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.CompBtn)
        Me.Controls.Add(Me.listBox2)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.ScoreTxt)
        Me.Controls.Add(Me.AvgTxtBx)
        Me.Controls.Add(Me.HSTTxtBx)
        Me.Controls.Add(Me.LSTTxtBx)
        Me.Controls.Add(Me.IdTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents IdTxt As TextBox
    Friend WithEvents LSTTxtBx As TextBox
    Friend WithEvents HSTTxtBx As TextBox
    Friend WithEvents AvgTxtBx As TextBox
    Friend WithEvents ScoreTxt As TextBox
    Friend WithEvents listBox1 As ListBox
    Friend WithEvents listBox2 As ListBox
    Friend WithEvents CompBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents AddIdBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents AddScoreBtn As Button
End Class
