using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    /// <summary>
    /// DAO groups for LINQ DBMS.
    /// </summary>
    public class LINQGroupDAO : IGroup
    {
        DataContext dataContext;

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        /// <param name="connectionString">A string value.</param>
        public LINQGroupDAO(string connectionString)
        {
            dataContext = new DataContext(connectionString);
        }

        /// <summary>
        /// Removing a group from the database.
        /// </summary>
        /// <param name="group">Group.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Delete(Groups group)
        {
            dataContext.GetTable<Groups>().DeleteOnSubmit(group);
            dataContext.SubmitChanges();
            return true;
        }

        /// <summary>
        /// Getting a list of all groups from the database.
        /// </summary>
        /// <returns>All groups in the database.</returns>
        public Groups[] GetGroups()
        {
            Table<Groups> groups = dataContext.GetTable<Groups>();
            return groups.ToArray();
        }

        /// <summary>
        /// Method which get index by group.
        /// </summary>
        /// <param name="groups">Group.</param>
        /// <returns>An int number.</returns>
        public int GetIdGroup(Groups groups)
        {
            var query = from gr in dataContext.GetTable<Groups>()
                        where gr.GroupName == groups.GroupName &&
                        gr.Specialty == groups.Specialty
                        select gr.GroupId;
            return query.First();
        }

        /// <summary>
        /// Adding a group to the database.
        /// </summary>
        /// <param name="group">Group.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Insert(Groups group)
        {
            dataContext.GetTable<Groups>().InsertOnSubmit(group);
            dataContext.SubmitChanges();
            return true;
        }

        /// <summary>
        /// Updating the group in database.
        /// </summary>
        /// <param name="nowGroup">Group for renewal.</param>
        /// <param name="newGroup">New group.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Update(Groups nowGroup, Groups newGroup)
        {
            nowGroup.GroupName = newGroup.GroupName;
            nowGroup.Specialty = newGroup.Specialty;
            dataContext.SubmitChanges();
            return true;
        }
    }
}
