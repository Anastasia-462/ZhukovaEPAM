using System;
using System.Collections;
using System.Collections.Generic;

namespace Serializer
{
    /// <summary>
    /// Collection of student.
    /// </summary>
    [Serializable]
    public class StudentCollection : ICollection<Student>
    {
        /// <summary>
        /// List of student.
        /// </summary>
        public List<Student> InnerCollection { get; set; }

        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public StudentCollection()
        {
            InnerCollection = new List<Student>();
        }

        /// <summary>
        /// </summary>
        /// <param name="index">An int number.</param>
        /// <returns></returns>
        public Student this[int index]
        {
            get { return (Student)InnerCollection[index]; }
            set { InnerCollection[index] = value; }
        }

        /// <summary>
        /// Amount elements in List.
        /// </summary>
        public int Count
        {
            get
            {
                return InnerCollection.Count;
            }
        }

        /// <summary>
        /// A boolean value for read.
        /// </summary>
        public bool IsReadOnly
        {
            get { return false; }
        }

        /// <summary>
        /// Method to add item.
        /// </summary>
        /// <param name="item">A Student object.</param>
        public void Add(Student item)
        {
            if (!Contains(item))
                InnerCollection.Add(item);
            else
                throw new Exception("This student was already added.");
        }


        /// <summary>
        /// Method to clear.
        /// </summary>
        public void Clear()
        {
            InnerCollection.Clear();
        }

        /// <summary>
        /// Method checks whether an item in the list or not.
        /// </summary>
        /// <param name="item">A Student object.</param>
        /// <returns>True if list contains item and false in the opposite case.</returns>
        public bool Contains(Student item)
        {
            bool found = false;

            foreach (Student st in InnerCollection)
            {
                if (st.Equals(item))
                    found = true;
            }
            return found;
        }

        /// <summary>
        /// Method to copy array.
        /// </summary>
        /// <param name="array">A Student array.</param>
        /// <param name="arrayIndex">An int number.</param>
        public void CopyTo(Student[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("The array cannot be null.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            if (Count > (array.Length - arrayIndex + 1))
                throw new ArgumentException("The destination array has fewer elements than the collection.");

            for (int i = 0; i < InnerCollection.Count; i++)
                array[i + arrayIndex] = InnerCollection[i];
        }

        /// <summary>
        /// Method to get enumerator.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<Student> GetEnumerator()
        {
            return InnerCollection.GetEnumerator();
        }

        /// <summary>
        /// Method to remove item from list.
        /// </summary>
        /// <param name="item">A Student object.</param>
        /// <returns>True if item was removed from list and false in the opposite case.</returns>
        public bool Remove(Student item)
        {
            bool result = false;

            for (int i = 0; i < InnerCollection.Count; i++)
            {
                Student curStudent = (Student)InnerCollection[i];

                if (Student.Equals(curStudent, item))
                {
                    InnerCollection.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return InnerCollection.GetEnumerator();
        }


        /// <summary>
        /// Overriden method to output a string with all students.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            string result = "";
            foreach (Student student in InnerCollection)
                result += student.ToString();
            return result;
        }

        /// <summary>
        /// Overriden method to compare objects.
        /// </summary>
        /// <param name="obj">An object.</param>
        /// <returns>True if objects are equal and false in the opposite case.</returns>
        public override bool Equals(object obj)
        {
            return obj is StudentCollection collection &&
                   EqualityComparer<List<Student>>.Default.Equals(InnerCollection, collection.InnerCollection) &&
                   Count == collection.Count &&
                   IsReadOnly == collection.IsReadOnly;
        }

        /// <summary>
        /// Method to get hashcode.
        /// </summary>
        /// <returns>Hashcode.</returns>
        public override int GetHashCode()
        {
            int hashCode = 1062018386;
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Student>>.Default.GetHashCode(InnerCollection);
            hashCode = hashCode * -1521134295 + Count.GetHashCode();
            hashCode = hashCode * -1521134295 + IsReadOnly.GetHashCode();
            return hashCode;
        }
    }
}
