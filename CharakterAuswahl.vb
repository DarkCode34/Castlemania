Public Class FmrCharakterAuswahl

    Dim AnimationTrigger As Integer = 1

    Private Sub CharakterAuswahl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.bg
    End Sub


    Private Sub tmrAnimation_Tick(sender As Object, e As EventArgs) Handles tmrAnimation.Tick

        Label1.Text = AnimationTrigger

        Select Case AnimationTrigger
            Case 1
                pctChar1.BackgroundImage = My.Resources.Wraith_01_Idle_Blinking_000
                pctChar1.BackgroundImageLayout = ImageLayout.Stretch
                pctChar2.BackgroundImage = My.Resources.Wraith_02_Idle_Blinking_000
                AnimationTrigger += 1
            Case 2
                pctChar1.BackgroundImage = My.Resources.Wraith_01_Idle_Blinking_001
                pctChar1.BackgroundImageLayout = ImageLayout.Stretch
                AnimationTrigger += 1
            Case 3
                pctChar1.BackgroundImage = My.Resources.Wraith_01_Idle_Blinking_002
                pctChar1.BackgroundImageLayout = ImageLayout.Stretch
                AnimationTrigger += 1
            Case 4
                pctChar1.BackgroundImage = My.Resources.Wraith_01_Idle_Blinking_003
                pctChar1.BackgroundImageLayout = ImageLayout.Stretch
                AnimationTrigger += 1
            Case 5
                pctChar1.BackgroundImage = My.Resources.Wraith_01_Idle_Blinking_004
                pctChar1.BackgroundImageLayout = ImageLayout.Stretch
                AnimationTrigger += 1
            Case 6
                pctChar1.BackgroundImage = My.Resources.Wraith_01_Idle_Blinking_005
                pctChar1.BackgroundImageLayout = ImageLayout.Stretch
                AnimationTrigger += 1
            Case 7
                pctChar1.BackgroundImage = My.Resources.Wraith_01_Idle_Blinking_006
                pctChar1.BackgroundImageLayout = ImageLayout.Stretch
                AnimationTrigger += 1
            Case 8
                pctChar1.BackgroundImage = My.Resources.Wraith_01_Idle_Blinking_007 'höhö, mit der Lizenz zum Töten..
                pctChar1.BackgroundImageLayout = ImageLayout.Stretch
                AnimationTrigger += 1
            Case 9
                pctChar1.BackgroundImage = My.Resources.Wraith_01_Idle_Blinking_008
                pctChar1.BackgroundImageLayout = ImageLayout.Stretch
                AnimationTrigger += 1
            Case 10
                pctChar1.BackgroundImage = My.Resources.Wraith_01_Idle_Blinking_009
                pctChar1.BackgroundImageLayout = ImageLayout.Stretch
                AnimationTrigger += 1
            Case 11
                pctChar1.BackgroundImage = My.Resources.Wraith_01_Idle_Blinking_010
                pctChar1.BackgroundImageLayout = ImageLayout.Stretch
                AnimationTrigger += 1
            Case 12
                pctChar1.BackgroundImage = My.Resources.Wraith_01_Idle_Blinking_011
                pctChar1.BackgroundImageLayout = ImageLayout.Stretch
                AnimationTrigger -= 11
        End Select
    End Sub
End Class