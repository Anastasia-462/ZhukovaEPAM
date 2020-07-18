using System.Collections.Generic;

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
        public string Name { get; protected set; }
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

        /// <summary>
        /// Overriden equality operation. 
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if the values are equal, false in the opposite case.</returns>
        public override bool Equals(object obj)
        {
            return obj is Goods goods &&
                   Name == goods.Name &&
                   Price == goods.Price;
        }

        /// <summary>
        /// Overriden method which calculates hashcode.
        /// </summary>
        /// <returns>An integer number.</returns>
        public override int GetHashCode()
        {
            int hashCode = -44027456;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// Overriden method ToString.
        /// </summary>
        /// <returns>A string with the value of the coefficients.</returns>
        public override string ToString()
        {
            return Name + " " + Price;
        }
    }
}
