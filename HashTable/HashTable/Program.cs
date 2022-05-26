using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "to");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");

            Console.WriteLine("Frequency of word 'to' is : " + hash.FrequencyOfWords("to"));
            Console.WriteLine("Frequency of word 'be' is : " + hash.FrequencyOfWords("be"));
            Console.WriteLine("Frequency of word 'or' is : " + hash.FrequencyOfWords("or"));
            Console.WriteLine("Frequency of word 'not' is : " + hash.FrequencyOfWords("not"));
        }
    }
}
