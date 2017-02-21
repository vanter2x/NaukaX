using System.Collections;
using System.Collections.Generic;

namespace SeeSharpBasics.Training3.Hashmaps
{
    public class HashmapExample
    {
        public void HashmapTest()
        {
            Hashtable hash = new Hashtable();

            hash.Add("bartek", "84080818074");

            //Dictionary<string, string> slownik = new Dictionary<string, string>();
        }

        public Hashtable GetCharactersCount(string candidate) //beataka -> b => 1, e => 1, a => 3, t => 1, k => 1
        {
            Hashtable result = new Hashtable();

            //result.Add("b", 1);
            //result.Add("e", 1);
            //result.Add("a", 1);

            for (int i = 0; i < candidate.Length; i++)
            {
                if (result.ContainsKey(candidate[i]))
                {
                    result[candidate[i]] = ((int)result[candidate[i]]) + 1;
                }
                else
                {
                    result.Add(candidate[i], 1);
                }
            }

            return result;
        }
    }
}