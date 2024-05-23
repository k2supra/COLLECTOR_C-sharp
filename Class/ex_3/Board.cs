using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeBoard
{
    class Board
    {
        protected char[,] board;
        private string[] borders = new string[18] { "|", "|", " ", "-----+", "-----+", "-----", "|", "|", " ", "-----+", "-----+", "-----", "|", "|", " ", " ", " ", " " };
        public Board() { board = new char[3, 3]; fill(); }
        public void fill()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = ' ';
                }
            }
        }
        public bool isFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool isEmpty(int index1, int index2, Board brd)
        {
            return brd[index1, index2] == ' ';
        }
        public void display()
        {
            int counter = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"  {board[i, j]}  " + borders[counter]);
                    counter++;
                }
                Console.WriteLine();
                for (int ij = 0; ij < 3; ij++)
                {
                    Console.Write(borders[counter]);
                    counter++;
                }
                Console.WriteLine();
            }
        }
        public char this[int index1, int index2]
        {
            get { return board[index1, index2]; }
            set { board[index1, index2] = value; }
        }
    }
}