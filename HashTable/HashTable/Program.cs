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
            Console.WriteLine("Press 1 for frequency of words\n2. for frequency of words in paragraph\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
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
                    break;

                case 2:
                    string temp = "Paranoids are not paranoid because they are paranoid but because " +
                        "they keep putting themselves deliberately into paranoid avoidable situations";
                    string[] samplephrase = temp.ToLower().Split(" ");

                    var phrase = samplephrase.Distinct();

                    int length = 0;
                    foreach (var item in phrase) { length++; }

                    MyMapNode<string, int> hash1 = new MyMapNode<string, int>(length);

                    int count = 1;
                    foreach (string word in samplephrase)
                    {
                        if (hash1.ContainsKey(word))
                        {
                            count = hash1.GetValue(word) + 1;
                            hash1.Remove(word);
                            hash1.Add(word, count);
                        }
                        else
                        {
                            hash1.Add(word, 1);
                        }
                    }

                    Console.WriteLine($"{"Frequency",20} = {"Count",10}\n");
                    foreach (string key in phrase)
                    {
                        Console.WriteLine($"{key,20} = {hash1.GetValue(key),10}");
                    }
                    break;
            }
        }
    }
}
