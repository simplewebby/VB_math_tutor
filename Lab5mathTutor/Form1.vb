'Tsagan Garyaeva
'Comp-185
'Lab 5 Math Tutor

Public Class Form1
    Dim rand As New Random
    Dim intResult, useranswer, num1, num2 As Integer
    Dim strOperator As String
    Public Property Green As Color = Green
    Public Property Red As Color = Red

    Private Sub btnCheckResult_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub txtResult_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNextProblem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblNum1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblOperator_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles radioDiv.CheckedChanged
        strOperator = "/ "
        'Loop to find a second operand that divides the first one evenly
        Do While (num1 Mod num2 <> 0)
            num1 = rand.Next(100) + 20
            num2 = rand.Next(100) + 20
        Loop
        lblNumbers.Text = CStr(num1) & " " & strOperator & " " & CStr(num2)
        intResult = num1 \ num2
        txtUserInput.Focus()


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        radioAdd.Checked = False
        radioSub.Checked = False
        radioMult.Checked = False
        radioDiv.Checked = False
        txtUserInput.Clear()
        txtUserInput.Focus()

        txtUserInput.Clear()
        lblCorrectAnswer.Text = " "
        lblNumbers.Text = " "
        Randomize()
        num1 = rand.Next(100) + 20
        num2 = rand.Next(100) + 20


    End Sub

    Private Sub btnCheckYourAnswer_Click(sender As Object, e As EventArgs) Handles btnCheckYourAnswer.Click
        Try

            If (txtUserInput.Text = String.Empty) Then
                MessageBox.Show("Please enter the answer")
                txtUserInput.Focus()
                'Check if the answer is an integer
            ElseIf (Integer.TryParse(txtUserInput.Text, intResult)) Then
                If (intResult = txtUserInput.Text) Then
                    txtUserInput.BackColor = Green
                    lblCorrectAnswer.Text = "Correct!"


                Else
                    lblCorrectAnswer.Text = "Incorrect, Please Try again"
                    txtUserInput.BackColor = Red
                    txtUserInput.Clear()

                End If
            Else
                MessageBox.Show("Invalid input, Try again")
                txtUserInput.Clear()

            End If
        Catch
        End Try


    End Sub

    Private Sub lblCorrectAnswer_Click(sender As Object, e As EventArgs) Handles lblCorrectAnswer.Click

    End Sub

    Private Sub radioAdd_CheckedChanged(sender As Object, e As EventArgs) Handles radioAdd.CheckedChanged
        strOperator = "+"
        lblNumbers.Text = CStr(num1) & " " & strOperator & " " & CStr(num2)
        intResult = num1 + num2
        txtUserInput.Focus()

    End Sub

    Private Sub radioSub_CheckedChanged(sender As Object, e As EventArgs) Handles radioSub.CheckedChanged
        strOperator = "-"
        lblNumbers.Text = CStr(num1) & " " & strOperator & " " & CStr(num2)
        intResult = num1 - num2
        txtUserInput.Focus()
    End Sub

    Private Sub radioMult_CheckedChanged(sender As Object, e As EventArgs) Handles radioMult.CheckedChanged
        strOperator = "*"
        lblNumbers.Text = CStr(num1) & " " & strOperator & " " & CStr(num2)
        intResult = num1 * num2
        txtUserInput.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        num1 = rand.Next(100) + 20
        num2 = rand.Next(100) + 20

    End Sub
End Class
