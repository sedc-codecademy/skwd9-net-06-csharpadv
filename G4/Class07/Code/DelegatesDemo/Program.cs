using System;

namespace DelegatesDemo
{
    class Program
    {
        public delegate void TranslationDelegate(string word);
        static void Main(string[] args)
        {
            TranslationDelegate baseDelegate = new TranslationDelegate(NativeMacedonian);
            TranslationDelegate enTranslationDelegate = new TranslationDelegate(EnglishTranslation);
            TranslationDelegate esTranslationDelegate = new TranslationDelegate(SpanishTranslation);
            TranslationDelegate deTranslationDelegate = new TranslationDelegate(GermanTranslation);
            TranslationDelegate poTranslationDelegate = new TranslationDelegate(PortugeseTranslation);

            //baseDelegate("Zdravo");
            //enTranslationDelegate("Zdravo");
            //esTranslationDelegate("Zdravo");
            //deTranslationDelegate("Zdravo");
            //poTranslationDelegate("Zdravo");

            //baseDelegate("Zdravo");

            // multicasting delegates
            baseDelegate += enTranslationDelegate;
            baseDelegate += esTranslationDelegate;
            baseDelegate += deTranslationDelegate;
            baseDelegate += poTranslationDelegate;

            baseDelegate -= deTranslationDelegate;

            baseDelegate("Zdravo");


            Console.ReadLine();
        }

        public static void NativeMacedonian(string word)
        {
            Console.WriteLine($"Makedonski: {word}");
        }

        public static void EnglishTranslation(string word)
        {
            string translation;
            switch (word)
            {
                case "Zdravo":
                    translation = "Hello";
                    break;
                default:
                    translation = "Ne postoi ovoj zbor vo nasiot angliski recnik";
                    break;
            }
            Console.WriteLine($"In English: {translation}");
        }

        public static void SpanishTranslation(string word)
        {
            string translation;
            switch (word)
            {
                case "Zdravo":
                    translation = "Hola";
                    break;
                default:
                    translation = "Ne postoi ovoj zbor vo nasiot spanski recnik";
                    break;
            }
            Console.WriteLine($"En espanol: {translation}");
        }

        public static void GermanTranslation(string word)
        {
            string translation;
            switch (word)
            {
                case "Zdravo":
                    translation = "Hallo";
                    break;
                default:
                    translation = "Ne postoi ovoj zbor vo nasiot germanski recnik";
                    break;
            }
            Console.WriteLine($"Auf Deutsch: {translation}");
        }

        public static void PortugeseTranslation(string word)
        {
            string translation;
            switch (word)
            {
                case "Zdravo":
                    translation = "Bom Dia";
                    break;
                default:
                    translation = "Ne postoi ovoj zbor vo nasiot portugalski recnik";
                    break;
            }
            Console.WriteLine($"Em portugues: {translation}");
        }
    }
}
