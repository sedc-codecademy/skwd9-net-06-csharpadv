using SEDC.TryBeingFit.Domain.Core.Interfaces;

namespace SEDC.TryBeingFit.Domain.Core.Entities
{
    public class VideoTraining : Training, IVideoTraining
    {
        public override string Print()
        {
            return $"[{Difficulty}] {Title} - {Description}";
        }

        public string CheckRating()
        {
            if (Rating == 1) return "Bad";
            if (Rating <= 3) return "Okay";
            if (Rating > 3) return "Good";
            return "Unknown";
        }

    }
}