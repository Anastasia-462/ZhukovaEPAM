namespace University
{
    /// <summary>
    /// The interface of the group access object.
    /// </summary>
    public interface IGroup
    {
        /// <summary>
        /// Method which get index by group.
        /// </summary>
        /// <param name="group">Group.</param>
        /// <returns>An int number.</returns>
        int GetIdGroup(Groups group);


        /// <summary>
        /// Adding a new group to the database.
        /// </summary>
        /// <param name="group">A group.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Insert(Groups group);

        /// <summary>
        /// Getting a list of all groups from the database.
        /// </summary>
        /// <returns>All groups.</returns>
        Groups[] GetGroups();

        /// <summary>
        /// Updating the group to the database.
        /// </summary>
        /// <param name="newGroup">A new group.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Update(Groups newGroup);

        /// <summary>
        /// Updating the group to the database.
        /// </summary>
        /// <param name="nowGroup">A current group.</param>
        /// <param name="newGroup">A new group.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Update(Groups nowGroup, Groups newGroup);

        /// <summary>
        /// Deleting the group to the database.
        /// </summary>
        /// <param name="group">A group.</param>
        /// <returns>True if the operation was successful, otherwise False.</returns>
        bool Delete(Groups group);


        /// <summary>
        /// Method which get group by index.
        /// </summary>
        /// <param name="id">An int number.</param>
        /// <returns>Groups.</returns>
        Groups GetGroupByIndex(int id);
    }
}
