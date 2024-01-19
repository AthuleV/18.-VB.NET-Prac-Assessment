Imports System.Reflection.Emit

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim textToAdd As String = TextBox1.Text.Trim()

        ' Check for empty input and duplicate entries
        If textToAdd.Length > 0 AndAlso Not ListBox1.Items.Contains(textToAdd) Then
            ListBox1.Items.Add(textToAdd)
            TextBox1.Clear() ' Clear the TextBox after adding
        ElseIf textToAdd.Length = 0 Then
            MessageBox.Show("Please enter a word or phrase.")
        Else
            MessageBox.Show("The word or phrase already exists in the list.")
            TextBox1.Clear()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Label1.Text = ListBox1.SelectedItem ' Display the selected value on the Label
        Label1.BackColor = Color.White ' Set the Label background to white
        Label1.ForeColor = Color.Black ' Reset text color to black
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Label1.Text = Label1.Text.ToUpper()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Label1.Text = Label1.Text.ToLower()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            Label1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            Label1.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

End Class
