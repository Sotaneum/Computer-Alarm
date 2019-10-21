Public Class Form1
    Private Sub NOWS_Tick(sender As Object, e As EventArgs) Handles NOWS.Tick
        Dim ampm As String
        If (Now().Hour > 12) Then
            ampm = "PM"
        Else
            ampm = "AM"
        End If
        NOW_TIME.Text = Now().ToString("hh:mm:ss") & " " & ampm
    End Sub
    Private Sub TEMP_PLAY_STOP_Click(sender As Object, e As EventArgs) Handles TEMP_PLAY_STOP.Click
        If Not (TB_URL.Text = "") Then
            If (TEMP_PLAY_STOP.Text = "재생") Then
                TEMP_PLAY_STOP.Text = "멈춤"
                My.Computer.Audio.Play(TB_URL.Text, AudioPlayMode.BackgroundLoop)
            Else
                TEMP_PLAY_STOP.Text = "재생"
                My.Computer.Audio.Stop()
            End If
        End If
    End Sub
    Private Sub B_ST_Click(sender As Object, e As EventArgs) Handles B_ST.Click
        Dim NOWTIME As Integer
        Dim HOURS As Integer
        Dim MINS As Integer
        Dim SECS As Integer
        If (TB_TIME_H.Text = "") Then
            TB_TIME_H.Text = "0"
        End If
        If (TB_TIME_M.Text = "") Then
            TB_TIME_M.Text = "0"
        End If
        If (TB_TIME_S.Text = "") Then
            TB_TIME_S.Text = "0"
        End If
        HOURS = TB_TIME_H.Text
        MINS = TB_TIME_M.Text
        SECS = TB_TIME_S.Text
        If (SECS - Now().Second < 0) Then
            MINS = MINS - 1
            SECS = SECS + 60
        End If
        If (MINS - Now().Minute < 0) Then
            HOURS = HOURS - 1
            MINS = MINS + 60
        End If
        NOWTIME = (HOURS - Now().Hour) * 60 * 60 + (MINS - Now().Minute) * 60 + SECS - Now().Second
        left_time.Enabled = True
        B_S.Enabled = True
        B_ST.Enabled = False
        Infomation.Visible = True
        Me.Hide()
        Infomation.BalloonTipText() = "알람이 시작되었습니다. 약 " & NOWTIME & "초 후 알람이 울림니다."
        Infomation.ShowBalloonTip(500)
    End Sub
    Private Sub left_time_Tick(sender As Object, e As EventArgs) Handles left_time.Tick
        Dim NOWTIME As Integer
        Dim HOURS As Integer
        Dim MINS As Integer
        Dim SECS As Integer
        If (TB_TIME_H.Text = "") Then
            TB_TIME_H.Text = "0"
        End If
        If (TB_TIME_M.Text = "") Then
            TB_TIME_M.Text = "0"
        End If
        If (TB_TIME_S.Text = "") Then
            TB_TIME_S.Text = "0"
        End If
        If (TB_TIME_H.Text = "0" & TB_TIME_M.Text = "0" & TB_TIME_S.Text = "0") Then
            TB_TIME_H.Text = Now().Hour
            TB_TIME_M.Text = Now().Minute
            TB_TIME_S.Text = Now().Second
        Else

        End If
        HOURS = TB_TIME_H.Text
        MINS = TB_TIME_M.Text
        SECS = TB_TIME_S.Text

        If (SECS - Now().Second < 0) Then
            MINS = MINS - 1
            SECS = SECS + 60
        End If
        If (MINS - Now().Minute < 0) Then
            HOURS = HOURS - 1
            MINS = MINS + 60
        End If
        TIME_LEFT.Text = HOURS - Now().Hour & ":" & MINS - Now().Minute & ":" & SECS - Now().Second
        NOWTIME = (HOURS - Now().Hour) * 60 * 60 + (MINS - Now().Minute) * 60 + SECS - Now().Second
        If (NOWTIME <= 0) Then
            OVER.Enabled = True
            left_time.Enabled = False
            B_ST.Enabled = False
            B_ST.Text = "알람 시작 / 트레이 모드"
        End If
        B_ST.Enabled = True
        B_ST.Text = "트레이 모드"
    End Sub
    Private Sub OVER_Tick(sender As Object, e As EventArgs) Handles OVER.Tick
        If Not (TB_URL.Text = "") Then
            My.Computer.Audio.Play(TB_URL.Text, AudioPlayMode.BackgroundLoop)
            ararms.Enabled = True
            OVER.Enabled = False
        End If
    End Sub
    Private Sub B_S_Click(sender As Object, e As EventArgs) Handles B_S.Click
        My.Computer.Audio.Stop()
        left_time.Enabled = False
        B_ST.Enabled = True
        B_S.Enabled = False
        ararms.Enabled = False
        B_ST.Text = "알람 시작 / 트레이 모드"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        B_S.Enabled = False
        TEMP_PLAY_STOP.Enabled = False
    End Sub
    Private Sub B_E_Click(sender As Object, e As EventArgs) Handles B_E.Click
        End
    End Sub

    Private Sub TB_URL_TextChanged(sender As Object, e As EventArgs) Handles TB_URL.TextChanged
        TEMP_PLAY_STOP.Enabled = True
    End Sub

    Private Sub Infomation_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Infomation.MouseDoubleClick
        Me.Show()
        Infomation.Visible = False
    End Sub

    Private Sub ararms_Tick(sender As Object, e As EventArgs) Handles ararms.Tick
        Infomation.BalloonTipText() = "설정하신 시간이 되었습니다."
        Infomation.ShowBalloonTip(500)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
