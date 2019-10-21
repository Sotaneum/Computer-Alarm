<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.B_ST = New System.Windows.Forms.Button()
        Me.TB_TIME_H = New System.Windows.Forms.TextBox()
        Me.L_TIME = New System.Windows.Forms.Label()
        Me.TB_URL = New System.Windows.Forms.TextBox()
        Me.L_MUSIC = New System.Windows.Forms.Label()
        Me.B_S = New System.Windows.Forms.Button()
        Me.B_E = New System.Windows.Forms.Button()
        Me.NOW_TIME = New System.Windows.Forms.Label()
        Me.TEMP_PLAY_STOP = New System.Windows.Forms.Button()
        Me.TB_TIME_M = New System.Windows.Forms.TextBox()
        Me.TB_TIME_S = New System.Windows.Forms.TextBox()
        Me.TIME_LEFT = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NOWS = New System.Windows.Forms.Timer(Me.components)
        Me.left_time = New System.Windows.Forms.Timer(Me.components)
        Me.OVER = New System.Windows.Forms.Timer(Me.components)
        Me.Infomation = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ararms = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'B_ST
        '
        Me.B_ST.Location = New System.Drawing.Point(10, 75)
        Me.B_ST.Name = "B_ST"
        Me.B_ST.Size = New System.Drawing.Size(371, 42)
        Me.B_ST.TabIndex = 0
        Me.B_ST.Text = "알람 시작 / 트레이 모드"
        Me.B_ST.UseVisualStyleBackColor = True
        '
        'TB_TIME_H
        '
        Me.TB_TIME_H.Location = New System.Drawing.Point(163, 19)
        Me.TB_TIME_H.Name = "TB_TIME_H"
        Me.TB_TIME_H.Size = New System.Drawing.Size(24, 21)
        Me.TB_TIME_H.TabIndex = 1
        '
        'L_TIME
        '
        Me.L_TIME.AutoSize = True
        Me.L_TIME.Location = New System.Drawing.Point(10, 22)
        Me.L_TIME.Name = "L_TIME"
        Me.L_TIME.Size = New System.Drawing.Size(69, 12)
        Me.L_TIME.TabIndex = 2
        Me.L_TIME.Text = "현재 시간 : "
        '
        'TB_URL
        '
        Me.TB_URL.Location = New System.Drawing.Point(68, 48)
        Me.TB_URL.Name = "TB_URL"
        Me.TB_URL.Size = New System.Drawing.Size(218, 21)
        Me.TB_URL.TabIndex = 3
        Me.TB_URL.Text = "D:\MOHPASoundtrack-FlyboysHD.wav"
        '
        'L_MUSIC
        '
        Me.L_MUSIC.AutoSize = True
        Me.L_MUSIC.Location = New System.Drawing.Point(10, 51)
        Me.L_MUSIC.Name = "L_MUSIC"
        Me.L_MUSIC.Size = New System.Drawing.Size(41, 12)
        Me.L_MUSIC.TabIndex = 4
        Me.L_MUSIC.Text = "음악 : "
        '
        'B_S
        '
        Me.B_S.Location = New System.Drawing.Point(12, 123)
        Me.B_S.Name = "B_S"
        Me.B_S.Size = New System.Drawing.Size(369, 40)
        Me.B_S.TabIndex = 5
        Me.B_S.Text = "알람 종료"
        Me.B_S.UseVisualStyleBackColor = True
        '
        'B_E
        '
        Me.B_E.Location = New System.Drawing.Point(12, 169)
        Me.B_E.Name = "B_E"
        Me.B_E.Size = New System.Drawing.Size(369, 40)
        Me.B_E.TabIndex = 6
        Me.B_E.Text = "프로그램 종료"
        Me.B_E.UseVisualStyleBackColor = True
        '
        'NOW_TIME
        '
        Me.NOW_TIME.Location = New System.Drawing.Point(75, 22)
        Me.NOW_TIME.Name = "NOW_TIME"
        Me.NOW_TIME.Size = New System.Drawing.Size(82, 12)
        Me.NOW_TIME.TabIndex = 7
        Me.NOW_TIME.Text = "0"
        Me.NOW_TIME.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TEMP_PLAY_STOP
        '
        Me.TEMP_PLAY_STOP.Location = New System.Drawing.Point(292, 48)
        Me.TEMP_PLAY_STOP.Name = "TEMP_PLAY_STOP"
        Me.TEMP_PLAY_STOP.Size = New System.Drawing.Size(89, 22)
        Me.TEMP_PLAY_STOP.TabIndex = 8
        Me.TEMP_PLAY_STOP.Text = "재생"
        Me.TEMP_PLAY_STOP.UseVisualStyleBackColor = True
        '
        'TB_TIME_M
        '
        Me.TB_TIME_M.Location = New System.Drawing.Point(193, 19)
        Me.TB_TIME_M.Name = "TB_TIME_M"
        Me.TB_TIME_M.Size = New System.Drawing.Size(24, 21)
        Me.TB_TIME_M.TabIndex = 9
        '
        'TB_TIME_S
        '
        Me.TB_TIME_S.Location = New System.Drawing.Point(223, 19)
        Me.TB_TIME_S.Name = "TB_TIME_S"
        Me.TB_TIME_S.Size = New System.Drawing.Size(24, 21)
        Me.TB_TIME_S.TabIndex = 10
        '
        'TIME_LEFT
        '
        Me.TIME_LEFT.Location = New System.Drawing.Point(319, 22)
        Me.TIME_LEFT.Name = "TIME_LEFT"
        Me.TIME_LEFT.Size = New System.Drawing.Size(62, 12)
        Me.TIME_LEFT.TabIndex = 11
        Me.TIME_LEFT.Text = "0"
        Me.TIME_LEFT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(253, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 12)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "남은 시간 : "
        '
        'NOWS
        '
        Me.NOWS.Enabled = True
        '
        'left_time
        '
        '
        'OVER
        '
        '
        'Infomation
        '
        Me.Infomation.Icon = CType(resources.GetObject("Infomation.Icon"), System.Drawing.Icon)
        Me.Infomation.Text = "NotifyIcon1"
        '
        'ararms
        '
        Me.ararms.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 234)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TIME_LEFT)
        Me.Controls.Add(Me.TB_TIME_S)
        Me.Controls.Add(Me.TB_TIME_M)
        Me.Controls.Add(Me.TEMP_PLAY_STOP)
        Me.Controls.Add(Me.NOW_TIME)
        Me.Controls.Add(Me.B_E)
        Me.Controls.Add(Me.B_S)
        Me.Controls.Add(Me.L_MUSIC)
        Me.Controls.Add(Me.TB_URL)
        Me.Controls.Add(Me.L_TIME)
        Me.Controls.Add(Me.TB_TIME_H)
        Me.Controls.Add(Me.B_ST)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "알람"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_ST As System.Windows.Forms.Button
    Friend WithEvents TB_TIME_H As System.Windows.Forms.TextBox
    Friend WithEvents L_TIME As System.Windows.Forms.Label
    Friend WithEvents TB_URL As System.Windows.Forms.TextBox
    Friend WithEvents L_MUSIC As System.Windows.Forms.Label
    Friend WithEvents B_S As System.Windows.Forms.Button
    Friend WithEvents B_E As System.Windows.Forms.Button
    Friend WithEvents NOW_TIME As System.Windows.Forms.Label
    Friend WithEvents TEMP_PLAY_STOP As System.Windows.Forms.Button
    Friend WithEvents TB_TIME_M As System.Windows.Forms.TextBox
    Friend WithEvents TB_TIME_S As System.Windows.Forms.TextBox
    Friend WithEvents TIME_LEFT As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NOWS As System.Windows.Forms.Timer
    Friend WithEvents left_time As System.Windows.Forms.Timer
    Friend WithEvents OVER As System.Windows.Forms.Timer
    Friend WithEvents Infomation As System.Windows.Forms.NotifyIcon
    Friend WithEvents ararms As System.Windows.Forms.Timer

End Class
