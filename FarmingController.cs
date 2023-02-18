namespace Project_test
{
    class FarmingController
    {
        private FarmingAnimalController dairyCow;
        // get or set value of dairy cow
        public FarmingAnimalController DairyCow
        {
            get {return dairyCow;}
            set {dairyCow = value;}
        }
         private FarmingAnimalController chicken;
        // get or set value of chicken
        public FarmingAnimalController Chicken
        {
            get {return chicken;}
            set {chicken = value;}
        }
         private FarmingAnimalController dog;
        // get or set value of dog
        public FarmingAnimalController Dog
        {
            get {return dog;}
            set {dog = value;}
        }
         private FarmingAnimalController pig;
        // get or set value of pig
        public FarmingAnimalController Pig
        {
            get {return pig;}
            set {pig = value;}
        }

        // initial value for farming animals
        public FarmingController()
        {
            DairyCow = new FarmingAnimalController();
            Chicken = new FarmingAnimalController();
            Dog = new FarmingAnimalController();
            Pig = new FarmingAnimalController();
        }

        // remove amount of animal
        // if amount greater than animalList.Count => clear animal list
        private void Remove(FarmingAnimalController animalController, string name, int number)
        {   
            if (animalController.AnimalList.Count >= number){

                // delete amount of animal
                FarmingAnimal newAnimal = new FarmingAnimal();

                if (name.Equals(Constant.DAIRY_COW_NAME)){
                    newAnimal = new DairyCow();
                }
                else  if (name.Equals(Constant.CHICKEN_NAME)){
                    newAnimal = new Chicken();
                } 
                else  if (name.Equals(Constant.DOG_NAME)){
                    newAnimal = new Dog();
                }
                else  if (name.Equals(Constant.PIG_NAME)){
                    newAnimal = new Pig();
                }
                else return;

                for (int i = 0; i < number; i++){
                    animalController.Add(newAnimal);
                }
            }
            else {
                // remove all element in list 
                animalController.AnimalList.Clear();
            }
        }

        // add amount animal into list
        private void Add(FarmingAnimalController animalController, string name, int number)
        {
            FarmingAnimal newAnimal = new FarmingAnimal();

            if (name.Equals(Constant.DAIRY_COW_NAME)){
                newAnimal = new DairyCow();
            }
            else  if (name.Equals(Constant.CHICKEN_NAME)){
                newAnimal = new Chicken();
            } 
            else  if (name.Equals(Constant.DOG_NAME)){
                newAnimal = new Dog();
            }
            else  if (name.Equals(Constant.PIG_NAME)){
                newAnimal = new Pig();
            }
            else return;

            for (int i = 0; i < number; i++){
                animalController.Add(newAnimal);
            }
        }

        // add animal
        public void AddAnimal(string animalName, int amount)
        {
            if (animalName.Equals(Constant.DAIRY_COW_NAME)){
                Add(DairyCow, Constant.DAIRY_COW_NAME, amount);
                return;
            }
            if (animalName.Equals(Constant.CHICKEN_NAME)){
                Add(Chicken, Constant.CHICKEN_NAME, amount);
                return;
            }
            if (animalName.Equals(Constant.DOG_NAME)){
                Add(Dog, Constant.DOG_NAME, amount);
                return;
            }
            if (animalName.Equals(Constant.PIG_NAME)){
                Add(Pig, Constant.PIG_NAME, amount);
                return;
            }
        }

        //  remove amount of animal
        public void RemoveAnimal(string animalName, int amount)
        {
            if (animalName.Equals(Constant.DAIRY_COW_NAME)){
                Remove(DairyCow, Constant.DAIRY_COW_NAME, amount);
                return;
            }
            if (animalName.Equals(Constant.CHICKEN_NAME)){
                Remove(Chicken, Constant.CHICKEN_NAME, amount);
                return;
            }
            if (animalName.Equals(Constant.DOG_NAME)){
                Remove(Dog, Constant.DOG_NAME, amount);
                return;
            }
            if (animalName.Equals(Constant.PIG_NAME)){
                Remove(Pig, Constant.PIG_NAME, amount);
                return;
            }
        }

        // print spend amount of animal
        public void TotalAmount()
        {
            float sum = DairyCow.TotalAmount(Constant.FOOD_WEIGHT_DAIRY_COW_EAT_PER_DAY)
                + Chicken.TotalAmount(Constant.FOOD_WEIGHT_CHICKEN_EAT_PER_DAY) 
                + Dog.TotalAmount(Constant.FOOD_WEIGHT_DOG_EAT_PER_DAY)
                + Pig.TotalAmount(Constant.FOOD_WEIGHT_PIG_EAT_PER_DAY);
            
            DairyCow.PrintTotalAmount(Constant.FOOD_WEIGHT_DAIRY_COW_EAT_PER_DAY);
            Chicken.PrintTotalAmount(Constant.FOOD_WEIGHT_CHICKEN_EAT_PER_DAY);
            Dog.PrintTotalAmount(Constant.FOOD_WEIGHT_DOG_EAT_PER_DAY);
            Pig.PrintTotalAmount(Constant.FOOD_WEIGHT_PIG_EAT_PER_DAY);

            Console.WriteLine($"\nTotal: {sum} price");
        }

        // show menu
        public void Menu()
        {
            Console.WriteLine("***************TOTAL AMOUNT**********");
            Console.WriteLine("Remove animal: Remove <Animal code> <Amount>");
            Console.WriteLine("1: Dairy Cow | 2: Chicken | 3: Pig | 4: Dog");
            Console.WriteLine("Add animal: Add <Animal code> <Amount>");
            Console.WriteLine("1: Dairy Cow | 2: Chicken | 3: Pig | 4: Dog");           
        }

        // execute user command
        public void UserCommand()
        {
            int chon1;
            int chon2;           
            do
            {                
                chon2 = int.Parse(Console.ReadLine());
                switch (chon2)
                {
                    case 1: 
                        
                        break;

                    case 2:
                        
                        break;

                    case 3:
                        
                        break;

                    case 4:
                        break;
                    default:
                        Console.WriteLine("vui long nhap lai");
                        break;
                }

            } while (chon2 != 4);
            Console.ReadLine();
        }
    }
}