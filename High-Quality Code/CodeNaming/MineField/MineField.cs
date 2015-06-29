////Refactor and improve the naming in the C# source project “3. Naming-Identifiers-Homework.zip”. You are allowed to make other improvements in the code as well (not only naming) as well as to fix bugs.//
////Task4//
namespace MineField
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Mines
    {
        private const int MAX = 35;
        private static string comand = string.Empty;
        private static char[,] field = CreateField();
        private static char[,] bombs = GetBombs();
        private static int counter = 0;
        private static bool explosion = false;
        private static List<Result> winers = new List<Result>(6);
        private static int fieldRow = 0;
        private static int fieldCol = 0;
        private static bool startGame = true;
        private static bool passedField = false;

        public static void Main(string[] args)
        {
            Game();
        }

        public static void Game()
        {
            try
            {
                do
                {
                    if (startGame)
                    {
                        Console.WriteLine("Let's play on “MineField”.Try your luck and discover the fields without bombs." +
                        " Comand 'top' present a chart, 'restart' start new game, 'exit' exit from the game!");
                        DrawField(field);
                        startGame = false;
                    }

                    Console.Write("Enter row and column : ");
                    comand = Console.ReadLine().Trim();
                    if (comand.Length >= 3)
                    {
                        if (int.TryParse(comand[0].ToString(), out fieldRow) &&
                            int.TryParse(comand[2].ToString(), out fieldCol) &&
                            fieldRow <= field.GetLength(0) && fieldCol <= field.GetLength(1))
                        {
                            comand = "turn";
                        }
                    }

                    if (fieldRow > 4 || fieldCol > 9)
                    {
                        throw new ArgumentOutOfRangeException("Outside of the field");
                    }

                    switch (comand)
                    {
                        case "top": 
                            Chart(winers); 
                            break;
                        case "restart":
                            field = CreateField();
                            bombs = GetBombs();
                            DrawField(field);
                            explosion = false;
                            startGame = false;
                            break;
                        case "exit":
                            Console.WriteLine("Bay, Bay, Bay!");
                            break;
                        case "turn":
                            if (bombs[fieldRow, fieldCol] != '*')
                            {
                                if (bombs[fieldRow, fieldCol] == '-')
                                {
                                    YourTurn(field, bombs, fieldRow, fieldCol);
                                    counter++;
                                }

                                if (MAX == counter)
                                {
                                    passedField = true;
                                }
                                else
                                {
                                    DrawField(field);
                                }
                            }
                            else
                            {
                                explosion = true;
                            }

                            break;
                        default:
                            Console.WriteLine("\nGreshka! invalid comand\n");
                            break;
                    }

                    if (explosion)
                    {
                        DrawField(bombs);
                        Console.Write("\nHrrrrrr! Die like a hero with {0} points. " + "Enter username: ", counter);
                        string username = Console.ReadLine();
                        Result userResult = new Result(username, counter);
                        if (winers.Count < 5)
                        {
                            winers.Add(userResult);
                        }
                        else
                        {
                            for (int i = 0; i < winers.Count; i++)
                            {
                                if (winers[i].Points < userResult.Points)
                                {
                                    winers.Insert(i, userResult);
                                    winers.RemoveAt(winers.Count - 1);
                                    break;
                                }
                            }
                        }

                        winers.Sort((Result r1, Result r2) => r2.Name.CompareTo(r1.Name));
                        winers.Sort((Result r1, Result r2) => r2.Points.CompareTo(r1.Points));
                        Chart(winers);
                        field = CreateField();
                        bombs = GetBombs();
                        counter = 0;
                        explosion = false;
                        startGame = true;
                    }

                    if (passedField)
                    {
                        Console.WriteLine("\nBRAVOOOS! Open 35 cells without drop of blood.");
                        DrawField(bombs);
                        Console.WriteLine("Enter your name, brother: ");
                        string name = Console.ReadLine();
                        Result points = new Result(name, counter);
                        winers.Add(points);
                        Chart(winers);
                        field = CreateField();
                        bombs = GetBombs();
                        counter = 0;
                        passedField = false;
                        startGame = true;
                    }
                }
                while (comand != "exit");
                Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
                Console.WriteLine("AREEEEEEeeeeeee.");
                Console.Read();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Chart(List<Result> result)
        {
            Console.WriteLine("\nPoints:");
            if (result.Count > 0)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, result[i].Name, result[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Chart!\n");
            }
        }

        private static void YourTurn(char[,] field, char[,] bombs, int row, int col)
        {
            char bombsCount = Count(bombs, row, col);
            bombs[row, col] = bombsCount;
            field[row, col] = bombsCount;
        }

        private static void DrawField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateField()
        {
            int fieldRows = 5;
            int fieldColumns = 10;
            char[,] field = new char[fieldRows, fieldColumns];
            for (int i = 0; i < fieldRows; i++)
            {
                for (int j = 0; j < fieldColumns; j++)
                {
                    field[i, j] = '?';
                }
            }

            return field;
        }

        private static char[,] GetBombs()
        {
            int bombRows = 5;
            int bombCols = 10;
            char[,] gameField = new char[bombRows, bombCols];

            for (int i = 0; i < bombRows; i++)
            {
                for (int j = 0; j < bombCols; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> bombsPositions = new List<int>();
            while (bombsPositions.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!bombsPositions.Contains(randomNumber))
                {
                    bombsPositions.Add(randomNumber);
                }
            }

            foreach (int position in bombsPositions)
            {
                int col = position / bombCols;
                int row = position % bombCols;
                if (row == 0 && position != 0)
                {
                    col--;
                    row = bombCols;
                }
                else
                {
                    row++;
                }

                gameField[col, row - 1] = '*';
            }

            return gameField;
        }

        private static void Accounts(char[,] field)
        {
            int cols = field.GetLength(0);
            int rows = field.GetLength(1);

            for (int row = 0; row < cols; row++)
            {
                for (int col = 0; col < rows; col++)
                {
                    if (field[row, col] != '*')
                    {
                        char count = Count(field, row, col);
                        field[row, col] = count;
                    }
                }
            }
        }

        private static char Count(char[,] bombField, int row, int col)
        {
            int countBombs = 0;
            int rows = bombField.GetLength(0);
            int cols = bombField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (bombField[row - 1, col] == '*')
                {
                    countBombs++;
                }
            }

            if (row + 1 < rows)
            {
                if (bombField[row + 1, col] == '*')
                {
                    countBombs++;
                }
            }

            if (col - 1 >= 0)
            {
                if (bombField[row, col - 1] == '*')
                {
                    countBombs++;
                }
            }

            if (col + 1 < cols)
            {
                if (bombField[row, col + 1] == '*')
                {
                    countBombs++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (bombField[row - 1, col - 1] == '*')
                {
                    countBombs++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (bombField[row - 1, col + 1] == '*')
                {
                    countBombs++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (bombField[row + 1, col - 1] == '*')
                {
                    countBombs++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (bombField[row + 1, col + 1] == '*')
                {
                    countBombs++;
                }
            }

            return char.Parse(countBombs.ToString());
        }

        public class Result
        {
            private string name;
            private int points;

            public Result()
            {
            }

            public Result(string name, int points)
            {
                this.Name = name;
                this.Points = points;
            }

            public string Name
            {
                get 
                { 
                    return this.name; 
                }

                set 
                { 
                    this.name = value;
                }
            }

            public int Points
            {
                get 
                { 
                    return this.points;
                }

                set 
                { 
                    this.points = value;
                }
            }
        }
    }
}
