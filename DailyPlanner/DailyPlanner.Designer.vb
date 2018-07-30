<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyPlanner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDailyPlanner))
        Me.lblFiles = New System.Windows.Forms.Label()
        Me.lstTaskFiles = New System.Windows.Forms.ListBox()
        Me.btnCreateFile = New System.Windows.Forms.Button()
        Me.btnPrintFile = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.dlgOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.printFileDialog = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'lblFiles
        '
        Me.lblFiles.AutoSize = True
        Me.lblFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiles.Location = New System.Drawing.Point(43, 35)
        Me.lblFiles.Name = "lblFiles"
        Me.lblFiles.Size = New System.Drawing.Size(53, 22)
        Me.lblFiles.TabIndex = 0
        Me.lblFiles.Text = "Files:"
        '
        'lstTaskFiles
        '
        Me.lstTaskFiles.FormattingEnabled = True
        Me.lstTaskFiles.ItemHeight = 22
        Me.lstTaskFiles.Location = New System.Drawing.Point(47, 60)
        Me.lstTaskFiles.Name = "lstTaskFiles"
        Me.lstTaskFiles.Size = New System.Drawing.Size(514, 224)
        Me.lstTaskFiles.TabIndex = 1
        '
        'btnCreateFile
        '
        Me.btnCreateFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateFile.Location = New System.Drawing.Point(47, 312)
        Me.btnCreateFile.Name = "btnCreateFile"
        Me.btnCreateFile.Size = New System.Drawing.Size(124, 44)
        Me.btnCreateFile.TabIndex = 2
        Me.btnCreateFile.Text = "Create File"
        Me.btnCreateFile.UseVisualStyleBackColor = True
        '
        'btnPrintFile
        '
        Me.btnPrintFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintFile.Location = New System.Drawing.Point(307, 312)
        Me.btnPrintFile.Name = "btnPrintFile"
        Me.btnPrintFile.Size = New System.Drawing.Size(124, 44)
        Me.btnPrintFile.TabIndex = 4
        Me.btnPrintFile.Text = "Print File"
        Me.btnPrintFile.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(437, 312)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 44)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFile.Location = New System.Drawing.Point(177, 312)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(124, 44)
        Me.btnOpenFile.TabIndex = 3
        Me.btnOpenFile.Text = "Open File"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(43, 392)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(96, 22)
        Me.lblFileName.TabIndex = 6
        Me.lblFileName.Text = "File Name:"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(145, 389)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(416, 28)
        Me.txtFileName.TabIndex = 6
        '
        'printFileDialog
        '
        Me.printFileDialog.UseEXDialog = True
        '
        'frmDailyPlanner
        '
        Me.AcceptButton = Me.btnCreateFile
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(617, 458)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrintFile)
        Me.Controls.Add(Me.btnCreateFile)
        Me.Controls.Add(Me.lstTaskFiles)
        Me.Controls.Add(Me.lblFiles)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDailyPlanner"
        Me.Text = "Daily Planner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFiles As Label
    Friend WithEvents lstTaskFiles As ListBox
    Friend WithEvents btnCreateFile As Button
    Friend WithEvents btnPrintFile As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents lblFileName As Label
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents dlgOpenFileDialog As OpenFileDialog
    Friend WithEvents printFileDialog As PrintDialog
End Class
