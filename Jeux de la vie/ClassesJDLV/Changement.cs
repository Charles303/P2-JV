using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesJDLV
{
    public class Changement
    {
        private int[,] tablenbvoisin;
        private string[,] tabledepart;

        public Changement(int[,] tablenbvoisin, string[,] tabledepart)
        {
            this.tablenbvoisin = tablenbvoisin;
            this.tabledepart = tabledepart;
        }
        /// <summary>
        /// Change la table de départ en état transitif en fonction des règles et des voisins
        /// </summary>
        /// <returns>table changé par les règles donnant les naissantes et les mourantes</returns>
        public string[,] Redistribution()
        {
            
            int[,] tableChanger = this.tablenbvoisin;
            string[,] tabledebut = this.tabledepart;
            
            int longueur = (this.tablenbvoisin).GetLength(0);
            bool tour=false;

            if (tour == false)
            {
                for (int i = 0; i < longueur; i++)
                {
                    for (int j = 0; j < longueur; j++)
                    {
                        if (tabledebut[i, j] == " " && tableChanger[i, j] == 3)
                        {
                            tabledebut[i, j] = "N";
                        }
                        if (tabledebut[i, j] == "*" && (tableChanger[i, j] == 1 || tableChanger[i, j] >= 4 || tableChanger[i, j] == 0))
                        {
                            tabledebut[i, j] = "M";
                        }
                    }
                }
                
                tour = true;
                return tabledebut;
            }
            else if (tour == true)
            {
                for (int i = 0; i < longueur; i++)
                {
                    for (int j = 0; j < longueur; j++)
                    {
                        if (tabledebut[i, j] == "N")
                        {
                            tabledebut[i, j] = "*";
                        }
                        if (tabledebut[i, j] == "M")
                        {
                            tabledebut[i, j] = " ";
                        }
                    }
                }
                
                return tabledebut;
            }

            return tabledebut;
        }
    }
}
