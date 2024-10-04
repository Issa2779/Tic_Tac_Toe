using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class TicTacToe
    { 
        static char[,] board = new char[,] {

            {'-','-','-' },
            {'-','-','-' },
            {'-','-','-' }

        };
        static char x = 'X';
        static char o = 'O';
        string name;
        public TicTacToe(string name) {
            this.name = name;
        }
        public bool setInput(int input,char xo)
        {

            switch (input) {

                case 1:
                    return inputValidate(Char.ToUpper(xo), 0, 0); 
                case 2:
                    return inputValidate(Char.ToUpper(xo), 0, 1); 
                case 3:
                    return inputValidate(Char.ToUpper(xo), 0, 2);
                case 4:
                    return inputValidate(Char.ToUpper(xo), 1, 0); 
                case 5:
                    return inputValidate(Char.ToUpper(xo), 1, 1);
                case 6:
                    return inputValidate(Char.ToUpper(xo), 1, 2);
                case 7:
                    return inputValidate(Char.ToUpper(xo), 2, 0);
                case 8:
                    return inputValidate(Char.ToUpper(xo), 2, 1);
                case 9:
                    return inputValidate(Char.ToUpper(xo), 2, 2);

                default:
                    break;

            }
            return true;
        }
        private bool inputValidate(char xo, int row, int col)
        {
            if (board[row, col] == x || board[row, col] == o)
            {
                Console.WriteLine("Pick another location");
                return true;
            }
            else
                board[row, col] = Char.ToUpper(xo);
            return false;
        }
        private void winnerAnnounce()
        {
            Console.WriteLine($"{name} is the Winner");
        }
        public bool checkResult()
        {
            int countX = 0;
            int countO = 0;

            //Check Diagonal X and O left to right
            for(int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i,i] == x)
                {
                    countX++;
                    if (countX == 3)
                    {
                        winnerAnnounce();
                        return false;
                    }
                }
                else if (board[i, i] == o)
                {
                    countO++;
                    if (countO == 3)
                    {
                        winnerAnnounce();
                        return false;
                    }
                }
            }
            countX = 0;
            countO = 0;

            //Check Diagonal X and O right to left
            for (int i = 0, j = 2; i < board.GetLength(0); i++, j--){

                if (board[i, j] == x)
                {
                    countX++;
                    if (countX == 3)
                    {
                        winnerAnnounce();
                        return false;
                    }
                }
                else if (board[i, j] == o)
                {
                    countO++;
                    if (countO == 3)
                    {
                        winnerAnnounce();
                        return false;
                    }
                }
            }

            countX = 0;
            countO = 0;

            //Check Horizonatal O and X
            for (int i = 0;i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == x)
                    {
                        countX++;
                        if (countX == 3)
                        {
                            winnerAnnounce();
                            return false;
                        }
                    }
                    else if (board[i, j] == o)
                    {
                        countO++;
                        if (countO == 3)
                        {
                            winnerAnnounce();
                            return false;
                        }
                    }
                }
                countX = 0;
                countO = 0;
            }

            //check vertical X and O
            for(int j = 0; j < board.GetLength(0); j++)
            {
                for(int i = 0;i <board.GetLength(1); i++)
                {
                    if (board[i, j] == x)
                    {
                        countX++;
                        if (countX == 3)
                        {
                            winnerAnnounce();
                            return false;
                        }
                    }
                    else if (board[i, j] == o)
                    {
                        countO++;
                        if (countO == 3)
                        {
                            winnerAnnounce();
                            return false;
                        }
                    }
                }
                countX = 0;
                countO = 0;
            }

            //check if draw
            int countD = 0;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == x || board[i, j] == o)
                    {
                        countD++;
                    }
                }
            }

            if(countD == 9)
            {
                Console.WriteLine("Draw");
                return false;
            }

            return true;
        }
        public void Print()
        {
            int count = 1;
            foreach (char c in board)
            {
                Console.Write(c + " ");
                if(count == 3)
                {
                    Console.WriteLine();
                    count = 0;
                }
                count++;
            }
        }
    }
}