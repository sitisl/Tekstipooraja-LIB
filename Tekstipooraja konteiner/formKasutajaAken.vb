Public Class formKasutajaAken
    Private Sub formKasutajaAken_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
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


End Class
