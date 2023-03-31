Partial Class form1
    'runs cmd.exe and passes the user commandinput as a argument causing it to run the command and bypass the restrictions
    Dim output As String = ""
    Dim Showincmd As String = ""
    Sub command(ByVal cmd As String)

        Dim command As String = cmd
        If cmd = "" Then
            MsgBox("error please type in a valid command")
        End If
        If DisplayInCmdToolStripMenuItem.Checked = True Then
            Showincmd = "False"
        Else
            Showincmd = "True"
        End If
        If DisplayInCmdToolStripMenuItem.Checked = True Then
            Dim process As New Process() ' Defines a new process
            process.StartInfo.FileName = "cmd.exe" ' tells the computer what file we are going to run
            process.StartInfo.Arguments = "/c" + command + "&& pause" ' passes the command to the shell
            process.StartInfo.UseShellExecute = False
            process.StartInfo.RedirectStandardOutput = Showincmd
            process.Start() ' runs the shell with the commands
        Else
            Dim process As New Process() ' Defines a new process
            process.StartInfo.FileName = "cmd.exe" ' tells the computer what file we are going to run
            process.StartInfo.Arguments = "/c" + command ' passes the command to the shell
            process.StartInfo.UseShellExecute = False
            process.StartInfo.RedirectStandardOutput = Showincmd
            process.Start() ' runs the shell with the commands
            output = process.StandardOutput.ReadToEnd() ' saves the output as a string
            Dim CMDresult As New CMDresult
            Me.Hide()
            CMDresult.Show()
            CMDresult.txbOut.Text = output
        End If

        If AutoClearOnOutputToolStripMenuItem.Checked = True Then
            cmbInput.Text = ""
        End If
    End Sub
End Class