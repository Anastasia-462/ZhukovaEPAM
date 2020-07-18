namespace Shop
{
    /// <summary>
    /// Class of computer as a specific goods.
    /// </summary>
    public class Computer : Technic
    {
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Computer() : base("Computer", 1322.5)
        {
        }

        /// <summary>
        /// Method that converting a Goods Type to an Integer.
        /// </summary>
        /// <param name="computer">A Computer value.</param>
        public static implicit operator int(Computer computer) => (int)(computer.Price * 100);

        /// <summary>
        /// Method that converting a Goods Type to an Double.
        /// </summary>
        /// <param name="computer">A Computer value.</param>
        public static implicit operator double(Computer computer) => computer.Price;

    }
}
