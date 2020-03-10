using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesJDLV
{
    public class ChangementTransition
    {
        private string[,] tableChangement;

        public ChangementTransition(string[,] tableChangement)
        {
            this.tableChangement = tableChangement;
        }
        /// <summary>
        /// Change la transision des naissantes et des mourantes
        /// </summary>
        /// <returns></returns>
        public string[,] FinalChangement()
        {
            for (int i = 0; i < this.tableChangement.GetLength(0); i++)
            {
                for (int j = 0; j < this.tableChangement.GetLength(1); j++)
                {
                    if (this.tableChangement[i,j] == "N")
                    {
                        this.tableChangement[i, j] = "*";
                    }
                    if (this.tableChangement[i,j] == "M")
                    {
                        this.tableChangement[i, j] = " ";
                    }
                }
            }

            return this.tableChangement;
        }
    }
}
