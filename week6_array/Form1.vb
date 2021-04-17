Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim day(6) As String
        Dim i As Integer = 0

        day(0) = "Sunday"
        day(1) = "Monday"
        day(2) = "Tuesday"
        day(3) = "Wednesday"
        day(4) = "Thursday"
        day(5) = "Friday"
        day(6) = "Saturday"
        System.Array.Sort(day)

        For i = 0 To 6
            ListBox1.Items.Add(day(i))
        Next



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strKelas(5, 3) As String
        Dim x As Integer = 0
        Dim y As Integer = 0

        strKelas(0, 0) = "DDT1A"
        strKelas(0, 1) = "DDT1B"
        strKelas(1, 0) = "DDT2A"
        strKelas(1, 1) = "DDT2B"
        strKelas(1, 2) = "DDT2C"

        For x = 0 To 1
            For y = 0 To 3

            Next
        Next


    End Sub
End Class
