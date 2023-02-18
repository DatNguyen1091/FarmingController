namespace Project_test
{
    class Dog : FarmingAnimal
    // get or set value for dog
    {
        public Dog()
        {        
            Name = Constant.DOG_NAME;
            EatFood = new Meat();
        }
    }
}