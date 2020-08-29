namespace University
{
    /// <summary>
    /// Class describing the group.
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Group name.
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Group() { }

        /// <summary>
        /// Method which returns values of class fields anf properties.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            return GroupName + "";
        }
    }
}
