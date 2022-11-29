' ----------------------------------------
'| Auteur : CLEMENT Pierre (INFO 25)      |
'|                                        |
'| Date : 27/11/2022                      |
'|                                        |
'| Utilite :                              |
'| Le Programme permet de jouer           |
'| des parties de morpion contre un ami.  |
'| Le jeu est sous le thème de Noël       |
' ----------------------------------------

Imports System.Threading

Public Class Morpion
    ' Libs
    Private random As New Random

    ' Vars
    Private morpion(3, 3), case_remplie, joueur_actuel, nombre_partie As Integer

    ' Couleurs
    Private ReadOnly colorError As Color = Color.IndianRed
    Private ReadOnly colorReset As Color = Color.White

    ' Images
    Private ReadOnly img_vide = My.Resources.vide
    Private ReadOnly img_question_mark = My.Resources.question_mark
    Private ReadOnly img_player1 = My.Resources.player1
    Private ReadOnly img_player1_diagonal1 = My.Resources.player1_diagonal1
    Private ReadOnly img_player1_diagonal2 = My.Resources.player1_diagonal2
    Private ReadOnly img_player1_horizontal = My.Resources.player1_horizontal
    Private ReadOnly img_player1_vertical = My.Resources.player1_vertical
    Private ReadOnly img_player2 = My.Resources.player2
    Private ReadOnly img_player2_diagonal1 = My.Resources.player2_diagonal1
    Private ReadOnly img_player2_diagonal2 = My.Resources.player2_diagonal2
    Private ReadOnly img_player2_horizontal = My.Resources.player2_horizontal
    Private ReadOnly img_player2_vertical = My.Resources.player2_vertical

    Private Sub Morpion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialise les variables et le form
        TB_joueur1_score.Text = 0
        TB_joueur2_score.Text = 0
        RB_1_partie.Checked = True
        nombre_partie = 1
        RB_joueur1_premier.Checked = True
        L_joueur_actuel.Text = "Joueur 1"
        joueur_actuel = 1
        PB_joueur_actuel.Image = img_player1
        L_parties_restantes.Text = "Partie(s) restante(s) : " & nombre_partie
        L_victoire.ResetText()
        TB_choix_nb_partie.Hide()
        L_choix_nb_partie.Hide()
        Changer_Actif_Morpion(False)

        ' Prend en compte l'évènement de choix de joueur
        For Each rb As RadioButton In GB_premier_joueur.Controls.OfType(Of RadioButton)()
            AddHandler rb.CheckedChanged, AddressOf RB_premier_joueur_CheckedChanged
        Next

        ' Prend en compte l'évènement de choix de nombre de partie(s)
        For Each rb As RadioButton In GB_choix_nb_partie.Controls.OfType(Of RadioButton)()
            AddHandler rb.CheckedChanged, AddressOf RB_choix_nb_partie_CheckedChanged
        Next
    End Sub

    Private Sub Vider_Morpion()
        ' Vide toute les variables et l'affichage
        ' lié au morpion

        case_remplie = 0

        ' Remplie le tableau d'un ensemble vide
        For i = 0 To 2
            For j = 0 To 2
                morpion(i, j) = 0
            Next
        Next

        ' Vide les images
        PB_1_1.Image = img_vide
        PB_1_2.Image = img_vide
        PB_1_3.Image = img_vide
        PB_2_1.Image = img_vide
        PB_2_2.Image = img_vide
        PB_2_3.Image = img_vide
        PB_3_1.Image = img_vide
        PB_3_2.Image = img_vide
        PB_3_3.Image = img_vide
    End Sub

    Private Sub Changer_Actif_Fin_Partie(bool As Boolean)
        ' Change l'actif des cases de morpion a la fin d'une partie
        ' en fonction de la valeur envoyée
        PB_1_1.Enabled = bool
        PB_1_2.Enabled = bool
        PB_1_3.Enabled = bool
        PB_2_1.Enabled = bool
        PB_2_2.Enabled = bool
        PB_2_3.Enabled = bool
        PB_3_1.Enabled = bool
        PB_3_2.Enabled = bool
        PB_3_3.Enabled = bool
        BT_Jouer.Enabled = Not bool
    End Sub

    Private Sub Verification_Partie_Gagnee()
        ' Methode de vérification des conditions de vitctoire

        Dim j As Integer
        Dim horizontal, horizontal1, horizontal2, horizontal3, vertical, vertical1, vertical2, vertical3, diagonal, diagonal1, diagonal2, egalite, victoire As Boolean
        egalite = True

        ' Conditions Joueur 1
        j = 1
        horizontal1 = morpion(0, 0) = j And morpion(0, 1) = j And morpion(0, 2) = j
        horizontal2 = morpion(1, 0) = j And morpion(1, 1) = j And morpion(1, 2) = j
        horizontal3 = morpion(2, 0) = j And morpion(2, 1) = j And morpion(2, 2) = j
        vertical1 = morpion(0, 0) = j And morpion(1, 0) = j And morpion(2, 0) = j
        vertical2 = morpion(0, 1) = j And morpion(1, 1) = j And morpion(2, 1) = j
        vertical3 = morpion(0, 2) = j And morpion(1, 2) = j And morpion(2, 2) = j
        diagonal1 = morpion(0, 0) = j And morpion(1, 1) = j And morpion(2, 2) = j
        diagonal2 = morpion(2, 0) = j And morpion(1, 1) = j And morpion(0, 2) = j
        horizontal = horizontal1 Or horizontal2 Or horizontal3
        vertical = vertical1 Or vertical2 Or vertical3
        diagonal = diagonal1 Or diagonal2
        If horizontal Or vertical Or diagonal Then
            If horizontal1 Then
                PB_1_1.Image = img_player1_horizontal
                PB_1_2.Image = img_player1_horizontal
                PB_1_3.Image = img_player1_horizontal
            ElseIf horizontal2 Then
                PB_2_1.Image = img_player1_horizontal
                PB_2_2.Image = img_player1_horizontal
                PB_2_3.Image = img_player1_horizontal
            ElseIf horizontal3 Then
                PB_3_1.Image = img_player1_horizontal
                PB_3_2.Image = img_player1_horizontal
                PB_3_3.Image = img_player1_horizontal
            ElseIf vertical1 Then
                PB_1_1.Image = img_player1_vertical
                PB_2_1.Image = img_player1_vertical
                PB_3_1.Image = img_player1_vertical
            ElseIf vertical2 Then
                PB_1_2.Image = img_player1_vertical
                PB_2_2.Image = img_player1_vertical
                PB_3_2.Image = img_player1_vertical
            ElseIf vertical3 Then
                PB_1_3.Image = img_player1_vertical
                PB_2_3.Image = img_player1_vertical
                PB_3_3.Image = img_player1_vertical
            ElseIf diagonal1 Then
                PB_1_1.Image = img_player1_diagonal1
                PB_2_2.Image = img_player1_diagonal1
                PB_3_3.Image = img_player1_diagonal1
            ElseIf diagonal2 Then
                PB_3_1.Image = img_player1_diagonal2
                PB_2_2.Image = img_player1_diagonal2
                PB_1_3.Image = img_player1_diagonal2
            End If
            Changer_Actif_Fin_Partie(False)
            TB_joueur1_score.Text += 1
            nombre_partie -= 1
            L_parties_restantes.Text = "Partie(s) restante(s) : " & nombre_partie
            egalite = False
            victoire = True
            L_victoire.Text = "Partie " & Val(TB_joueur1_score.Text) + Val(TB_joueur2_score.Text) & " remportée par " & TB_joueur1.Text & " !"
        End If

        ' Conditions Joueur 2
        j = 2
        horizontal1 = morpion(0, 0) = j And morpion(0, 1) = j And morpion(0, 2) = j
        horizontal2 = morpion(1, 0) = j And morpion(1, 1) = j And morpion(1, 2) = j
        horizontal3 = morpion(2, 0) = j And morpion(2, 1) = j And morpion(2, 2) = j
        vertical1 = morpion(0, 0) = j And morpion(1, 0) = j And morpion(2, 0) = j
        vertical2 = morpion(0, 1) = j And morpion(1, 1) = j And morpion(2, 1) = j
        vertical3 = morpion(0, 2) = j And morpion(1, 2) = j And morpion(2, 2) = j
        diagonal1 = morpion(0, 0) = j And morpion(1, 1) = j And morpion(2, 2) = j
        diagonal2 = morpion(2, 0) = j And morpion(1, 1) = j And morpion(0, 2) = j
        horizontal = horizontal1 Or horizontal2 Or horizontal3
        vertical = vertical1 Or vertical2 Or vertical3
        diagonal = diagonal1 Or diagonal2
        If horizontal Or vertical Or diagonal Then
            If morpion(0, 0) = j And morpion(0, 1) = j And morpion(0, 2) = j Then
                PB_1_1.Image = img_player2_horizontal
                PB_1_2.Image = img_player2_horizontal
                PB_1_3.Image = img_player2_horizontal
            End If
            If morpion(1, 0) = j And morpion(1, 1) = j And morpion(1, 2) = j Then
                PB_2_1.Image = img_player2_horizontal
                PB_2_2.Image = img_player2_horizontal
                PB_2_3.Image = img_player2_horizontal
            End If
            If morpion(2, 0) = j And morpion(2, 1) = j And morpion(2, 2) = j Then
                PB_3_1.Image = img_player2_horizontal
                PB_3_2.Image = img_player2_horizontal
                PB_3_3.Image = img_player2_horizontal
            End If
            If morpion(0, 0) = j And morpion(1, 0) = j And morpion(2, 0) = j Then
                PB_1_1.Image = img_player2_vertical
                PB_2_1.Image = img_player2_vertical
                PB_3_1.Image = img_player2_vertical
            End If
            If morpion(0, 1) = j And morpion(1, 1) = j And morpion(2, 1) = j Then
                PB_1_2.Image = img_player2_vertical
                PB_2_2.Image = img_player2_vertical
                PB_3_2.Image = img_player2_vertical
            End If
            If morpion(0, 2) = j And morpion(1, 2) = j And morpion(2, 2) = j Then
                PB_1_3.Image = img_player2_vertical
                PB_2_3.Image = img_player2_vertical
                PB_3_3.Image = img_player2_vertical
            End If
            If morpion(0, 0) = j And morpion(1, 1) = j And morpion(2, 2) = j Then
                PB_1_1.Image = img_player2_diagonal1
                PB_2_2.Image = img_player2_diagonal1
                PB_3_3.Image = img_player2_diagonal1
            End If
            If morpion(2, 0) = j And morpion(1, 1) = j And morpion(0, 2) = j Then
                PB_3_1.Image = img_player2_diagonal2
                PB_2_2.Image = img_player2_diagonal2
                PB_1_3.Image = img_player2_diagonal2
            End If
            Changer_Actif_Fin_Partie(False)
            TB_joueur2_score.Text += 1
            nombre_partie -= 1
            L_parties_restantes.Text = "Partie(s) restante(s) : " & nombre_partie
            egalite = False
            victoire = True
            L_victoire.Text = "Partie " & Val(TB_joueur1_score.Text) + Val(TB_joueur2_score.Text) & " remportée par " & TB_joueur2.Text & " !"
        End If

        ' Condition égalité
        If egalite = True And case_remplie = 9 Then
            Changer_Actif_Fin_Partie(False)
            nombre_partie -= 1
            L_parties_restantes.Text = "Partie(s) restante(s) : " & nombre_partie
            L_victoire.Text = TB_joueur1.Text & " et " & TB_joueur2.Text & " ont fait une égalité !"
            victoire = True
        End If

        ' Affichage des résultats de fin de partie
        If nombre_partie = 0 Then
            BT_Jouer.Enabled = False
            Dim j1 As Integer = Val(TB_joueur1_score.Text)
            Dim j2 As Integer = Val(TB_joueur2_score.Text)
            Select Case j1
                Case = j2
                    L_victoire.Text = TB_joueur1.Text & " et " & TB_joueur2.Text & " ont fait une égalité : " & j1 & " à " & j2 & " !"
                Case < j2
                    L_victoire.Text = TB_joueur2.Text & " a " & Verbe_De_Victoire_Aleatoire() & " " & TB_joueur1.Text & " : " & j2 & " à " & j1 & " !"
                Case > j2
                    L_victoire.Text = TB_joueur1.Text & " a " & Verbe_De_Victoire_Aleatoire() & " " & TB_joueur2.Text & " : " & j1 & " à " & j2 & " !"
            End Select
        End If

        ' Si tour du bot ensuite, agit
        If CB_bot.Checked = True And joueur_actuel = 2 And case_remplie < 9 And victoire = False Then
            Changer_Actif_Fin_Partie(False)
            BT_Jouer.Enabled = False
            Bot_Active_Case_Dispo()
        ElseIf CB_bot.Checked = True And joueur_actuel = 1 And case_remplie < 9 And victoire = False Then
            Changer_Actif_Fin_Partie(True)
            BT_Reset.Enabled = True
        End If

    End Sub

    Private Sub Changer_Actif_Morpion(bool As Boolean)
        ' Change l'actif des cases de morpion
        ' en fonction de la valeur envoyée
        PB_1_1.Enabled = bool
        PB_1_2.Enabled = bool
        PB_1_3.Enabled = bool
        PB_2_1.Enabled = bool
        PB_2_2.Enabled = bool
        PB_2_3.Enabled = bool
        PB_3_1.Enabled = bool
        PB_3_2.Enabled = bool
        PB_3_3.Enabled = bool
        BT_Jouer.Enabled = Not bool
        BT_Reset.Enabled = bool
        If bool = False Then
            PB_grille.Hide()
        Else
            PB_grille.Show()
        End If
    End Sub

    Private Sub Changer_Actif_Config(bool As Boolean)
        ' Change l'actif de configuration de parties
        ' en fonction de la valeur envoyée
        GB_choix_nb_partie.Enabled = bool
        GB_premier_joueur.Enabled = bool
        GB_partie_gagnee.Enabled = bool
        If bool = False Then
            BT_Jouer.Text = "Continuer"
        Else
            BT_Jouer.Text = "Commencer la partie"
        End If
    End Sub

    Private Sub Changement_Visuel_Joueur()
        ' Methode qui change visuellement l'affichage en fonction
        ' du joueur actif
        If joueur_actuel = 1 Then
            L_joueur_actuel.Text = TB_joueur1.Text
            PB_joueur_actuel.Image = img_player1
        ElseIf joueur_actuel = 2 Then
            L_joueur_actuel.Text = TB_joueur2.Text
            PB_joueur_actuel.Image = img_player2
        End If
    End Sub

    Private Sub Afficher_MessageBox_Information(msg As String)
        ' Affichage d'un pop-up d'information
        MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
    End Sub

    Private Sub PB_Case_Click(sender As Object, e As EventArgs) Handles PB_1_1.Click, PB_1_2.Click, PB_1_3.Click, PB_2_1.Click, PB_2_2.Click, PB_2_3.Click, PB_3_1.Click, PB_3_2.Click, PB_3_3.Click
        ' Evenement de clique d'une des cases du morpion
        Dim l_text As String = sender.name.Chars(3)
        Dim c_text As String = sender.name.Chars(5)
        Dim l As Integer = Val(l_text) - 1
        Dim c As Integer = Val(c_text) - 1

        ' Condition pour savoir si l'on peux ou non attribuer la case
        ' et a quel joueur
        If morpion(l, c) = 0 Then
            If joueur_actuel = 1 Then
                sender.Image = img_player1
                morpion(l, c) = 1
                joueur_actuel = 2
            ElseIf joueur_actuel = 2 Then
                sender.Image = img_player2
                morpion(l, c) = 2
                joueur_actuel = 1
            End If
            Changement_Visuel_Joueur()
            case_remplie += 1
            Verification_Partie_Gagnee()
        End If
    End Sub

    Private Sub BT_Reset_Click(sender As Object, e As EventArgs) Handles BT_Reset.Click
        ' Evenement de clique du bouton de réinitialisation de partie

        ' Confirmation en cas de réinitialisation précoce
        If nombre_partie <> 0 Then
            If MessageBox.Show("Souhaitez-vous vraiment réinitialiser la partie ? Elle n'est pourtant pas terminée !", "Réinitialiser", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        ' Changement visuel
        Changer_Actif_Morpion(False)
        Changer_Actif_Config(True)
        Vider_Morpion()
        TB_joueur1_score.Text = 0
        TB_joueur2_score.Text = 0

        ' Réatribu en fonction du joueur coché
        If RB_joueur1_premier.Checked = True Then
            PB_joueur_actuel.Image = img_player1
            L_joueur_actuel.Text = TB_joueur1.Text
            joueur_actuel = 1
        ElseIf RB_joueur2_premier.Checked = True Then
            PB_joueur_actuel.Image = img_player2
            L_joueur_actuel.Text = TB_joueur2.Text
            joueur_actuel = 2
        ElseIf RB_random_premier.Checked = True Then
            PB_joueur_actuel.Image = img_question_mark
            L_joueur_actuel.Text = RB_random_premier.Text
            joueur_actuel = random.Next(1, 3)
        End If

        ' Réatribu en fonction du nombre de parties coché
        If RB_1_partie.Checked = True Then
            nombre_partie = 1
        ElseIf RB_5_parties.Checked = True Then
            nombre_partie = 5
        ElseIf RB_choix_nb_partie.Checked = True Then
            nombre_partie = Val(TB_choix_nb_partie.Text)
        End If

        ' Changement visuel
        L_parties_restantes.Text = "Partie(s) restante(s) : " & nombre_partie
        L_victoire.ResetText()
    End Sub

    Private Sub BT_Jouer_Click(sender As Object, e As EventArgs) Handles BT_Jouer.Click
        ' Evenement de clique du bouton de lancement de partie

        ' Vérifie que les inputs soient bien saisis
        If TB_joueur1.Text Is "" Or TB_joueur2.Text Is "" Or (RB_choix_nb_partie.Checked = True And TB_choix_nb_partie.Text Is "") Then
            If TB_joueur1.Text Is "" And TB_joueur2.Text Is "" And (RB_choix_nb_partie.Checked = True And TB_choix_nb_partie.Text Is "") Then
                Afficher_MessageBox_Information("Saisissez une valeur pour le Joueur 1 et 2 ainsi que pour le nombre de parties !")
                TB_joueur1.BackColor = colorError
                TB_joueur2.BackColor = colorError
                TB_choix_nb_partie.BackColor = colorError
            ElseIf TB_joueur1.Text Is "" And (RB_choix_nb_partie.Checked = True And TB_choix_nb_partie.Text Is "") Then
                Afficher_MessageBox_Information("Saisissez une valeur pour le Joueur 1 ainsi que pour le nombre de parties !")
                TB_joueur1.BackColor = colorError
                TB_choix_nb_partie.BackColor = colorError
            ElseIf TB_joueur2.Text Is "" And (RB_choix_nb_partie.Checked = True And TB_choix_nb_partie.Text Is "") Then
                Afficher_MessageBox_Information("Saisissez une valeur pour le Joueur 2 ainsi que pour le nombre de parties !")
                TB_joueur2.BackColor = colorError
                TB_choix_nb_partie.BackColor = colorError
            ElseIf TB_joueur1.Text Is "" And TB_joueur2.Text Is "" Then
                Afficher_MessageBox_Information("Saisissez une valeur pour le Joueur 1 et 2 !")
                TB_joueur1.BackColor = colorError
                TB_joueur2.BackColor = colorError
            ElseIf TB_joueur1.Text Is "" Then
                Afficher_MessageBox_Information("Saisissez une valeur pour le Joueur 1 !")
                TB_joueur1.BackColor = colorError
            ElseIf TB_joueur2.Text Is "" Then
                Afficher_MessageBox_Information("Saisissez une valeur pour le Joueur 2 !")
                TB_joueur2.BackColor = colorError
            ElseIf RB_choix_nb_partie.Checked = True And TB_choix_nb_partie.Text Is "" Then
                Afficher_MessageBox_Information("Saisissez une valeur pour le nombre de parties !")
                TB_choix_nb_partie.BackColor = colorError
            End If
            Exit Sub
        End If

        ' Changement visuel
        Changement_Visuel_Joueur()
        Changer_Actif_Morpion(True)
        Changer_Actif_Config(False)
        Vider_Morpion()
        L_victoire.ResetText()

        ' Si bot en premier il agit
        If CB_bot.Checked = True And joueur_actuel = 2 Then
            Changer_Actif_Fin_Partie(False)
            BT_Jouer.Enabled = False
            Bot_Active_Case_Dispo()
        End If
    End Sub
    Private Sub RB_choix_nb_partie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Change les variables et le form
        ' en fonction du RB coché
        Dim rb As RadioButton = DirectCast(sender, RadioButton)
        If rb Is RB_1_partie Then
            TB_choix_nb_partie.Hide()
            L_choix_nb_partie.Hide()
            RB_choix_nb_partie.Text = "Je choisis"
            nombre_partie = 1
        ElseIf rb Is RB_5_parties Then
            TB_choix_nb_partie.Hide()
            L_choix_nb_partie.Hide()
            RB_choix_nb_partie.Text = "Je choisis"
            nombre_partie = 5
        ElseIf rb Is RB_choix_nb_partie Then
            TB_choix_nb_partie.Show()
            L_choix_nb_partie.Show()
            RB_choix_nb_partie.ResetText()
            TB_choix_nb_partie.ResetText()
            TB_choix_nb_partie.BackColor = colorReset
            nombre_partie = Val(TB_choix_nb_partie.Text)
        End If
        L_parties_restantes.Text = "Partie(s) restante(s) : " & nombre_partie
    End Sub


    Private Sub Wait(interval As Integer)
        ' Boucle qui permet d'attendre un interval donné (ms)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Laisse l'application responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    Private Sub Bot_Active_Case_Dispo()
        ' Le bot joue comme un joueur avec un délai d'attente
        BT_Reset.Enabled = False
        Wait(random.Next(500, 1000))
        While True
            Dim l As Integer = random.Next(0, 3)
            Dim c As Integer = random.Next(0, 3)

            If morpion(l, c) = 0 Then

                If l = 0 And c = 0 Then
                    PB_1_1.Image = img_player2
                ElseIf l = 0 And c = 1 Then
                    PB_1_2.Image = img_player2
                ElseIf l = 0 And c = 2 Then
                    PB_1_3.Image = img_player2

                ElseIf l = 1 And c = 0 Then
                    PB_2_1.Image = img_player2
                ElseIf l = 1 And c = 1 Then
                    PB_2_2.Image = img_player2
                ElseIf l = 1 And c = 2 Then
                    PB_2_3.Image = img_player2

                ElseIf l = 2 And c = 0 Then
                    PB_3_1.Image = img_player2
                ElseIf l = 2 And c = 1 Then
                    PB_3_2.Image = img_player2
                ElseIf l = 2 And c = 2 Then
                    PB_3_3.Image = img_player2
                End If

                morpion(l, c) = 2
                joueur_actuel = 1
                Changement_Visuel_Joueur()
                case_remplie += 1
                Verification_Partie_Gagnee()
                Exit While
            End If
        End While
        BT_Reset.Enabled = True
    End Sub

    Private Sub RB_premier_joueur_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Change les variables et le form
        ' en fonction du RB coché
        Dim rb As RadioButton = DirectCast(sender, RadioButton)
        L_joueur_actuel.Text = rb.Text
        If rb Is RB_joueur1_premier Then
            PB_joueur_actuel.Image = img_player1
            joueur_actuel = 1
        ElseIf rb Is RB_joueur2_premier Then
            PB_joueur_actuel.Image = img_player2
            joueur_actuel = 2
        ElseIf rb Is RB_random_premier Then
            PB_joueur_actuel.Image = img_question_mark
            joueur_actuel = random.Next(1, 3)
        End If
    End Sub

    Private Sub TB_joueur1_TextChanged(sender As Object, e As EventArgs) Handles TB_joueur1.TextChanged
        ' Evenement de changement de valeur dans un input
        TB_joueur1.BackColor = colorReset
        RB_joueur1_premier.Text = sender.text
        Changement_Visuel_Joueur()
    End Sub

    Private Sub TB_joueur2_TextChanged(sender As Object, e As EventArgs) Handles TB_joueur2.TextChanged
        ' Evenement de changement de valeur dans un input
        TB_joueur1.BackColor = colorReset
        RB_joueur2_premier.Text = sender.text
        Changement_Visuel_Joueur()
    End Sub

    Private Sub TB_choix_nb_partie_TextChanged(sender As Object, e As EventArgs) Handles TB_choix_nb_partie.TextChanged
        ' Evenement de changement de valeur dans un input

        ' Empêche les 0 en première position
        If sender.text IsNot "" Then
            If sender.text.chars(0) = "0" Then
                Dim res As String = ""
                If sender.text.length <> 1 Then
                    For i = 0 To sender.text.length - 1
                        If i <> 0 Then
                            res &= sender.text.chars(i)
                        End If
                    Next
                    sender.text = res
                Else
                    sender.text = ""
                End If

            End If
        End If

        ' Attribue le nombre de partie
        TB_choix_nb_partie.BackColor = colorReset
        If sender.text IsNot "" Then
            nombre_partie = Val(sender.text)
        Else
            nombre_partie = 0
        End If
        L_parties_restantes.Text = "Partie(s) restante(s) : " & nombre_partie

    End Sub

    Private Sub CB_bot_CheckedChanged(sender As Object, e As EventArgs) Handles CB_bot.CheckedChanged
        ' Changement visuel quand la case est cochée ou décochée
        If CB_bot.Checked = True Then
            TB_joueur2.Enabled = False
            TB_joueur2.Text = "Bot"
        Else
            TB_joueur2.Enabled = True
            TB_joueur2.Text = "Joueur 2"
        End If
    End Sub

    Private Sub TB_choix_nb_partie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_choix_nb_partie.KeyPress
        ' Evenement quand une touche est pressée
        ' sur un input, applique des filtres

        ' Chiffres uniquement
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Function Verbe_De_Victoire_Aleatoire()
        ' Différents verbes choisis aléatoirement
        ' lié à la victoire d'un joueur face à l'autre
        Dim verbes() As String = {
            "abattu",
            "anéanti",
            "assassiné",
            "corrigé",
            "dégommé",
            "démoli",
            "descendu",
            "détruit",
            "éclaté",
            "écrasé",
            "étripé",
            "fait fléchir",
            "fait la peau à",
            "farci",
            "guillotiné",
            "infligé une rouste à",
            "lapidé",
            "liquidé",
            "oblitéré",
            "occi",
            "ouvert",
            "pacifié",
            "puni",
            "roulé sur",
            "supprimé",
            "surplombé",
            "triomphé contre",
            "trucidé",
            "vaincu",
            "zigouillé"
        }
        Return verbes(random.Next(0, verbes.Length - 1))
    End Function

    Private Sub PB_quitter_Click(sender As Object, e As EventArgs) Handles PB_quitter.Click
        ' Demande avant de quitte l'application
        If MessageBox.Show("Souhaitez-vous vraiment quitter l'application ?", "Fermer le programme", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            Application.Exit()
            End
        End If
    End Sub
End Class