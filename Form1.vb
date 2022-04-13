Public Class FmrStartBildschirm
    Private Sub FmrStartBildschirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pctStartBackgroundImage As Image = My.Resources.Main1
        Dim HintergrundMusik As New music

        pctStart.BackgroundImage = pctStartBackgroundImage
        pctStart.BackgroundImageLayout = ImageLayout.Stretch

        'HintergrundMusik.BackGroundMusic()
    End Sub

    Private Sub pctStart_Click(sender As Object, e As EventArgs) Handles pctStart.Click
        Me.Hide()
        FmrCharakterAuswahl.Show()
    End Sub
End Class
