using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NotepadEncryption
{
    class Program
    {
        static string Reader()
        { 
            FileStream stream = new FileStream(Environment.CurrentDirectory  + "\\text.txt", FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            string str = reader.ReadToEnd();
            stream.Close();
            return str;
        }

        static int[] NotepadGeneration(string str)
        {
            int[] notepad = new int[str.Length];
            Random rnd = new Random();
            for (int i = 0; i < notepad.Length; i++)
            {
                notepad[i] = rnd.Next(33, 126);
            }
            return notepad;
        }
        
        static char [] ConvertToChar(int [] array)
        {
            char[] res = new char[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                res[i] = (char)array[i];
            }
            return res;
        }

        static int [] ConvertToInt (string str)
        {
            int [] res = new int [str.Length];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = Convert.ToInt32(str[i]);
            }
            return res;
        }

        static string Encryption(string str, int [] notepad)
        {
            char[] inputChar = str.ToCharArray();
            int[] resInt = new int[inputChar.Length];
            for (int i = 0; i < inputChar.Length; i++)
            {
                resInt[i] = inputChar[i] ^ notepad[i];
            }
            char[] buffer = ConvertToChar(resInt);
            string res = new string(buffer);

            //Console.Write("Encrypted in int: ");
            //Print(resInt);
                           
            return res;
        }

        static string Decryption(string encrypted, int[] notepad)
        {
            int[] resInt = new int[encrypted.Length];
            for (int i = 0; i < resInt.Length; i++)
            {
                resInt[i] = encrypted[i] ^ notepad[i];
            }
            char[] buffer = ConvertToChar(resInt);
            string res = new string(buffer);

            //Console.Write("Decrypted in int: ");
            //Print(resInt);

            return res;
        }

        static void Print (int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            string message = Reader();
            Console.WriteLine(message);

            Console.WriteLine();

            int[] messageInInt = ConvertToInt(message);
            //Console.Write("Input message: ");
            //Print(messageInInt);

            int[] notepad = NotepadGeneration(message);
            //Console.Write("Notepad: ");
            //Print(notepad);

            string encrypted = Encryption(message, notepad);
            Console.WriteLine("Enctrypted string:");
            Console.WriteLine(encrypted);

            Console.WriteLine();

            string decrypted = Decryption(encrypted, notepad);
            Console.WriteLine("Decrypted text:");
            Console.WriteLine(decrypted);
        }
    }
}
