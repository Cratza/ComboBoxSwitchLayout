Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim chooseItem As String = ComboBox1.SelectedItem.ToString()
        Dim resLocation As Point = New Point(13, 50)
        Select Case chooseItem
            Case "GroupBox1"
                GroupBox1.BringToFront()
                GroupBox1.Location = resLocation
            Case "GroupBox2"
                GroupBox2.BringToFront()
                GroupBox2.Location = resLocation
            Case "GroupBox3"
                GroupBox3.BringToFront()
                GroupBox3.Location = resLocation
            Case Else
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(GroupBox1.Location.X + GroupBox1.Width + 30, GroupBox1.Location.Y + GroupBox1.Height + 100)
    End Sub


End Class
