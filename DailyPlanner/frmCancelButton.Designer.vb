<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelButton
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCancelButton))
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.lblCancelMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(89, 255)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 48)
        Me.btnYes.TabIndex = 0
        Me.btnYes.Text = "YES"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(230, 255)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 48)
        Me.btnNo.TabIndex = 1
        Me.btnNo.Text = "NO"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'lblCancelMessage
        '
        Me.lblCancelMessage.AutoSize = True
        Me.lblCancelMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelMessage.Location = New System.Drawing.Point(70, 126)
        Me.lblCancelMessage.Name = "lblCancelMessage"
        Me.lblCancelMessage.Size = New System.Drawing.Size(264, 25)
        Me.lblCancelMessage.TabIndex = 2
        Me.lblCancelMessage.Text = "Do you want to close the file?"
        '
        'frmCancelButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 353)
        Me.Controls.Add(Me.lblCancelMessage)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCancelButton"
        Me.Text = "Are You Sure?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents lblCancelMessage As Label
End Class
