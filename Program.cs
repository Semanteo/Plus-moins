using System;

namespace Jeu1
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
	
	// Tant que le jeu n'est pas fini (game over, vous savez !)...
	while (!over)
	{
		string inputString = Console.ReadLine();
		int inputNumber;
		
		// Si la conversion a marché...
		if (int.TryParse(inputString, out inputNumber))
		{
			// Si c'est en dehors des limites...
			if (inputNumber < 0
			    || inputNumber > 100)
			{
				Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 (inclus).");
			}
			
			// Si c'est le bon...
			else if (inputNumber == secretNumber)
			{
				Console.WriteLine("Vous avez gagné ! Le nombre mystère était : {0}.", secretNumber);
				over = true;
			}
			
			// Si c'est trop petit...
			else if (inputNumber < secretNumber)
			{
				Console.WriteLine("C'est plus.");
			}
			
			// Si c'est trop grand...
			else
			{
				Console.WriteLine("C'est moins.");
			}
		}
		// Si la conversion n'a pas réussi...
		else
		{
			Console.WriteLine("Une erreur est survenue lors de la conversion.");
			Console.WriteLine("Veuillez entrer un nombre compris entre 1 et 100 (inclus).");
		}
	}
	
	// L'instruction suivante permet de marquer une pause à la fin : le programme attend que vous appuyez sur Entrée et va récupérer ce que vous avez écrit.
	// Ici, le résultat de la fonction n'est pas utilisé : on n'affecte aucune variable avec.
	// On utilise donc la fonction comme si elle rendait void.
	Console.ReadLine();

}
    }
}
