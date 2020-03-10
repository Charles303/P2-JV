using System;

namespace ClassesJDLV
{
    public class Chance
    {
        
        private int chance;
        private string[,] table;
        private int taillex;
        private int tailley;

        public Chance(int chance, string[,] table, int taillex,int tailley)
        {
            this.chance = chance;
            this.table = table;
            this.taillex = taillex;
            this.tailley = tailley;
            
        }

        /// <summary>
        /// chance en %
        /// </summary>
        /// <returns>Premier tableau généré aléatoirement</returns>
        public string[,] Luck()
        {

            
            Random r = new Random();
            
            for (int i = 0; i < taillex; i++)
            {
                for (int j = 0; j < tailley; j++)
                { 
                    int aleatoire = r.Next(100);

                    if (aleatoire <= this.chance) //si tombe dans % de chance donc vivant au départ
                    {
                        this.table[i,j] = "*";
                    }       //sinon tombe pas vivant donc rien
                    else
                    {
                        this.table[i, j] = " ";
                    } 
                }
            }
            return this.table;
        }

    }

}
