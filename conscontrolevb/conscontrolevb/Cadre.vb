Public Class Cadre : Inherits Salarie
    
    private dim listsalarie as List(Of Salarie)
    
    Public Sub New (ByVal lenom As String, ByVal leprenom as String, ByVal larue as String, ByVal laville as String, ByVal lesalaire as double, ByVal ladate as Date)
        MyBase.New(lenom, leprenom, larue, laville, lesalaire, ladate)
        listsalarie = New List(Of Salarie)
    End Sub
    Public Sub New (ByVal lenom As String, ByVal leprenom as String, ByVal lesalaire as double, ByVal ladate as Date)
        MyBase.New(lenom, leprenom, lesalaire, ladate)
        listsalarie = New List(Of Salarie)
    End Sub
    public sub ajouteunsalarie(ByVal leSalarie As Salarie)
        listsalarie.Add(leSalarie)
    end sub
    public function affichersalarie()
        Dim i as integer
        dim texte as String
        For i = 0 to listsalarie.count -1
            texte = texte & listsalarie(i).affichertout() & vbnewline
        Next
        Return texte
    end function
End Class