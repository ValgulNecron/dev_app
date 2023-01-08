Imports CLdevoir
Namespace cldevoir
End Namespace
Module consdevoir


    Sub Main()

        Dim touche As String
        Dim saisie As String
        Dim note As Double
        Dim nom As String
        'Dim D1 As CLdevoire
        'D1.SetNote(8)


        Dim D1 As New CLdevoire

        Console.WriteLine("Bonjour, Veuillez donner votre note")

        saisie = Console.ReadLine()
        note = CDbl(saisie)
        D1.SetNote(note)
        Console.WriteLine("entrer le nom du professeur ayant note le davoir")
        nom = Console.ReadLine()
        D1.SetProfesseur(nom)
        Console.WriteLine(D1.Message())
        'Console.WriteLine(D1.noteDevoir) 'pour acceder a une variable privée lors de la compilation une erreur aura lieux 
        'Console.WriteLine(D1.noteDevoir())
        Console.WriteLine(D1.GetNote()) 'on peut cependant l'obtenir avec les geter publique 
        Console.WriteLine("Appuyez sur Entrée pour continuer")
        'Console.WriteLine(D1.nomProfesseur)
        touche = Console.ReadLine()






        Dim D2 As New CLdevoire 'on utilise new pour creer un nouveeaux objet si l'instruction new n'est pas mit un nouvelle objet ne sera pas creer
        Console.WriteLine("Bonjour, Veuillez donner votre note")
        saisie = Console.ReadLine()
        note = CDbl(saisie)
        D2.SetNote(note)
        Console.WriteLine("entrer le nom du professeur ayant note le davoir")
        nom = Console.ReadLine()
        D2.SetProfesseur(nom)
        Console.WriteLine(D2.Message())

        Console.WriteLine("la moyenne est de : ")
        Console.WriteLine(D1.CalculeMoyenne(D2))
        Console.WriteLine("Appuyez sur Entrée pour continuer")
        touche = Console.ReadLine()




        Dim D3 As New List(Of CLdevoire)
        Dim i As Int64
        Dim j As Int64
        Dim R As Int64
        R = 9223372036854775807 'limite d'un int coder sur 64 bits 
        For i = 1 To R 'va de 1 jusqu'a la limite d'un int coder sur 64bit 
            D3.Add(New CLdevoire) 'creer un nouvelle objet a chaque ocurence de la boucle
            Console.WriteLine(i) 'affiche a combien d'objet creer on est 
        Next
        ' le programme crash apres avoir atteint 100% de ram utiliser si le swap est off 
        ' le programme crash pas si le swap est on (17 000 000+ d'objet) 
        ' la limite doit donc etre 1 la quantiter de ram 
        ' et 2 la limite du system d'exploitation sur des systeme 64bits de -9 223 372 036 854 775 808 à 9 223 372 036 854 775 807 soit 18 446 744 073 709 551 615 bits par programme
        ' sur des systeme 32bits de -2 147 483 648 à 2 147 483 647 soit 4 294 967 295 bits par programme

        While true
        	D3.Add(New CLdevoire)
                Console.WriteLine(i)
		i= i+1
	end while
        touche = Console.ReadLine()
    End Sub

End Module
