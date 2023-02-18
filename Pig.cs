namespace Project_test
{
    class Pig : FarmingAnimal
    {
        // get or set value for pig
        public Pig()
        {
            Name = Constant.PIG_NAME;
            EatFood = new Bran();
        }
    }
}