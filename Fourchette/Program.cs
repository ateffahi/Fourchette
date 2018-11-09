using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // gestion des fichiers

namespace Fourchette
{
    class Program
    {
        static string path = @"C:\Temp\Resultat.txt";


        static void Main(string[] args)
        {

          
            int sortie;
            int chance = 10;
            int i;

            bool jeu = true;

            while (jeu == true)
            {
                Random rnd = new Random();
                int numbre = rnd.Next(1, 100);
                Console.WriteLine(numbre);
                Console.WriteLine($"Entrer un chiffre entre 1 et 100, vous avez {chance} chances");
                for (i = 1; i <= 10; i++)
                {

                    string essai = Console.ReadLine();
                    bool success = Int32.TryParse(essai, out sortie);

                  
                    if (success && (sortie > 0 && sortie <= 100))
                    {

                        if (sortie > numbre)
                        {
                            Console.WriteLine("c'est moins");
                        }
                        else if (sortie < numbre)
                        {
                            Console.WriteLine("c'est plus");
                        }
                        else
                        {
                            Console.WriteLine("Super Vous avez gagner \r\n"); // \r\n retour a la ligne.

                            break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Je vous dis de rentrer un chiffre entre 1 et 100 SVP !!!!");
                    }

                    if (i < 10) { Console.WriteLine($"Try again, il vous reste {chance - i} chances"); }

                    if (i == 10)
                    {
                        Console.WriteLine($"Désolé, vous avez Perdu la réponse etait {numbre}");

                    }

                }

                Console.WriteLine("Est ce que vous voulez Rejouer ? O / N .... O: Oui     N: Non");
                string reponse = Console.ReadLine();

                if (reponse == "o" || reponse == "O")
                {
                    jeu = true;
                }
                else
                {
                    jeu = false;
                }


            }
            

            Console.ReadKey();

        }
    }
}
