using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesJDLV;
/*
 * * = vivant
 * M = meurt
 *   = mort
 * N = nait
 * 
 * 
 */
namespace AfficherJeux
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int dimensionx = 30;
            int dimensiony = 30;

            string[,] tableau = new string[dimensionx, dimensiony];
            Chance c = new Chance(10,tableau,dimensionx,dimensiony);  //mettre la valeur de la chance
            string[,] donneesChance = c.Luck();   //créer le départ

            string[,] tabletwo = new string[dimensionx, dimensiony];
            string[,] tablethree = new string[dimensionx, dimensiony];

            int tempsAttente=500;   //va dans les sleeps et calculé en millisecondes

            

            Afficher(donneesChance);

            while (true)
            {
                Verification v = new Verification(donneesChance);        //donne le premier tableau
                int[,] tableauVoisins = v.Verifier();       //passe le tableau en revue pour sortir ses voisins

                System.Threading.Thread.Sleep(tempsAttente);
                Console.Clear();

                Changement ch = new Changement(tableauVoisins, donneesChance);   //donne le tableau des voisins
                tabletwo = ch.Redistribution();        //change les valeurs selon les règles

                Afficher(tabletwo);

                System.Threading.Thread.Sleep(tempsAttente);
                Console.Clear();

                ChangementTransition transition = new ChangementTransition(tabletwo);
                tablethree = transition.FinalChangement();

                Afficher(tablethree);
            }
            
            

        }
        /// <summary>
        /// Méthode qui affiche la table actuelle
        /// </summary>
        /// <param name="TableauParamètre"></param>
        public static void Afficher(string[,] TableauParamètre)
        {
            for (int i = 0; i < TableauParamètre.GetLength(0); i++)
            {
                for (int j = 0; j < TableauParamètre.GetLength(1); j++)
                {
                    Console.Write(TableauParamètre[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
