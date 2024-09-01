Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Definindo as coisas'
        GroupBox1.Text = "Selecione"
        GroupBox5.Text = "Obstáculos"
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom

        'Limpando as coisas'
        GroupBox2.Text = ""
        GroupBox4.Text = ""
        GroupBox6.Text = ""

        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""

        'Musga'
        My.Computer.Audio.Play(My.Resources.PrologueLoop, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub ComboBox1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Adicionando as coisas na list-box'
        ComboBox1.Items.Add("História")
        ComboBox1.Items.Add("Capítulos")
        ComboBox1.Items.Add("Gameplay")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Limpando a list-box pra não acumular item'
        ListBox1.Items.Clear()

        'Limpando a picture-box e textos
        PictureBox1.Image = Nothing
        GroupBox2.Text = ""
        Label1.Text = ""

        'Escondendo as coisas'
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox5.Visible = False
        GroupBox6.Visible = False

        Select Case ComboBox1.SelectedIndex
            Case 0 'História'
                ListBox1.Items.Add("Sinopse")
                ListBox1.Items.Add("Personagens")
            Case 1 'Capítulos'
                ListBox1.Items.Add("Forsaken City")
                ListBox1.Items.Add("Old Site")
                ListBox1.Items.Add("Celestial Resort")
                ListBox1.Items.Add("Golden Ridge")
                ListBox1.Items.Add("Mirror Temple")
                ListBox1.Items.Add("Reflection")
                ListBox1.Items.Add("The Summit")
            Case 2 'Gameplay'
                ListBox1.Items.Add("Coletáveis")
                ListBox1.Items.Add("Movimentação")
                ListBox1.Items.Add("Objetos")
        End Select
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'Escondendo as coisas'
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox5.Visible = False
        GroupBox6.Visible = False

        'Desmarcando as coisas
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False

        'História'
        If ComboBox1.SelectedIndex = 0 Then
            Select Case ListBox1.SelectedIndex
                Case 0 'Sinopse'
                    'Ajustando a picture-box e colocando imagens
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                    PictureBox1.Image = My.Resources.logo

                    GroupBox2.Text = "Sinopse"
                    Label1.Text = "Celeste é um jogo de plataforma 2D aonde os jogadores controlam a personagem Madeline, que tem como objetivo escalar a perigosa montanha Celeste, passando por diversos obstáculos mortais. Além de pular e escalar paredes, Madeline também é capaz de efetuar dashes no chão e no ar, que servem de impulso para sua movimentação. O jogo trata de assuntos como ansiedade e depressão, e recebe muito reconhecimento não só pela sua história, como também pela sua dificuldade, trilha sonora, e arte."
                Case 1 'Personagens'
                    'Modificando as parada pra aparecer as coisa certa'
                    GroupBox3.Visible = True
                    GroupBox4.Visible = True

                    RadioButton4.Visible = True
                    RadioButton5.Visible = True

                    GroupBox3.Text = "Personagens"

                    RadioButton1.Text = "Madeline"
                    RadioButton2.Text = "Theo"
                    RadioButton3.Text = "Badeline"
                    RadioButton4.Text = "Véia"
                    RadioButton5.Text = "Mr. Oshiro"

                    GroupBox3.Top = 194
                    GroupBox4.Top = 194
                    GroupBox5.Top = 377
                    GroupBox5.Top = 377
            End Select
        End If

        'Capítulos'
        If ComboBox1.SelectedIndex = 1 Then
            'Ajustando a picture-box
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            Select Case ListBox1.SelectedIndex
                Case 0
                    PictureBox1.Image = My.Resources.ForsakenCity
                    GroupBox2.Text = "Forsaken City"
                    Label1.Text = "Capítulo 1: Forsaken City introduz as mecânicas e coletáveis do jogo para o jogador, o que inclui o dash e os moranguinhos que todo mundo ama, também introduzindo diversos objetos da gameplay, e o nosso InstaPixer favorito: Theo. O local em si possui a aparência de uma de uma cidade completamente devastada e coberta de neve."
                Case 1
                    PictureBox1.Image = My.Resources.OldSite
                    GroupBox2.Text = "Old Site"
                    Label1.Text = "Capítulo 2: Old Site. Madeline, após chegar ao local, cai no sono. Após acordar, ela percebe que diversas mudanças aconteceram nos seus arredores: o fogo da fogueira agora é verde, luzes azuis estão descendo pelo céu, e as escrituras no Memorial da Montanha Celeste estão todas embaralhadas e se movendo de maneira aleatória. Depois de explorar as construções do local, ela encontra um grande espelho. Após passar por ele, ela vê seu reflexo, distorcido, e com seus olhos vermelhos fixados nela... Até que o espelho se quebra."
                Case 2
                    PictureBox1.Image = My.Resources.CelestialResort
                    GroupBox2.Text = "Celestial Resort"
                    Label1.Text = "Capítulo 3: Celestial Resort; Madeline encontra um hotel abandonado no meio da montanha. Depois de entrar pela porta da frente, ela se depara com um velho livro de inquilinos do hotel. Após ler o livro, ela decide tocar o sino de atendentes na mesa, sumonando uma figura fantasmagórica. Ainda assustada com a presença do fantasma, Madeline é convencida de que nada estava de errado com ele ou com o hotel. Mr. Oshiro, como se chamava, era o presidente do Celestial Resort. Ele assume que Madeline vai ficar no hotel, mas Madeline insiste que ela estava só de passagem; Mr. Ohsiro, teimoso, se recusa a acreditar que Madeline estava indo embora, e começa a levá-la à suíte presidencial, esperando que ela fique no hotel..."
                Case 3
                    PictureBox1.Image = My.Resources.GoldenRidge
                    GroupBox2.Text = "Golden Ridge"
                    Label1.Text = "Capítulo 4: Golden Ridge; Depois de sair do Celestial Resort, Madeline encontra com a Véia, que lhe dá um aviso: se ela continuasse, encontraria perigo,e dizendo que ela deveria desistir. Madeline enche seu peito de coragem, e diz que estava determinada a continuar. E assim o fez - passa por todos os obstáculos até encontrar uma enorme ravina, e não tinha outra opção senão pegar o velho bondinho para ir ao outro lado. Theo encontra com ela, e ambos pegam o bonde até o outro lado, enquanto Madeline se questiona sobre a real segurança daquele bondinho. Theo percebe a grande preocupação de Madeline, e tira uma selfie com ela para que ela acalme seus nervos. Tudo parecia irbem, até que..."
                Case 4
                    PictureBox1.Image = My.Resources.MirrorTemple
                    GroupBox2.Text = "Mirror Temple"
                    Label1.Text = "Capítulo 5: Mirror Temple; Madeline e Theo encontram um templo misterioso. Theo, encafifado com a magnitude do templo, deseja explorar; Madeline, ainda nervosa com os acontecimentos no bondinho, alerta Theo de que isso pode não ser uma boa ideia. Ainda assim, Theo entra, então Madeline, sem opção, apenas o segue. Pouco tempo depois, Madeline encontra o telefone de Theo jogado no chão emfrente a um espelho com o símbolo um olho misterioso. Assustada e dizendo a si mesma para não entrar em pânico, Madeline pega o celular, e parte em busca de Theo, agora desaparecido dentro do templo."
                Case 5
                    PictureBox1.Image = My.Resources.Reflection
                    GroupBox2.Text = "Reflection"
                    Label1.Text = "Capítulo 6: Reflection; Madeline e Theo fazem um pequeno acampamento, onde é relevado por Madeline que ela possui problemas com aniedade e depressão. Também é explicado que Badeline é a parte de Madeline que escapou do espelho, e que reflete as coisas de que Madeline não é muito orgulhosa, e que a montanha de alguma as deu uma forma. Após tirar uma selfie com Theo e dormir, Madeline, em seus sonhos, decide de que não é mais hora de ficar correndo de seus problemas e que ela deveria lidar com eles de alguma forma, decidindo 'libertar' Badeline. Entretanto, Badeline não queria ser 'liberta', vendo isso como um abandono, se tomando de raiva pela pessoa a qual ela tentava ajudar ao seu máximo. Assustada, Madeline entra em pânico mais uma vez. Ela tenta se acalmar com as técnicas que Theo a ensinou, mas dessa vez, o ódio de Badeline era tão grande que nem mesmo elas foram o suficiente para acabar com a raiva de Badeline, que arremessa Madeline pelas profundezas da montanha."
                Case 6
                    PictureBox1.Image = My.Resources.TheSummit
                    GroupBox2.Text = "The Summit"
                    Label1.Text = "Capítulo 7: The Summit; Depois de cair na caverna e confrontar Badeline, Madeline e Badeline finalmente se entendem. Madeline entende que Badeline não é algo que deve ser deixado para trás, pois, querendo ou não, ainda é parte dela. Badeline não era somente 'um amontuado de sentimentos ruins', era parte de Madeline, que ela negligenciava e tentava esquecer, fazendo uma bola de neve que só aumentava em tamanho. Do outro lado, Badeline percebe que o desejo de Madeline estava muito mais ligado ao sentimento de ser livre da tristeza, da ansiedade, de enfrentar os seus medos, de ser uma pessoa mais forte. Ao final, Madeline percebe que ela não era a única assustada, e que Badeline também tinha seus medos, e que as duas iam vencer sobre eles, juntas. Assim, unidas, as duas partem em direção ao pico da montanha, mais uma vez; só que agora, uma tem a outra."
            End Select
        End If

        'Gameplay'
        If ComboBox1.SelectedIndex = 2 Then
            Select Case ListBox1.SelectedIndex
                Case 0 'Collectibles'
                    'Ajustando a picture-box e colocando imagens
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                    PictureBox1.Image = My.Resources.GoldenMoranguinho

                    GroupBox2.Text = "Coletáveis"
                    Label1.Text = "Coletáveis são itens presentes nos capítulos de Celeste, que podem ou não alterar a gameplay. Moranguinhos, por exemplo, são coletados apenas por diversão, e alguns são muito difíceis de serem pegos. Cassettes também liberam novos níveis para serem jogados, e Crystal Hearts são muito difíceis de serem coletados e desbloqueiam coisas 'misteriosas.'"

                    'Modificando as parada pra aparecer as coisa certa'
                    GroupBox3.Visible = True
                    GroupBox4.Visible = True

                    RadioButton4.Visible = False
                    RadioButton5.Visible = False

                    GroupBox3.Text = "Coletáveis"

                    RadioButton1.Text = "Moranguinhos"
                    RadioButton2.Text = "Cassettes"
                    RadioButton3.Text = "Crystal Hearts"

                    GroupBox3.Top = 194
                    GroupBox4.Top = 194
                    GroupBox5.Top = 377
                    GroupBox5.Top = 377
                Case 1 'Movimentação'
                    'Ajustando a picture-box e colocando imagens
                    PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
                    PictureBox1.Image = My.Resources.Falling

                    GroupBox2.Text = "Movimentação"
                    Label1.Text = "A movimentação do jogo é fluida e dinâmica, se baseando em movimentos rápidos no chão e no ar. O jogador conta com a capacidade de andar e escalar paredes por um tempo limitado, além de pular entre paredes para realizar uma escalada. O dash é uma mecânica essencial da movimentação e serve como um impulso que pode ir para diversas posições, também podendo ser realizado no ar, o junto a um pulo, o dash-jump."
                Case 2 'Objetos'
                    'Ajustando a picture-box e colocando imagens
                    PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
                    PictureBox1.Image = My.Resources.Objetos

                    GroupBox2.Text = "Objetos"
                    Label1.Text = "Objetos estão presentes em todos os capítulos e são uma peça chave do jogo, que adicionam para a dificuldade de Celeste. Eles vem em diversos sabores, como espinhos, de longe o tipo mais comum, e que te matam no contato, servindo como obstáculos. Outros podem ser como as parades do segundo capítulo, que sevem como uma maneira de se locomover, e te matam se utilizadas de maneira errada. Outras podem ser plataformas que se movem após determinada interação, bolhas que te jogam pelo ar, e diversas variedades que acrescentam pro jogo de maneira dinâmica."

                    'Modificando as parada pra aparecer as coisa certa'
                    GroupBox5.Visible = True
                    GroupBox6.Visible = True

                    CheckBox1.Text = "Spikes"
                    CheckBox2.Text = "Crystal"
                    CheckBox3.Text = "Crystal Spikes"

                    GroupBox3.Top = 337
                    GroupBox4.Top = 377
                    GroupBox5.Top = 194
                    GroupBox6.Top = 194
            End Select
        End If
    End Sub

    'Radio-buttons'
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'Selecionando as coisa de acordocom a combo-box'
        Select Case ComboBox1.SelectedIndex
            Case 0 'Personagem'
                PictureBox2.Image = My.Resources.Madeline
                GroupBox4.Text = "Madeline"
                Label2.Text = "Madeline é uma pessoa muito forte e determinada, ainda que viva em conflitos consigo mesma, escalando a montanha para se desafiar. Sua coragem é notada pelos demais personagens, e alguns até mesmo a alertam para voltar antes que se machucasse. Ainda assim, ela continua, determinada a acabar com seus medos e ansiedades, tendo controle sobre a sua vida, ainda que seja algo perigoso."
            Case 2 'Collectible'
                PictureBox2.Image = My.Resources.Moranguinho
                GroupBox4.Text = "Moranguinhos"
                Label2.Text = "Moranguinhos são muito comuns e estão em praticamente todos os capítulos do jogo. Eles aparecem em diversas salas, inclusive salas escondidas.Após serem coletados, vão seguir o jogador até que ele fique sobre o chão por um pequeno período de tempo. Coletar moranguinhos dá ao jogador pontos, que não servem pra nada: na verdade, moranguinhos não mudam sua gameplay de maneira alguma, e estão ali apenas para serem coletados, e para que voce mostre pro seu amigo o quão hardcore você é."
        End Select

        'Nada selecionado'
        If RadioButton1.Checked = False Then
            PictureBox2.Image = Nothing
            GroupBox4.Text = " "
            Label2.Text = " "
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'Selecionando as coisa de acordocom a combo-box'
        Select Case ComboBox1.SelectedIndex
            Case 0 'Personagem'
                PictureBox2.Image = My.Resources.Theo
                GroupBox4.Text = "Theo"
                Label2.Text = "Theo escala a montanha junto de Madeline. Ele é um fotógrafo aspirante que está escalando o Monte Celeste, em sua maioria, por fotos que vão alavancar seus seguidores no InstaPix. Theo sempre age de maneira amigável, oferecendo suporte e companhia para Madeline em sua jornada."
            Case 2 'Collectible'
                PictureBox2.Image = My.Resources.Cassette
                GroupBox4.Text = "Cassettes"
                Label2.Text = "Cassetes são coletáveis que podem ser encontrados em todos os capítulos do jogo, os quais ficam escondidos em salas secretas. Após encontrá-las, o player precisa passar por plataformas coloridas que aparecem e desaparecem ao ritmo da música da sala, para finalmente conseguir o cassete. Depois de coletados, liberam o chamado 'B-Side', que é uma versão mais difícil do capítulo do qual o cassete foi coletado. Apesar de serem coletáveis opcionais, são necessários para coletar todos os Crystal Hearts do jogo."
        End Select

        'Nada selecionado'
        If RadioButton2.Checked = False Then
            PictureBox2.Image = Nothing
            GroupBox4.Text = " "
            Label2.Text = " "
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        'Selecionando as coisa de acordocom a combo-box'
        Select Case ComboBox1.SelectedIndex
            Case 0 'Personagem'
                PictureBox2.Image = My.Resources.Badeline
                GroupBox4.Text = "Badeline"
                Label2.Text = "Badeline é a parte insegura de Madeline, que toma forma dentro da montanha, e segundo ela mesma, é a parte 'pragmática' de Madeline, englobando seus medos, solidão, falhas, inadequação e falta de esperança em uma personificação. Ela pensa nas coisas de uma maneira mais lógica, ao invés de simplesmente seguir o que seu coração diz, e critica Madeline o tempo todo por isso. Não só isso, ela possui constante ataques de raiva, e a todo momento tenta impedir que Madeline cumpra seu objetivo, tentando fazer com que ela desista."
            Case 2 'Collectible'
                PictureBox2.Image = My.Resources.CrystalHeart
                GroupBox4.Text = "Crystal Hearts"
                Label2.Text = "Corações de Cristal (ou simplesmente Crystal Hearts) são coletáveis que podem ser encontrados em todos os capítulos. Eles podem mudar de cor dependendo do 'lado' do capítulo em que o player está. No total, existem 24 Crystal Hearts em Celeste, com o tipo mais comum sendo os azuis. Enquanto alguns podem ser encontrados no final dos B-Sides e C-Sides, os azuis, mais comuns, são escondidos no final dos capítulos A-Side e podem ser acessados através de puzzles ou áreas secretas."
        End Select

        'Nada selecionado'
        If RadioButton3.Checked = False Then
            PictureBox2.Image = Nothing
            GroupBox4.Text = " "
            Label2.Text = " "
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        'Véia'
        PictureBox2.Image = My.Resources.Granny
        GroupBox4.Text = "Véia"
        Label2.Text = "A Véia é uma das poucas pessoas que habitam a montanha. Não só isso, ela também demonstra grande sabedoria sobre a montanha, constantemente alertando Madeline sobre seus poderes. Sua atitude é despreocupada e descontraída, o que serve como ponte para que Madeline se solte e revele mais coisas sobre si mesma."

        'Nada selecionado'
        If RadioButton4.Checked = False Then
            PictureBox2.Image = Nothing
            GroupBox4.Text = " "
            Label2.Text = " "
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        'Oshiro'
        PictureBox2.Image = My.Resources.Oshiro
        GroupBox4.Text = "Mr. Oshiro"
        Label2.Text = "Mr. Oshiro é um dos residentes da Montanha Celeste, e um dos quais Madeline encontra em sua jornada. Ele aparece pela primeira vez no Resort Celeste, e é dito como o fantasma do nodo do Resort, que, apesar da falta de funcionários ou clientes, continua o operando."

        'Nada selecionado'
        If RadioButton5.Checked = False Then
            PictureBox2.Image = Nothing
            GroupBox4.Text = " "
            Label2.Text = " "
        End If
    End Sub

    'Check-boxes'
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'Spikes'
        PictureBox3.Image = My.Resources.Spikes
        Label3.Text = "Você rela, você morre."

        'Não selecionado'
        If CheckBox1.Checked = False Then
            PictureBox3.Image = Nothing
            Label3.Text = " "
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        'Crystal Spikes'
        PictureBox4.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox4.Image = My.Resources.CrystalSpikes
        Label4.Text = "Você rela, você morre."

        'Não selecionado'
        If CheckBox2.Checked = False Then
            PictureBox4.Image = Nothing
            Label4.Text = " "
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        'Crystals'
        PictureBox5.Image = My.Resources.Crystals
        Label5.Text = "Você rela, você morre."

        'Não selecionado'
        If CheckBox3.Checked = False Then
            PictureBox5.Image = Nothing
            Label5.Text = " "
        End If
    End Sub
End Class

