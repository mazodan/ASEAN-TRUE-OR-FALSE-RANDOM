﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Result
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
        Me.lblRes = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtScore = New System.Windows.Forms.TextBox
        Me.btnAgain = New System.Windows.Forms.Button
        Me.btnMainMenu = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRes
        '
        Me.lblRes.AutoSize = True
        Me.lblRes.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRes.ForeColor = System.Drawing.Color.Gold
        Me.lblRes.Location = New System.Drawing.Point(229, 12)
        Me.lblRes.Name = "lblRes"
        Me.lblRes.Size = New System.Drawing.Size(301, 30)
        Me.lblRes.TabIndex = 14
        Me.lblRes.Text = "SORRY, YOU LOST THIS QUIZ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(229, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 30)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "YOUR SCORE: "
        '
        'txtScore
        '
        Me.txtScore.BackColor = System.Drawing.Color.Black
        Me.txtScore.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.ForeColor = System.Drawing.Color.LawnGreen
        Me.txtScore.Location = New System.Drawing.Point(389, 49)
        Me.txtScore.Multiline = True
        Me.txtScore.Name = "txtScore"
        Me.txtScore.ReadOnly = True
        Me.txtScore.Size = New System.Drawing.Size(57, 40)
        Me.txtScore.TabIndex = 16
        Me.txtScore.TabStop = False
        Me.txtScore.Text = "10"
        '
        'btnAgain
        '
        Me.btnAgain.BackColor = System.Drawing.Color.Lime
        Me.btnAgain.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgain.ForeColor = System.Drawing.Color.Snow
        Me.btnAgain.Location = New System.Drawing.Point(234, 133)
        Me.btnAgain.Name = "btnAgain"
        Me.btnAgain.Size = New System.Drawing.Size(123, 67)
        Me.btnAgain.TabIndex = 17
        Me.btnAgain.Text = "PLAY AGAIN"
        Me.btnAgain.UseVisualStyleBackColor = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.Lime
        Me.btnMainMenu.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.ForeColor = System.Drawing.Color.Snow
        Me.btnMainMenu.Location = New System.Drawing.Point(363, 133)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(120, 67)
        Me.btnMainMenu.TabIndex = 18
        Me.btnMainMenu.Text = "MAIN MENU"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Lime
        Me.btnExit.Font = New System.Drawing.Font("Lucida Console", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Snow
        Me.btnExit.Location = New System.Drawing.Point(489, 133)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 67)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ASEAN_TF.My.Resources.Resources.asean_summit
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 213)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(670, 237)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnAgain)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRes)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Result"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Result"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRes As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents btnAgain As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
