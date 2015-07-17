Imports System.Data.SqlClient
Public Class FrmDisplay
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim token As Integer
    Dim str As String
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub FrmDisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()



    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Left -= 5

        If Label3.Left <= -Width Then
            Label3.Left = Width

        End If

        Label1.Left -= 5

        If Label1.Left <= -Width Then
            Label1.Left = Width

        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
