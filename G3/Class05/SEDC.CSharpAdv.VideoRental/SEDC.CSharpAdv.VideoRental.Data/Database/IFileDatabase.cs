using SEDC.CSharpAdv.VideoRental.Data.BaseModels;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.VideoRental.Data.Database
{
    public interface IFileDatabase<T>
        where T : BaseEntity
    {
        int Id { get; set; }
        List<T> Read();
        bool Write(List<T> entities);
        void Seed(List<T> seedData);
    }
}
