<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyPlannerDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDailyPlannerDetails))
        Me.lblTask = New System.Windows.Forms.Label()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.chkComplete = New System.Windows.Forms.CheckBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstTasks = New System.Windows.Forms.ListBox()
        Me.mskDate = New System.Windows.Forms.MaskedTextBox()
        Me.mskTime = New System.Windows.Forms.MaskedTextBox()
        Me.dlgColorDialog = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'lblTask
        '
        Me.lblTask.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTask.AutoSize = True
        Me.lblTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask.Location = New System.Drawing.Point(482, 15)
        Me.lblTask.Name = "lblTask"
        Me.lblTask.Size = New System.Drawing.Size(55, 22)
        Me.lblTask.TabIndex = 1
        Me.lblTask.Text = "Task:"
        '
        'txtTask
        '
        Me.txtTask.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTask.Location = New System.Drawing.Point(486, 38)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(182, 26)
        Me.txtTask.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(482, 76)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(53, 22)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date:"
        '
        'lblTime
        '
        Me.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(486, 141)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(136, 22)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "Time (HH : MM)"
        '
        'lblCategory
        '
        Me.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(486, 242)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(50)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(88, 22)
        Me.lblCategory.TabIndex = 7
        Me.lblCategory.Text = "Category:"
        '
        'chkComplete
        '
        Me.chkComplete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkComplete.AutoSize = True
        Me.chkComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkComplete.Location = New System.Drawing.Point(490, 210)
        Me.chkComplete.Margin = New System.Windows.Forms.Padding(50)
        Me.chkComplete.Name = "chkComplete"
        Me.chkComplete.Size = New System.Drawing.Size(122, 26)
        Me.chkComplete.TabIndex = 8
        Me.chkComplete.Text = "Complete?"
        Me.chkComplete.UseVisualStyleBackColor = True
        '
        'lblColor
        '
        Me.lblColor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(533, 272)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(71, 22)
        Me.lblColor.TabIndex = 10
        Me.lblColor.Text = "lblColor"
        '
        'btnColor
        '
        Me.btnColor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnColor.Location = New System.Drawing.Point(531, 305)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(106, 35)
        Me.btnColor.TabIndex = 11
        Me.btnColor.Text = "Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(486, 522)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(182, 45)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(486, 471)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(182, 45)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(486, 415)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(182, 45)
        Me.btnRemove.TabIndex = 14
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(486, 364)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(182, 45)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstTasks
        '
        Me.lstTasks.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstTasks.FormattingEnabled = True
        Me.lstTasks.HorizontalScrollbar = True
        Me.lstTasks.ItemHeight = 20
        Me.lstTasks.Location = New System.Drawing.Point(0, 0)
        Me.lstTasks.Name = "lstTasks"
        Me.lstTasks.Size = New System.Drawing.Size(437, 600)
        Me.lstTasks.TabIndex = 16
        '
        'mskDate
        '
        Me.mskDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mskDate.Location = New System.Drawing.Point(486, 100)
        Me.mskDate.Mask = "00/00/0000"
        Me.mskDate.Name = "mskDate"
        Me.mskDate.Size = New System.Drawing.Size(182, 26)
        Me.mskDate.TabIndex = 17
        Me.mskDate.ValidatingType = GetType(Date)
        '
        'mskTime
        '
        Me.mskTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mskTime.Location = New System.Drawing.Point(486, 163)
        Me.mskTime.Mask = "90:00"
        Me.mskTime.Name = "mskTime"
        Me.mskTime.Size = New System.Drawing.Size(182, 26)
        Me.mskTime.TabIndex = 18
        Me.mskTime.ValidatingType = GetType(Date)
        '
        'frmDailyPlannerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 600)
        Me.Controls.Add(Me.mskTime)
        Me.Controls.Add(Me.mskDate)
        Me.Controls.Add(Me.lstTasks)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.chkComplete)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.lblTask)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDailyPlannerDetails"
        Me.Text = "Daily Planner Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTask As Label
    Friend WithEvents txtTask As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents chkComplete As CheckBox
    Friend WithEvents lblColor As Label
    Friend WithEvents btnColor As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lstTasks As ListBox
    Friend WithEvents mskDate As MaskedTextBox
    Friend WithEvents mskTime As MaskedTextBox
    Friend WithEvents dlgColorDialog As ColorDialog
End Class
