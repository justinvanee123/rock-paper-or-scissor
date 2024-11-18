using System;
class Program
{
    static void Main(String[] args)
    {

        Random random = new Random();
        bool playAgain = true;
        string player;
        string computer;

        while (playAgain)
        {
            player = "";
            computer = "";

            while (player != "ROCK" && player != "PAPER" && player != "SCISSOR")
            {
                Console.WriteLine("Enter ROCK, PAPER or SCISSOR: ");
                player = Console.ReadLine();
                player = player.ToUpper();

            }

            switch (random.Next(1, 4))
            {
                case 1:
                    computer = "ROCK";
                    break;
                case 2:
                    computer = "PAPER";
                    break;
                case 3:
                    computer = "SCISSOR ";
                    break;
            }

            Console.WriteLine("player: " + player);
            Console.WriteLine("computer: " + computer);

            switch(player) 
            {
                case "ROCK":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("Its a draw! ");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("You Lose! ");
                    }
                    else
                    {
                        Console.WriteLine("You win!");
                    }
                    break;
                case "PAPER":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("You win! ");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("Its a draw! ");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                    }
                    break;
                case "SCISSOR":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("You Lose! ");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("You win! ");
                    }
                    else
                    {
                        Console.WriteLine("Its a draw!");
                    }
                    break;
                   
            }

        }


        Console.ReadKey();
    }

}
