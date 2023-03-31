<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CMDresult
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
        Me.txbOut = New System.Windows.Forms.TextBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txbOut
        '
        Me.txbOut.Location = New System.Drawing.Point(12, 12)
        Me.txbOut.Multiline = True
        Me.txbOut.Name = "txbOut"
        Me.txbOut.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txbOut.Size = New System.Drawing.Size(776, 397)
        Me.txbOut.TabIndex = 0
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(12, 415)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(776, 23)
        Me.btnclose.TabIndex = 1
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'CMDresult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.txbOut)
        Me.Name = "CMDresult"
        Me.Text = "CMDresult"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbOut As TextBox
    Friend WithEvents btnclose As Button
End Class
