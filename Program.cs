using System;

namespace Plus
{
    class Program
    {
static void Main(string[] args)
{
	bool over = false;
	Random rand = new Random();
	int secretNumber = rand.Next(101);

	Console.WriteLine("Bienvenue dans le jeu du Plus ou Moins !");
	Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 (inclus).");
	
	while (!over)
	{
		string inputString = Console.ReadLine();
		int inputNumber;
		if (int.TryParse(inputString, out inputNumber))
		{
			if (inputNumber < 0
			    || inputNumber > 100)
			{
				Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 (inclus).");
			}
			
			else if (inputNumber == secretNumber)
			{
				Console.WriteLine("Vous avez gagné ! Le nombre mystère était : {0}.", secretNumber);
				over = true;
			}
			
			else if (inputNumber < secretNumber)
			{
				Console.WriteLine("C'est plus.");
			}
			
			else
			{
				Console.WriteLine("C'est moins.");
			}
		}
		else
		{
			Console.WriteLine("Une erreur est survenue lors de la conversion.");
			Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 (inclus).");
		}
	}
	Console.ReadLine();
}
    }
}
