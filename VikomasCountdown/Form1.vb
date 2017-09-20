Imports System.Windows.Forms
Imports Microsoft
Imports System
Public Class Form1


    Dim Countdown As Timer

    Dim Start As DateTime = DateTime.Now
    Dim EndDay As New DateTime(2017, 12, 25, 0, 0, 0)
    Dim Time As New TimeSpan()

    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.InitializeComponent()
        Time = EndDay.Subtract(DateTime.Now)
        Dim Counting = Time.ToString("dd")
        lbCountdown.Text = Counting & " days to go!"
    End Sub

End Class
