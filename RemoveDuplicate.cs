using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndRemoveDuplicate
{
    class RemoveDuplicate
    {
        static void Main(string[] args)
        {
            
        }
        public int[] RemoveDuplicateMtd(int[] iArray)
        {
            int arrayLength = iArray.Length;
            List<int> unique = new List<int>(arrayLength);

            

            if (arrayLength > 0)
            {
                unique.Add(iArray[0]);
            }

            for (int i = 1; i < arrayLength; i++)
            {
                if (iArray[i] != iArray[i - 1])
                {
                    unique.Add(iArray[i]);
                }
            }

            return unique.ToArray();

            
        }
    }
}
