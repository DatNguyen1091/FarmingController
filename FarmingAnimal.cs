namespace Project_test
{
    class FarmingAnimal
    {
        private string name;
        // get or set value for name
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private Food eatFood;
        // get or set food that farming animal eat
        internal Food EatFood
        {
            get 
            {
                return eatFood;
            }
            set
            {
                eatFood = value;
            }
        }
    }
}