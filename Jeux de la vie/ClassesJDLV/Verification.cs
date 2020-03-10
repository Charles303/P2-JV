using System;
using System.Collections.Generic;
using System.Text;
namespace ClassesJDLV
{
    public class Verification
    {
        private string[,] derniertable;

        public Verification(string[,] derniertable)
        {
            this.derniertable = derniertable;
        }
        /// <summary>
        /// Calcule le nombre de voisins par cases
        /// </summary>
        /// <returns>Un tableau avec le nombre de voisins</returns>
        public int[,] Verifier()
        {
            int longueur = (this.derniertable).GetLength(0);
            int[,] tabletwo = new int[(this.derniertable).GetLength(0), (this.derniertable).GetLength(1)];

            for (int i = 1; i < longueur-1; i++)
            {
                for (int j = 1; j < longueur-1; j++)
                {
                    if (this.derniertable[i - 1, j] == "*")     //à gauche
                    {
                        tabletwo[i, j]++;
                    }
                    if (this.derniertable[i - 1, j - 1] == "*")     //en haut gauche
                    {
                        tabletwo[i, j]++;
                    }
                    if (this.derniertable[i, j - 1] == "*")     //en haut
                    {
                        tabletwo[i, j]++;
                    }
                    if (this.derniertable[i + 1, j - 1] == "*")     //en hau droit
                    {
                        tabletwo[i, j]++;
                    }
                    if (this.derniertable[i + 1, j] == "*")     //à droite
                    {
                        tabletwo[i, j]++;
                    }
                    if (this.derniertable[i + 1, j + 1] == "*")     //en bas droite
                    {
                        tabletwo[i, j]++;
                    }
                    if (this.derniertable[i, j + 1] == "*")     //en bas
                    {
                        tabletwo[i, j]++;
                    }
                    if (this.derniertable[i - 1, j + 1] == "*")     //en bas gauche
                    {
                        tabletwo[i, j]++;
                    }
                }
            }

            return tabletwo;
        }
        
    }

}
