<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EtchASketch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.DrawWaveformsButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DrawBox = New System.Windows.Forms.PictureBox()
        Me.OptionsMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DrawBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OptionsMenuStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SelectColorButton.Location = New System.Drawing.Point(12, 362)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(180, 76)
        Me.SelectColorButton.TabIndex = 0
        Me.SelectColorButton.Text = "Select Color"
        Me.ToolTip1.SetToolTip(Me.SelectColorButton, "Select a color for your pen.")
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'DrawWaveformsButton
        '
        Me.DrawWaveformsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DrawWaveformsButton.Location = New System.Drawing.Point(198, 362)
        Me.DrawWaveformsButton.Name = "DrawWaveformsButton"
        Me.DrawWaveformsButton.Size = New System.Drawing.Size(180, 76)
        Me.DrawWaveformsButton.TabIndex = 1
        Me.DrawWaveformsButton.Text = "Draw Waveforms"
        Me.ToolTip1.SetToolTip(Me.DrawWaveformsButton, "Draws a few waveforms on a grid.")
        Me.DrawWaveformsButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ClearButton.Location = New System.Drawing.Point(384, 362)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(180, 76)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Shakes the form to erase the drawing.")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(570, 362)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(180, 76)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Leave the program.")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DrawBox
        '
        Me.DrawBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawBox.ContextMenuStrip = Me.OptionsMenuStrip
        Me.DrawBox.Location = New System.Drawing.Point(12, 31)
        Me.DrawBox.Name = "DrawBox"
        Me.DrawBox.Size = New System.Drawing.Size(738, 325)
        Me.DrawBox.TabIndex = 4
        Me.DrawBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.DrawBox, "Insert your drawings here")
        '
        'OptionsMenuStrip
        '
        Me.OptionsMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.OptionsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.OptionsMenuStrip.Name = "ContextMenuStrip1"
        Me.OptionsMenuStrip.Size = New System.Drawing.Size(111, 76)
        Me.OptionsMenuStrip.Text = "Options"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitMenuItem
        '
        Me.ExitMenuItem.Name = "ExitMenuItem"
        Me.ExitMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.ExitMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorMenuItem, Me.DrawWaveformsMenuItem, Me.ClearMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SelectColorMenuItem
        '
        Me.SelectColorMenuItem.Name = "SelectColorMenuItem"
        Me.SelectColorMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.SelectColorMenuItem.Text = "Select Color"
        '
        'DrawWaveformsMenuItem
        '
        Me.DrawWaveformsMenuItem.Name = "DrawWaveformsMenuItem"
        Me.DrawWaveformsMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.DrawWaveformsMenuItem.Text = "Draw Waveforms"
        '
        'ClearMenuItem
        '
        Me.ClearMenuItem.Name = "ClearMenuItem"
        Me.ClearMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.ClearMenuItem.Text = "Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.EditToolStripMenuItem1, Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(764, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitMenuItem1})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'ExitMenuItem1
        '
        Me.ExitMenuItem1.Name = "ExitMenuItem1"
        Me.ExitMenuItem1.Size = New System.Drawing.Size(116, 26)
        Me.ExitMenuItem1.Text = "Exit"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorMenuItem1, Me.DrawWaveformsMenuItem1, Me.ClearMenuItem1})
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'SelectColorMenuItem1
        '
        Me.SelectColorMenuItem1.Name = "SelectColorMenuItem1"
        Me.SelectColorMenuItem1.Size = New System.Drawing.Size(205, 26)
        Me.SelectColorMenuItem1.Text = "Select Color"
        '
        'DrawWaveformsMenuItem1
        '
        Me.DrawWaveformsMenuItem1.Name = "DrawWaveformsMenuItem1"
        Me.DrawWaveformsMenuItem1.Size = New System.Drawing.Size(205, 26)
        Me.DrawWaveformsMenuItem1.Text = "Draw Waveforms"
        '
        'ClearMenuItem1
        '
        Me.ClearMenuItem1.Name = "ClearMenuItem1"
        Me.ClearMenuItem1.Size = New System.Drawing.Size(205, 26)
        Me.ClearMenuItem1.Text = "Clear"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'EtchASketch
        '
        Me.AcceptButton = Me.DrawWaveformsButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(764, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DrawBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DrawWaveformsButton)
        Me.Controls.Add(Me.SelectColorButton)
        Me.Name = "EtchASketch"
        Me.Text = "Etch-a-sketch"
        CType(Me.DrawBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OptionsMenuStrip.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SelectColorButton As Button
    Friend WithEvents DrawWaveformsButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DrawBox As PictureBox
    Friend WithEvents OptionsMenuStrip As ContextMenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsMenuItem As ToolStripMenuItem
    Friend WithEvents ClearMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SelectColorMenuItem1 As ToolStripMenuItem
    Friend WithEvents DrawWaveformsMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClearMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ToolTip1 As ToolTip
End Class
