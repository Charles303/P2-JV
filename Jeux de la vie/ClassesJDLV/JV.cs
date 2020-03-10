using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesJDLV
{
    class JV
    {
        private static JV instance;
        public static JV GetInstance()
        {
            if (instance == null)
            {
                instance = new JV();
                
            }
            return instance;
        }
        private JV()
        {

        }
    }
}
