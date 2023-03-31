Imports System.Runtime.InteropServices.WindowsRuntime

Partial Public Class Form1
    Private Sub btnrun_Click_1(sender As Object, e As EventArgs) Handles btnrun.Click
        Call command(cmbInput.Text)
    End Sub

    Private Sub btnCloase_Click(sender As Object, e As EventArgs) Handles btnCloase.Click
        Dim RetVal As Integer
        RetVal = MsgBox("Do you Really wish to exit?", MsgBoxStyle.YesNo, "Close Message")
        Select Case RetVal
            Case 6
                ' Yes = 6 button clicked
                Me.Close()
            Case 7, 2
                ' No = 7 button clicked
                ' Cancel = 2 button clicked
                Exit Sub
            Case Else
                MsgBox("In case else - should not be here! Call programmer")
                Exit Sub
        End Select
    End Sub

    Private Sub WillUpdataLaterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WillUpdataLaterToolStripMenuItem.Click

    End Sub
End Class
