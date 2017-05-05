using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barany_Farkas
{
    class Palya
    {
        public Csomopont[,] Csomopontok = new Csomopont[7, 7];//[x,y]

        public Palya()
        {
            for (int y = 0; y < 7; y++)
                for (int x = 0; x < 7; x++)
                    if (x > 1 && x < 5 || y > 1 && y < 5)
                        Csomopontok[x, y] = new Csomopont();


        }
        
    }
}
