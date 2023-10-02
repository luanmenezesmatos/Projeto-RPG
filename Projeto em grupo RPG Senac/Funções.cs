using System.Data.SQLite;
using System.Drawing;
using static Projeto_em_grupo_RPG_Senac.Banco;

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
                    "│                          ----> A RETOMADA <----                          │",
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
            Banco.Reset();
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
                    insertCommand.Parameters.AddWithValue("@def", 10);
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

                        string updateQuery = $"UPDATE jogador SET jog_nome = \"{Nome}\" WHERE jog_id >= 0;";

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

                        string updateQuery = $"UPDATE jogador SET jog_hp = {Valor} WHERE jog_id >= 0;";

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

                        string updateQuery = $"UPDATE jogador SET jog_ata = {Valor} WHERE jog_id >= 0;";

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

                        string updateQuery = $"UPDATE jogador SET jog_def = {Valor} WHERE jog_id >= 0;";

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

                        string selectQuery = "SELECT jog_nome FROM jogador WHERE jog_id >= 0;";

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

                        string selectQuery = "SELECT jog_hp FROM jogador WHERE jog_id >= 0;";

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

                        string selectQuery = "SELECT jog_ata FROM jogador WHERE jog_id >= 0;";

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

                        string selectQuery = "SELECT jog_def FROM jogador WHERE jog_id >= 0;";

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

                        string[] Itens = { "lata de comida", "vodka", "frasco suspeito", "capacete usado", "munição", "granada", "faca", "peça de rádio" };

                        foreach (string str in Itens)
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
            Jogador.Atualizar.DEF(10);

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
            Console.Write($"│ HP: {Banco.Jogador.Ler.HP(),3}   │");
            Console.SetCursorPosition(Console.WindowWidth - 13, Console.WindowHeight - 18);
            Console.Write($"│ ATA: {Banco.Jogador.Ler.ATA(),3}  │");
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
    internal class História
    {
        public static void Mulher()
        {
            Usual.Escrever("Você entra na casa..." +
                                                    "\n\nE se depara com uma mulher." +
                                                    "\n\n[1] Pedir ajuda" +
                                                    "\n[2] Ameaçar para conseguir informações");
            switch (Usual.Escolha(2))
            {
                case 1:
                    Usual.Escrever("Você pede ajuda à mulher e diz tudo o que aconteceu com você. Ela tem compaixão de sua situação, e te dá comida e bebida, mas diz que não pode ficar aqui. " +
                        "\n\n- (2) Lata de comida" +
                        "\n- (1) Vodka" +
                        "\n\nAntes de você partir, ela diz conhecer um lugar onde você pode encontrar a peça necessária para consertar o rádio do avião." +
                        "\n\n[1] Ir até o local", ReadKey: true);

                    Item.Atualizar.LataDeComida(Item.Ler.LataDeComida() + 2);
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
                    // BATALHA FURTIVA

                    Usual.Escrever("Você entra furtivamente na instalação e consegue passar entre as tropas. Porém, há um guarda na entrada do galpão vindo em sua direção." +
                        "\n\n");

                    int hpEnemy = 80;
                    int ataEnemy;
                    int defEnemy;
                    bool defesa = false;
                    Random randint = new Random();

                    bool inimigoDerrotado = false; // Variável de controle para saber se o inimigo foi derrotado

                    while (!inimigoDerrotado)
                    {
                        Usual.Escrever("\n\nSelecione uma ação:" +
                        "\n\n[1] Ataque" +
                        "\n\n[2] Defesa" +
                        "\n\n[3] Usar item");

                        ataEnemy = randint.Next(5, 21);
                        defEnemy = randint.Next(5, 31);

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
                                            Usual.Escrever("Você comeu uma lata de comida, recuperando 20 de HP.");
                                            Banco.Item.Atualizar.LataDeComida(Banco.Item.Ler.LataDeComida() - 1);
                                            Banco.Jogador.Atualizar.HP(Banco.Jogador.Ler.HP() + 20);
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
                                if (ataEnemy - Banco.Jogador.Ler.DEF() > 0)
                                {
                                    Usual.Escrever($"O inimigo te ataca, causando {ataEnemy - Banco.Jogador.Ler.DEF()} de dano.");
                                    Banco.Jogador.Atualizar.HP(Banco.Jogador.Ler.HP() - (ataEnemy - Banco.Jogador.Ler.DEF()));
                                }
                                else
                                {
                                    Usual.Escrever("O inimigo não te causa dano.");
                                }
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
                            Usual.Escrever("Você derrotou o nazista! Fim da batalha.", ReadKey: true);

                            Menus.Victory();
                            inimigoDerrotado = true;
                        }
                    }
                    break;
                case 2:
                    // MODO PORRA LOCA

                    Usual.Escrever("Você invade a instalação, alertando todas as tropas nazistas. Você se depara com um esquadrão de 5 nazistas vigiando a entrada do galpão, armados até os dentes.");

                    int hpEnemy2 = 150;
                    int ataEnemy2 = 15;

                    bool defesa2 = false;

                    Random randint2 = new Random();

                    bool inimigoDerrotado2 = false; // Variável de controle para saber se o inimigo foi derrotado

                    while (!inimigoDerrotado2)
                    {
                        Usual.Escrever("\n\nSelecione uma ação:" +
                        "\n\n[1] Ataque" +
                        "\n\n[2] Defesa" +
                        "\n\n[3] Usar item");

                        switch (Usual.Escolha(3))
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
                                                Usual.Escrever("Você comeu uma lata de comida, recuperando 20 de HP.");
                                                Banco.Item.Atualizar.LataDeComida(Banco.Item.Ler.LataDeComida() - 1);
                                                Banco.Jogador.Atualizar.HP(Banco.Jogador.Ler.HP() + 20);
                                            }
                                            else
                                            {
                                                Usual.Escrever("A lata de comida não fez efeito.");
                                                Banco.Item.Atualizar.LataDeComida(Banco.Item.Ler.LataDeComida() - 1);
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
                                                Banco.Item.Atualizar.Vodka(Banco.Item.Ler.Vodka() - 1);
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
                                            if (randint2.Next(1, 101) <= 70) // 70% de chance de acertar (morre)
                                            {
                                                Usual.Escrever("Você bebeu o frasco suspeito, que era um veneno, então você morreu.");
                                                Banco.Item.Atualizar.FrascoSuspeito(Banco.Item.Ler.FrascoSuspeito() - 1);

                                                Menus.GameOver();
                                            }
                                            else
                                            {
                                                Usual.Escrever("O frasco suspeito não fez efeito.");
                                                Banco.Item.Atualizar.FrascoSuspeito(Banco.Item.Ler.FrascoSuspeito() - 1);
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
                                                Banco.Item.Atualizar.Granada(Banco.Item.Ler.Granada() - 1);
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
                            int ataqueAleatorio = randint2.Next(5, 16); // Ataque aleatório entre 5 e 15

                            if (defesa2)
                            {
                                if (ataqueAleatorio - Banco.Jogador.Ler.DEF() > 0)
                                {
                                    Usual.Escrever($"O inimigo te ataca, causando {ataqueAleatorio - Banco.Jogador.Ler.DEF()} de dano.");
                                    Banco.Jogador.Atualizar.HP(Banco.Jogador.Ler.HP() - (ataqueAleatorio - Banco.Jogador.Ler.DEF()));
                                }
                                else
                                {
                                    Usual.Escrever("O inimigo não te causa dano.");
                                }
                            }
                            else
                            {
                                Usual.Escrever($"O inimigo te ataca, causando {ataqueAleatorio} de dano.");
                                Banco.Jogador.Atualizar.HP(Banco.Jogador.Ler.HP() - ataqueAleatorio);
                            }       
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
                        }

                        if (hpEnemy2 <= 0)
                        {
                            Usual.Escrever("Você derrotou o esquadrão! Fim da batalha.", ReadKey: true);

                            Menus.Victory();
                            inimigoDerrotado2 = true;
                        }
                    }
                    break;
            }
        }
    }
}
