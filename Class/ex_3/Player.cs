using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeBoard;

namespace TicTacToePlayer
{
    class Player
    {
        public char Symbol { get; set; }
        public Player(char symbol) { this.Symbol = symbol; }

        public virtual void placeSymbol(Board board)
        {
            Console.WriteLine($"Player {this.Symbol}, choose a position to place: ");
            Console.Write("Enter a row: ");
            int row = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Enter a col: ");
            int col = int.Parse(Console.ReadLine()) - 1;
            if (board.isEmpty(row, col, board))
            {
                board[row, col] = this.Symbol;
            }
            else
            {
                Console.WriteLine("This place is not empty. Please, choose another position");
                placeSymbol(board);
            }
        }
    }
    class Bot : Player
    {
        private Random random;
        public Bot(char symbol) : base(symbol) { this.random = new Random(); }
        public override void placeSymbol(Board brd)
        {
            int random_index = random.Next(countFreePlaces(brd));
            string[] string_index = collectFreePlaces(brd)[random_index].Split(',');
            int index1 = int.Parse(string_index[0]);
            int index2 = int.Parse(string_index[1]);

            Console.WriteLine($"Bot {this.Symbol} placed symbol at position ({index1 + 1}, {index2 + 1})");
            brd[index1, index2] = this.Symbol;
        }
        public int countFreePlaces(Board brd)
        {
            int counter = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (brd.isEmpty(i, j, brd))
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
        public string[] collectFreePlaces(Board brd)
        {
            string[] free = new string[countFreePlaces(brd)];
            byte counter = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (brd.isEmpty(i, j, brd))
                    {
                        free[counter] = $"{i},{j}";
                        counter++;
                    }
                }
            }
            return free;
        }
    }
}