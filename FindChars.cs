using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndRemoveDuplicate
{
    public class FindChars
    {
         public string Find_Char_N2(string string1, string string2)
        {
            string ret = "";


            foreach (var c in string1)
            {
                foreach (var cc in string2)
                {
                    if (c == cc)
                    {
                        ret += c;
                        break;
                    }
                }
            }
            return ret;
        }


        public string Find_Char_N(string string1, string string2)
        {
            string ret = "";

            char[] chString2 = string2.ToCharArray();

            foreach (var c in string1)
            {
                if (chString2.Contains(c))
                    ret += c;
            }
            return ret;
        }
    }
    
}
