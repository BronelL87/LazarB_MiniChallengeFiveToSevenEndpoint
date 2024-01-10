using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_MiniChallengeFiveToSevenEndpoint.Services.MadL.OddOrEven
{
    public class OddOrEvenService : IOddOrEvenServices
    {
        public string EvenOrOdd(string num)
        {
            int number;
            if (int.TryParse(num, out number) && (number % 2 == 0))
            {


                return $"{number} is an even number.";

            }
            else if (int.TryParse(num, out number) && (number % 2 != 0))
            {
                return $"{number} is an odd number";
            }
            else
            {
                return "Incorrect Format";
            }
        }

    }

}


