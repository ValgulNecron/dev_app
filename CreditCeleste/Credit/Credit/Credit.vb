Public Class Credit
    'pourquoi créer un objet ??
    'pour être reutiliser
    'pour un héritage : un credit, une loa ,une loa-ldd, un credit bail
    'pourra être utilisé par un ecran, une tablette, une application web (aspx)
    'un service web, api
    '
    'variable privee

    Private monMontant As Double
    Private monDuree As Double
    Private monTaux As Double
    Private monMensualite As Double

    Sub New() 'constructeur

    End Sub

    Sub New(montant As Double, duree As Double, taux As Double)
        'par defaut en vb, c'est public
        'par defaut en c#, c'est prive
        monMontant = montant
        monDuree = duree
        monTaux = taux

        'on en deduit celui a calculer car il est a 0
    End Sub

    Public Function getMensualite() As Double
        'm = v0 + 1 / (1 - (1 + i) ^-n)

        monTaux = monTaux / 1200 'taux annuel mis en mensuel

        monMensualite = Math.Round((monMontant * monTaux) / (1 - Math.Pow(1 + monTaux, -monDuree)))

        Return monMensualite
    End Function
    
    Public Function getMontant() As Double
        Return monMontant
    End Function
    
    Public Function getDuree() As Double
        Return monDuree
    End Function
    
    Public Function getTaux() As Double
        Return monTaux
    End Function

    Public Function getInfos() As String
        Return ("Montant : " & monMontant & "; Durée : " & monDuree & " ; taux : " & monTaux & " ; mensualité :" & monMensualite)
    End Function

End Class