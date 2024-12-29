<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonShuffleR = New System.Windows.Forms.Button()
        Me.ButtonShuffleL = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(31, 48)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(178, 49)
        Me.ButtonClear.TabIndex = 0
        Me.ButtonClear.Text = "Clear Track Button"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonShuffleR
        '
        Me.ButtonShuffleR.Location = New System.Drawing.Point(31, 114)
        Me.ButtonShuffleR.Name = "ButtonShuffleR"
        Me.ButtonShuffleR.Size = New System.Drawing.Size(178, 49)
        Me.ButtonShuffleR.TabIndex = 1
        Me.ButtonShuffleR.Text = "Shuffle Tracks Right"
        Me.ButtonShuffleR.UseVisualStyleBackColor = True
        '
        'ButtonShuffleL
        '
        Me.ButtonShuffleL.Location = New System.Drawing.Point(31, 180)
        Me.ButtonShuffleL.Name = "ButtonShuffleL"
        Me.ButtonShuffleL.Size = New System.Drawing.Size(178, 49)
        Me.ButtonShuffleL.TabIndex = 2
        Me.ButtonShuffleL.Text = "Shuffle Tracks Left"
        Me.ButtonShuffleL.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 241)
        Me.Controls.Add(Me.ButtonShuffleL)
        Me.Controls.Add(Me.ButtonShuffleR)
        Me.Controls.Add(Me.ButtonClear)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Button Action"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonShuffleR As Button
    Friend WithEvents ButtonShuffleL As Button
End Class
