using System.Runtime.Serialization;
namespace Project_test
{
    class FarmingAnimalController
    {
        private List<FarmingAnimal> animalList;
        // get or set value for animal list
        internal List<FarmingAnimal> AnimalList
        {
            get
            {
                return animalList;
            }
            set
            {
                animalList = value;
            }            
        } // Animal list in cages
        
        // initial value for animallist
        public FarmingAnimalController()
        {
            AnimalList = new List<FarmingAnimal>();
        }

        // add animal into list
        public void Add(FarmingAnimal animal)
        {
            AnimalList.Add(animal);
        }

        // remove animal outto list
        public void Remove(FarmingAnimal animal)
        {
            AnimalList.Remove(animal);
        }

        // get total amount of food that animal eat
        public float TotalAmount(float weight)
        {
            if(AnimalList.Count > 0){
                return AnimalList[0].EatFood.Amount(weight) * AnimalList.Count;
            }
            else return 0;
        }

        // print total pend of animal
        public void PrintTotalAmount(float weight)
        {
            if(AnimalList.Count > 0){
                Console.WriteLine($"{AnimalList.Count} {AnimalList[0].Name} eat {weight * AnimalList.Count}Kg {AnimalList[0].EatFood.Name} spend {TotalAmount(weight)} price");
            } 
            else 
                Console.WriteLine("Not thing to show!");
        }
    }
}