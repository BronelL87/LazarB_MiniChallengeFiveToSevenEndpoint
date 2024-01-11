using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_MiniChallengeFiveToSevenEndpoint.Services.MadL.ReverseNum;

    public class ReverseNumService : IReverseNumServices
    {
        public string ReverseNumbers(string userNumber)
        {

            int numberOne;
             int reverseN = 0;  
            if(int.TryParse(userNumber, out numberOne)){
             
              while(numberOne > 0){
                reverseN = reverseN*10 + numberOne%10;
                numberOne /= 10;
              }
              return $"The reverse of {userNumber} is {reverseN}";
            }else {
                return "That is not a number";
            }
            
            
            
        }
    }
