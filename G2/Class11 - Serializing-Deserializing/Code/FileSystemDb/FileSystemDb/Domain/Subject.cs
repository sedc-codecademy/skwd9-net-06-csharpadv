using FileSystemDb.Domain.Enums;

namespace FileSystemDb.Domain
{
    public class Subject : BaseEntity
    {
        public string Title { get; set; }
        public AcademyType Academy { get; set; }
        public int NumOfModules { get; set; }
        public override string GetInfo()
        {
            return $"{Title} from {Academy}, with {NumOfModules} modules.";
        }
    }
}
