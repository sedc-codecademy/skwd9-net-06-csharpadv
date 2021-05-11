using System;
using System.Collections.Generic;
using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Interfaces;
using System.Linq;

namespace TryBeingFit.Domain.Models
{
    public abstract class Training : BaseEntity, ITraining
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public TrainingType Type { get; set; }
        public Difficulty Difficulty { get; set; }
        private List<int> Rates { get; set; }
        public string Link { get; set; }

        public Training(string title, string description, int duration, TrainingType type, Difficulty difficulty, string link)
        {
            Title = title;
            Description = description;
            Duration = duration;
            Type = type;
            Difficulty = difficulty;
            Link = link;
            Rates = new List<int>();
        }

        public double GetRating()
        {
            return Rates.Average();
        }

        public override string GetInfo()
        {
            return $"{Title} ({GetRating()})\n\t{Description}\n\t{Duration} {Difficulty}\n\t{Link}";
        }

        //1-5
        public void RateTraining(int rate)
        {
            if (rate < 1 || rate > 5)
                throw new Exception("Invalid rating. Rating should be between 1 and 5");

            Rates.Add(rate);
        }
    }
}
