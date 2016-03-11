<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainGame
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
        Me.components = New System.ComponentModel.Container
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblLife = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblPass = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtScore = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTimeLeft = New System.Windows.Forms.TextBox
        Me.pbarTime = New System.Windows.Forms.ProgressBar
        Me.Qtimer = New System.Windows.Forms.Timer(Me.components)
        Me.txtQuestion = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnTrue = New System.Windows.Forms.Button
        Me.btnFalse = New System.Windows.Forms.Button
        Me.stBtnR = New System.Windows.Forms.Button
        Me.lblQuestionNumber = New System.Windows.Forms.Label
        Me.btnPass = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(81, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "LIVES"
        '
        'lblLife
        '
        Me.lblLife.AutoSize = True
        Me.lblLife.BackColor = System.Drawing.Color.Gold
        Me.lblLife.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLife.ForeColor = System.Drawing.Color.Red
        Me.lblLife.Location = New System.Drawing.Point(155, 13)
        Me.lblLife.Name = "lblLife"
        Me.lblLife.Size = New System.Drawing.Size(66, 26)
        Me.lblLife.TabIndex = 4
        Me.lblLife.Text = "❤❤❤"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(237, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PASS LEFT"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.Color.Gold
        Me.lblPass.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.Red
        Me.lblPass.Location = New System.Drawing.Point(358, 13)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(40, 26)
        Me.lblPass.TabIndex = 6
        Me.lblPass.Text = "✓✓"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(404, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 30)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SCORE"
        '
        'txtScore
        '
        Me.txtScore.BackColor = System.Drawing.Color.Black
        Me.txtScore.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.ForeColor = System.Drawing.Color.LawnGreen
        Me.txtScore.Location = New System.Drawing.Point(489, 13)
        Me.txtScore.Multiline = True
        Me.txtScore.Name = "txtScore"
        Me.txtScore.ReadOnly = True
        Me.txtScore.Size = New System.Drawing.Size(40, 26)
        Me.txtScore.TabIndex = 8
        Me.txtScore.TabStop = False
        Me.txtScore.Text = "99"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(197, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 30)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "TIME LEFT"
        '
        'txtTimeLeft
        '
        Me.txtTimeLeft.BackColor = System.Drawing.Color.Black
        Me.txtTimeLeft.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeLeft.ForeColor = System.Drawing.Color.LawnGreen
        Me.txtTimeLeft.Location = New System.Drawing.Point(317, 66)
        Me.txtTimeLeft.Multiline = True
        Me.txtTimeLeft.Name = "txtTimeLeft"
        Me.txtTimeLeft.ReadOnly = True
        Me.txtTimeLeft.Size = New System.Drawing.Size(98, 40)
        Me.txtTimeLeft.TabIndex = 10
        Me.txtTimeLeft.TabStop = False
        Me.txtTimeLeft.Text = "10"
        '
        'pbarTime
        '
        Me.pbarTime.Location = New System.Drawing.Point(12, 112)
        Me.pbarTime.Maximum = 10
        Me.pbarTime.Name = "pbarTime"
        Me.pbarTime.Size = New System.Drawing.Size(588, 23)
        Me.pbarTime.TabIndex = 11
        Me.pbarTime.Value = 10
        '
        'Qtimer
        '
        Me.Qtimer.Interval = 10
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtQuestion.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.ForeColor = System.Drawing.Color.Yellow
        Me.txtQuestion.Location = New System.Drawing.Point(12, 171)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.ReadOnly = True
        Me.txtQuestion.Size = New System.Drawing.Size(588, 67)
        Me.txtQuestion.TabIndex = 12
        Me.txtQuestion.TabStop = False
        Me.txtQuestion.Text = "Accountants in the Philippines who are ASEAN certified can work in any ASEAN memb" & _
            "er states"
        Me.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(197, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 30)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "QUESTION"
        '
        'btnTrue
        '
        Me.btnTrue.BackColor = System.Drawing.Color.Lime
        Me.btnTrue.Font = New System.Drawing.Font("Lucida Console", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrue.ForeColor = System.Drawing.Color.Snow
        Me.btnTrue.Location = New System.Drawing.Point(49, 244)
        Me.btnTrue.Name = "btnTrue"
        Me.btnTrue.Size = New System.Drawing.Size(221, 104)
        Me.btnTrue.TabIndex = 14
        Me.btnTrue.Text = "TRUE"
        Me.btnTrue.UseVisualStyleBackColor = False
        '
        'btnFalse
        '
        Me.btnFalse.BackColor = System.Drawing.Color.Firebrick
        Me.btnFalse.Font = New System.Drawing.Font("Lucida Console", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFalse.ForeColor = System.Drawing.SystemColors.Info
        Me.btnFalse.Location = New System.Drawing.Point(332, 244)
        Me.btnFalse.Name = "btnFalse"
        Me.btnFalse.Size = New System.Drawing.Size(221, 104)
        Me.btnFalse.TabIndex = 15
        Me.btnFalse.Text = "FALSE"
        Me.btnFalse.UseVisualStyleBackColor = False
        '
        'stBtnR
        '
        Me.stBtnR.Location = New System.Drawing.Point(49, 66)
        Me.stBtnR.Name = "stBtnR"
        Me.stBtnR.Size = New System.Drawing.Size(117, 23)
        Me.stBtnR.TabIndex = 16
        Me.stBtnR.Text = "RandomTest"
        Me.stBtnR.UseVisualStyleBackColor = True
        '
        'lblQuestionNumber
        '
        Me.lblQuestionNumber.AutoSize = True
        Me.lblQuestionNumber.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNumber.ForeColor = System.Drawing.Color.Gold
        Me.lblQuestionNumber.Location = New System.Drawing.Point(322, 138)
        Me.lblQuestionNumber.Name = "lblQuestionNumber"
        Me.lblQuestionNumber.Size = New System.Drawing.Size(25, 30)
        Me.lblQuestionNumber.TabIndex = 17
        Me.lblQuestionNumber.Text = "1"
        '
        'btnPass
        '
        Me.btnPass.BackColor = System.Drawing.Color.Lime
        Me.btnPass.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPass.ForeColor = System.Drawing.Color.Snow
        Me.btnPass.Location = New System.Drawing.Point(533, 63)
        Me.btnPass.Name = "btnPass"
        Me.btnPass.Size = New System.Drawing.Size(67, 36)
        Me.btnPass.TabIndex = 18
        Me.btnPass.Text = "PASS"
        Me.btnPass.UseVisualStyleBackColor = False
        '
        'MainGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(612, 360)
        Me.Controls.Add(Me.btnPass)
        Me.Controls.Add(Me.lblQuestionNumber)
        Me.Controls.Add(Me.stBtnR)
        Me.Controls.Add(Me.btnFalse)
        Me.Controls.Add(Me.btnTrue)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.pbarTime)
        Me.Controls.Add(Me.txtTimeLeft)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLife)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainGame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblLife As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTimeLeft As System.Windows.Forms.TextBox
    Friend WithEvents pbarTime As System.Windows.Forms.ProgressBar
    Friend WithEvents Qtimer As System.Windows.Forms.Timer
    Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnTrue As System.Windows.Forms.Button
    Friend WithEvents btnFalse As System.Windows.Forms.Button
    Friend WithEvents stBtnR As System.Windows.Forms.Button
    Friend WithEvents lblQuestionNumber As System.Windows.Forms.Label
    Friend WithEvents btnPass As System.Windows.Forms.Button
End Class
