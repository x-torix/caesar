// See https://aka.ms/new-console-template for more information

namespace caesar
{

    class Program
    {
        static string jakisText;
        static int klucz;

        static void Main(string[] args)
        {
            Console.WriteLine("1. kod cezara");
            Console.WriteLine("2. Wyjście");

            string zadanie = Console.ReadLine();

            switch (zadanie)
            {
                case "1":
                    Console.WriteLine("Wpisz co chcesz: ");
                    jakisText = Console.ReadLine();

                    Console.WriteLine("Wpisz klucz: ");
                    klucz = Convert.ToInt32(Console.ReadLine());

                    KluczMessage(jakisText, klucz);
                    break;
            }

            Console.WriteLine();
        }
        static void KluczMessage(string jakisText, int klucz)
        {
            char[] charLetters = jakisText.ToLower().ToCharArray();
            string cipherText = "";

            for (int i = 0; i < charLetters.Length; i++)
            {
                int originalValue = (int) charLetters[i];

                if (originalValue > 96 && originalValue < 123)
                {
                    int shiftValue = 0;

                    if ((originalValue + klucz) > 123)
                    {
                        int leftOver = 122 - originalValue;
                        shiftValue = 96 + (klucz - leftOver);
                    }
                    else
                    {
                        shiftValue = originalValue + klucz;
                    }
                    
                    string newLetter = Convert.ToChar(shiftValue).ToString();
                    cipherText += newLetter;
                }
                else
                {
                    string newLetter = Convert.ToChar(originalValue).ToString();
                    cipherText += newLetter;
                }
            }

            Console.WriteLine("\n" + cipherText);
        }

    }
}