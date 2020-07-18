using System;

namespace Shop
{
    /// <summary>
    /// Class of shampoo as a specific goods.
    /// </summary>
    public class Shampoo : Chemicals
    {
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Shampoo() : base("Shampoo", 8.5)
        {
        }
        //public static implicit operator Shampoo(Chemicals chemicals) => new Shampoo();

        /// <summary>
        /// Method that converting a Goods Type to an Integer.
        /// </summary>
        /// <param name="shampoo">A Shampoo value.</param>
        public static implicit operator int(Shampoo shampoo) => (int)(shampoo.Price * 100);

        /// <summary>
        /// Method that converting a Goods Type to an Double.
        /// </summary>
        /// <param name="shampoo">A Shampoo value.</param>
        public static implicit operator double(Shampoo shampoo) => shampoo.Price;
    }
}
