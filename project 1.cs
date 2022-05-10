using System;

namespace TicTacToe2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the tic-tac-toe game!");

            //game

            string[] playerMoves = new string[9];
            Console.WriteLine("What's the state of the first field?");
            Console.WriteLine("What's the state of the second field?");
            Console.WriteLine("What's the state of the third field?");
            Console.WriteLine("What's the state of the fourth field?");
            Console.WriteLine("What's the state of the fifth field?");
            Console.WriteLine("What's the state of the sixth field?");
            Console.WriteLine("What's the state of the seventh field?");
            Console.WriteLine("What's the state of the eight field?");
            Console.WriteLine("What's the state of the nineth field?");

            playerMoves[0] = (Console.ReadLine());
            playerMoves[1] = (Console.ReadLine());
            playerMoves[2] = (Console.ReadLine());
            playerMoves[3] = (Console.ReadLine());
            playerMoves[4] = (Console.ReadLine());
            playerMoves[5] = (Console.ReadLine());
            playerMoves[6] = (Console.ReadLine());
            playerMoves[7] = (Console.ReadLine());
            playerMoves[8] = (Console.ReadLine());

            //Board

            Console.WriteLine($" {playerMoves[0]} | {playerMoves[1]} | {playerMoves[2]} ");
            Console.WriteLine("- -+- -+- -");
            Console.WriteLine($" {playerMoves[3]} | {playerMoves[4]} | {playerMoves[5]} ");
            Console.WriteLine("- -+- -+- o-");
            Console.WriteLine($" {playerMoves[6]} | {playerMoves[7]} | {playerMoves[8]} ");

            Console.WriteLine();
            Console.WriteLine("Game Over!");
        }
    }
}