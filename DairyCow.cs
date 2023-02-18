namespace Project_test
{
    class DairyCow : FarmingAnimal
    {
        // get or set value for dairy cow
        public DairyCow()
        {
            Name = Constant.DAIRY_COW_NAME;
            EatFood = new Grass();
        }
    }
}