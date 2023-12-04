using System;

namespace Tic_Tac_Toe_Excercise
{
    public class Program
    {
        //the playflied
        static char[,] playField =
        {
            {'1', '2', '3' }, //row 0
            {'4', '5', '6' }, //row 1
            {'7', '8', '9' }, //row 2
        };
        static int turns = 0;
        public static void Main(string[] args)
        {
            int player = 2; //player 1 starts
            int input = 0;
            bool inputConrrect = true;

            //Run code as long as the program runs
            
            //Testing if field is already taken
            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                SetFied();
                #region
                //Check winning condition
                char[] playerChars = { 'X', 'O' };
                foreach(char playerChar in playerChars)
                {
                    if (((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar))
                        || ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar))
                        || ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar))
                        || ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 1] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[1, 2] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar))
                        )
                    {
                        if(playerChar == 'X')
                        {
                            Console.WriteLine("\nPlayer 1 has won");
                        }else if(playerChar == 'O')
                        {
                            Console.WriteLine("\nPlayer 2 has won");
                        }
                        //TODO reset field

                        Console.WriteLine("Please press any key to reset the game!");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                    else if(turns == 10)
                    {
                        Console.WriteLine("\nDRAWW");
                        Console.WriteLine("Please press any key to reset the game!");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }

                }
                #endregion

                #region
                do
                {
                    Console.Write($"\nEnter {player}: Chose your field!: ");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number");
                    }

                    if ((input == 1 ) && (playField[0, 0] == '1'))
                        inputConrrect = true;
                    else if ((input == 2) && (playField[0,1] == '2'))
                        inputConrrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputConrrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputConrrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputConrrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputConrrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputConrrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputConrrect = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        inputConrrect = true;
                    else
                    {
                        Console.WriteLine("\n Incorrect input! Please use another field!");
                        inputConrrect = false;
                    }
                } while (!inputConrrect);
                #endregion
            } while (true);
            Console.ReadKey();
        }

        public static void ResetField()
        {
            char[,] playFieldInitial =
            {
                {'1', '2', '3' }, //row 0
                {'4', '5', '6' }, //row 1
                {'7', '8', '9' }, //row 2
            };
            playField = playFieldInitial;
            SetFied();
            turns = 0;
        }
        public static void SetFied()
        {
            Console.Clear();
            Console.WriteLine("    |    |    ");
            //TODO replace numbers with variables
            Console.WriteLine(" {0}  |  {1} |  {2}", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            //TODO replace numbers with variables
            Console.WriteLine(" {0}  |  {1} |  {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            //TODO replace numbers with variables
            Console.WriteLine(" {0}  |  {1} |  {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("    |    |    ");
            turns++;
        }
        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';

            if (player == 1)
            {
                playerSign = 'O';
            }
            else if (player == 2)
            {
                playerSign = 'X';
            }
            switch (input)
            {
                case 1:
                    playField[0, 0] = playerSign;
                    break;
                case 2:
                    playField[0, 1] = playerSign;
                    break;
                case 3:
                    playField[0, 2] = playerSign;
                    break;
                case 4:
                    playField[1, 0] = playerSign;
                    break;
                case 5:
                    playField[1, 1] = playerSign;
                    break;
                case 6:
                    playField[1, 2] = playerSign;
                    break;
                case 7:
                    playField[2, 0] = playerSign;
                    break;
                case 8:
                    playField[2, 1] = playerSign;
                    break;
                case 9:
                    playField[2, 2] = playerSign;
                    break;
            }
        }
    }
}
