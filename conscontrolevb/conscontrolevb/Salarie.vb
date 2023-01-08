Public Class Salarie
    private Dim nom as String
    private Dim prenom as String
    Private dim rue as String
    Private dim ville as String
    private dim salaire as double
    private dim date_embauche as Date
    public sub New(ByVal lenom As String, ByVal leprenom as String, ByVal larue as String, ByVal laville as String, ByVal lesalaire as double, ByVal ladate as Date)
        nom = lenom
        prenom = leprenom
        rue = larue
        ville = laville
        salaire = lesalaire
        date_embauche = ladate
    End Sub
    public sub New(ByVal lenom As String, ByVal leprenom as String, ByVal lesalaire as double, ByVal ladate as Date)
        nom = lenom
        prenom = leprenom
        rue = ""
        ville = ""
        salaire = lesalaire
        date_embauche = ladate
    End Sub
    public function affichercords()
        Return "ville : " & ville & " rue : " & rue
    end function
    public function affichertout()
        Return "nom : " & nom & " prenom : " & prenom & " salaire : " & salaire & " date_embauche : " & date_embauche
    end function
    public sub augmentersalaire(ByVal laugmentation as double)
        salaire = salaire * (1+laugmentation)
    end sub
    public function donnersalaire()
        return salaire
    end function
    public function calculezprime()
        Dim prime As Double
        if donnerancienter()>10
            prime = salaire * 0.10
        else if donnerancienter()>5
            prime = salaire * 0.05
        Else  
            prime = 0
        End If        
        Return prime
    end function
    public function donnerancienter()
        Dim ancien As Integer
        ancien = DateDiff(DateInterval.Year, date_embauche, Date.Today)
        Return ancien
    end function
End Class