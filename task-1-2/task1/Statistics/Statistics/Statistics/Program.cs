using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Statistics
{
    class Program
    {
        static string Reader(string fileName)
        {
            FileStream stream = new FileStream(Environment.CurrentDirectory + fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            string str = reader.ReadToEnd();
            stream.Close();
            return str;
        }
        
        static void Counter(char [] alphabet, string str)
        {
            Console.WriteLine("Result:");
            char[] stringChar = str.ToCharArray();
            for (int i = 0; i < alphabet.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < stringChar.Length; j++)
                {
                    if (alphabet[i] == stringChar[j])
                    {
                        counter++;
                    }
                }
                Console.Write(alphabet[i] + "=" + counter * 100 / str.Length + "%  ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
                                    'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
                                    't', 'u', 'v', 'w', 'x', 'y', 'z'};

            string bible = Reader("//bible.txt");
            string tutorial = Reader("//tutorial.txt");
            string speaking = Reader("//speaking.txt");
            string fiction = Reader("//fiction.txt");
            string fairytale = Reader("//fairytale.txt");

            Console.WriteLine("Bible example: ");
            Console.WriteLine(bible);
            Counter(alphabet, bible);

            Console.WriteLine("Tutorial example: ");
            Console.WriteLine(tutorial);
            Counter(alphabet, tutorial);

            Console.WriteLine("Speaking example: ");
            Console.WriteLine(speaking);
            Counter(alphabet, speaking);

            Console.WriteLine("Fiction literature example: ");
            Console.WriteLine(fiction);
            Counter(alphabet, fiction);

            Console.WriteLine("Fairytale example: ");
            Console.WriteLine(fairytale);
            Counter(alphabet, fairytale);
        }
    }
}
