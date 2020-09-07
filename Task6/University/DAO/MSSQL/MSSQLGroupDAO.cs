using System.Collections.Generic;
using System.Data.SqlClient;

namespace University
{
    /// <summary>
    /// DAO groups for MS SQL Server DBMS.
    /// </summary>
    public class MSSQLGroupDAO : IGroup
    {
        /// <summary>
        /// SQL query to add data to the database.
        /// </summary>
        private const string INSERT_EXPRESSION =
            "INSERT INTO Groups(GroupName) VALUES (@groupName)";

        /// <summary>
        /// SQL query to get the list of groups from the database.
        /// </summary>
        private const string GET_GROUP_INFORMATION_EXPRESSION
            = "SELECT * FROM Groups";

        /// <summary>
        /// SQL query to update data in the database.
        /// </summary>
        private const string UPDATE_EXPRESSION
            = "UPDATE Groups SET GroupName=@groupName WHERE GroupId=@groupId";

        /// <summary>
        /// SQL query to delete data from the database.
        /// </summary>
        private const string DELETE_EXPRESSION
            = "DELETE FROM Groups WHERE GroupId=@groupId";

        /// <summary>
        /// Obtaining an group ID.
        /// </summary>
        private const string GET_GROUP_EXPRESSION
            = "SELECT GroupId FROM Groups WHERE GroupName=@groupName";


        private string connectionString;


        /// <summary>
        /// Creation of DAO groups for MS SQL Server.
        /// </summary>
        /// <param name="connectionString">The string connecting to the database.</param>
        public MSSQLGroupDAO(string connectionString)
        {
            this.connectionString = connectionString;

            FactoryDAO factory = FactoryDAO.GetFactoryDAO(FactoryDAO.DBMS.MSSQL, connectionString);
        }

        public int GetIdGroup(Group group)
        {
            int id = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(GET_GROUP_EXPRESSION, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@groupName", group.GroupName));
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    id = reader.GetInt32(0);
                }
            }
            return id;
        }

        private Group CreateGroup(SqlDataReader reader)
        {
            Group group = new Group();

            group.GroupName = reader.GetString(1);
            return group;
        }

        /// <summary>
        /// Adding a group to the MS SQL Server database.
        /// </summary>
        /// <param name="group">Group.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Insert(Group group)
        {
            int numb;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(INSERT_EXPRESSION, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@groupName", group.GroupName));

                numb = sqlCommand.ExecuteNonQuery();
            }
            return numb > 0;
        }

        /// <summary>
        /// Getting a list of all groups from the MS SQL Server database.
        /// </summary>
        /// <returns>All groups in the database.</returns>
        public Group[] GetGroups()
        {
            List<Group> group = new List<Group>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    GET_GROUP_INFORMATION_EXPRESSION,
                    connection);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                        group.Add(CreateGroup(reader));
            }
            return group.ToArray();
        }

        /// <summary>
        /// Updating the group in the MS SQL Server database.
        /// </summary>
        /// <param name="nowGroup">Group for renewal.</param>
        /// <param name="newGroup">New group.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Update(Group nowGroup, Group newGroup)
        {
            int numb;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                int id = GetIdGroup(nowGroup);

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(UPDATE_EXPRESSION, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@groupName", newGroup.GroupName));
                numb = sqlCommand.ExecuteNonQuery();
            }
            return numb > 0;
        }

        /// <summary>
        /// Removing a group from the MS SQL Server database.
        /// </summary>
        /// <param name="group">Group.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public bool Delete(Group group)
        {
            int numb;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                int id = GetIdGroup(group);

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(DELETE_EXPRESSION, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@groupId", id));
                numb = sqlCommand.ExecuteNonQuery();
            }
            return numb > 0;
        }
    }
}
