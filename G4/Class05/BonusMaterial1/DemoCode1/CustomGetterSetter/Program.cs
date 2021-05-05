using System;

namespace CustomGetterSetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking parking = new Parking();
            parking.Capacity = 100;
            parking.Occupied = 80;

            Console.WriteLine(parking);
            //parking.Print();

            parking.Free = 40;
            Console.WriteLine(parking);

            parking.Capacity = 200;
            Console.WriteLine(parking);

            Console.ReadLine();
        }    
    }
}
