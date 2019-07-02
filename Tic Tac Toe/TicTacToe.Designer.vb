<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicTacToe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicTacToe))
        Me.B1 = New System.Windows.Forms.Button()
        Me.A3 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.A2 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.C2 = New System.Windows.Forms.Button()
        Me.C1 = New System.Windows.Forms.Button()
        Me.C3 = New System.Windows.Forms.Button()
        Me.A1 = New System.Windows.Forms.Button()
        Me.fileStrip = New System.Windows.Forms.MenuStrip()
        Me.FilrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.fileStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'B1
        '
        Me.B1.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.B1, "B1")
        Me.B1.Name = "B1"
        Me.B1.UseVisualStyleBackColor = False
        '
        'A3
        '
        Me.A3.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.A3, "A3")
        Me.A3.Name = "A3"
        Me.A3.UseVisualStyleBackColor = False
        '
        'B2
        '
        Me.B2.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.B2, "B2")
        Me.B2.Name = "B2"
        Me.B2.UseVisualStyleBackColor = False
        '
        'A2
        '
        Me.A2.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.A2, "A2")
        Me.A2.Name = "A2"
        Me.A2.UseVisualStyleBackColor = False
        '
        'B3
        '
        Me.B3.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.B3, "B3")
        Me.B3.Name = "B3"
        Me.B3.UseVisualStyleBackColor = False
        '
        'C2
        '
        Me.C2.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.C2, "C2")
        Me.C2.Name = "C2"
        Me.C2.UseVisualStyleBackColor = False
        '
        'C1
        '
        Me.C1.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.C1, "C1")
        Me.C1.Name = "C1"
        Me.C1.UseVisualStyleBackColor = False
        '
        'C3
        '
        Me.C3.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.C3, "C3")
        Me.C3.Name = "C3"
        Me.C3.UseVisualStyleBackColor = False
        '
        'A1
        '
        Me.A1.BackColor = System.Drawing.Color.LightSteelBlue
        resources.ApplyResources(Me.A1, "A1")
        Me.A1.Name = "A1"
        Me.A1.UseVisualStyleBackColor = False
        '
        'fileStrip
        '
        Me.fileStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilrToolStripMenuItem})
        resources.ApplyResources(Me.fileStrip, "fileStrip")
        Me.fileStrip.Name = "fileStrip"
        '
        'FilrToolStripMenuItem
        '
        Me.FilrToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.CloseToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.FilrToolStripMenuItem.Name = "FilrToolStripMenuItem"
        resources.ApplyResources(Me.FilrToolStripMenuItem, "FilrToolStripMenuItem")
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        resources.ApplyResources(Me.NewGameToolStripMenuItem, "NewGameToolStripMenuItem")
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        resources.ApplyResources(Me.CloseToolStripMenuItem, "CloseToolStripMenuItem")
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        '
        'TicTacToe
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.C3)
        Me.Controls.Add(Me.A1)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.A2)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.A3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.fileStrip)
        Me.MainMenuStrip = Me.fileStrip
        Me.Name = "TicTacToe"
        Me.ShowIcon = False
        Me.fileStrip.ResumeLayout(False)
        Me.fileStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B1 As Button
    Friend WithEvents A3 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents A2 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents C2 As Button
    Friend WithEvents C1 As Button
    Friend WithEvents C3 As Button
    Friend WithEvents A1 As Button
    Friend WithEvents fileStrip As MenuStrip
    Friend WithEvents FilrToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
