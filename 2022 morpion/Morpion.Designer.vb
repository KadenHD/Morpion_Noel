<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Morpion
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Morpion))
        Me.GB_premier_joueur = New System.Windows.Forms.GroupBox()
        Me.RB_random_premier = New System.Windows.Forms.RadioButton()
        Me.RB_joueur2_premier = New System.Windows.Forms.RadioButton()
        Me.RB_joueur1_premier = New System.Windows.Forms.RadioButton()
        Me.TB_joueur1_score = New System.Windows.Forms.TextBox()
        Me.RB_5_parties = New System.Windows.Forms.RadioButton()
        Me.RB_1_partie = New System.Windows.Forms.RadioButton()
        Me.GB_choix_nb_partie = New System.Windows.Forms.GroupBox()
        Me.L_choix_nb_partie = New System.Windows.Forms.Label()
        Me.TB_choix_nb_partie = New System.Windows.Forms.TextBox()
        Me.RB_choix_nb_partie = New System.Windows.Forms.RadioButton()
        Me.TB_joueur2_score = New System.Windows.Forms.TextBox()
        Me.GB_partie_gagnee = New System.Windows.Forms.GroupBox()
        Me.TB_joueur2 = New System.Windows.Forms.TextBox()
        Me.TB_joueur1 = New System.Windows.Forms.TextBox()
        Me.BT_Jouer = New System.Windows.Forms.Button()
        Me.L_joueur_actuel = New System.Windows.Forms.Label()
        Me.PB_joueur_actuel = New System.Windows.Forms.PictureBox()
        Me.PB_3_3 = New System.Windows.Forms.PictureBox()
        Me.PB_2_1 = New System.Windows.Forms.PictureBox()
        Me.PB_1_3 = New System.Windows.Forms.PictureBox()
        Me.PB_3_2 = New System.Windows.Forms.PictureBox()
        Me.PB_2_3 = New System.Windows.Forms.PictureBox()
        Me.PB_1_2 = New System.Windows.Forms.PictureBox()
        Me.PB_3_1 = New System.Windows.Forms.PictureBox()
        Me.PB_2_2 = New System.Windows.Forms.PictureBox()
        Me.PB_1_1 = New System.Windows.Forms.PictureBox()
        Me.PB_grille = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BT_Reset = New System.Windows.Forms.Button()
        Me.L_parties_restantes = New System.Windows.Forms.Label()
        Me.L_victoire = New System.Windows.Forms.Label()
        Me.PB_quitter = New System.Windows.Forms.PictureBox()
        Me.CB_bot = New System.Windows.Forms.CheckBox()
        Me.GB_premier_joueur.SuspendLayout()
        Me.GB_choix_nb_partie.SuspendLayout()
        Me.GB_partie_gagnee.SuspendLayout()
        CType(Me.PB_joueur_actuel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_3_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_2_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_1_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_3_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_2_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_3_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_2_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_grille, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_quitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_premier_joueur
        '
        Me.GB_premier_joueur.BackColor = System.Drawing.Color.IndianRed
        Me.GB_premier_joueur.Controls.Add(Me.RB_random_premier)
        Me.GB_premier_joueur.Controls.Add(Me.RB_joueur2_premier)
        Me.GB_premier_joueur.Controls.Add(Me.RB_joueur1_premier)
        Me.GB_premier_joueur.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_premier_joueur.Location = New System.Drawing.Point(565, 337)
        Me.GB_premier_joueur.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GB_premier_joueur.Name = "GB_premier_joueur"
        Me.GB_premier_joueur.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GB_premier_joueur.Size = New System.Drawing.Size(169, 111)
        Me.GB_premier_joueur.TabIndex = 32
        Me.GB_premier_joueur.TabStop = False
        Me.GB_premier_joueur.Text = "Qui commence ?"
        '
        'RB_random_premier
        '
        Me.RB_random_premier.AutoSize = True
        Me.RB_random_premier.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_random_premier.Location = New System.Drawing.Point(26, 78)
        Me.RB_random_premier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RB_random_premier.Name = "RB_random_premier"
        Me.RB_random_premier.Size = New System.Drawing.Size(91, 24)
        Me.RB_random_premier.TabIndex = 3
        Me.RB_random_premier.TabStop = True
        Me.RB_random_premier.Text = "Aléatoire"
        Me.RB_random_premier.UseVisualStyleBackColor = True
        '
        'RB_joueur2_premier
        '
        Me.RB_joueur2_premier.AutoSize = True
        Me.RB_joueur2_premier.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_joueur2_premier.Location = New System.Drawing.Point(26, 51)
        Me.RB_joueur2_premier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RB_joueur2_premier.Name = "RB_joueur2_premier"
        Me.RB_joueur2_premier.Size = New System.Drawing.Size(88, 24)
        Me.RB_joueur2_premier.TabIndex = 2
        Me.RB_joueur2_premier.TabStop = True
        Me.RB_joueur2_premier.Text = "Joueur 2"
        Me.RB_joueur2_premier.UseVisualStyleBackColor = True
        '
        'RB_joueur1_premier
        '
        Me.RB_joueur1_premier.AutoSize = True
        Me.RB_joueur1_premier.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_joueur1_premier.Location = New System.Drawing.Point(26, 24)
        Me.RB_joueur1_premier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RB_joueur1_premier.Name = "RB_joueur1_premier"
        Me.RB_joueur1_premier.Size = New System.Drawing.Size(88, 24)
        Me.RB_joueur1_premier.TabIndex = 1
        Me.RB_joueur1_premier.TabStop = True
        Me.RB_joueur1_premier.Text = "Joueur 1"
        Me.RB_joueur1_premier.UseVisualStyleBackColor = True
        '
        'TB_joueur1_score
        '
        Me.TB_joueur1_score.Enabled = False
        Me.TB_joueur1_score.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_joueur1_score.Location = New System.Drawing.Point(119, 28)
        Me.TB_joueur1_score.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_joueur1_score.Name = "TB_joueur1_score"
        Me.TB_joueur1_score.ReadOnly = True
        Me.TB_joueur1_score.Size = New System.Drawing.Size(35, 27)
        Me.TB_joueur1_score.TabIndex = 15
        '
        'RB_5_parties
        '
        Me.RB_5_parties.AutoSize = True
        Me.RB_5_parties.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_5_parties.Location = New System.Drawing.Point(26, 51)
        Me.RB_5_parties.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RB_5_parties.Name = "RB_5_parties"
        Me.RB_5_parties.Size = New System.Drawing.Size(92, 24)
        Me.RB_5_parties.TabIndex = 2
        Me.RB_5_parties.TabStop = True
        Me.RB_5_parties.Text = " 5 parties"
        Me.RB_5_parties.UseVisualStyleBackColor = True
        '
        'RB_1_partie
        '
        Me.RB_1_partie.AutoSize = True
        Me.RB_1_partie.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_1_partie.Location = New System.Drawing.Point(26, 24)
        Me.RB_1_partie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RB_1_partie.Name = "RB_1_partie"
        Me.RB_1_partie.Size = New System.Drawing.Size(81, 24)
        Me.RB_1_partie.TabIndex = 1
        Me.RB_1_partie.TabStop = True
        Me.RB_1_partie.Text = "1 partie"
        Me.RB_1_partie.UseVisualStyleBackColor = True
        '
        'GB_choix_nb_partie
        '
        Me.GB_choix_nb_partie.BackColor = System.Drawing.Color.White
        Me.GB_choix_nb_partie.Controls.Add(Me.L_choix_nb_partie)
        Me.GB_choix_nb_partie.Controls.Add(Me.TB_choix_nb_partie)
        Me.GB_choix_nb_partie.Controls.Add(Me.RB_choix_nb_partie)
        Me.GB_choix_nb_partie.Controls.Add(Me.RB_5_parties)
        Me.GB_choix_nb_partie.Controls.Add(Me.RB_1_partie)
        Me.GB_choix_nb_partie.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_choix_nb_partie.Location = New System.Drawing.Point(565, 221)
        Me.GB_choix_nb_partie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GB_choix_nb_partie.Name = "GB_choix_nb_partie"
        Me.GB_choix_nb_partie.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GB_choix_nb_partie.Size = New System.Drawing.Size(169, 117)
        Me.GB_choix_nb_partie.TabIndex = 31
        Me.GB_choix_nb_partie.TabStop = False
        Me.GB_choix_nb_partie.Text = "Nombre de partie(s)"
        '
        'L_choix_nb_partie
        '
        Me.L_choix_nb_partie.AutoSize = True
        Me.L_choix_nb_partie.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_choix_nb_partie.Location = New System.Drawing.Point(85, 80)
        Me.L_choix_nb_partie.Name = "L_choix_nb_partie"
        Me.L_choix_nb_partie.Size = New System.Drawing.Size(69, 20)
        Me.L_choix_nb_partie.TabIndex = 20
        Me.L_choix_nb_partie.Text = "partie(s)"
        '
        'TB_choix_nb_partie
        '
        Me.TB_choix_nb_partie.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_choix_nb_partie.Location = New System.Drawing.Point(52, 74)
        Me.TB_choix_nb_partie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_choix_nb_partie.MaxLength = 2
        Me.TB_choix_nb_partie.Name = "TB_choix_nb_partie"
        Me.TB_choix_nb_partie.ShortcutsEnabled = False
        Me.TB_choix_nb_partie.Size = New System.Drawing.Size(27, 27)
        Me.TB_choix_nb_partie.TabIndex = 19
        '
        'RB_choix_nb_partie
        '
        Me.RB_choix_nb_partie.AutoSize = True
        Me.RB_choix_nb_partie.Location = New System.Drawing.Point(26, 78)
        Me.RB_choix_nb_partie.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RB_choix_nb_partie.Name = "RB_choix_nb_partie"
        Me.RB_choix_nb_partie.Size = New System.Drawing.Size(93, 24)
        Me.RB_choix_nb_partie.TabIndex = 3
        Me.RB_choix_nb_partie.TabStop = True
        Me.RB_choix_nb_partie.Text = "Je choisis"
        Me.RB_choix_nb_partie.UseVisualStyleBackColor = True
        '
        'TB_joueur2_score
        '
        Me.TB_joueur2_score.Enabled = False
        Me.TB_joueur2_score.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_joueur2_score.Location = New System.Drawing.Point(119, 67)
        Me.TB_joueur2_score.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_joueur2_score.Name = "TB_joueur2_score"
        Me.TB_joueur2_score.ReadOnly = True
        Me.TB_joueur2_score.Size = New System.Drawing.Size(35, 27)
        Me.TB_joueur2_score.TabIndex = 16
        '
        'GB_partie_gagnee
        '
        Me.GB_partie_gagnee.BackColor = System.Drawing.Color.SeaGreen
        Me.GB_partie_gagnee.Controls.Add(Me.CB_bot)
        Me.GB_partie_gagnee.Controls.Add(Me.TB_joueur2)
        Me.GB_partie_gagnee.Controls.Add(Me.TB_joueur1)
        Me.GB_partie_gagnee.Controls.Add(Me.TB_joueur2_score)
        Me.GB_partie_gagnee.Controls.Add(Me.TB_joueur1_score)
        Me.GB_partie_gagnee.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_partie_gagnee.Location = New System.Drawing.Point(565, 103)
        Me.GB_partie_gagnee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GB_partie_gagnee.Name = "GB_partie_gagnee"
        Me.GB_partie_gagnee.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GB_partie_gagnee.Size = New System.Drawing.Size(169, 127)
        Me.GB_partie_gagnee.TabIndex = 30
        Me.GB_partie_gagnee.TabStop = False
        Me.GB_partie_gagnee.Text = "Tableau des Joueurs"
        '
        'TB_joueur2
        '
        Me.TB_joueur2.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_joueur2.Location = New System.Drawing.Point(12, 67)
        Me.TB_joueur2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_joueur2.MaxLength = 10
        Me.TB_joueur2.Name = "TB_joueur2"
        Me.TB_joueur2.Size = New System.Drawing.Size(101, 27)
        Me.TB_joueur2.TabIndex = 18
        Me.TB_joueur2.Text = "Joueur 2"
        '
        'TB_joueur1
        '
        Me.TB_joueur1.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_joueur1.Location = New System.Drawing.Point(12, 28)
        Me.TB_joueur1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TB_joueur1.MaxLength = 10
        Me.TB_joueur1.Name = "TB_joueur1"
        Me.TB_joueur1.Size = New System.Drawing.Size(101, 27)
        Me.TB_joueur1.TabIndex = 17
        Me.TB_joueur1.Text = "Joueur 1"
        '
        'BT_Jouer
        '
        Me.BT_Jouer.BackColor = System.Drawing.Color.IndianRed
        Me.BT_Jouer.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Jouer.Location = New System.Drawing.Point(565, 456)
        Me.BT_Jouer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BT_Jouer.Name = "BT_Jouer"
        Me.BT_Jouer.Size = New System.Drawing.Size(169, 38)
        Me.BT_Jouer.TabIndex = 29
        Me.BT_Jouer.Text = "Commencer la partie"
        Me.BT_Jouer.UseVisualStyleBackColor = False
        '
        'L_joueur_actuel
        '
        Me.L_joueur_actuel.AutoSize = True
        Me.L_joueur_actuel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.L_joueur_actuel.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_joueur_actuel.Location = New System.Drawing.Point(610, 46)
        Me.L_joueur_actuel.Name = "L_joueur_actuel"
        Me.L_joueur_actuel.Size = New System.Drawing.Size(81, 37)
        Me.L_joueur_actuel.TabIndex = 34
        Me.L_joueur_actuel.Text = "Zone"
        '
        'PB_joueur_actuel
        '
        Me.PB_joueur_actuel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PB_joueur_actuel.Location = New System.Drawing.Point(554, 43)
        Me.PB_joueur_actuel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_joueur_actuel.Name = "PB_joueur_actuel"
        Me.PB_joueur_actuel.Size = New System.Drawing.Size(50, 50)
        Me.PB_joueur_actuel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_joueur_actuel.TabIndex = 33
        Me.PB_joueur_actuel.TabStop = False
        '
        'PB_3_3
        '
        Me.PB_3_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PB_3_3.Image = CType(resources.GetObject("PB_3_3.Image"), System.Drawing.Image)
        Me.PB_3_3.Location = New System.Drawing.Point(353, 371)
        Me.PB_3_3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_3_3.Name = "PB_3_3"
        Me.PB_3_3.Size = New System.Drawing.Size(100, 100)
        Me.PB_3_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_3_3.TabIndex = 28
        Me.PB_3_3.TabStop = False
        '
        'PB_2_1
        '
        Me.PB_2_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PB_2_1.Image = CType(resources.GetObject("PB_2_1.Image"), System.Drawing.Image)
        Me.PB_2_1.Location = New System.Drawing.Point(86, 238)
        Me.PB_2_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_2_1.Name = "PB_2_1"
        Me.PB_2_1.Size = New System.Drawing.Size(100, 100)
        Me.PB_2_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_2_1.TabIndex = 27
        Me.PB_2_1.TabStop = False
        '
        'PB_1_3
        '
        Me.PB_1_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PB_1_3.Location = New System.Drawing.Point(353, 114)
        Me.PB_1_3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_1_3.Name = "PB_1_3"
        Me.PB_1_3.Size = New System.Drawing.Size(100, 100)
        Me.PB_1_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_1_3.TabIndex = 26
        Me.PB_1_3.TabStop = False
        '
        'PB_3_2
        '
        Me.PB_3_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PB_3_2.Image = CType(resources.GetObject("PB_3_2.Image"), System.Drawing.Image)
        Me.PB_3_2.Location = New System.Drawing.Point(222, 371)
        Me.PB_3_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_3_2.Name = "PB_3_2"
        Me.PB_3_2.Size = New System.Drawing.Size(100, 100)
        Me.PB_3_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_3_2.TabIndex = 25
        Me.PB_3_2.TabStop = False
        '
        'PB_2_3
        '
        Me.PB_2_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PB_2_3.Image = CType(resources.GetObject("PB_2_3.Image"), System.Drawing.Image)
        Me.PB_2_3.Location = New System.Drawing.Point(353, 238)
        Me.PB_2_3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_2_3.Name = "PB_2_3"
        Me.PB_2_3.Size = New System.Drawing.Size(100, 100)
        Me.PB_2_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_2_3.TabIndex = 24
        Me.PB_2_3.TabStop = False
        '
        'PB_1_2
        '
        Me.PB_1_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PB_1_2.Image = CType(resources.GetObject("PB_1_2.Image"), System.Drawing.Image)
        Me.PB_1_2.Location = New System.Drawing.Point(222, 114)
        Me.PB_1_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_1_2.Name = "PB_1_2"
        Me.PB_1_2.Size = New System.Drawing.Size(100, 100)
        Me.PB_1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_1_2.TabIndex = 23
        Me.PB_1_2.TabStop = False
        '
        'PB_3_1
        '
        Me.PB_3_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PB_3_1.Image = CType(resources.GetObject("PB_3_1.Image"), System.Drawing.Image)
        Me.PB_3_1.Location = New System.Drawing.Point(86, 371)
        Me.PB_3_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_3_1.Name = "PB_3_1"
        Me.PB_3_1.Size = New System.Drawing.Size(100, 100)
        Me.PB_3_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_3_1.TabIndex = 22
        Me.PB_3_1.TabStop = False
        '
        'PB_2_2
        '
        Me.PB_2_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PB_2_2.Image = CType(resources.GetObject("PB_2_2.Image"), System.Drawing.Image)
        Me.PB_2_2.Location = New System.Drawing.Point(222, 238)
        Me.PB_2_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_2_2.Name = "PB_2_2"
        Me.PB_2_2.Size = New System.Drawing.Size(100, 100)
        Me.PB_2_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_2_2.TabIndex = 21
        Me.PB_2_2.TabStop = False
        '
        'PB_1_1
        '
        Me.PB_1_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PB_1_1.Image = CType(resources.GetObject("PB_1_1.Image"), System.Drawing.Image)
        Me.PB_1_1.Location = New System.Drawing.Point(86, 114)
        Me.PB_1_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_1_1.Name = "PB_1_1"
        Me.PB_1_1.Size = New System.Drawing.Size(100, 100)
        Me.PB_1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_1_1.TabIndex = 20
        Me.PB_1_1.TabStop = False
        '
        'PB_grille
        '
        Me.PB_grille.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PB_grille.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_grille.Image = Global._2022_morpion.My.Resources.Resources.grid
        Me.PB_grille.Location = New System.Drawing.Point(12, 46)
        Me.PB_grille.Name = "PB_grille"
        Me.PB_grille.Size = New System.Drawing.Size(501, 503)
        Me.PB_grille.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_grille.TabIndex = 35
        Me.PB_grille.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(760, 537)
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'BT_Reset
        '
        Me.BT_Reset.BackColor = System.Drawing.Color.SeaGreen
        Me.BT_Reset.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Reset.Location = New System.Drawing.Point(565, 502)
        Me.BT_Reset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BT_Reset.Name = "BT_Reset"
        Me.BT_Reset.Size = New System.Drawing.Size(169, 38)
        Me.BT_Reset.TabIndex = 37
        Me.BT_Reset.Text = "Reset"
        Me.BT_Reset.UseVisualStyleBackColor = False
        '
        'L_parties_restantes
        '
        Me.L_parties_restantes.AutoSize = True
        Me.L_parties_restantes.BackColor = System.Drawing.Color.SeaGreen
        Me.L_parties_restantes.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_parties_restantes.Location = New System.Drawing.Point(26, 18)
        Me.L_parties_restantes.Name = "L_parties_restantes"
        Me.L_parties_restantes.Size = New System.Drawing.Size(49, 21)
        Me.L_parties_restantes.TabIndex = 17
        Me.L_parties_restantes.Text = "Zone"
        '
        'L_victoire
        '
        Me.L_victoire.AutoSize = True
        Me.L_victoire.BackColor = System.Drawing.Color.IndianRed
        Me.L_victoire.Font = New System.Drawing.Font("Ebrima", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_victoire.Location = New System.Drawing.Point(25, 43)
        Me.L_victoire.Name = "L_victoire"
        Me.L_victoire.Size = New System.Drawing.Size(72, 32)
        Me.L_victoire.TabIndex = 38
        Me.L_victoire.Text = "Zone"
        '
        'PB_quitter
        '
        Me.PB_quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PB_quitter.Image = Global._2022_morpion.My.Resources.Resources.quit
        Me.PB_quitter.Location = New System.Drawing.Point(728, 16)
        Me.PB_quitter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_quitter.Name = "PB_quitter"
        Me.PB_quitter.Size = New System.Drawing.Size(40, 40)
        Me.PB_quitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_quitter.TabIndex = 39
        Me.PB_quitter.TabStop = False
        '
        'CB_bot
        '
        Me.CB_bot.AutoSize = True
        Me.CB_bot.Location = New System.Drawing.Point(12, 96)
        Me.CB_bot.Name = "CB_bot"
        Me.CB_bot.Size = New System.Drawing.Size(145, 24)
        Me.CB_bot.TabIndex = 40
        Me.CB_bot.Text = "Jouer contre Bot"
        Me.CB_bot.UseVisualStyleBackColor = True
        '
        'Morpion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.PB_quitter)
        Me.Controls.Add(Me.L_victoire)
        Me.Controls.Add(Me.L_parties_restantes)
        Me.Controls.Add(Me.BT_Reset)
        Me.Controls.Add(Me.L_joueur_actuel)
        Me.Controls.Add(Me.PB_joueur_actuel)
        Me.Controls.Add(Me.GB_premier_joueur)
        Me.Controls.Add(Me.GB_choix_nb_partie)
        Me.Controls.Add(Me.GB_partie_gagnee)
        Me.Controls.Add(Me.BT_Jouer)
        Me.Controls.Add(Me.PB_3_3)
        Me.Controls.Add(Me.PB_2_1)
        Me.Controls.Add(Me.PB_1_3)
        Me.Controls.Add(Me.PB_3_2)
        Me.Controls.Add(Me.PB_2_3)
        Me.Controls.Add(Me.PB_1_2)
        Me.Controls.Add(Me.PB_3_1)
        Me.Controls.Add(Me.PB_2_2)
        Me.Controls.Add(Me.PB_1_1)
        Me.Controls.Add(Me.PB_grille)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Morpion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Morpion"
        Me.GB_premier_joueur.ResumeLayout(False)
        Me.GB_premier_joueur.PerformLayout()
        Me.GB_choix_nb_partie.ResumeLayout(False)
        Me.GB_choix_nb_partie.PerformLayout()
        Me.GB_partie_gagnee.ResumeLayout(False)
        Me.GB_partie_gagnee.PerformLayout()
        CType(Me.PB_joueur_actuel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_3_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_2_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_1_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_3_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_2_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_1_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_3_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_2_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_grille, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_quitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_premier_joueur As GroupBox
    Friend WithEvents RB_joueur2_premier As RadioButton
    Friend WithEvents RB_joueur1_premier As RadioButton
    Friend WithEvents TB_joueur1_score As TextBox
    Friend WithEvents RB_5_parties As RadioButton
    Friend WithEvents RB_1_partie As RadioButton
    Friend WithEvents GB_choix_nb_partie As GroupBox
    Friend WithEvents TB_joueur2_score As TextBox
    Friend WithEvents GB_partie_gagnee As GroupBox
    Friend WithEvents BT_Jouer As Button
    Friend WithEvents PB_3_3 As PictureBox
    Friend WithEvents PB_2_1 As PictureBox
    Friend WithEvents PB_1_3 As PictureBox
    Friend WithEvents PB_3_2 As PictureBox
    Friend WithEvents PB_2_3 As PictureBox
    Friend WithEvents PB_1_2 As PictureBox
    Friend WithEvents PB_3_1 As PictureBox
    Friend WithEvents PB_2_2 As PictureBox
    Friend WithEvents PB_1_1 As PictureBox
    Friend WithEvents L_joueur_actuel As Label
    Friend WithEvents PB_joueur_actuel As PictureBox
    Friend WithEvents PB_grille As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BT_Reset As Button
    Friend WithEvents L_parties_restantes As Label
    Friend WithEvents TB_joueur2 As TextBox
    Friend WithEvents TB_joueur1 As TextBox
    Friend WithEvents L_victoire As Label
    Friend WithEvents RB_random_premier As RadioButton
    Friend WithEvents RB_choix_nb_partie As RadioButton
    Friend WithEvents TB_choix_nb_partie As TextBox
    Friend WithEvents L_choix_nb_partie As Label
    Friend WithEvents PB_quitter As PictureBox
    Friend WithEvents CB_bot As CheckBox
End Class
