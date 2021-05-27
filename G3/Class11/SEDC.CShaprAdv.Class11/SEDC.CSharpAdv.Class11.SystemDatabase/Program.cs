using SEDC.CSharpAdv.Class11.SystemDatabase.Entites;
using System;
using System.Collections.Generic;

namespace SEDC.CSharpAdv.Class11.SystemDatabase
{
    class Program
    {
        static Db<Student> _studentDb = new Db<Student>();
        static Db<Subject> _subjectDb = new Db<Subject>();

        public static void Seed()
        {
            if(_studentDb.GetAll().Count == 0)
            {
                Console.WriteLine("===========INSERTING STUDENTS=============");
                _studentDb.Insert(new Student("Bob", "Bobsky", 25));
                _studentDb.Insert(new Student("Trajan", "Stevkovski", 26));
                _studentDb.Insert(new Student("Nikola", "Dalchevski", 23));
            }

            if (_subjectDb.GetAll().Count == 0)
            {
                Console.WriteLine("===========INSERTING SUBJECTS=============");
                _subjectDb.Insert(new Subject("C# Advanced", Academy.Code, 60));
                _subjectDb.Insert(new Subject("Introduction to Servers", Academy.Network, 40));
                _subjectDb.Insert(new Subject("Photoshop", Academy.Design, 32));
            }
        }

        static void Main(string[] args)
        {
            Seed();

            List<Student> students = _studentDb.GetAll();
            List<Subject> subjects = _subjectDb.GetAll();

            foreach (var student in students)
            {
                Console.WriteLine(student.Info());
            }

            foreach (var subject in subjects)
            {
                Console.WriteLine(subject.Info());
            }

            Student chuck = new Student("Chuck", "Noris", 22);
            int id = _studentDb.Insert(chuck);
            Console.WriteLine(id);

            Student chuckById = _studentDb.GetById(id);
            Console.WriteLine(chuckById.Info());


            Console.ReadLine();
        }
    }
}
