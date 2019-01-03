Public Class frmJob8
    Dim sumScore As Decimal = 0
    Dim sumCredit As Decimal = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtSubject.Text.Trim = "" Or txtScore.Text.Trim = "" Or txtCredit.Text.Trim = "" Then
            MessageBox.Show("กรอกข้อมูลไม่ครบถ้วน", "", MessageBoxButtons.OK)
            Exit Sub
        Else
            getScore(Val(txtScore.Text))
            lstSubject.Items.Add(txtSubject.Text)
            lstScore.Items.Add(txtScore.Text)
            lstCredit.Items.Add(txtCredit.Text)
            lstSubject.SelectedIndex = lstSubject.Items.Count - 1
            calData()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblOldTotalCredit.Text = sumCredit
        lblOldGPA.Text = sumScore / sumCredit
        lblOldTotalScore.Text = sumScore
        lblNewGPA.Text = ""
        txtSubject.Clear()
        txtScore.Clear()
        txtCredit.Clear()
        lstSubject.Items.Clear()
        lstScore.Items.Clear()
        lstGrade.Items.Clear()
        lstCredit.Items.Clear()
    End Sub

    Private Sub frmJob8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sumScore = 150
        sumCredit = 50
        lblOldTotalScore.Text = sumScore
        lblOldTotalCredit.Text = sumCredit
        lblOldGPA.Text = sumScore / sumCredit
        calData()
    End Sub

    Private Sub lstSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSubject.SelectedIndexChanged
        Dim s1 As Integer = lstSubject.SelectedIndex
        Dim s2 As Integer = lstSubject.SelectedIndex = lstSubject.Items.Count
        If lstSubject.SelectedIndex Then
            lstScore.SelectedIndex = s1
            lstCredit.SelectedIndex = s1
            lstGrade.SelectedIndex = s1
        ElseIf lstSubject.SelectedIndex = s2 Then
            lstScore.SelectedIndex = s2
            lstCredit.SelectedIndex = s2
            lstGrade.SelectedIndex = s2
        End If
    End Sub

    Private Sub lstScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstScore.SelectedIndexChanged
        Dim s1 As Integer = lstScore.SelectedIndex
        Dim s2 As Integer = lstScore.SelectedIndex = lstScore.Items.Count
        If lstScore.SelectedIndex Then
            lstSubject.SelectedIndex = s1
            lstCredit.SelectedIndex = s1
            lstGrade.SelectedIndex = s1
        ElseIf lstScore.SelectedIndex = s2 Then
            lstSubject.SelectedIndex = s2
            lstCredit.SelectedIndex = s2
            lstGrade.SelectedIndex = s2
        End If
    End Sub

    Private Sub lstCredit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCredit.SelectedIndexChanged
        Dim s1 As Integer = lstCredit.SelectedIndex
        Dim s2 As Integer = lstCredit.SelectedIndex = lstCredit.Items.Count
        If lstCredit.SelectedIndex Then
            lstScore.SelectedIndex = s1
            lstSubject.SelectedIndex = s1
            lstGrade.SelectedIndex = s1
        ElseIf lstCredit.SelectedIndex = s2 Then
            lstScore.SelectedIndex = s2
            lstSubject.SelectedIndex = s2
            lstGrade.SelectedIndex = s2
        End If
    End Sub

    Private Sub lstGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGrade.SelectedIndexChanged
        Dim s1 As Integer = lstGrade.SelectedIndex
        Dim s2 As Integer = lstGrade.SelectedIndex = lstGrade.Items.Count
        If lstGrade.SelectedIndex Then
            lstScore.SelectedIndex = s1
            lstCredit.SelectedIndex = s1
            lstSubject.SelectedIndex = s1
        ElseIf lstGrade.SelectedIndex = s2 Then
            lstScore.SelectedIndex = s2
            lstCredit.SelectedIndex = s2
            lstSubject.SelectedIndex = s2
        End If
    End Sub
    Private Function getScore(ByVal a As Decimal) As String
        Dim g As String
        If a >= 80 Then
            g = "A"
        ElseIf a >= 75 Then
            g = "B+"
        ElseIf a >= 70 Then
            g = "B"
        ElseIf a >= 65 Then
            g = "C+"
        ElseIf a >= 60 Then
            g = "C"
        ElseIf a >= 55 Then
            g = "D+"
        ElseIf a >= 50 Then
            g = "D"
        Else
            g = "F"
        End If
        lstGrade.Items.Add(g)
        Return a
    End Function
    Private Sub calData()
        Dim sumGPA, getCre, getSc, g As Decimal
        For i As Integer = 0 To lstGrade.Items.Count - 1
            If lstGrade.Items(i) = "A" Then
                g = 4
            ElseIf lstGrade.Items(i) = "B+" Then
                g = 3.5
            ElseIf lstGrade.Items(i) = "B" Then
                g = 3
            ElseIf lstGrade.Items(i) = "C+" Then
                g = 2.5
            ElseIf lstGrade.Items(i) = "C" Then
                g = 2
            ElseIf lstGrade.Items(i) = "D+" Then
                g = 1.5
            ElseIf lstGrade.Items(i) = "D" Then
                g = 1
            ElseIf lstGrade.Items(i) = "F" Then
                g = 0
            End If
            getCre += lstCredit.Items(i)
            getSc += g * lstCredit.Items(i)
            sumGPA = ((getSc + sumScore) / (getCre + sumCredit))
        Next
        lblNewGPA.Text = sumGPA.ToString("#.##")
    End Sub

    Private Sub txtScore_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScore.KeyPress
        Dim keyInt As Integer = Asc(e.KeyChar)
        If (keyInt >= 48 And keyInt <= 57) Or keyInt = 48 Or keyInt = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtCredit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCredit.KeyPress
        txtScore_KeyPress(sender, e)
    End Sub
End Class