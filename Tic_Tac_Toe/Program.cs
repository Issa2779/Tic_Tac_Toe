namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = true;
            TicTacToe player1 = new TicTacToe("Player 1");
            TicTacToe player2 = new TicTacToe("Player 2");

            player1.Print();
            Console.WriteLine("\n");
            
            while (result)
            {
                bool dup = true;
                bool checkInput = true;
                int input;

                while (dup)
                {
                    Console.WriteLine("Player 1 (X): ");
                    checkInput = int.TryParse(Console.ReadLine(), out input);
                    dup = player1.setInput(input,'x');

                    result = player1.checkResult();
                    player1.Print();
                }

                if (!result) {break;}
                Console.WriteLine();

                dup = true;
                while (dup)
                {
                    Console.WriteLine("Player 2 (O): ");
                    checkInput = int.TryParse(Console.ReadLine(), out input);
                    dup = player2.setInput(input, 'o');

                    result = player2.checkResult();
                    player2.Print();
                }
            }
            
        }
        
    }
}