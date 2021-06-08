using System;
using System.Collections.Generic;
using System.Text;
using MapperDemo.DomainModels;
using MapperDemo.ViewModels;

namespace MapperDemo.Mappers
{
    public static class SubjectMapper
    {
        public static SubjectModel ToModel(this Subject subject)
        {
            return new SubjectModel
            {
                Name = subject.Name,
                NumberOfClasses = subject.NumberOfClasses
            };
        }
    }
}
