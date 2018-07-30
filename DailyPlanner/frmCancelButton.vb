Public Class frmCancelButton
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click

        frmDailyPlannerDetails.Close()
        Me.Close()

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

        Me.Close()

    End Sub
End Class