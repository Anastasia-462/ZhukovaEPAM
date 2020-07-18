namespace Shop
{
    /// <summary>
    /// Class of chemicals as a specific type of goods.
    /// </summary>
    public class Chemicals : Goods
    {
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="name">A string.</param>
        /// <param name="price">A double number.</param>
        protected Chemicals(string name, double price) : base(name, price)
        {
        }

        /// <summary>
        /// Overriden operation is additions.
        /// </summary>
        /// <param name="ch1">A Chemicals value.</param>
        /// <param name="ch2">A Chemicals value.</param>
        /// <returns>New object of the class Chemicals.</returns>
        public static Chemicals operator +(Chemicals ch1, Chemicals ch2)
        {
            string name = ch1.Name + " - " + ch2.Name;
            double price = (ch1.Price + ch2.Price) / 2;
            return new Chemicals(name, price);
        }

        /// <summary>
        /// Method that converting a Chemicals to an FoodSupply.
        /// </summary>
        /// <param name="foodSupply">A FoodSupply value.</param>
        public static explicit operator Chemicals(FoodSupply foodSupply)
        {
            return new Chemicals(foodSupply.Name, foodSupply.Price);
        }

        /// <summary>
        /// Method that converting a Chemicals to an Technic.
        /// </summary>
        /// <param name="technic">A Technic value.</param>
        public static explicit operator Chemicals(Technic technic)
        {
            return new Chemicals(technic.Name, technic.Price);
        }
    }
}
