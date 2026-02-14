<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        cmdIRTEN = New Button()
        cmdEZABATU = New Button()
        cmdAGURTU = New Button()
        lblAgurtu = New Label()
        SuspendLayout()
        ' 
        ' cmdIRTEN
        ' 
        cmdIRTEN.BackColor = Color.DarkTurquoise
        cmdIRTEN.ForeColor = Color.Coral
        cmdIRTEN.Location = New Point(577, 318)
        cmdIRTEN.Name = "cmdIRTEN"
        cmdIRTEN.Size = New Size(94, 29)
        cmdIRTEN.TabIndex = 0
        cmdIRTEN.Text = "IRTEN"
        cmdIRTEN.UseVisualStyleBackColor = False
        ' 
        ' cmdEZABATU
        ' 
        cmdEZABATU.BackColor = Color.DarkTurquoise
        cmdEZABATU.ForeColor = Color.Coral
        cmdEZABATU.Location = New Point(374, 318)
        cmdEZABATU.Name = "cmdEZABATU"
        cmdEZABATU.Size = New Size(94, 29)
        cmdEZABATU.TabIndex = 1
        cmdEZABATU.Text = "EZABATU"
        cmdEZABATU.UseVisualStyleBackColor = False
        ' 
        ' cmdAGURTU
        ' 
        cmdAGURTU.BackColor = Color.DarkTurquoise
        cmdAGURTU.ForeColor = Color.DarkOrange
        cmdAGURTU.Location = New Point(170, 318)
        cmdAGURTU.Name = "cmdAGURTU"
        cmdAGURTU.Size = New Size(94, 29)
        cmdAGURTU.TabIndex = 2
        cmdAGURTU.Text = "AGURTU"
        cmdAGURTU.UseVisualStyleBackColor = False
        ' 
        ' lblAgurtu
        ' 
        lblAgurtu.AutoSize = True
        lblAgurtu.Font = New Font("Segoe UI", 67F)
        lblAgurtu.ForeColor = Color.Coral
        lblAgurtu.Location = New Point(296, 104)
        lblAgurtu.Name = "lblAgurtu"
        lblAgurtu.Size = New Size(243, 149)
        lblAgurtu.TabIndex = 3
        lblAgurtu.Text = "----"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkCyan
        ClientSize = New Size(800, 450)
        Controls.Add(lblAgurtu)
        Controls.Add(cmdAGURTU)
        Controls.Add(cmdEZABATU)
        Controls.Add(cmdIRTEN)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdIRTEN As Button
    Friend WithEvents cmdEZABATU As Button
    Friend WithEvents cmdAGURTU As Button
    Friend WithEvents lblAgurtu As Label

End Class
