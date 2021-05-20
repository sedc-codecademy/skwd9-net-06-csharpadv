using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StringBuilderDemo
{
    public class NameGenerator
    {
        private string[] firstNames = { "Aleksandar", "Petre", "Bojana", "Deni", "Dimitar", "Ivan", "Katerina", "Marko", "Matej", "Panche", "Radmila", "Simon", "Jovan", "Luka" };
        private string[] lastNames = { "Jangelo", "Arso", "Stojano", "Riste", "Mite", "Nace", "Atanaso", "Manasko", "Koco"};
        private string[] suffixes = { "v", "vski", "va", "vska", "ski", "ska"};


        public void Run()
        {
            var res = firstNames.Concat(firstNames);
            res = res.Concat(res).Concat(res).Concat(res).Concat(res).Concat(res);
            firstNames = res.Concat(res).ToArray();

            Console.WriteLine(firstNames.Length);

            long index = 0;
            foreach (var one in firstNames)
            {
                foreach (var two in firstNames)
                {
                    foreach (var three in firstNames)
                    {
                        foreach (var four in firstNames)
                        {
                            index += 1;
                        }
                    }
                }
            }
            Console.WriteLine($"Here {index}");
        }

        public IEnumerable<string> GenerateNames()
        {
            return from fname in firstNames
                   from lname in lastNames
                   from suffix in suffixes
                   select $"{fname} {lname}{suffix}";
        }

    }
}
