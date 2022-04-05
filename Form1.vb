Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblOut.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMonth.SelectedIndexChanged
        Dim strDayMonths(,) As String = {{"31", "Januay"},
                                         {"28 or 29", "February"},
                                         {"31", "March"},
                                         {"30", "April"},
                                         {"31", "May"},
                                         {"30", "June"},
                                         {"31", "July"},
                                         {"31", "August"},
                                         {"30", "September"},
                                         {"31", "October"},
                                         {"30", "November"},
                                         {"31", "Dicember"}}

        Dim intMonth As Integer = cbMonth.SelectedIndex
        lblOut.Text = strDayMonths(intMonth, 0) & "days in" &
                                    strDayMonths(intMonth, 1)
    End Sub
End Class
