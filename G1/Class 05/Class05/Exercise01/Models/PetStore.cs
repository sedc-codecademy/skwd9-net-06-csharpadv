using System.Collections.Generic;
using System.Linq;

namespace Exercise01.Models
{
    //public class PetStore<T, T2> where T : Pet where T2 : Pet
    public class PetStore<T> where T : Pet, IPet
    {
        public string StoreName { get; set; }
        public List<T> Pets;
        public PetStore(string name)
        {
            Pets = new List<T>();
            StoreName = name;
        }

        public string GetPets()
        {
            string info = $"Pets in {StoreName} store:\n";

            foreach(T pet in Pets)
            {
                info += pet.GetInfo() + "\n";
            }

            return info;
        }

        public string BuyPet(string name)
        {
            T pet = Pets.FirstOrDefault(x => x.Name == name);

            if(pet == null)
            {
                return "Pet with that name does not exist";
                //throw new Exception("Pet with that name does not exist");
            }

            Pets.Remove(pet);
            return $"You have bought {pet.Name}!";
        }
    }
}
