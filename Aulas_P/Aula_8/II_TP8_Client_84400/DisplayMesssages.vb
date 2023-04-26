Public Class DisplayMesssages

    Private Sub DisplayMesssages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Debug"
        txtSent.ScrollBars = RichTextBoxScrollBars.ForcedVertical
        txtSent.HideSelection = False
        txtReceived.ScrollBars = RichTextBoxScrollBars.ForcedVertical
        txtReceived.HideSelection = False
    End Sub

End Class