using TryBeingFit.Domain.Enums;
using TryBeingFit.Domain.Interfaces;

namespace TryBeingFit.Domain.Models
{
    public class VideoTraining : Training, IVideoTraining
    {
        public VideoTraining(string title, string description, int duration, Difficulty difficulty, string link) :
            base(title, description, duration, TrainingType.Video, difficulty, link)
        {
        }
    }
}
