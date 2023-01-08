<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.moins = New System.Windows.Forms.Button()
        Me.nom = New System.Windows.Forms.Label()
        Me.nomtx = New System.Windows.Forms.TextBox()
        Me.prenomtx = New System.Windows.Forms.TextBox()
        Me.prenom = New System.Windows.Forms.Label()
        Me.debut = New System.Windows.Forms.Button()
        Me.fin = New System.Windows.Forms.Button()
        Me.plus = New System.Windows.Forms.Button()
        Me.ajoutds = New System.Windows.Forms.Button()
        Me.ajout = New System.Windows.Forms.Button()
        Me.idbx = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.Label()
        Me.Ccivvdrbx = New System.Windows.Forms.TextBox()
        Me.Ccivvdr = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'moins
        '
        Me.moins.Location = New System.Drawing.Point(312, 15)
        Me.moins.Name = "moins"
        Me.moins.Size = New System.Drawing.Size(75, 23)
        Me.moins.TabIndex = 0
        Me.moins.Text = "<"
        Me.moins.UseVisualStyleBackColor = True
        '
        'nom
        '
        Me.nom.AutoSize = True
        Me.nom.Location = New System.Drawing.Point(27, 15)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(27, 13)
        Me.nom.TabIndex = 1
        Me.nom.Text = "nom"
        '
        'nomtx
        '
        Me.nomtx.Location = New System.Drawing.Point(95, 12)
        Me.nomtx.Name = "nomtx"
        Me.nomtx.Size = New System.Drawing.Size(100, 20)
        Me.nomtx.TabIndex = 2
        '
        'prenomtx
        '
        Me.prenomtx.Location = New System.Drawing.Point(95, 43)
        Me.prenomtx.Name = "prenomtx"
        Me.prenomtx.Size = New System.Drawing.Size(100, 20)
        Me.prenomtx.TabIndex = 5
        '
        'prenom
        '
        Me.prenom.AutoSize = True
        Me.prenom.Location = New System.Drawing.Point(12, 46)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(42, 13)
        Me.prenom.TabIndex = 4
        Me.prenom.Text = "prenom"
        '
        'debut
        '
        Me.debut.Location = New System.Drawing.Point(312, 44)
        Me.debut.Name = "debut"
        Me.debut.Size = New System.Drawing.Size(75, 23)
        Me.debut.TabIndex = 3
        Me.debut.Text = "<<<"
        Me.debut.UseVisualStyleBackColor = True
        '
        'fin
        '
        Me.fin.Location = New System.Drawing.Point(393, 44)
        Me.fin.Name = "fin"
        Me.fin.Size = New System.Drawing.Size(75, 23)
        Me.fin.TabIndex = 7
        Me.fin.Text = ">>>"
        Me.fin.UseVisualStyleBackColor = True
        '
        'plus
        '
        Me.plus.Location = New System.Drawing.Point(393, 15)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(75, 23)
        Me.plus.TabIndex = 6
        Me.plus.Text = ">"
        Me.plus.UseVisualStyleBackColor = True
        '
        'ajoutds
        '
        Me.ajoutds.Location = New System.Drawing.Point(111, 82)
        Me.ajoutds.Name = "ajoutds"
        Me.ajoutds.Size = New System.Drawing.Size(75, 23)
        Me.ajoutds.TabIndex = 9
        Me.ajoutds.Text = "ajoutds"
        Me.ajoutds.UseVisualStyleBackColor = True
        '
        'ajout
        '
        Me.ajout.Location = New System.Drawing.Point(30, 82)
        Me.ajout.Name = "ajout"
        Me.ajout.Size = New System.Drawing.Size(75, 23)
        Me.ajout.TabIndex = 8
        Me.ajout.Text = "ajout"
        Me.ajout.UseVisualStyleBackColor = True
        '
        'idbx
        '
        Me.idbx.Location = New System.Drawing.Point(384, 215)
        Me.idbx.Name = "idbx"
        Me.idbx.Size = New System.Drawing.Size(100, 20)
        Me.idbx.TabIndex = 11
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(316, 218)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(15, 13)
        Me.id.TabIndex = 10
        Me.id.Text = "id"
        '
        'Ccivvdrbx
        '
        Me.Ccivvdrbx.Location = New System.Drawing.Point(384, 245)
        Me.Ccivvdrbx.Name = "Ccivvdrbx"
        Me.Ccivvdrbx.Size = New System.Drawing.Size(100, 20)
        Me.Ccivvdrbx.TabIndex = 13
        '
        'Ccivvdr
        '
        Me.Ccivvdr.AutoSize = True
        Me.Ccivvdr.Location = New System.Drawing.Point(316, 248)
        Me.Ccivvdr.Name = "Ccivvdr"
        Me.Ccivvdr.Size = New System.Drawing.Size(43, 13)
        Me.Ccivvdr.TabIndex = 12
        Me.Ccivvdr.Text = "Ccivvdr"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Ccivvdrbx)
        Me.Controls.Add(Me.Ccivvdr)
        Me.Controls.Add(Me.idbx)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.ajoutds)
        Me.Controls.Add(Me.ajout)
        Me.Controls.Add(Me.fin)
        Me.Controls.Add(Me.plus)
        Me.Controls.Add(Me.prenomtx)
        Me.Controls.Add(Me.prenom)
        Me.Controls.Add(Me.debut)
        Me.Controls.Add(Me.nomtx)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.moins)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents moins As Button
    Friend WithEvents nomtx As TextBox
    Friend WithEvents prenomtx As TextBox
    Friend WithEvents prenom As Label
    Friend WithEvents debut As Button
    Friend WithEvents fin As Button
    Friend WithEvents plus As Button
    Friend WithEvents nom As Label
    Friend WithEvents ajoutds As Button
    Friend WithEvents ajout As Button
    Friend WithEvents idbx As TextBox
    Friend WithEvents id As Label
    Friend WithEvents Ccivvdrbx As TextBox
    Friend WithEvents Ccivvdr As Label
End Class
