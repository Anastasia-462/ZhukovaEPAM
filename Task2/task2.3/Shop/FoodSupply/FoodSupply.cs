namespace Shop
{
    /// <summary>
    /// Class of product as a specific type of goods.
    /// </summary>
    public class FoodSupply : Goods
    {
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="name">A string.</param>
        /// <param name="price">A double number.</param>
        protected FoodSupply(string name, double price) : base(name, price)
        {
        }

        /// <summary>
        /// Overriden operation is additions.
        /// </summary>
        /// <param name="f1">A Product value.</param>
        /// <param name="f2">A Product value.</param>
        /// <returns>New object of the class Product.</returns>
        public static FoodSupply operator +(FoodSupply f1, FoodSupply f2)
        {
            string name = f1.Name + " - " + f2.Name;
            double price = (f1.Price + f2.Price) / 2;
            return new FoodSupply(name, price);
        }
    }
}
