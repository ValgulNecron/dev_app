Imports System.Data.SqlClient

Public Class Form1
    'connexion a la bdd
    'serveur ; l'adresse ip/dns
    'la base de données
    'le moyen securisé : id / mdp
    'authentification sqlServeur
    Dim ReadOnly _
        _strConnexion =
            "Data Source=10.129.253.209;User Id=connEleveSio;password=mdpEleveSio; Initial Catalog=creditCeleste"
    ' authentification active directory
    'Dim strConnexion = "Data Source=10.129.253.209;Integrated Security=SSPI;Initial Catalog=creditCeleste"
    'requete
    Dim ReadOnly strRequete As String = "SELECT nomVendeur, prenomVendeur, Ccivvdr, numeroVendeur FROM Vendeur"
    'connexion à la bdd
    Dim ReadOnly _oConnexion As SqlConnection = new SqlConnection(_strConnexion)
    'création de la commande
    Dim ReadOnly _oCommand = New SqlCommand(strRequete, _oConnexion)
    ' création d'un adaptateur
    Dim _oAdapter As SqlDataAdapter 
    ' pour stocker les info en local
    ' pour les synchro 
    ' en utilisant un dataset
    Dim _oDataSet As DataSet 
    ' on va gerer les Objet sql
    dim _obuilder as SqlCommandBuilder 
    ' et pour gerer le tableaux
    dim _i As Integer = 0 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ouvrir la base de données
        ' _oConnexion.Open()
        ' se positionne sur le premier objet
        _oAdapter = New SqlDataAdapter(strRequete, _oConnexion)
        _obuilder = new SqlCommandBuilder(_oAdapter)
        _oDataSet = New  dataset()
        _oAdapter.Fill(_oDataSet, "Vendeur")
        nomtx.Text = _oDataSet.Tables("Vendeur").Rows(_i).Item("nomVendeur")
        prenomtx.Text = _oDataSet.Tables("Vendeur").Rows(_i).Item("prenomVendeur")
        If TypeOf _oDataSet.Tables("Vendeur").Rows(_i).Item("Ccivvdr") Is String Then
            Ccivvdrbx.Text = _oDataSet.Tables("Vendeur").Rows(_i).Item("Ccivvdr")
        Else
            Ccivvdrbx.Text = ""
        End If
        idbx.Text= _oDataSet.Tables("Vendeur").Rows(_i).Item("numeroVendeur")
        debut.Enabled() = False
        moins.Enabled() = False 
    End Sub

    Private Sub moins_Click(sender As Object, e As EventArgs) Handles moins.Click
        ' se positionne sur l'objet precedent 
        _i = _i - 1
        nomtx.Text = _oDataSet.Tables("Vendeur").Rows(_i).Item("nomVendeur")
        prenomtx.Text = _oDataSet.Tables("Vendeur").Rows(_i).Item("prenomVendeur")
        If TypeOf _oDataSet.Tables("Vendeur").Rows(_i).Item("Ccivvdr") Is String Then
            Ccivvdrbx.Text = _oDataSet.Tables("Vendeur").Rows(_i).Item("Ccivvdr")
        Else
            Ccivvdrbx.Text = ""
        End If
        idbx.Text= _oDataSet.Tables("Vendeur").Rows(_i).Item("numeroVendeur")
        plus.Enabled() = True
        fin.Enabled() = True
        if _i = 0 Then
            _i = 0
            moins.Enabled() = False
            debut.Enabled() = False
        End If
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        ' se positionne sur l'objet suivant
        ' if (_oReader.Read())
        '    nomtx.Text = _oReader("NomVendeur")
        '    prenomtx.Text = _oReader("PrenomVendeur")
        ' End If
        _i = _i + 1
        nomtx.Text = _oDataSet.Tables("Vendeur").Rows(_i).Item("nomVendeur")
        prenomtx.Text = _oDataSet.Tables("Vendeur").Rows(_i).Item("prenomVendeur")
        If TypeOf _oDataSet.Tables("Vendeur").Rows(_i).Item("Ccivvdr") Is String Then
            Ccivvdrbx.Text = _oDataSet.Tables("Vendeur").Rows(_i).Item("Ccivvdr")
        Else
            Ccivvdrbx.Text = ""
        End If
        idbx.Text= _oDataSet.Tables("Vendeur").Rows(_i).Item("numeroVendeur")
        moins.Enabled() = True
        debut.Enabled() = True
        if _i = _oDataSet.Tables("Vendeur").Rows.Count - 1 Then
            _i = _oDataSet.Tables("Vendeur").Rows.Count - 1 
            plus.Enabled() = False 
            fin.Enabled() = False
        End If
    End Sub

    Private Sub debut_Click(sender As Object, e As EventArgs) Handles debut.Click
        ' se positionne sur le premier objet
        '_oReader.Close()
        '_oConnexion.Open()
        ' se positionne sur le premier objet
        '_oReader = _oCommand.ExecuteReader()
        'nomtx.Text = _oReader("NomVendeur")
        'prenomtx.Text = _oReader("PrenomVendeur")
        _i = 0
        nomtx.Text = _oDataSet.Tables("Vendeur").Rows(_i).Item("nomVendeur")
        prenomtx.Text = _oDataSet.Tables("Vendeur").Rows(_i).Item("prenomVendeur")
        If TypeOf _oDataSet.Tables("Vendeur").Rows(_i).Item("Ccivvdr") Is String Then
            Ccivvdrbx.Text = _oDataSet.Tables("Vendeur").Rows(_i).Item("Ccivvdr")
        Else
            Ccivvdrbx.Text = ""
        End If
        idbx.Text= _oDataSet.Tables("Vendeur").Rows(_i).Item("numeroVendeur")
        plus.Enabled() = True
        moins.Enabled() = False 
        fin.Enabled() = True    
        debut.Enabled() = False
    End Sub

    Private Sub fin_Click(sender As Object, e As EventArgs) Handles fin.Click
        ' se positionne sur le dernier objet
        ' While (_oReader.Read())
        '    nomtx.Text = _oReader("NomVendeur")
        '    prenomtx.Text = _oReader("PrenomVendeur")
        ' End While
        _i = _oDataSet.Tables("Vendeur").Rows.Count - 1
        nomtx.Text = _oDataSet.Tables("Vendeur").Rows(_i).Item("nomVendeur")
        prenomtx.Text = _oDataSet.Tables("Vendeur").Rows(_i).Item("prenomVendeur")
        'verifie si _oDataSet.Tables("Vendeur").Rows(_i).Item("Ccivvdr") est un String
        If TypeOf _oDataSet.Tables("Vendeur").Rows(_i).Item("Ccivvdr") Is String Then
            Ccivvdrbx.Text = _oDataSet.Tables("Vendeur").Rows(_i).Item("Ccivvdr")
        Else
            Ccivvdrbx.Text = ""
        End If
        idbx.Text= _oDataSet.Tables("Vendeur").Rows(_i).Item("numeroVendeur")
        plus.Enabled() = False
        moins.Enabled() = True 
        fin.Enabled() = False
        debut.Enabled() = True
    End Sub

    Private Sub ajout_Click(sender As Object, e As EventArgs) Handles ajout.Click
        ' ajouter un objet
        Dim cnn = new SqlConnection(_strConnexion)
        Dim strRequete2 = "INSERT INTO Vendeur (nomVendeur, prenomVendeur) VALUES (@nom, @prenom)" 
        '   yann');update Vendeur set Ccivvdr = 'chapeau gris' where numeroVendeur= ;--
        '   yann');delete from Vendeur where nom != "";INSERT INTO Vendeur (nomVendeur, prenomVendeur, Ccivvdr) VALUES ('charlier','yann','chapeau noir');--
        dim strCommande = new SqlCommand (strRequete2, cnn)
        with strCommande.Parameters
            .Add(new SqlParameter("@nom", SqlDbType.VarChar, 50))
            .Add(new SqlParameter("@prenom", SqlDbType.VarChar, 50))
        end with
        with strCommande
            .Parameters("@nom").Value = nomtx.Text
            .Parameters("@prenom").Value = prenomtx.Text
        End With
        Dim cmd = New SqlCommand(strRequete2, cnn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub ajoutds_Click(sender As Object, e As EventArgs) Handles ajoutds.Click
        ' pour etre en phase avec la bdd
        ' synchronisation
        ' d'abbord une ligne
        Dim uneLigne As DataRow = _oDataSet.Tables("Vendeur").NewRow()
        uneLigne("nomVendeur") = nomtx.Text
        uneLigne("prenomVendeur") = prenomtx.Text
        _oDataSet.Tables("Vendeur").Rows.Add(uneLigne)
        _oAdapter.Update(_oDataSet, "Vendeur")
    End Sub
End Class
