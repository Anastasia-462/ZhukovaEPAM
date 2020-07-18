namespace Shop
{
    /// <summary>
    /// Class of technic as a specific type of goods.
    /// </summary>
    public class Technic : Goods
    {
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="name">A string.</param>
        /// <param name="price">A double number.</param>
        public Technic(string name, double price) : base(name, price)
        {
        }

        /// <summary>
        /// Overriden operation is additions.
        /// </summary>
        /// <param name="t1">A Technic value.</param>
        /// <param name="t2">A Technic value.</param>
        /// <returns>New object of the class Technic.</returns>
        public static Technic operator +(Technic t1, Technic t2)
        {
            string name = t1.Name + " - " + t2.Name;
            double price = (t1.Price + t2.Price) / 2;
            return new Technic(name, price);
        }

        /// <summary>
        /// Method that converting a Technic to an Chemicals.
        /// </summary>
        /// <param name="chemicals">A Chemicals value.</param>
        public static explicit operator Technic(Chemicals chemicals)
        {
            return new Technic(chemicals.Name, chemicals.Price);
        }

        /// <summary>
        /// Method that converting a Technic to an FoodSupply.
        /// </summary>
        /// <param name="foodSupply">A FoodSupply value.</param>
        public static explicit operator Technic(FoodSupply foodSupply)
        {
            return new Technic(foodSupply.Name, foodSupply.Price);
        }
    }
}
