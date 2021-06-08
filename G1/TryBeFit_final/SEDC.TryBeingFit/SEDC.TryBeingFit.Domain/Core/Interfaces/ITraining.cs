using SEDC.TryBeingFit.Domain.Core.Enums;

namespace SEDC.TryBeingFit.Domain.Core.Interfaces
{
	public interface ITraining
	{
		string Title { get; set; }
		string Description { get; set; }
		int Time { get; set; }
		Difficulty Difficulty { get; set; }
	}
}
