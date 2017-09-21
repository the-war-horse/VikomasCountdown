Imports System.Windows.Forms
Imports Microsoft
Imports System
Public Class VikomasCountdown

    Dim Time As New TimeSpan()
    Dim Start As DateTime = DateTime.Now
    Dim EndDay As New DateTime(2017, 12, 25, 0, 0, 0)

    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.InitializeComponent()
        'Time = New TimeSpan(0, CInt(lbCountdown.Text), 0)
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Countdown As Timer = Nothing
        Time = EndDay.Subtract(DateTime.Now)
        lbCountdown.Text = String.Format(" {0} days, {1}h, {2}m and {3}s to go!", Time.Days, Time.Hours, Time.Minutes, Time.Seconds)
        'Dim Counting = Time.ToString("ss")
        'lbCountdown.Text = Counting & " days to go!"
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub


End Class
