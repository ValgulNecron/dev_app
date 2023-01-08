Module conscontrole
    Sub Main
        dim cad1 as Cadre
        
        dim sal1 as Salarie
        dim sal2 as Salarie
        
        dim laDate as date 
        laDate = new date(1997,11,8)
        cad1 = new Cadre("Dubois", "Rose", "6 rue des petits pas", "villard en bré", 3200,laDate)
        console.writeline(cad1.affichercords())
        cad1.ajouteunsalarie(sal1)
        cad1.ajouteunsalarie(sal2)
        console.writeline(cad1.affichersalarie())
    End Sub
End Module