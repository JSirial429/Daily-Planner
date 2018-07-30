' import libraries
Imports System.IO

'Affirmation of Authorship
'Name:Jorge Sirias
'Date : 6/10/2018
'I affirm that this program was created by Me. It Is solely my work And does Not include any work done by anyone Else.


Module modDPlanner

    'Boolean variable that states whether or not user has chosen to open file as opposed to creating file
    Public blnOpenFileChosen As Boolean = False

    'File name selected by user. Used when saving to the file
    Public strFileName As String

    'Structure definition
    Public Structure dailyTasks

        Dim strTaskName As String
        Dim dtTaskDate As Date
        Dim dtTaskTime As Date
        Dim blnComplete As Boolean
        Dim strTaskCategory As String

    End Structure

    'Bln variable that is true when user clicks on create file from the initial form
    Public blnCreateFileSelected As Boolean

    'Create an object variable of the StreamWriter class
    Public createFile As StreamWriter

    'String variable used in the conversion function
    Public strTasks As String

    Public Function Converter(ByVal strStructure As dailyTasks)

        'Concatenates elements in structure to one single string
        strTasks = strStructure.strTaskName + "," + CStr(strStructure.dtTaskDate) + "," + CStr(strStructure.dtTaskTime) +
        "," + CStr(strStructure.blnComplete) + "," + strStructure.strTaskCategory

        'returns string
        Return strTasks

    End Function
End Module
