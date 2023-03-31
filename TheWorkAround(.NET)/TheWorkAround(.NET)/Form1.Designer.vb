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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnrun = New System.Windows.Forms.Button()
        Me.btnCloase = New System.Windows.Forms.Button()
        Me.cmbInput = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoClearOnOutputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayInCmdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.WillUpdataLaterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome to The Workarounf(.NET)"
        '
        'btnrun
        '
        Me.btnrun.Location = New System.Drawing.Point(397, 58)
        Me.btnrun.Name = "btnrun"
        Me.btnrun.Size = New System.Drawing.Size(75, 23)
        Me.btnrun.TabIndex = 2
        Me.btnrun.Text = "Run"
        Me.btnrun.UseVisualStyleBackColor = True
        '
        'btnCloase
        '
        Me.btnCloase.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCloase.Location = New System.Drawing.Point(3, 87)
        Me.btnCloase.Name = "btnCloase"
        Me.btnCloase.Size = New System.Drawing.Size(75, 23)
        Me.btnCloase.TabIndex = 3
        Me.btnCloase.Text = "Close"
        Me.btnCloase.UseVisualStyleBackColor = True
        '
        'cmbInput
        '
        Me.cmbInput.FormattingEnabled = True
        Me.cmbInput.Location = New System.Drawing.Point(3, 60)
        Me.cmbInput.Name = "cmbInput"
        Me.cmbInput.Size = New System.Drawing.Size(388, 21)
        Me.cmbInput.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WillUpdataLaterToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoClearOnOutputToolStripMenuItem, Me.DisplayInCmdToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'AutoClearOnOutputToolStripMenuItem
        '
        Me.AutoClearOnOutputToolStripMenuItem.Checked = True
        Me.AutoClearOnOutputToolStripMenuItem.CheckOnClick = True
        Me.AutoClearOnOutputToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoClearOnOutputToolStripMenuItem.Name = "AutoClearOnOutputToolStripMenuItem"
        Me.AutoClearOnOutputToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.AutoClearOnOutputToolStripMenuItem.Text = "Auto Clear on Output"
        '
        'DisplayInCmdToolStripMenuItem
        '
        Me.DisplayInCmdToolStripMenuItem.CheckOnClick = True
        Me.DisplayInCmdToolStripMenuItem.Name = "DisplayInCmdToolStripMenuItem"
        Me.DisplayInCmdToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.DisplayInCmdToolStripMenuItem.Text = "Display in cmd"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'WillUpdataLaterToolStripMenuItem
        '
        Me.WillUpdataLaterToolStripMenuItem.Name = "WillUpdataLaterToolStripMenuItem"
        Me.WillUpdataLaterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WillUpdataLaterToolStripMenuItem.Text = "will update later"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnrun
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.btnCloase
        Me.ClientSize = New System.Drawing.Size(484, 116)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbInput)
        Me.Controls.Add(Me.btnCloase)
        Me.Controls.Add(Me.btnrun)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "The Work Around(.NET)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnrun As Button
    Friend WithEvents btnCloase As Button
    Friend WithEvents cmbInput As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents AutoClearOnOutputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayInCmdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WillUpdataLaterToolStripMenuItem As ToolStripMenuItem
End Class
