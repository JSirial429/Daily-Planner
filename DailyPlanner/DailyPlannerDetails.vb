' import libraries
Imports System.IO

'Affirmation of Authorship
'Name:Jorge Sirias
'Date : 6/10/2018
'I affirm that this program was created by Me. It Is solely my work And does Not include any work done by anyone Else.


Public Class frmDailyPlannerDetails

    'Class Var that hold string of color
    Dim strColor As String

    'creating list to hold data pulled from user input
    Dim lstThisTask As New List(Of dailyTasks)

    'Creating an instance of the data structure dailyTaska
    Dim theseTasks As dailyTasks

    Private Sub frmDailyPlannerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblColor.Text = String.Empty

        'Save and cancel buttons are disabled or enabled depending on whether or not a file has been created
        If blnCreateFileSelected = True And lstTasks.Items.Count > 0 Then

            btnSave.Enabled = True
            btnCancel.Enabled = True
            lstTasks.Items.Clear()
            txtTask.Text = String.Empty
            mskDate.Text = String.Empty
            mskTime.Text = String.Empty
            chkComplete.Checked = False
            lblColor.Text = String.Empty

        Else

            btnSave.Enabled = False
            btnCancel.Enabled = False

        End If

        ''------------------EXPERIMENTAL-------------------------
        'If blnOpenFileChosen = True Then

        '    'For Each fileOpenTasks As String In lstTasks.Items

        '    '    With theseTasks

        '    '        .strTaskName = txtTask.Text
        '    '        .dtTaskDate = CDate(mskDate.Text)
        '    '        .dtTaskTime = CDate(mskTime.Text)
        '    '        .blnComplete = CBool(chkComplete.Checked)
        '    '        .strTaskCategory = lblColor.Text

        '    '    End With

        '    'Next

        '    'Local Var to store substrings
        '    Dim strName, strDate, strTime, strColor, strChecked As String

        '    'Local Var that holds list item as string
        '    Dim strListItem, strListItemCopy As String

        '    'Local var that holds index of delimiter
        '    Dim intComma As Integer

        '    'local var that is used as a counter
        '    Dim intInnerCounter, intIterator As Integer

        '    For intOuterCounter = 0 To lstTasks.Items.Count - 1

        '        strListItem = CStr(lstTasks.SelectedItem(intOuterCounter))

        '        strListItemCopy = lstTasks.SelectedItem(intOuterCounter)

        '        Do Until intInnerCounter = 4

        '            If intInnerCounter = 0 Then

        '                intComma = strListItem.IndexOf(",")

        '                strListItemCopy = strListItem

        '                Dim NewSubString = strListItemCopy.Substring(0, intComma - 1)

        '                strListItem = strListItem.Substring(intComma + 1)

        '                theseTasks.strTaskName = NewSubString

        '            End If

        '            If intInnerCounter = 1 Then

        '                intComma = strListItem.IndexOf(",")

        '                strListItemCopy = strListItem

        '                Dim NewSubString = strListItemCopy.Substring(0, intComma - 1)

        '                strListItem = strListItem.Substring(intComma + 1)

        '                theseTasks.dtTaskDate = CDate(NewSubString)

        '            End If

        '            If intInnerCounter = 2 Then

        '                intComma = strListItem.IndexOf(",")

        '                strListItemCopy = strListItem

        '                Dim NewSubString = strListItemCopy.Substring(0, intComma - 1)

        '                strListItem = strListItem.Substring(intComma + 1)

        '                theseTasks.dtTaskTime = CDate(NewSubString)



        '            End If

        '            If intInnerCounter = 3 Then

        '                intComma = strListItem.IndexOf(",")

        '                strListItemCopy = strListItem

        '                Dim NewSubString = strListItemCopy.Substring(0, intComma - 1)

        '                strListItem = strListItem.Substring(intComma + 1)

        '                theseTasks.blnComplete = CBool(NewSubString)

        '            Else

        '                theseTasks.strTaskCategory = strListItem

        '            End If

        '        Loop

        '        lstThisTask.Add(theseTasks)

        '    Next


        'End If
        ''---------------------------------------------------------

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        If txtTask.Text = String.Empty Or mskDate.Text = String.Empty Or mskTime.Text = String.Empty Or
           lblColor.Text = String.Empty Then

            MessageBox.Show("You cannot have any empty values on the form." + vbNewLine + "Please try again.", "Empty Values")

        Else

            ''Creating an instance of the data structure dailyTasks
            'Dim theseTasks As dailyTasks

            With theseTasks

                .strTaskName = txtTask.Text
                .dtTaskDate = CDate(mskDate.Text)
                .dtTaskTime = CDate(mskTime.Text)
                .blnComplete = CBool(chkComplete.Checked)
                .strTaskCategory = lblColor.Text

            End With

            '----------------------------THIS SEEMS UNECESSARY-----------------
            lstThisTask.Add(theseTasks)
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            lstTasks.Items.Add(Converter(theseTasks))

            'Clearing textboxes
            txtTask.Text = String.Empty
            mskDate.Text = String.Empty
            mskTime.Text = String.Empty
            chkComplete.Checked = False
            lblColor.Text = String.Empty

            MessageBox.Show("You have added a task!", "Success")

        End If


    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        'Local var that stores index in the list box
        Dim selectedIndex = 0

        selectedIndex = lstTasks.SelectedIndex

        If blnOpenFileChosen = True Then

            MessageBox.Show("You can't modify the file but only read the file", "Action not allowed")

        Else

            If selectedIndex = -1 Then

                MessageBox.Show("No task has been chosen!", "No Task Selected")

            Else

                lstTasks.Items.RemoveAt(selectedIndex)

                lstThisTask.RemoveAt(selectedIndex)

                MessageBox.Show("You have removed a task from the list.", "Success")

                'Clearing textboxes
                txtTask.Text = String.Empty
                mskDate.Text = String.Empty
                mskTime.Text = String.Empty
                chkComplete.Checked = False
                lblColor.Text = String.Empty

            End If


        End If

    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click

        'Local var that holds dialog result
        Dim openColorDialog As DialogResult = dlgColorDialog.ShowDialog()

        If openColorDialog = Windows.Forms.DialogResult.OK Then

            lblColor.ForeColor = dlgColorDialog.Color

            strColor = dlgColorDialog.Color.ToString

            lblColor.Text = strColor

        End If

    End Sub

    Private Sub frmDailyPlannerDetails_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated


        'Save and cancel buttons are disabled or enabled depending on whether or not a file has been created
        If blnCreateFileSelected = True And lstTasks.Items.Count > 0 Then

            btnSave.Enabled = True
            btnCancel.Enabled = True

        Else

            btnSave.Enabled = False
            btnCancel.Enabled = False

        End If

    End Sub

    Private Sub lstTasks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTasks.SelectedIndexChanged

        'Storing the index of the item in the list box
        Dim intSelectedIndex As Integer = lstTasks.SelectedIndex

        If blnOpenFileChosen = False Then

            If intSelectedIndex >= 0 Then

                Dim retrieveTasks As dailyTasks = lstThisTask.Item(intSelectedIndex)

                With retrieveTasks

                    txtTask.Text = .strTaskName
                    mskDate.Text = CStr(.dtTaskDate)
                    mskTime.Text = CStr(.dtTaskTime)
                    chkComplete.Checked = CStr(.blnComplete)
                    lblColor.Text = .strTaskCategory

                End With

            End If

        End If


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        For intCount = 0 To lstThisTask.Count - 1

            Dim getTask As dailyTasks = lstThisTask.Item(intCount)

            Dim strConvertTask As String = Converter(getTask)

            createFile.WriteLine(strConvertTask)

        Next

        createFile.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        frmCancelButton.Show()

    End Sub
End Class