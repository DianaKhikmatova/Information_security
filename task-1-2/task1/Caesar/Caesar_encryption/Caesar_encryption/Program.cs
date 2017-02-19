using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_encryption
{
    class Program
    {
        public static string Caesar(char [] alphabet, int shift, string input)
        {
            char[] inputChar = input.ToCharArray();
            string res = "";
            bool isInAlphabet = false;
            for (int i = 0; i < input.Length; i++)
            {
                isInAlphabet = false;
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (inputChar[i] == alphabet[j])
                    {
                        res += alphabet[(j + shift) % alphabet.Length];
                        isInAlphabet = true;
                    }
                }
                if (isInAlphabet == false)
                {
                    res += inputChar[i];
                }
            }
            Console.WriteLine(res);
            return res;
        }

        public static void CaesarDecryption(char[] alphabet, int shift, string encrypted)
        {
            if (shift >= alphabet.Length)
            {
                shift = shift - alphabet.Length;
            }
            string res = "";
            bool isInAlphabet = false;
            for (int i = 0; i < encrypted.Length; i++)
            {
                isInAlphabet = false;
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (encrypted[i] == alphabet[j])
                    {
                        if (j - shift < 0)
                        {
                            res += alphabet[(j - shift + alphabet.Length)];
                            isInAlphabet = true;
                        }
                        else
                        {
                            res += alphabet[(j - shift)];
                            isInAlphabet = true;
                        }
                    }
                }
                if (isInAlphabet == false)
                {
                    res += encrypted[i];
                }
            }

            Console.WriteLine(res);
        }

        static void Main(string[] args)
        {
            char[] alphabetEn = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
                                    'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
                                    't', 'u', 'v', 'w', 'x', 'y', 'z'};
            char[] alphabetRu = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з',
                                    'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с','т',
                                    'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь',
                                    'э', 'ю', 'я'};
            Console.Write("Enter your text: ");
            string input = Console.ReadLine();
            input = input.ToLower();
            Console.Write("Enter the shift: ");
            int shift = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose the language (English - 1, Russian - 2)");
            int lang = int.Parse(Console.ReadLine());
            string encrypted = "";
            if (lang == 1)
            {
                encrypted = Caesar(alphabetEn, shift, input);
                Console.Write("Decrypted: ");
                CaesarDecryption(alphabetEn, shift, encrypted);
            }
            if (lang == 2)
            {
                encrypted = Caesar(alphabetRu, shift, input);
                Console.Write("Decrypted: ");
                CaesarDecryption(alphabetRu, shift, encrypted);
            }
        }
    }
}
