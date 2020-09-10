using System.Data.Linq.Mapping;

namespace University
{
    /// <summary>
    /// Class describing the group.
    /// </summary>
    [Table(Name = "Groups")]
    public class Groups
    {
        /// <summary>
        /// Group id.
        /// </summary>
        [Column(Name = "GroupId", IsPrimaryKey = true, IsDbGenerated = true)]
        public int GroupId { get; set; }

        /// <summary>
        /// Group name.
        /// </summary>
        [Column(Name = "GroupName")]
        public string GroupName { get; set; }

        /// <summary>
        /// Specialty.
        /// </summary>
        [Column(Name = "Specialty")]
        public string Specialty { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Groups() { }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="groupId">A string value.</param>
        /// <param name="groupName">A string value.</param>
        /// <param name="specialty">A string value.</param>
        public Groups(string groupName, string specialty) 
        {
            GroupName = groupName;
            Specialty = specialty;
        }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="groupName">A string value.</param>
        public Groups(string groupName)
        {
            GroupName = groupName;
        }

        /// <summary>
        /// Method which returns values of class fields anf properties.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            return GroupName + " " + Specialty + ";";
        }
    }
}
