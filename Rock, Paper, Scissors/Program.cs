namespace Rock__Paper__Scissors
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();

			int playerScore = 0;
			int enemyScore = 0;

            Console.WriteLine("Welcome To Rock, Paper, Scissors...(Also known as Dead or Alive's Predecessor)");

			while (playerScore != 3 && enemyScore !=3)
			{
                Console.WriteLine("\nPlayer Score - " + playerScore + " Enemy Score - " + enemyScore);
                Console.WriteLine("\nPlease enter 'r' for Rock, 'p' for Paper, or any other key for Scissors");
				string playerChoice = Console.ReadLine();

				int enemyChoice = random.Next(0, 3);

				if (enemyChoice == 0)
				{
                    Console.WriteLine("Enemy chose Rock.");

					switch (playerChoice)
					{
						case "r":
                            Console.WriteLine("Draw!");
							break;
						case "p":
                            Console.WriteLine("You Win!");
							playerScore++;
							break;
						default:
                            Console.WriteLine("You Lose!");
							enemyScore++;
							break;
                    }
				}
				else if (enemyChoice == 1)
				{
                    Console.WriteLine("Enemy chose Paper.");

					switch (playerChoice)
					{
						case "r":
							Console.WriteLine("You Lose!");
							enemyScore++;
							break;
						case "p":
							Console.WriteLine("Draw!");	
							break;
						default:
							Console.WriteLine("You Win!");
							playerScore++;
							break;
					}
				}
				else
				{
                    Console.WriteLine("Enemy chose Scissors.");

					switch (playerChoice)
					{
						case "r":
							Console.WriteLine("You Win!");
							playerScore++;
							break;
						case "p":
							Console.WriteLine("You Lose!");
							enemyScore++;
							break;
						default:
							Console.WriteLine("Draw!");
							break;
					}
				}
            }

			if (playerScore == 3)
			{
                Console.WriteLine("You are the Victor!");
            }
			else
			{
                Console.WriteLine("You have been defeated in battle...come back after training.");
            }
        }
	}
}