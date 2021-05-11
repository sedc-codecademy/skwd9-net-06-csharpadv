
using TryBeingFit.Domain.Models;

namespace TryBeingFit.Domain.Database
{
    public static class LocalDatabase
    {
        public static IDbTable<StandardUser> StandardUsers { get; set; } = new LocalDbTable<StandardUser>();
        public static IDbTable<PremiumUser> PremiumUsers { get; set; } = new LocalDbTable<PremiumUser>();
        public static IDbTable<TrainerUser> TrainerUsers { get; set; } = new LocalDbTable<TrainerUser>();
        public static IDbTable<VideoTraining> VideoTrainings { get; set; } = new LocalDbTable<VideoTraining>();
        public static IDbTable<LiveTraining> LiveTrainings { get; set; } = new LocalDbTable<LiveTraining>();
    }
}
