<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        cbMute = New CheckBox()
        SuspendLayout()
        '
        'cbMute
        '
        Me.cbMute.Checked = Global.StudyX.My.MySettings.Default.Mute
        Me.cbMute.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.StudyX.My.MySettings.Default, "Mute", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbMute.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMute.Location = New System.Drawing.Point(1, 229)
        Me.cbMute.Name = "cbMute"
        Me.cbMute.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbMute.Size = New System.Drawing.Size(97, 17)
        Me.cbMute.TabIndex = 34
        Me.cbMute.Text = "Mute Sounds"
        Me.cbMute.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cbMute)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbMute As CheckBox
End Class
