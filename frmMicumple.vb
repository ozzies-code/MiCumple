Public Class frmMicumple
    Private Sub btnDateTime_Click(sender As Object, e As EventArgs) Handles btnDateTime.Click
        MsgBox("Su fecha de cumpleaños es " & DateTimePicker1.Text)
        MsgBox("Día: " &
            DateTimePicker1.Value.DayOfYear.ToString() & " del 2025")
    End Sub
End Class