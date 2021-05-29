using System;

namespace SEDC.ClassDispose.HeapAndStack
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User martin = new User { Id = 1, FullName = "Martin Panovski" };

            Console.WriteLine(martin.FullName);

            martin.FullName = "Petre Arsovski";

            User ivo = new User { Id = 2, FullName = "Ivo Kostovski" };


            Console.ReadLine();
        }
    }
}
