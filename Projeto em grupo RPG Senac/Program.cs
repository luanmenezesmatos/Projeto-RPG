using Projeto_em_grupo_RPG_Senac;
using System.Text;
using static Projeto_em_grupo_RPG_Senac.Banco;


// Pra fazer
// - Inserir nome, que será o nome do personagem (depois subsitutir todos os nomes do personagem pelo nome escolhido) (opcional)
// - Brigas épicas (esquemas de batalha rpg, usando itens)
// - Falta conferir se os itens já foram pegos, para não serem pegos novamente
class Program
{
    public static void Main()
    {
        // UTF-8
        Console.OutputEncoding = Encoding.UTF8;

        // Desativando barra de escrita visível

        Console.CursorVisible = false;

        // Menu Maximizar

        Menus.MensagemMaximizar();

        // Cria o banco de dados
        Banco.Run();

    // Menu Principal

    MenuPrincipal:

        Menus.Inicio();

    // Jogo

    PontoZero:

        Usual.Escrever("Sob o manto noturno, os motores rugiam enquanto o Capitão Antoine Lefevre manobrava seu caça. \nEm um instante fatídico, o avião foi atingido, levando-o a uma queda desesperada. \nCom habilidade e coragem, guiou a máquina danificada para uma clareira perto de Paris, sua amada cidade agora sob o domínio nazista. \nA batalha pela liberdade ganhava um novo protagonista, determinado a trazer esperança a uma nação oprimida." +
            "\n\n[1] Tentar pedir ajuda pelo rádio" +
            "\n[2] Pegar seu equipamento e ir em direção à cidade para tentar se abrigar" +
            "\n[3] Tentar consertar seu avião");
        switch (Usual.Escolha(3))
        {
            case 1:
                Usual.Escrever("Seu rádio sofreu danos em virtude da queda, mas há uma faísca de esperança que aquece o coração: você tem a capacidade de repará-lo. Tudo o que é necessário é encontrar a peça necessária." +
                    "\n\n[1] Voltar");
                Usual.Escolha(1);
                goto PontoZero;
            case 2:
                Usual.Escrever("Você chega na cidade, faminto, exausto, xoxo, capenga e destruído. O que você faz?" +
                    "\n\n[1] Entrar na primeira casa que vê" +
                    "\n[2] Continuar andando, à procura de ajuda");
                switch (Usual.Escolha(2))
                {
                    case 1: // OK, SÓ FALTA TERMINAR PARTE DA MULHER E LUTAS
                    Casa:

                        Usual.Escrever("Você entra na casa... Ela aparentemente está vazia." +
                            "\n\n[1] Checar se a casa está realmente vazia (reconhecimento do território)" +
                            "\n[2] Procurar por suprimentos" +
                            "\n[3] Dar uma de baiano e descansar");
                        switch (Usual.Escolha(3))
                        {
                            case 1:
                                Usual.Escrever("Você vasculha a casa inteira, e... encontra... ninguém." +
                                    "\n\n[1] Voltar");
                                Usual.Escolha(1);
                                goto Casa;
                            case 2:
                                Usual.Escrever("Você achou alguns suprimentos." +
                                    "\n\n- (3) Lata de comida" +
                                    "\n- (2) Pentes de munição" +
                                    "\n\n[1] Voltar");

                                Banco.Item.Atualizar.LataDeComida(Banco.Item.Ler.LataDeComida() + 3);
                                Banco.Item.Atualizar.Munição(Banco.Item.Ler.Munição() + 2);

                                Usual.Escolha(1);
                                goto Casa;
                            case 3:
                                Usual.Escrever("Você descansa por um tempo.");
                                Thread.Sleep(3000);
                                Console.WriteLine("\n\n  vrumm...");
                                Thread.Sleep(5000);
                                Console.WriteLine("  VrRUmm...");
                                Thread.Sleep(6000);
                                Console.WriteLine("  TUUM TUM..");
                                Thread.Sleep(2000);
                                Usual.Escrever("\nVocê acorda, e olha pela janela. Um comboio inimigo acabou de parar em frente à sua casa." +
                                    "\n\nO que você faz?" +
                                    "\n\n[1] Tentar se esconder" +
                                    "\n[2] Enfrentar eles", false);
                                switch (Usual.Escolha(2))
                                {
                                    case 1:
                                        Usual.Escrever("Você se esconde dentro de um armário. 3 soldados entram na casa... e estão te procurando." +
                                            "\n\n[1] Continuar onde está" +
                                            "\n[2] Tentar trocar de esconderijo");
                                        switch (Usual.Escolha(2))
                                        {
                                            case 1:
                                                Usual.Escrever("Você continua em seu esconderijo..." +
                                                    "\n\nDepois de um longo e angustiante tempo, os soldados inimigos vão embora." +
                                                    "\n\nVocê sai do armário." +
                                                    "\n\nVocê sai da casa, e anda por um bom tempo... até que escuta um barulho vindo de dentro de uma das casas." +
                                                    "\n\n[1] Entrar na casa");
                                                Usual.Escolha(1);
                                                Usual.Escrever("Você entra na casa..." +
                                                    "\n\nE se depara com uma mulher." +
                                                    "\n\n[1] Pedir ajuda" +
                                                    "\n[2] Ameaçar para conseguir informações"); // A PARTIR DAQUI, FUNÇÃO MULHER
                                                switch (Usual.Escolha(2))
                                                {
                                                    case 1:
                                                        Usual.Escrever("Você pede ajuda à mulher e diz tudo o que aconteceu com você. Ela tem compaixão de sua situação, e te dá comida e bebida, mas diz que não pode ficar aqui. " +
                                                            "\n\n- (1) Lata de comida" +
                                                            "\n- (1) Vodka" +
                                                            "\n\nAntes de você partir, ela diz conhecer um lugar onde você pode encontrar a peça necessária para consertar o rádio do avião." +
                                                            "\n\n[1] Ir até o local");

                                                        Item.Atualizar.LataDeComida(Item.Ler.LataDeComida() + 1);
                                                        Item.Atualizar.Vodka(Item.Ler.Vodka() + 1);

                                                        break;
                                                    case 2:
                                                        Usual.Escrever("A mulher fica assustada, e te dá a informação de onde você pode encontrar a peça do rádio do avião." +
                                                            "\n\n[1] Ir até o local");
                                                        Usual.Escolha(1);
                                                        break;
                                                }

                                                Usual.Escrever("Chegando lá, você se depara com um galpão de suprimentos militares e encontra um esquadrão inimigo." +
                                                    "\n\n[1] Modo furtivo" +
                                                    "\n[2] Modo porra loca");
                                                switch (Usual.Escolha(2))
                                                {
                                                    case 1:
                                                        // COMEÇAR BATALHA EPICA DE 1 X GRUPOS ISOLADOS
                                                        // BATALHAS TIRAM HP

                                                        Usual.Escrever("Você entra furtivamente na instalação e consegue passar entre as tropas. Porém, há um guarda na entrada do galpão vindo em sua direção." +
                                                            "\n\n");

                                                        int hpEnemy = 35;
                                                        int ataEnemy = 15;
                                                        int defEnemy = 10;
                                                        bool defesa = false;
                                                        Random randint = new Random();

                                                        while (true)
                                                        {
                                                            Usual.Escrever("\n\nSelecione uma ação:" +
                                                            "\n\n[1] Ataque" +
                                                            "\n\n[2] Defesa" +
                                                            "\n\n[3] Usar item");

                                                            switch (Usual.Escolha(3))
                                                            {
                                                                case 1:
                                                                    Usual.Escrever($"Você ataca o inimigo, causando {Banco.Jogador.Ler.ATA()} de dano. O inimigo agora possui {hpEnemy}.");
                                                                    hpEnemy -= Banco.Jogador.Ler.ATA();
                                                                    Thread.Sleep(1000);

                                                                    break;
                                                                case 2:
                                                                    Usual.Escrever($"Você se defende, reduzindo o próximo dano do inimigo em {Banco.Jogador.Ler.DEF()}.");
                                                                    defesa = true;
                                                                    Thread.Sleep(1000);

                                                                    break;
                                                                case 3:
                                                                    defesa = false;

                                                                    Usual.Escrever("Selecione um item:" +
                                                                        "\n\n[1] Lata de comida" +
                                                                        "\n\n[2] Vodka" +
                                                                        "\n\n[3] Frasco suspeito" +
                                                                        "\n\n[4] Granada");

                                                                    switch (Usual.Escolha(4))
                                                                    {
                                                                        case 1:
                                                                            if (Banco.Item.Ler.LataDeComida() > 0)
                                                                            {
                                                                                Usual.Escrever("Você comeu uma lata de comida, recuperando 15 de HP.");
                                                                                Banco.Item.Atualizar.LataDeComida(Banco.Item.Ler.LataDeComida() - 1);
                                                                                Banco.Jogador.Atualizar.HP(Banco.Jogador.Ler.HP() + 15);
                                                                            }
                                                                            else
                                                                            {
                                                                                Usual.Escrever("Você não possui esse item.");
                                                                            }

                                                                            break;
                                                                        case 2:
                                                                            if (Banco.Item.Ler.Vodka() > 0)
                                                                            {
                                                                                Usual.Escrever("Você bebeu uma vodka, ganhando mais 20 de ataque porém perdendo 20 de defesa.");
                                                                                Banco.Item.Atualizar.Vodka(Banco.Item.Ler.Vodka() - 1);
                                                                                Banco.Jogador.Atualizar.ATA(Banco.Jogador.Ler.ATA() + 20);
                                                                                Banco.Jogador.Atualizar.DEF(Banco.Jogador.Ler.DEF() - 20);
                                                                            }
                                                                            else
                                                                            {
                                                                                Usual.Escrever("Você não possui esse item.");
                                                                            }

                                                                            break;
                                                                        case 3:
                                                                            if (Banco.Item.Ler.FrascoSuspeito() > 0)
                                                                            {
                                                                                Usual.Escrever("Você bebeu o frasco suspeito, que era um veneno, então você morreu.");
                                                                                Banco.Item.Atualizar.FrascoSuspeito(Banco.Item.Ler.FrascoSuspeito() - 1);

                                                                                Menus.GameOver();
                                                                            }
                                                                            else
                                                                            {
                                                                                Usual.Escrever("Você não possui esse item.");
                                                                            }

                                                                            break;
                                                                        case 4:
                                                                            if (Banco.Item.Ler.Granada() > 0)
                                                                            {
                                                                                Usual.Escrever("Você jogou uma granada, causando 100 de dano.");
                                                                                Banco.Item.Atualizar.Granada(Banco.Item.Ler.Granada() - 1);
                                                                                hpEnemy -= 100;
                                                                            }
                                                                            else
                                                                            {
                                                                                Usual.Escrever("Você não possui esse item.");
                                                                            }

                                                                            break;
                                                                    }

                                                                    break;
                                                            }

                                                            // Ataque ou defesa do inimigo

                                                            if (randint.Next(1, 101) < 50)
                                                            {
                                                                // Ataque do inimigo (se defesa = true, ataEnemy - defesa do jogador)

                                                                if (defesa)
                                                                {
                                                                    Usual.Escrever($"O inimigo te ataca, causando {ataEnemy - Banco.Jogador.Ler.DEF()} de dano.");
                                                                    Banco.Jogador.Atualizar.HP(Banco.Jogador.Ler.HP() - (ataEnemy - Banco.Jogador.Ler.DEF()));
                                                                }
                                                                else
                                                                {
                                                                    Usual.Escrever($"O inimigo te ataca, causando {ataEnemy} de dano.");
                                                                    Banco.Jogador.Atualizar.HP(Banco.Jogador.Ler.HP() - ataEnemy);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                // Inimigo defende (seu ataque - defesa do inimigo)

                                                                Usual.Escrever($"O inimigo se defende, reduzindo o próximo dano em {defEnemy}.");
                                                                ataEnemy -= defEnemy;
                                                            }

                                                            if (hpEnemy <= 0)
                                                            {
                                                                Usual.Escrever("Você derrotou o nazista! Fim da batalha.");
                                                            }
                                                        }
                                                    case 2:
                                                        // COMEÇAR BATALHA EPICA DE 1 X 259
                                                        // BATALHAS TIRAM HP

                                                        Usual.Escrever("Você invade a instalação, alertando todas as tropas nazistas. Você se depara com um esquadrão de 5 nazistas vigiando a entrada do galpão, armados até os dentes.");

                                                        int hpEnemy2 = 50;
                                                        int ataEnemy2 = 15;
                                                        bool defesa2 = false;

                                                        Random randint2 = new Random();

                                                        while (true)
                                                        {
                                                            Usual.Escrever("\n\nSelecione uma ação:" +
                                                            "\n\n[1] Ataque" +
                                                            "\n\n[2] Defesa" +
                                                            "\n\n[3] Usar item");

                                                            switch (Usual.Escolha(2))
                                                            {
                                                                case 1:
                                                                    int danoJogador = randint2.Next(Banco.Jogador.Ler.ATA() - 5, Banco.Jogador.Ler.ATA() + 5); // Dano do jogador (ataque - 5 até ataque + 5)
                                                                    Usual.Escrever($"Você ataca o inimigo, causando {danoJogador} de dano. O inimigo agora possui {hpEnemy2 - danoJogador}.");
                                                                    hpEnemy2 -= danoJogador;
                                                                    Thread.Sleep(1000);

                                                                    break;
                                                                case 2:
                                                                    Usual.Escrever($"Você se defende, reduzindo o próximo dano do inimigo em {Banco.Jogador.Ler.DEF()}.");
                                                                    defesa2 = true;
                                                                    Thread.Sleep(1000);

                                                                    break;
                                                                case 3:
                                                                    defesa2 = false;

                                                                    Usual.Escrever("Selecione um item:" +
                                                                        "\n\n[1] Lata de comida" +
                                                                        "\n\n[2] Vodka" +
                                                                        "\n\n[3] Frasco suspeito" +
                                                                        "\n\n[4] Granada");

                                                                    switch (Usual.Escolha(4))
                                                                    {
                                                                        case 1:
                                                                            if (Banco.Item.Ler.LataDeComida() > 0)
                                                                            {
                                                                                if (randint2.Next(1, 101) <= 70) // 70% de chance de acertar
                                                                                {
                                                                                    Usual.Escrever("Você comeu uma lata de comida, recuperando 15 de HP.");
                                                                                    Banco.Item.Atualizar.LataDeComida(Banco.Item.Ler.LataDeComida() - 1);
                                                                                    Banco.Jogador.Atualizar.HP(Banco.Jogador.Ler.HP() + 15);
                                                                                }
                                                                                else
                                                                                {
                                                                                    Usual.Escrever("A lata de comida não fez efeito.");
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                Usual.Escrever("Você não possui uma lata de comida.");
                                                                            }

                                                                            break;
                                                                        case 2:
                                                                            if (Banco.Item.Ler.Vodka() > 0)
                                                                            {
                                                                                if (randint2.Next(1, 101) <= 50) // 50% de chance de acertar
                                                                                {
                                                                                    Usual.Escrever("Você bebeu uma vodka, ganhando mais 20 de ataque porém perdendo 20 de defesa.");
                                                                                    Banco.Item.Atualizar.Vodka(Banco.Item.Ler.Vodka() - 1);
                                                                                    Banco.Jogador.Atualizar.ATA(Banco.Jogador.Ler.ATA() + 20);
                                                                                    Banco.Jogador.Atualizar.DEF(Banco.Jogador.Ler.DEF() - 20);
                                                                                }
                                                                                else
                                                                                {
                                                                                    Usual.Escrever("A vodka não fez efeito.");
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                Usual.Escrever("Você não possui uma vodka.");
                                                                            }

                                                                            break;
                                                                        case 3:
                                                                            if (Banco.Item.Ler.FrascoSuspeito() > 0)
                                                                            {
                                                                                if (randint2.Next(1, 101) <= 30) // 30% de chance de acertar
                                                                                {
                                                                                    Usual.Escrever("Você bebeu o frasco suspeito, que era um veneno, então você morreu.");
                                                                                    Banco.Item.Atualizar.FrascoSuspeito(Banco.Item.Ler.FrascoSuspeito() - 1);

                                                                                    Menus.GameOver();
                                                                                }
                                                                                else
                                                                                {
                                                                                    Usual.Escrever("O frasco suspeito não fez efeito.");
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                Usual.Escrever("Você não possui um frasco suspeito.");
                                                                            }

                                                                            break;
                                                                        case 4:
                                                                            if (Banco.Item.Ler.Granada() > 0)
                                                                            {
                                                                                if (randint2.Next(1, 101) <= 80) // 80% de chance de acertar
                                                                                {
                                                                                    Usual.Escrever("Você jogou uma granada, causando 100 de dano.");
                                                                                    Banco.Item.Atualizar.Granada(Banco.Item.Ler.Granada() - 1);
                                                                                    hpEnemy2 -= 100;
                                                                                }
                                                                                else
                                                                                {
                                                                                    Usual.Escrever("A granada falhou em causar dano.");
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                Usual.Escrever("Você não possui uma granada.");
                                                                            }

                                                                            break;
                                                                    }
                                                                    break;
                                                            }

                                                            // Ataque ou defesa do inimigo

                                                            if (randint2.Next(1, 101) < 50)
                                                            {
                                                                int ataqueAleatorio = randint2.Next(10, 21); // Ataque aleatório entre 10 e 20
                                                                int ataqueInimigo = defesa2 ? ataqueAleatorio - Banco.Jogador.Ler.DEF() : ataqueAleatorio;
                                                                Usual.Escrever($"O inimigo te ataca, causando {ataqueInimigo} de dano.");
                                                                Banco.Jogador.Atualizar.HP(Banco.Jogador.Ler.HP() - ataqueInimigo);
                                                            }
                                                            else
                                                            {
                                                                int reducaoAleatoria = randint2.Next(5, 16); // Redução aleatória entre 5 e 15
                                                                int defesaInimigo = reducaoAleatoria;
                                                                Usual.Escrever($"O inimigo se defende, reduzindo o próximo dano em {defesaInimigo}.");
                                                                ataEnemy2 -= defesaInimigo;
                                                            }

                                                            if (Banco.Jogador.Ler.HP() <= 0)
                                                            {
                                                                Usual.Escrever("Você foi morto pelo esquadrão inimigo.", ReadKey: true);

                                                                Menus.GameOver();
                                                                goto MenuPrincipal;
                                                            }

                                                            if (hpEnemy2 <= 0)
                                                            {
                                                                Usual.Escrever("Você derrotou o esquadrão! Fim da batalha.", ReadKey: true);

                                                                Menus.Victory();
                                                                goto MenuPrincipal;
                                                            }
                                                        }
                                                }

                                                break;
                                            case 2:
                                                Usual.Escrever("Você tenta trocar de esconderijo... e um soldado inimigo te avista." +
                                                    "\n\n[1] Correr" +
                                                    "\n[2] Partir pra cima dele");
                                                switch (Usual.Escolha(2))
                                                {
                                                    case 1:
                                                        if (Banco.Jogador.Ler.HP() <= 30)
                                                        {
                                                            {
                                                                Usual.Escrever("Você percebe que a porta dos fundos está livre, e decide correr até ela para fugir..." +
                                                                "\n\nVocê consegue!" +
                                                                "\n\nMas é baleado na perna, no momento em que escapa pela porta (- 30 HP)." +
                                                                "\n\nVocê não resiste...", ReadKey: true);
                                                            }

                                                            Menus.GameOver();
                                                            goto MenuPrincipal;
                                                        }
                                                        else
                                                        {
                                                            Banco.Jogador.Atualizar.HP(Banco.Jogador.Ler.HP() - 30);
                                                            Usual.Escrever("Você percebe que a porta dos fundos está livre, e decide correr até ela para fugir..." +
                                                           "\n\nVocê consegue!" +
                                                           "\n\nMas é baleado na perna, no momento em que escapa pela porta (- 30 HP)" +
                                                           "\n\n[1] Continuar correndo" +
                                                           "\n[2] Encontrar um local para se esconder");
                                                            switch (Usual.Escolha(2))
                                                            {
                                                                case 1:
                                                                    Usual.Escrever("Você corre pela sua vida, mas você está exausto e muito machucado..." +
                                                                        "\n\nVocê desmaia.");
                                                                    Thread.Sleep(3000);
                                                                    Usual.Escrever("Ao acordar, você se encontra em um local desconhecido." +
                                                                        "\n\n Você grita por socorro, até perceber que está na enfermaria do exército francês." +
                                                                        "\n\n Você foi salvo", false, ReadKey: true);

                                                                    Menus.Victory();
                                                                    goto MenuPrincipal;
                                                                case 2:
                                                                    Usual.Escrever("O primeiro lugar que você pensa em se esconder é em alguma das casas à sua volta... mas isso seria muito óbvio. Então, você decide se esconder no esgoto.");
                                                                    Thread.Sleep(3000);
                                                                    Usual.Escrever("A princípio você acreditou que tivesse sido uma boa escolha... mas ao descer você dá de cara com soldados inimigos, e é capturado.", false, ReadKey: true);

                                                                    Menus.GameOver();
                                                                    goto MenuPrincipal;
                                                            }
                                                        }

                                                        break;
                                                    case 2:
                                                    SoldadoExecutado:

                                                        Usual.Escrever("Você parte pra cima do soldado inimigo e... consegue executar ele. Então, você percebe que a porta dos fundos está livre e decide fugir dali." +
                                                            "\n\nVocê anda por um bom tempo, até que escuta um barulho vindo de uma das casas." +
                                                            "\n\n[1] Entrar na casa" +
                                                            "\n[2] Pilhar o corpo");
                                                        switch (Usual.Escolha(2))
                                                        {
                                                            case 1:
                                                                // Mulher (de novo)

                                                                Usual.Escrever("Você entra na casa..." +
                                                                "\n\nE se depara com uma mulher." +
                                                                "\n\n[1] Pedir ajuda" +
                                                                "\n[2] Ameaçar para conseguir informações"); // A PARTIR DAQUI, FUNÇÃO MULHER

                                                                switch (Usual.Escolha(2))
                                                                {
                                                                    case 1:
                                                                        Usual.Escrever("Você pede ajuda à mulher e diz tudo o que aconteceu com você. Ela tem compaixão de sua situação, e te dá comida e bebida, mas diz que não pode ficar aqui. " +
                                                                            "\n\n- (1) Lata de comida" +
                                                                            "\n- (1) Vodka" +
                                                                            "\n\nAntes de você partir, ela diz conhecer um lugar onde você pode encontrar a peça necessária para consertar o rádio do avião." +
                                                                            "\n\n[1] Ir até o local");

                                                                        Banco.Item.Atualizar.LataDeComida(1);
                                                                        Banco.Item.Atualizar.Vodka(1);

                                                                        break;
                                                                    case 2:
                                                                        Usual.Escrever("A mulher fica assustada, e te dá a informação de onde você pode encontrar a peça do rádio do avião." +
                                                                            "\n\n[1] Ir até o local");
                                                                        Usual.Escolha(1);
                                                                        break;
                                                                }

                                                                break;
                                                            case 2:
                                                                Usual.Escrever("Você conseguiu:" +
                                                                    "\n\n- (3) Pente de munição" +
                                                                    "\n- (1) Capacete usado" +
                                                                    "\n- (1) Frasco suspeito");

                                                                Banco.Item.Atualizar.Munição(Banco.Item.Ler.Munição() + 3);
                                                                Banco.Item.Atualizar.CapaceteUsado(Banco.Item.Ler.CapaceteUsado() + 1);
                                                                Banco.Item.Atualizar.FrascoSuspeito(Banco.Item.Ler.FrascoSuspeito() + 1);
                                                                goto SoldadoExecutado;
                                                        }
                                                        break;
                                                }
                                                break;
                                        }
                                        break;
                                    case 2:
                                        Usual.Escrever("Os inimigos entram em sua casa. Você troca tiro com eles, e... acaba morrendo." +
                                            "\n\nVocê não é o John Wick.", ReadKey: true);

                                        Menus.GameOver();
                                        goto MenuPrincipal;
                                }
                                break;
                        }
                        break;
                    case 2:
                        Usual.Escrever("Você anda por um bom tempo, até que escuta um barulho vindo de dentro de uma das casas." +
                            "\n\n[1] Entrar na casa");



                        break;
                }
                break;
            case 3:
                Console.Clear();
                Usual.Escrever("Seu avião está muito danificado, não tem conserto. Seu bobão." +
                    "\n\n[1] Voltar");
                Usual.Escolha(1);
                goto PontoZero;
        }

        Console.ReadKey();
    }
}
