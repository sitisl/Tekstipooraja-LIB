Public Class formKasutajaAken


    Private Function leiaTaishaalik(ByRef sisendTekst As String)
        Dim cnt As Integer
        Dim Vowels() As Char = {"a", "A", "e", "E", "i", "I", "o", "O", "u", "U"}
        For Each c As Char In sisendTekst
            If c Like "[AaEeIiOoUu]" Then
                cnt = cnt + 1
            End If
        Next

        Return cnt
    End Function
    Private Sub btnPoora1_Click(sender As Object, e As EventArgs) Handles btnPoora1.Click

        Dim pooraja As Tekstipooraja_LIB.ITeisendused

        pooraja = New Tekstipooraja_LIB.CTekstipooraja

        pooraja.strTekst = txtSisendtekst.Text

        txtValjundTekst1.Text = pooraja.pooraTekst()

    End Sub
    Private Sub btnPoora2_Click(sender As Object, e As EventArgs) Handles btnPoora2.Click
        Dim pooraja As Tekstipooraja_LIB.ITeisendused
        pooraja = New Tekstipooraja_LIB.CTekstipooraja

        pooraja.teisendaTekst(txtSisendtekst.Text)
        txtValjundTekst2.Text = pooraja.strTekst
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        timerUuenda.Enabled = True
        btnStart.Enabled = False
    End Sub

    Private Sub timerUuenda_Tick(sender As Object, e As EventArgs) Handles timerUuenda.Tick
        Dim pooraja As Tekstipooraja_LIB.ITeisendused

        pooraja = New Tekstipooraja_LIB.CTekstipooraja

        pooraja.strTekst = txtSisendtekst.Text

        txtValjundTekst1.Text = pooraja.pooraTekst()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        timerUuenda.Enabled = False
        btnStart.Enabled = True
    End Sub

    Private Sub txtSisendtekst_TextChanged(sender As Object, e As EventArgs) Handles txtSisendtekst.TextChanged
        'txtCnt.Text = txtSisendtekst.Text.Length()
        txtCnt.Text = leiaTaishaalik(txtSisendtekst.Text)
    End Sub
End Class
