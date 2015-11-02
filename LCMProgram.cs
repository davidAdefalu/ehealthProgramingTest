using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndRemoveDuplicate
{
    public class LCMProgram
    {
        
    
        public static int LCM(IList<int> numbers)
        {

            LCMProgram p = new LCMProgram();
            //Check If < 2 numbers are passed
            if (numbers.Count < 2)
                throw new ArgumentException("Invalid Arguments");
            return p.LCM(numbers, 0);
        }

        //Method recursively goes over pairs of argument
        private  int LCM(IList<int> argumentArray, int startPoint)
        {
       

            if (startPoint + 2 == argumentArray.Count)
            {
                return this.LCM(argumentArray[startPoint], argumentArray[startPoint+1]);
            }
            else
            {
                return LCM(argumentArray[startPoint], LCM(argumentArray, startPoint+1));
            }
        }

        public int LCM(int a, int b)
        {
            return (a * b / GCD(a, b));
        }

    
        public  int GCD(int a, int b)
        {
            // Euclidean algorithm
            int t;
            while (b != 0)
            {
                t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

    }
}
