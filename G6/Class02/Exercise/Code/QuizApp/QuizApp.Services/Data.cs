using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Services
{
    public class Data
    {
        public List<Question> AllQuestions { get; set; }
        public Data()
        {
            AllQuestions = new List<Question>
            {
                new Question("What is the capital of Tasmania?", new string[] { "Dodoma", "Hobart", "Launceston", "Wellington" }, 1),
                new Question("What is the tallest building in the Republic of the Congo?", new string[] { "Kinshasa Democratic Republic of the Congo Temple", "Palais de la Nation", "Kongo Trade Centre", "Nabemba Tower" }, 3),
                new Question("Which of these is not one of Pluto's moons?", new string[] { "Styx", "Hydra", "Nix", "Lugia" } , 3),
                new Question("What is the smallest lake in the world?", new string[] { "Onega Lake", "Benxi Lake", "Kivu Lake", "Wakatipu Lake" } , 1),
                new Question("What country has the largest population of alpacas?", new string[] { "Chad", "Peru", "Australia", "Niger" } , 1),
            };
            
        }
    }
}
