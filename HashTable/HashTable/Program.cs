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
            Console.WriteLine("Press 1 for frequency of words\n2. for frequency of words in paragraph\n3. Remove a word");
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
                    string[] samplephrase = temp.ToLower().Split();
                    var phrase = samplephrase.Distinct();
                    int length = 0;
                    foreach (var item in phrase)
                    { 
                        length++;
                    }

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
                    Console.WriteLine($"{"Frequency",15} = {"Count",5}\n");
                    foreach (string key in phrase)
                    {
                        Console.WriteLine($"{key,15} = {hash1.GetValue(key),5}");
                    }
                    break;

                case 3:
                    string temp2 = "Paranoids are not paranoid because they are paranoid but because " +
                "they keep putting themselves deliberately into paranoid avoidable situations";
                    string[] samplephrase2 = temp2.ToLower().Split();
                    var phrase2 = samplephrase2.Distinct();
                    int length2 = 0;
                    foreach (var item in samplephrase2)
                    {
                        length2++;
                    }

                    MyMapNode<string, int> hash2 = new MyMapNode<string, int>(length2);
                    hash2.Remove("avoidable");

                    foreach (string value in samplephrase2)
                    {
                        Console.Write(value + " ");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
