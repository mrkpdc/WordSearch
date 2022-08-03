using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            permettere di scegliere tra italiano e inglese
            chiedere una frase
            chiedere una parola
            controllare se la parola è contenuta nella frase
            */

            // Messaggio di benvenuto
            Console.WriteLine("Name: Mirko Pedico");
            Console.WriteLine();
            Console.WriteLine("**********| Welcome to WordSearch! This software searches for a word in a text.                 |**********");
            Console.WriteLine("**********| Benvenuto su WordSearch! Questo programma cerca una parola all'interno di un brano. |**********");
            Console.WriteLine();
            Console.WriteLine("Version 1.0 - 2022");
            Console.WriteLine();

            // Soluzione estesa
            string language = GetLanguage(); // ottengo la lingua scelta
            string[] translations = GetTranslations(language); // memorizzo le traduzioni della lingua scelta nell'array translations
            CheckSentenceAndGiveAnswer(translations); // passo le traduzioni corrette al programma principale che le userà per informare l'utente


            /*Soluzione super astratta:
            CheckSentenceAndGiveAnswer(GetTranslations(GetLanguage()));
            */

            Console.ReadKey();
        }

        public static string GetLanguage()
        {
            string language = string.Empty;
            while (language != "1" && language != "2")
            {
                Console.WriteLine("Scegli la tua lingua // Select your language (1 = Italiano, 2 = English):");
                language = Console.ReadLine();
            }
            return (language);
        }

        public static string[] GetTranslations(string language)
        {
            string[] translations = new string[4];
            if (language == "1")
            {
                translations[0] = "Inserisci una frase:";
                translations[1] = "Inserisci una parola da cercare:";
                translations[2] = "La frase contiene la parola.";
                translations[3] = "La frase non contiene la parola.";
            }
            else
            {
                translations[0] = "Insert a sentence:";
                translations[1] = "Insert a word to search:";
                translations[2] = "The sentence contains the word.";
                translations[3] = "The sentence does not contain the word.";
            }

            return translations;
        }

        public static void CheckSentenceAndGiveAnswer(string[] translations)
        {
            Console.WriteLine(translations[0]);
            string sentence = Console.ReadLine();
            Console.WriteLine(translations[1]);
            string word = Console.ReadLine();
            if (sentence.Contains(word))
                Console.WriteLine(translations[2]);
            else
                Console.WriteLine(translations[3]);
        }
    }
}
