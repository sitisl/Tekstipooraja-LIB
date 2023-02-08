Public Class CAlgoritmiline
    Implements ITeisendused

    Private intAlgusSymbol As Integer
    Private intLoppSymbol As Integer
    Private strPooratavTekst As String
    Private Function pooraAlgo(ByRef strPooratavTekst As String)
        Dim output As String = ""
        For i = Len(strPooratavTekst) To 1 Step -1
            output = output & Mid(strPooratavTekst, i, 1)
        Next
        Return output
    End Function

    Private Property intAlgus As Integer Implements ITeisendused.intAlgus
        Get
            Return intAlgusSymbol
        End Get
        Set(value As Integer)
            intAlgusSymbol = value
        End Set
    End Property

    Private Property intLopp As Integer Implements ITeisendused.intLopp
        Get
            Return intLoppSymbol
        End Get
        Set(value As Integer)
            intLoppSymbol = value
        End Set
    End Property

    Private Property strTekst As String Implements ITeisendused.strTekst
        Get
            Return strPooratavTekst
        End Get
        Set(value As String)
            strPooratavTekst = value
        End Set
    End Property

    Private Sub teisendaTekst(ByRef strSisendTekst As String) Implements ITeisendused.teisendaTekst
        strPooratavTekst = pooraAlgo(strSisendTekst)
    End Sub

    Private Function pooraTekst() As String Implements ITeisendused.pooraTekst
        'Dim output As String = ""
        'For i = Len(strPooratavTekst) To 1 Step -1
        '    output = output & Mid(strPooratavTekst, i, 1)
        'Next
        'Return output
        Return pooraAlgo(strPooratavTekst)
    End Function
End Class
