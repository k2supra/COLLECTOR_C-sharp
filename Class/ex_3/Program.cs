
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeBoard;
using TicTacToePlayer;

namespace TicTacToeGame
{
    class TicTacToeGame
    {
        private Player player1;
        private Player player2;
        private Board board;
        private Random random;
        private Player current_player;
        public TicTacToeGame(bool player) 
        {
            this.board = new Board();
            this.random = new Random();
            char symbol1 = random.Next(2) == 0 ? 'X' : 'O';
            char symbol2 = symbol1 == 'X' ? 'O' : 'X';
            this.player1 = new Player(symbol1);
            if (!player)
            {
                this.player2 = new Bot(symbol2);
            }
            else 
            {
                this.player2 = new Player(symbol2);
            }
            this.current_player = random.Next(2) == 0 ? player1 : player2;
        }
        public bool isWinner()
        {
            if (this.board[0, 0] == current_player.Symbol && this.board[0, 1] == current_player.Symbol && this.board[0, 2] == current_player.Symbol) { this.board.display(); return true; }
            if (this.board[1, 0] == current_player.Symbol && this.board[1, 1] == current_player.Symbol && this.board[1, 2] == current_player.Symbol) { this.board.display(); return true; }
            if (this.board[2, 0] == current_player.Symbol && this.board[2, 1] == current_player.Symbol && this.board[2, 2] == current_player.Symbol) { this.board.display(); return true; }
            if (this.board[0, 0] == current_player.Symbol && this.board[1, 0] == current_player.Symbol && this.board[2, 0] == current_player.Symbol) { this.board.display(); return true; }
            if (this.board[0, 1] == current_player.Symbol && this.board[1, 1] == current_player.Symbol && this.board[2, 1] == current_player.Symbol) { this.board.display(); return true; }
            if (this.board[0, 2] == current_player.Symbol && this.board[1, 2] == current_player.Symbol && this.board[2, 2] == current_player.Symbol) { this.board.display(); return true; }
            if (this.board[0, 0] == current_player.Symbol && this.board[1, 1] == current_player.Symbol && this.board[2, 2] == current_player.Symbol) { this.board.display(); return true; }
            if (this.board[0, 2] == current_player.Symbol && this.board[1, 1] == current_player.Symbol && this.board[2, 0] == current_player.Symbol) { this.board.display(); return true; }
            return false;
        }
        public void game()
        {
            while (!isWinner())
            {
                current_player = current_player == player1 ? player2 : player1;
                if (this.board.isFull())
                {
                    board.display();
                    Console.WriteLine("The game is a draw!");
                    break;
                }
                board.display();
                current_player.placeSymbol(this.board);   
            }
            if (isWinner())
            {
                Console.WriteLine($"Congratulations! Player {current_player.Symbol} has won the game!");
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write(" 1 - player vs bot | 2 - player vs player");
                byte choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            TicTacToeGame tttgame = new TicTacToeGame(false);
                            tttgame.game();
                        }
                        break;
                    case 2:
                        {
                            TicTacToeGame tttgame = new TicTacToeGame(true);
                            tttgame.game();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}