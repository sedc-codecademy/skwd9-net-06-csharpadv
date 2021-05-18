using SEDC.CSharpAdv.VideoRental.Data.BaseModels;
using SEDC.CSharpAdv.VideoRental.Data.Enumerations;
using System;

namespace SEDC.CSharpAdv.VideoRental.Data.Models
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public string Language { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Length { get; set; }
        public int AgeRestriction { get; set; }
        public int Quantity { get; set; }
    }
}
