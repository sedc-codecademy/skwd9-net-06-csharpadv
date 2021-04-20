using SEDC.CSharpAdv.Class01.Task01.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdv.Class01.Task01.Logic.Services
{
    public class SearchService
    {
        public List<SearchResult> CountApperancesInText2(string text, List<string> names)
        {
            string[] searchText = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return names.Select(name =>
            new SearchResult 
            {
                Name = name,
                Appearance = searchText.Where(word => word.Equals(name, StringComparison.OrdinalIgnoreCase)).Count()
            }).ToList();
        }

        public Dictionary<string, int> CountApperancesInText1(string text, List<string> names)
        {
            Dictionary<string, int> searchResults = new Dictionary<string, int>();
            string[] searchText = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string name in names)
            {
                if (searchResults.ContainsKey(name))
                {
                    continue;
                }

                string[] result = Array.FindAll(searchText, word => word.Equals(name, StringComparison.OrdinalIgnoreCase));
                searchResults[name] = result.Length;
            }
            
            return searchResults;
        }

        public void CountApperancesInText(string text, List<string> names)
        {
            string[] searchText = text.Split(" ");

            int counter = 0;
            foreach(string name in names)
            {
                // name
                // trajan
                foreach (string word in searchText)
                {
                    // long text that contains 10 times trajan
                    // name - word
                    if(word.Trim().ToLower() == name.Trim().ToLower())
                    {
                        counter++;
                    }
                }
                // name  = trajan;
                // counter = 10;
                Console.WriteLine($"Name: {name} is contained {counter} times");
                counter = 0;
            }
        }
    }
}
