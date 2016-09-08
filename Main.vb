Option Strict On

Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Text = "Changing Machine #1"
   
    End Sub
    Private Sub btnCalculate_click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim given As Integer = CInt(Me.txtGiven.Text)
        Dim total As Integer = CInt(Me.txtTotal.Text)
        Dim change As Integer = given - total

        lblChange.Text = CStr(change)

        num_transactions = num_transactions + 1
        Dim no_1000 As Integer = 0
        Dim no_500 As Integer = 0
        Dim no_100 As Integer = 0
        Dim no_50 As Integer = 0
        Dim no_20 As Integer = 0
        Dim no_10 As Integer = 0
        Dim no_5 As Integer = 0
        Dim no_2 As Integer = 0
        Dim no_1 As Integer = 0

        While change >= 1000
            no_1000 += 1
            change = change - 1000
            Me.lbl1000.Text = CStr(no_1000)
        End While
        While change >= 500
            no_500 += 1
            change = change - 500
            Me.lbl500.Text = CStr(no_500)
        End While
        While change >= 100
            no_100 += 1
            change = change - 100
            Me.lbl100.Text = CStr(no_100)
        End While
        While change >= 50
            no_50 += 1
            change = change - 50
            Me.lbl50.Text = CStr(no_50)
        End While
        While change >= 20
            no_20 += 1
            change = change - 20
            Me.lbl20.Text = CStr(no_20)
        End While
        While change >= 10
            no_10 += 1
            change = change - 10
            Me.lbl10.Text = CStr(no_10)
        End While
        While change >= 5
            no_5 += 1
            change = change - 5
            Me.lbl5.Text = CStr(no_5)
        End While
        While change >= 2
            no_2 += 1
            change = change - 2
            Me.lbl2.Text = CStr(no_2)
        End While
        If change >= 1 Then
            no_1 += 1
            change = change - 1
            Me.lbl1.Text = CStr(no_1)
        End If
    End Sub
End Class
