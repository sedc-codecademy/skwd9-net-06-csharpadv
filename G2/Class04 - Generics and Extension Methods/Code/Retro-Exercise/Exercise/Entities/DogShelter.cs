using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Entities
{
	public static class DogShelter
	{
		public static List<Dog> Dogs;
		static DogShelter()
		{
			Dogs = new List<Dog>();
		}
		public static void PrintAll()
		{
			foreach (Dog dog in Dogs)
			{
				Console.WriteLine($"{dog.Name} - {dog.Color}");
			}
		}
	}
}
