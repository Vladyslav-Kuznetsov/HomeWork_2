using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawHouseAndTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string house = @"
                           (   )
                          (    )
                           (    )
                          (    )
                            )  )
                           (  (                  /\
                            (_)                 /  \  /\
                    ________[_]________      /\/    \/  \
           /\      /\        ______    \    /   /\/\  /\/\
          /  \    //_\       \    /\    \  /\/\/    \/    \
   /\    / /\/\  //___\       \__/  \    \/
  /  \  /\/    \//_____\       \ |[]|     \
 /\/\/\/       //_______\       \|__|      \
/      \      /XXXXXXXXXX\                  \
        \    /_I_II  I__I_\__________________\
               I_I|  I__I_____[]_|_[]_____I
               I_II  I__I_____[]_|_[]_____I
               I II__I  I     XXXXXXX     I
            ~~~~~'   '~~~~~~~~~~~~~~~~~~~~~~~~";

            Console.WriteLine(house);
            Console.WriteLine();
            Console.WriteLine(@"|\");
            Console.WriteLine(@"| \");
            Console.WriteLine(@"|  \");
            Console.WriteLine(@"|   \");
            Console.WriteLine(@"|    \");
            Console.WriteLine(@"|     \");
            Console.WriteLine(@"|      \");
            Console.WriteLine(@"|_______\");
            Console.ReadLine();
        }
    }
}
