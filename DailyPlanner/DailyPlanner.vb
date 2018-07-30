' import libraries
Imports System.IO
Imports System.Drawing.Printing

'Affirmation of Authorship
'Name:Jorge Sirias
'Date : 6/10/2018
'I affirm that this program was created by Me. It Is solely my work And does Not include any work done by anyone Else.


Public Class frmDailyPlanner
    Private Sub frmDailyPlanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnCreateFile_Click(sender As Object, e As EventArgs) Handles btnCreateFile.Click

        ''Create an object variable of the StreamWriter class
        'Dim createFile As StreamWriter

        ''Local variable that hold string value for the text box txtFileName
        'Dim strFileName As String

        'Local varaible 
        Dim blnFileExists As Boolean

        'Assigning the string value in textbox to local variable
        strFileName = txtFileName.Text


        If strFileName = String.Empty Then

            MessageBox.Show("File Name cannot be empty." + vbNewLine +
                                "Please give a name to the file you are trying to create.", "No name given.")

        ElseIf Not (strFileName.Contains("txt")) Then 'File does not have .txt appended

            'Appending ".txt" to strFileName
            strFileName = strFileName + ".txt"

            'Assigning boolean value to variable based on if file exists or not
            blnFileExists = File.Exists(strFileName)

            If blnFileExists Then

                MessageBox.Show(strFileName + " file already exists please rename your file to something else.")

            Else

                'Create file with file.CreateText method of the streamwriter class
                createFile = File.CreateText(strFileName)

                blnCreateFileSelected = True

                'Open task details form
                frmDailyPlannerDetails.ShowDialog()

            End If

        Else 'File given already has .txt appended

            blnFileExists = File.Exists(strFileName)

            If blnFileExists Then

                MessageBox.Show(strFileName + " file already exists please rename your file to something else.")

            Else

                'Create file with file.CreateText method of the streamwriter class
                createFile = File.CreateText(strFileName)

                blnCreateFileSelected = True

                'Open task details form
                frmDailyPlannerDetails.ShowDialog()

            End If

        End If

        txtFileName.Text = String.Empty

        'Add file to listbox
        lstTaskFiles.Items.Add(strFileName)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close application
        Me.Close()

    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click

        'Object of the stream reader class
        Dim readFile As StreamReader

        'Local variable 
        Dim openFileDialog As DialogResult

        'Filtering for *.txt files
        dlgOpenFileDialog.Filter = "txt file (Text Files)|*.txt"

        'Open dialog box to open file
        openFileDialog = dlgOpenFileDialog.ShowDialog()

        If openFileDialog = Windows.Forms.DialogResult.OK Then

            'Stores the string value of the file path 
            strFileName = dlgOpenFileDialog.FileName

            '-------------------------Might need it to shorten file path-----------------
            ''Stores the index of ".txt"
            'Dim intDotIndex = strLongFilepath.IndexOf(".")
            '----------------------------------------------------------------------------

            ''Stores the index of "\" character
            'Dim intSlashIndex = 0

            ''Stores string value of "\"
            'Dim strSlash As String

            'Do Until strSlash = "\"

            '    Dim countIndex = intDotIndex



            'Loop

            'Local variable that holds name of the text file
            'Dim strFileName As String

            ''Local variable that holds String for "\"
            'Dim strSlash As String

            ''Counter for while loop
            'Dim intCount = intDotIndex

            ''intSlashIndex = strLongFilepath.IndexOf("\", intDotIndex)

            ''strFileName = strLongFilepath.Substring(intSlashIndex)

            ''txtFileName.Text = strFileName

            'Do Until strSlash = "\"

            '    intCount -= 1

            '    strSlash = strLongFilepath.Substring(intDotIndex, intDotIndex - 1)

            'Loop

            'Open File
            readFile = File.OpenText(strFileName)

            'Local variable that holds a line of string data from the open file
            Dim strLineFile As String

            'Read until
            Do Until readFile.EndOfStream

                strLineFile = readFile.ReadLine()

                frmDailyPlannerDetails.lstTasks.Items.Add(strLineFile)

            Loop

            txtFileName.Text = strFileName

        End If

        'Set boolean value to true
        blnOpenFileChosen = True

        'Add file to listbox
        lstTaskFiles.Items.Add(strFileName)

        'Display form Daily Planner Details
        frmDailyPlannerDetails.ShowDialog()

    End Sub

    Private Sub btnPrintFile_Click(sender As Object, e As EventArgs) Handles btnPrintFile.Click

        'Display printer file dialog
        printFileDialog.ShowDialog()

    End Sub
End Class
