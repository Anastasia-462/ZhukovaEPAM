namespace Shop
{
    /// <summary>
    /// Class of product.
    /// </summary>
    public abstract class Goods
    {
        /// <summary>
        /// Name of product.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// price of product.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="name">A string.</param>
        /// <param name="price">A double number.</param>
        public Goods(string name, double price)
        {
            Name = name;
            Price = price;            
        }
    }
}
