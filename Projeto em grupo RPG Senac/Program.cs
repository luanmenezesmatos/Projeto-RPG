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
                                                História.Mulher();
                                                goto MenuPrincipal;
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

                                                        bool partiu = false;

                                                        if (partiu)
                                                        {
                                                            Usual.Escrever("Você parte pra cima do soldado inimigo e... consegue executar ele. Então, você percebe que a porta dos fundos está livre e decide fugir dali." +
                                                            "\n\nVocê anda por um bom tempo, até que escuta um barulho vindo de uma das casas." +
                                                            "\n\n[1] Entrar na casa");
                                                            switch (Usual.Escolha(1))
                                                            {
                                                                case 1:
                                                                    História.Mulher();
                                                                    goto MenuPrincipal;
                                                            }
                                                        } else
                                                        {
                                                            Usual.Escrever("Você parte pra cima do soldado inimigo e... consegue executar ele. Então, você percebe que a porta dos fundos está livre e decide fugir dali." +
                                                            "\n\nVocê anda por um bom tempo, até que escuta um barulho vindo de uma das casas." +
                                                            "\n\n[1] Entrar na casa" +
                                                            "\n[2] Pilhar o corpo");
                                                            switch (Usual.Escolha(2))
                                                            {
                                                                case 1:
                                                                    História.Mulher();
                                                                    goto MenuPrincipal;
                                                                case 2:
                                                                    Usual.Escrever("Você conseguiu:" +
                                                                        "\n\n- (3) Pente de munição" +
                                                                        "\n- (1) Capacete usado" +
                                                                        "\n- (1) Frasco suspeito");

                                                                    Banco.Item.Atualizar.Munição(Banco.Item.Ler.Munição() + 3);
                                                                    Banco.Item.Atualizar.CapaceteUsado(Banco.Item.Ler.CapaceteUsado() + 1);
                                                                    Banco.Item.Atualizar.FrascoSuspeito(Banco.Item.Ler.FrascoSuspeito() + 1);

                                                                    partiu = true;
                                                                    goto SoldadoExecutado;
                                                            }
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
                        Usual.Escolha(1);
                        História.Mulher();
                        goto MenuPrincipal;
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
