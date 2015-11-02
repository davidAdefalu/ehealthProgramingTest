using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndRemoveDuplicate
{
    public class RotateByN
    {
        public int[] RotateVal(int[] input, int degree)
        { 
        
            int arraySize = input.Length;

            int[] output = new  int[input.Length]; 
        
        
            int outPutNvalue = degree;

            for (int i = 0; i < input.Length; i++) {
            int value = input.Length - degree;
                if (degree != 0) {
                    output[i] = input[value];
                    degree--;
                } else {
                    output[i] = input[i - outPutNvalue];
                }
            
            }

            for (int i = 0; i < arraySize; i++) {
                int j = output[i];
            
            }

            return output;

        }
    }
}
