using System;

namespace SEDC.CSharpAdv.Class14.GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Trajan Stevkovski", 21);

            student.FullName = "Trajan Stevkovski";
            student.IsWorking = true;
            //student.Age = 11;

            Console.ReadLine();
        }
    }
}
