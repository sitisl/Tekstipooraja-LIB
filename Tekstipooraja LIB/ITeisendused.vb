Public Interface ITeisendused
    Property intAlgus As Integer 'Esiemene symbol
    Property intLopp As Integer  'Viimane symbol
    Property strTekst As String  'Sisestatud tekst


    Function pooraTekst() As String
    Sub teisendaTekst(ByRef strSisendTekst As String)

End Interface
