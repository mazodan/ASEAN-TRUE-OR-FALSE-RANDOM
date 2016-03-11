Public Class MainGame



    Private Sub MainGame_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        TextBox3.Visible = False
        If MessageBox.Show("Are you sure you want to Quit this quiz", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            MainMenu.Show()

        Else
            e.Cancel = True
            TextBox3.Visible = True
        End If
    End Sub

End Class