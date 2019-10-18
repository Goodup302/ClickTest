Public Class FormMain
    Public Cps As Integer = 0
    Public TotalCps As Integer = 0
    Public Timer As Integer = 0
    Public Started As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Credit"
        Me.LabelCredit.Text = ("Voici les credits" & Chr(13) &
                              "Merci pour avoir téléchargé " & Me.FormSkinMain.Text & Chr(13)
                             )
#End Region
        Me.LabelCps.Text = ""
        Me.LabelTotalCps.Text = ""
        Me.NumericSelectTimer.Value = 5
        Me.ButtonMain.Visible = True
        Me.ButtonClickTester.Visible = False
        Me.ButtonStoped.Visible = False
    End Sub

#Region "Theme"
    Sub DefineColor(ByVal Color As Color)
        Me.ButtonMain.BaseColor = Color
        Me.LabelCps.ForeColor = Color
        Me.LabelTotalCps.ForeColor = Color
        Me.TabControl.ActiveColor = Color
        Me.NumericSelectTimer.ButtonColor = Color
        Me.LabelCps.ForeColor = Color
        Me.LabelTotalCps.ForeColor = Color
        Me.ButtonStoped.BaseColor = Color
        Me.LabelSelectTimer.ForeColor = Color
        '
        Me.TabControl.Visible = False
        Me.TabControl.Visible = True
    End Sub
    Private Sub ButtonClolorRed_Click(sender As Object, e As EventArgs) Handles ButtonClolorRed.Click
        DefineColor(Me.ButtonClolorRed.BaseColor)
    End Sub

    Private Sub ButtonClolorCyan_Click(sender As Object, e As EventArgs) Handles ButtonClolorCyan.Click
        DefineColor(Me.ButtonClolorCyan.BaseColor)
    End Sub

    Private Sub ButtonClolorBlue_Click(sender As Object, e As EventArgs) Handles ButtonClolorBlue.Click
        DefineColor(Me.ButtonClolorBlue.BaseColor)
    End Sub

    Private Sub ButtonClolorLimeGreen_Click(sender As Object, e As EventArgs) Handles ButtonClolorLimeGreen.Click
        DefineColor(Me.ButtonClolorLimeGreen.BaseColor)
    End Sub

    Private Sub ButtonClolorOrange_Click(sender As Object, e As EventArgs) Handles ButtonClolorOrange.Click
        DefineColor(Me.ButtonClolorOrange.BaseColor)
    End Sub

    Private Sub ButtonClolorPurple_Click(sender As Object, e As EventArgs) Handles ButtonClolorPurple.Click
        DefineColor(Me.ButtonClolorPurple.BaseColor)
    End Sub
#End Region
    Private Sub ButtonMain_Click(sender As Object, e As EventArgs) Handles ButtonMain.Click
        If Started = False Then
            Cps = 0
            Me.ButtonClickTester.Text = "Clique ici le plus vite possible (" & Cps & ")"
            Me.LabelCps.Text = "CPS " & Cps
            Me.LabelTotalCps.Text = "Tu a fait " & TotalCps & " CPS pour " & Timer & " seconds."
            Me.Timer1.Interval = 1000
            Me.Timer1.Enabled = True
            Me.NumericSelectTimer.Enabled = False
            Me.ButtonMain.Visible = False
            Me.ButtonClickTester.Visible = True
            Me.ButtonStoped.Visible = True
            Me.GroupBoxTheme.Enabled = False
            Started = True
        End If
    End Sub
    Private Sub ButtonClickTester_Click(sender As Object, e As EventArgs) Handles ButtonClickTester.Click
        If Started = True Then
            Cps += 1
            TotalCps += 1
            Me.ButtonClickTester.Text = "Clique ici le plus vite possible (" & Cps & ")"
            Me.LabelTotalCps.Text = "Tu a fait " & TotalCps & " CPS pour " & Timer & " seconds."
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer += 1
        Me.LabelTotalCps.Text = "Tu a fait " & TotalCps & " CPS pour " & Timer & " seconds."
        Me.LabelCps.Text = "CPS " & Cps
        If Timer <> Me.NumericSelectTimer.Value Then
            Cps = 0
        Else
            Me.Timer1.Enabled = False
            Started = False
            MsgBox("Tu a fait : " & TotalCps / Timer & " CPS en moyen pendant " & Timer & " Seconds", 64, "Resultat")
            Cps = 0
            TotalCps = 0
            Timer = 0
            Me.ButtonClickTester.Visible = False
            Me.ButtonMain.Visible = True
            Me.NumericSelectTimer.Enabled = True
            Me.ButtonStoped.Visible = False
            Me.GroupBoxTheme.Enabled = True
            Me.LabelCps.Text = ""
            Me.LabelTotalCps.Text = ""
        End If
    End Sub

    Private Sub NumericSelectTimer_Click(sender As Object, e As EventArgs) Handles NumericSelectTimer.Click
    End Sub

    Private Sub ButtonStoped_Click(sender As Object, e As EventArgs) Handles ButtonStoped.Click
        Me.Timer1.Enabled = False
        Started = False
        Cps = 0
        TotalCps = 0
        Timer = 0
        Me.ButtonClickTester.Visible = False
        Me.ButtonMain.Visible = True
        Me.NumericSelectTimer.Enabled = True
        Me.ButtonStoped.Visible = False
        Me.GroupBoxTheme.Enabled = True
        Me.LabelCps.Text = ""
        Me.LabelTotalCps.Text = ""
    End Sub
End Class