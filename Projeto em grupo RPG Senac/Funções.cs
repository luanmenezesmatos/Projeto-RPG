using System.Data.SQLite;
using System.Drawing;

namespace Projeto_em_grupo_RPG_Senac
{
    internal class Menus
    {
        public static void MensagemMaximizar()
        {
            string Mensagem = "Por favor, maximize a janela";

            int AlturaConsole = 0, LarguraConsole = 0;
            int AlturaMáximaConsole = Console.LargestWindowHeight;
            int LarguraMáximaConsole = Console.LargestWindowWidth;
            bool temp = true;

            while (temp)
            {
                if (Console.WindowHeight != AlturaConsole || Console.WindowWidth != LarguraConsole)
                {
                    // Desativando barra de escrita visível

                    Console.CursorVisible = false;

                    Console.Clear();

                    AlturaConsole = Console.WindowHeight;
                    LarguraConsole = Console.WindowWidth;

                    for (int i = 0; i < AlturaConsole / 2; i++)
                    {
                        Console.WriteLine("");
                    }
                    for (int i = 0; i < LarguraConsole / 2 - Mensagem.Length / 2; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(Mensagem);
                }

                if ((AlturaConsole >= AlturaMáximaConsole - 5) && (LarguraConsole >= LarguraMáximaConsole - 5))
                {
                    temp = false;

                    Console.BufferHeight = Console.WindowHeight;
                    Console.BufferWidth = Console.WindowWidth;
                }
            }

            Console.Clear();
        }
        public static void InserirNome() // Fazer
        {

        }
        public static void Inicio()
        {
            int AlturaConsole = Console.WindowHeight;
            int LarguraConsole = Console.WindowWidth;
            int AcharMaior = 0;
            string[] Título = new string[5]
                {
                    "┌──────────────────────────────────────────────────────────────────────────┐",
                    "│                                                                          │",
                    "│ ----> JORGE O SOLDADINHO, A RESTAURAÇÃO ÉPICA DE RÁDIO E A MULHER  <---- │",
                    "│                                                                          │",
                    "└──────────────────────────────────────────────────────────────────────────┘"
                };
            string[] Desenho = new string[9]
                {
                    "           ------",
                    "          | | # \\                                      |",
                    "          | ____ \\_________|----^\"|\"\"\"\"\"|\"\\___________ |" ,
                    "           \\___\\   FO + 94 >>    `\"\"\"\"\"\"\"\"     =====  \"|D" ,
                    "                 ^^-------____--\"\"\"\"\"\"\"\"\"\"+\"\"--_  __--\"|" ,
                    "                             `\"\"|\"-->####)+---|`\"\"     |" ,
                    "                                           \\  \\" ,
                    "                                          <- O -)" ,
                    "                                            `\"'"
                };
            string Mensagem = "APERTE QUALQUER TECLA PARA JOGAR";

            Console.SetCursorPosition(0, 2);

            foreach (string Parte in Título)
            {
                for (int i = 0; i < LarguraConsole / 2 - Título[1].Length / 2; i++)
                {
                    Console.Write(" ");
                }

                Console.Write(Parte + "\n");
            }
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");

            for (int i = 0; i < Desenho.Length; i++)
            {
                if (Desenho[i].Length > AcharMaior)
                {
                    AcharMaior = Desenho[i].Length;
                }
            }

            foreach (string Parte in Desenho)
            {
                for (int i = 0; i < LarguraConsole / 2 - AcharMaior / 2 - 10; i++)
                {
                    Console.Write(" ");
                }

                Console.Write(Parte + "\n");
            }
            Console.WriteLine("\n\n\n\n\n\n\n\n\n");

            for (int i = 0; i < LarguraConsole / 2 - Mensagem.Length / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write(Mensagem);

            Console.ReadKey();
            Console.Clear();
        }
        public static void GameOver()
        {
            int AlturaConsole = Console.WindowHeight;
            int LarguraConsole = Console.WindowWidth;
            int AcharMaior = 0;
            string[] Desenho = new string[11]
                {
                    "███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀" ,
                    "██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼" ,
                    "██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀" ,
                    "██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼" ,
                    "███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄" ,
                    "┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼" ,
                    "███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼" ,
                    "██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼" ,
                    "██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼" ,
                    "██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼" ,
                    "███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄"
                };
            string Mensagem = "APERTE QUALQUER TECLA PARA REINICIAR";

            // Desativando barra de escrita visível

            Console.CursorVisible = false;

            for (int i = 0; i < Desenho.Length; i++)
            {
                if (Desenho[i].Length > AcharMaior)
                {
                    AcharMaior = Desenho[i].Length;
                }
            }

            Console.Clear();
            for (int i = 0; i < AlturaConsole / 2 - 11; i++)
            {
                Console.WriteLine(" ");
            }
            foreach (string Parte in Desenho)
            {
                for (int i = 0; i < LarguraConsole / 2 - AcharMaior / 2; i++)
                {
                    Console.Write(" ");
                }

                Console.Write(Parte + "\n");
            }
            Console.WriteLine("\n\n\n\n");

            for (int i = 0; i < LarguraConsole / 2 - Mensagem.Length / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write(Mensagem);

            Thread.Sleep(2000);
            while (Console.KeyAvailable == true)
            {
                Console.ReadKey();
            }

            Console.ReadKey();
            Console.Clear();
            Banco.Reset();
        }
        public static void Victory()
        {
            int AlturaConsole = Console.WindowHeight;
            int LarguraConsole = Console.WindowWidth;
            int AcharMaior = 0;
            string[] Desenho = new string[5]
                {
                    "██    ██  ██████  ██    ██     ██     ██ ██ ███    ██ ██ " ,
                    " ██  ██  ██    ██ ██    ██     ██     ██ ██ ████   ██ ██ " ,
                    "  ████   ██    ██ ██    ██     ██  █  ██ ██ ██ ██  ██ ██ " ,
                    "   ██    ██    ██ ██    ██     ██ ███ ██ ██ ██  ██ ██    " ,
                    "   ██     ██████   ██████       ███ ███  ██ ██   ████ ██ "
                };
            string Mensagem = "APERTE QUALQUER TECLA PARA REINICIAR";

            // Desativando barra de escrita visível

            Console.CursorVisible = false;

            for (int i = 0; i < Desenho.Length; i++)
            {
                if (Desenho[i].Length > AcharMaior)
                {
                    AcharMaior = Desenho[i].Length;
                }
            }

            Console.Clear();
            for (int i = 0; i < AlturaConsole / 2 - 5; i++)
            {
                Console.WriteLine(" ");
            }
            foreach (string Parte in Desenho)
            {
                for (int i = 0; i < LarguraConsole / 2 - AcharMaior / 2; i++)
                {
                    Console.Write(" ");
                }

                Console.Write(Parte + "\n");
            }
            Console.WriteLine("\n\n\n\n");

            for (int i = 0; i < LarguraConsole / 2 - Mensagem.Length / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write(Mensagem);

            Thread.Sleep(2000);
            while (Console.KeyAvailable == true)
            {
                Console.ReadKey();
            }

            Console.ReadKey();
            Console.Clear();
            Banco.Reset();
        }
    }
    internal class Usual
    {
        public static void Escrever(string Texto, bool LimpaTela = true, bool ReadKey = false)
        {
            char var;

            // Desativando barra de escrita visível

            Console.CursorVisible = false;

            if (LimpaTela)
            {
                Console.Clear();
            }

            Info.Run();

            for (int i = 0; i < Texto.Length; i++)
            {
                var = Texto[i];

                if (Console.CursorLeft == 0 && Console.CursorTop == 0)
                {
                    Console.SetCursorPosition(2, 2);
                }
                else if (Console.CursorLeft == 0)
                {
                    int Linha_atual = Console.CursorTop;
                    Console.SetCursorPosition(2, Linha_atual);
                }
                else if (Console.CursorTop == Console.WindowHeight - 3)
                {
                    if (Console.CursorLeft == Console.WindowWidth - 4 || var == '\n')
                    {
                        Console.Write("...");
                        while (Console.KeyAvailable)
                        {
                            Console.ReadKey(true);
                        }
                        Console.ReadKey();
                        for (int j = 2; j < Console.WindowHeight - 2; j++)
                        {
                            Console.SetCursorPosition(2, j);
                            for (int k = 0; k < Console.WindowWidth - 3; k++)
                            {
                                Console.Write(" ");
                            }
                        }
                        if (var == '\n')
                        {
                            Console.SetCursorPosition(2, 1);
                        }
                        else
                        {
                            Console.SetCursorPosition(2, 2);
                        }
                    }
                }
                else if (Console.CursorLeft == Console.WindowWidth - 2)
                {
                    int Linha_atual = Console.CursorTop;
                    Console.SetCursorPosition(2, Linha_atual + 1);
                }

                Console.Write(var);

                // Tempo entre cada letra

                if (Console.KeyAvailable == false)
                {
                    if (var == '.' || var == '?' || var == '!')
                    {
                        Thread.Sleep(250);
                    }
                    Thread.Sleep(10);
                }
            }

            if (ReadKey == true)
            {
                while (Console.KeyAvailable == true)
                {
                    Console.ReadKey();
                }

                Console.ReadKey();
            }
        }
        public static int Escolha(int quant_opcoes)
        {
            int Linha_atual = Console.CursorTop;

            Console.SetCursorPosition(2, Linha_atual + 2);
            Console.Write(new string(": "));

        responder:
            int resposta;
            try
            {
                Console.CursorVisible = true;
                resposta = int.Parse(Console.ReadLine());
                Console.CursorVisible = false;
                if (resposta < 1 || resposta > quant_opcoes)
                {
                    Console.SetCursorPosition(4, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth - 6));
                    Console.SetCursorPosition(4, Console.CursorTop);
                    goto responder;
                }
                return resposta;
            }
            catch
            {
                Console.SetCursorPosition(4, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth - 6));
                Console.SetCursorPosition(4, Console.CursorTop);
                goto responder;
            }
        }
    }
    internal class História
    {
        public static void Mulher()
        {

        }
    }
    internal class Banco
    {
        private static void Criar_Banco_de_Dados()
        {
            string temp = Directory.GetCurrentDirectory();

            Directory.CreateDirectory($@"{temp}\Banco");
            SQLiteConnection.CreateFile($@"{temp}\Banco\GameDB.db"); // Cria o arquivo do banco de dados
        }
        private static void Criar_Tabelas()
        {
            string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS jogador (
                jog_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                jog_nome TEXT NOT NULL,
                jog_hp INT NOT NULL,
                jog_ata INT NOT NULL,
                jog_def INT NOT NULL
            );
            
            CREATE TABLE IF NOT EXISTS item (
                item_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                item_nome TEXT NOT NULL,
                item_quant INT NOT NULL
            );";

                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
        private static void Fazer_Inserts()
        {
            // INSERTS

            string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // INSERT  Jogador

                string insertQuery = "INSERT INTO jogador (jog_nome, jog_hp, jog_ata, jog_def) VALUES (@nome, @hp, @ata, @def);";

                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@nome", "Jorginho");
                    insertCommand.Parameters.AddWithValue("@hp", 40);
                    insertCommand.Parameters.AddWithValue("@ata", 15);
                    insertCommand.Parameters.AddWithValue("@def", 20);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();
                }

                // INSERT  item

                insertQuery = "INSERT INTO item (item_nome, item_quant) VALUES (@nome, @quant);";

                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@nome", "lata de comida");
                    insertCommand.Parameters.AddWithValue("@quant", 0);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "vodka");
                    insertCommand.Parameters.AddWithValue("@quant", 0);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "frasco suspeito");
                    insertCommand.Parameters.AddWithValue("@quant", 0);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "capacete usado");
                    insertCommand.Parameters.AddWithValue("@quant", 0);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "munição");
                    insertCommand.Parameters.AddWithValue("@quant", 0);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "granada");
                    insertCommand.Parameters.AddWithValue("@quant", 0);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "faca");
                    insertCommand.Parameters.AddWithValue("@quant", 0);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();

                    insertCommand.Parameters.AddWithValue("@nome", "peça de rádio");
                    insertCommand.Parameters.AddWithValue("@quant", 0);
                    insertCommand.ExecuteNonQuery();
                    insertCommand.Parameters.Clear();
                }

                connection.Close();
            }
        }
        public static void Run()
        {
            string temp = Directory.GetCurrentDirectory();

            if (File.Exists($@"{temp}\Banco\GameDB.db") == false) // Verifica se o banco de dados já existe
            {
                Criar_Banco_de_Dados();
                Criar_Tabelas();
                Fazer_Inserts();
            }
        }

        public class Jogador
        {
            public class Atualizar
            {
                public static void Nome(string Nome)
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = $"UPDATE jogador SET jog_nome = \"{Nome}\" WHERE jog_id = 1;";

                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                        {
                            updateCommand.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                }
                public static void HP(int Valor)
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = $"UPDATE jogador SET jog_hp = {Valor} WHERE jog_id = 1;";

                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                        {
                            updateCommand.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                }
                public static void ATA(int Valor)
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = $"UPDATE jogador SET jog_hp = {Valor} WHERE jog_id = 1;";

                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                        {
                            updateCommand.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                }
                public static void DEF(int Valor)
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = $"UPDATE jogador SET jog_hp = {Valor} WHERE jog_id = 1;";

                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                        {
                            updateCommand.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                }
            }
            public class Ler
            {
                public static string Nome()
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";
                    string temp = "";

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string selectQuery = "SELECT jog_nome FROM jogador WHERE jog_id = 1;";

                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    temp = reader.GetString(0);
                                }
                            }
                        }
                        connection.Close();
                    }
                    return temp;
                }

                public static int HP()
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";
                    int temp = 0;

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string selectQuery = "SELECT jog_hp FROM jogador WHERE jog_id = 1;";

                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    temp = reader.GetInt32(0);
                                }
                            }
                        }
                        connection.Close();
                    }
                    return temp;
                }

                public static int ATA()
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";
                    int temp = 0;

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string selectQuery = "SELECT jog_ata FROM jogador WHERE jog_id = 1;";

                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    temp = reader.GetInt32(0);
                                }
                            }
                        }
                        connection.Close();
                    }
                    return temp;
                }

                public static int DEF()
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";
                    int temp = 0;

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string selectQuery = "SELECT jog_def FROM jogador WHERE jog_id = 1;";

                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    temp = reader.GetInt32(0);
                                }
                            }
                        }
                        connection.Close();
                    }
                    return temp;
                }
            }
        }
        public class Item
        {
            public class Atualizar
            {
                public static void Todos(int Quantidade)
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string[] Itens = {"lata de comida", "vodka", "frasco suspeito", "capacete usado", "munição", "granada", "faca", "peça de rádio"};

                        foreach(string str in Itens)
                        {
                            string updateQuery = $"UPDATE item SET item_quant = {Quantidade} WHERE item_nome = \"{str}\";";

                            using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCommand.ExecuteNonQuery();
                            }
                        }

                        connection.Close();
                    }
                }
                public static void LataDeComida(int Quantidade)
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = $"UPDATE item SET item_quant = {Quantidade} WHERE item_nome = \"lata de comida\";";

                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                        {
                            updateCommand.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                }
                public static void Vodka(int Quantidade)
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = $"UPDATE item SET item_quant = {Quantidade} WHERE item_nome = \"vodka\";";

                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                        {
                            updateCommand.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                }
                public static void FrascoSuspeito(int Quantidade)
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = $"UPDATE item SET item_quant = {Quantidade} WHERE item_nome = \"frasco suspeito\";";

                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                        {
                            updateCommand.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                }
                public static void CapaceteUsado(int Quantidade)
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = $"UPDATE item SET item_quant = {Quantidade} WHERE item_nome = \"capacete usado\";";

                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                        {
                            updateCommand.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                }
                public static void Munição(int Quantidade)
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = $"UPDATE item SET item_quant = {Quantidade} WHERE item_nome = \"munição\";";

                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                        {
                            updateCommand.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                }
                public static void Granada(int Quantidade)
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = $"UPDATE item SET item_quant = {Quantidade} WHERE item_nome = \"granada\";";

                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                        {
                            updateCommand.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                }
                public static void Faca(int Quantidade)
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = $"UPDATE item SET item_quant = {Quantidade} WHERE item_nome = \"faca\";";

                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                        {
                            updateCommand.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                }
                public static void PeçaDeRádio(int Quantidade)
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = $"UPDATE item SET item_quant = {Quantidade} WHERE item_nome = \"peça de rádio\";";

                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                        {
                            updateCommand.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                }
            }
            public class Ler
            {
                public static int LataDeComida()
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";
                    int temp = 0;

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string selectQuery = "SELECT item_quant FROM item WHERE item_nome = \"lata de comida\";";

                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    temp = reader.GetInt32(0);
                                }
                            }
                        }
                        connection.Close();
                    }
                    return temp;
                }
                public static int Vodka()
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";
                    int temp = 0;

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string selectQuery = "SELECT item_quant FROM item WHERE item_nome = \"vodka\";";

                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    temp = reader.GetInt32(0);
                                }
                            }
                        }
                        connection.Close();
                    }
                    return temp;
                }
                public static int FrascoSuspeito()
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";
                    int temp = 0;

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string selectQuery = "SELECT item_quant FROM item WHERE item_nome = \"frasco suspeito\";";

                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    temp = reader.GetInt32(0);
                                }
                            }
                        }
                        connection.Close();
                    }
                    return temp;
                }
                public static int CapaceteUsado()
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";
                    int temp = 0;

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string selectQuery = "SELECT item_quant FROM item WHERE item_nome = \"capacete usado\";";

                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    temp = reader.GetInt32(0);
                                }
                            }
                        }
                        connection.Close();
                    }
                    return temp;
                }
                public static int Munição()
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";
                    int temp = 0;

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string selectQuery = "SELECT item_quant FROM item WHERE item_nome = \"munição\";";

                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    temp = reader.GetInt32(0);
                                }
                            }
                        }
                        connection.Close();
                    }
                    return temp;
                }
                public static int Granada()
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";
                    int temp = 0;

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string selectQuery = "SELECT item_quant FROM item WHERE item_nome = \"granada\";";

                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    temp = reader.GetInt32(0);
                                }
                            }
                        }
                        connection.Close();
                    }
                    return temp;
                }
                public static int Faca()
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";
                    int temp = 0;

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string selectQuery = "SELECT item_quant FROM item WHERE item_nome = \"faca\";";

                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    temp = reader.GetInt32(0);
                                }
                            }
                        }
                        connection.Close();
                    }
                    return temp;
                }
                public static int PeçaDeRádio()
                {
                    string connectionString = $"Data Source=Banco\\GameDB.db;Version=3;";
                    int temp = 0;

                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string selectQuery = "SELECT item_quant FROM item WHERE item_nome = \"peça de rádio\";";

                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    temp = reader.GetInt32(0);
                                }
                            }
                        }
                        connection.Close();
                    }
                    return temp;
                }
            }
        }
        public static void Reset()
        {
            Jogador.Atualizar.Nome("Jorginho");
            Jogador.Atualizar.HP(40);
            Jogador.Atualizar.ATA(15);
            Jogador.Atualizar.DEF(20);

            Item.Atualizar.Todos(0);
        }
    }
    internal class Info
    {
        public static void Run() 
        {
            int LeftAtual = Console.CursorLeft;
            int TopAtual = Console.CursorTop;
            bool Vodka = false, Faca = false, Granada = false, CapaceteUsado = false, FrascoSuspeito = false, LataDeComida = false, Munição = false, PeçaDeRádio = false;

            Console.SetCursorPosition(Console.WindowWidth - 13, Console.WindowHeight - 20);
            Console.Write("┌───────────┐");
            Console.SetCursorPosition(Console.WindowWidth - 13, Console.WindowHeight - 19);
            Console.Write($"│ HP: {Banco.Jogador.Ler.HP(), 3}   │");
            Console.SetCursorPosition(Console.WindowWidth - 13, Console.WindowHeight - 18);
            Console.Write($"│ ATA: {Banco.Jogador.Ler.ATA(), 3}  │");
            Console.SetCursorPosition(Console.WindowWidth - 13, Console.WindowHeight - 17);
            Console.Write($"│ DEF: {Banco.Jogador.Ler.DEF(),3}  │");
            Console.SetCursorPosition(Console.WindowWidth - 13, Console.WindowHeight - 16);
            Console.Write($"└───────────┘");

            for (int i = 0; i < 12; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth - 23, Console.WindowHeight - 14 + i);
                if (i == 0)
                {
                    Console.Write("┌─────────────────────┐");
                }
                else if (i == 1)
                {
                    Console.Write("│        ITEMS        │");
                }
                else if (i == 11)
                {
                    Console.Write("└─────────────────────┘");
                }
                else
                {
                    Console.Write("│                     │");
                }
            }
            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth - 21, Console.WindowHeight - 11 + i);
                if (Banco.Item.Ler.Vodka() > 0 && Vodka == false)
                {
                    Console.Write($"Vodka: {Banco.Item.Ler.Vodka(),2}");
                    Vodka = true;
                }
                else if (Banco.Item.Ler.Faca() > 0 && Faca == false)
                {
                    Console.Write($"Faca: {Banco.Item.Ler.Faca(),2}");
                    Faca = true;
                }
                else if (Banco.Item.Ler.Granada() > 0 && Granada == false)
                {
                    Console.Write($"Granada: {Banco.Item.Ler.Granada(),2}");
                    Granada = true;
                }
                else if (Banco.Item.Ler.CapaceteUsado() > 0 && CapaceteUsado == false)
                {
                    Console.Write($"Capacete usado: {Banco.Item.Ler.CapaceteUsado(),2}");
                    CapaceteUsado = true;
                }
                else if (Banco.Item.Ler.FrascoSuspeito() > 0 && FrascoSuspeito == false)
                {
                    Console.Write($"Frasco suspeito: {Banco.Item.Ler.FrascoSuspeito(),2}");
                    FrascoSuspeito = true;
                }
                else if (Banco.Item.Ler.LataDeComida() > 0 && LataDeComida == false)
                {
                    Console.Write($"Lata de comida: {Banco.Item.Ler.LataDeComida(),2}");
                    LataDeComida = true;
                }
                else if (Banco.Item.Ler.Munição() > 0 && Munição == false)
                {
                    Console.Write($"Munição: {Banco.Item.Ler.Munição(),2}");
                    Munição = true;
                }
                else if (Banco.Item.Ler.PeçaDeRádio() > 0 && PeçaDeRádio == false)
                {
                    Console.Write($"Peça de rádio: {Banco.Item.Ler.PeçaDeRádio(),2}");
                    PeçaDeRádio = true;
                }
            }

            Console.SetCursorPosition(LeftAtual, TopAtual);
        }
    }
}
