namespace Project_test
{
    class Food
    {
        private string name;
        // get or set food name
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

        private float price;
        // get or set food price 
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        
        // calculate total amount of food weight
        public float Amount(float weight)
        {
            return price * weight;
        }
    }
}