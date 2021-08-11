Imports System.Text.RegularExpressions ' Regular Expressions Namespace]

Public Class Form1
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        IdTxt.Text = ""
        ScoreTxt.Text = ""
        HSTTxtBx.Text = ""
        LSTTxtBx.Text = ""
        AvgTxtBx.Text = ""
    End Sub

    Private Sub AddIdBtn_Click(sender As Object, e As EventArgs) Handles AddIdBtn.Click
        Dim AddId As Boolean 'Is Name  Valid?

        'If Not A Matching Format Entered Check for validation
        If Not Regex.Match(IdTxt.Text, "^[1-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Numerical Characters Only!") 'Inform User
            IdTxt.Focus() 'Return Focus
            IdTxt.Clear() 'Clear TextBox
            AddId = False 'Boolean = False
        Else
            'Adds it to listbox if valid
            listBox1.Items.AddRange(IdTxt.Text.Split(vbNewLine))
        End If

    End Sub

    Private Sub AddScoreBtn_Click(sender As Object, e As EventArgs) Handles AddScoreBtn.Click

        Dim AddScore As Boolean 'Is Name  Valid?

        'If Not A Matching Format Entered Check for validation
        If Not Regex.Match(ScoreTxt.Text, "^[1-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Numerical Characters Only!") 'Inform User
            ScoreTxt.Focus() 'Return Focus
            ScoreTxt.Clear() 'Clear TextBox
            AddScore = False 'Boolean = False
        Else
            'Adds it to listbox if valid
            listBox2.Items.AddRange(ScoreTxt.Text.Split(vbNewLine))
        End If
    End Sub

    Private Sub IdTxt_TextChanged(sender As Object, e As EventArgs) Handles IdTxt.TextChanged

    End Sub

    Private Sub CompBtn_Click(sender As Object, e As EventArgs) Handles CompBtn.Click
        Dim CurrentHighest As Integer = 0
        Dim CurrentLowest As Integer = 1
        Dim Total As Double = 0
        Dim Count As Double = 0
        Dim Average As Double = 0

        For Each item As Integer In listBox2.Items
            If item > CurrentHighest Then CurrentHighest = item
        Next

        For Each item As Integer In listBox2.Items
            If item < CurrentLowest Then CurrentLowest = item
        Next

        For I As Integer = 0 To listbox2.Items.Count - 1
            Total += Val(listbox2.Items(I))
            Count += 1
        Next

        Average = Total / Count
        AvgTxtBx.Text = Average.ToString
        HSTTxtBx.Text = CurrentHighest.ToString
        LSTTxtBx.Text = CurrentLowest.ToString

    End Sub
End Class
