using TryBeingFit.Domain.Enums;

namespace TryBeingFit.Domain.Interfaces
{
    public interface ITraining
    {
        string Title { get; set; }
        string Description { get; set; }
        int Duration { get; set; }
        TrainingType Type { get; set; }
        Difficulty Difficulty { get; set; }
        string Link { get; set; }
    }
}
