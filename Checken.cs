namespace Project_test
{
    class Chicken : FarmingAnimal
    {
        // get or set value for dairy cow
        public Chicken()
        {
            Name = Constant.CHICKEN_NAME;
            EatFood = new Corn();
        }
    }
}