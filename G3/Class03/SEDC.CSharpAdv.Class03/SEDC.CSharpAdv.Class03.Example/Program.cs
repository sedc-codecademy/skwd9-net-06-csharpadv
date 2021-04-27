using System;

namespace SEDC.CSharpAdv.Class03.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("Hello World!");
        }
    }

    abstract class User
    {
        // common data
        public abstract void DoSomething();
    }

    class Person : User
    {
        private bool _isDoingSomething;
        private SomeService _someService;

        public Person()
        {
            _isDoingSomething = true;
            _someService = new SomeService();
        }

        public override void DoSomething()
        {
            Console.WriteLine("FirstName, LastName, and specific data for Perosn");
        }
    }

    class SomeService
    {

    }

    interface IPrintUser
    {
        void PrintUser();
    }
}
