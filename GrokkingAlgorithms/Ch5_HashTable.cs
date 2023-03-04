using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    class Ch5_HashTable
    {
        public static void Execute_HashTable()
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "Akshay");
            ht.Add("2", "Hari");
            ht.Add("3", "Raghvan");
            ht.Add("4", "Milind");
            ICollection key = ht.Keys;
            Console.WriteLine("Retrieving all elements: ");
            Console.WriteLine();
            foreach (var k in key)
            {
                Console.WriteLine(k + ":" + ht[k]);
            }
            ArrayList al = new ArrayList(key);
            Console.WriteLine("Retrieving all keys in the arraylist");
            Console.WriteLine();
            foreach (var n in al)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
