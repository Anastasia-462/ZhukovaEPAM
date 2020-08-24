namespace University
{
    /// <summary>
    /// The interface of the group access object.
    /// </summary>
    public interface IGroup
    {
        //string[] GetGroupName();

        //int GetIndexByName(string name);
        //string GetGroupByIndex(int id);

        /// <summary>
        /// Adding a new group to the database.
        /// </summary>
        /// <param name="group">A group.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Insert(Group group);

        /// <summary>
        /// Getting a list of all groups from the database.
        /// </summary>
        /// <returns>All groups.</returns>
        Group[] GetGroups();

        /// <summary>
        /// Updating the group to the database.
        /// </summary>
        /// <param name="nowGroup">A current group.</param>
        /// <param name="newGroup">A new group.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Update(Group nowGroup, Group newGroup);

        /// <summary>
        /// Deleting the group to the database.
        /// </summary>
        /// <param name="group">A group.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Delete(Group group);
    }
}
