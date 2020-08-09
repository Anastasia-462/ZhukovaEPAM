using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
//using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serializer
{
    /// <summary>
    /// Class for serialization and deserialization of classes and their generalized collections.
    /// </summary>
    /// <typeparam name="T">Universal parameter.</typeparam>
    public static class Serialization<T>
    {
        //XML

        /// <summary>
        /// Method to xml serialization of class.
        /// </summary>
        /// <param name="path">File path.</param>
        /// <param name="value">Universal parameter.</param>
        /// <returns>True if the class is serialized and false in the opposite case.</returns>
        public static bool XmlSerialization(string path, T value)
        {
            bool result = false;

            XmlSerializer format = new XmlSerializer(typeof(T));
            using (Stream fStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                format.Serialize(fStream, value);
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Method to xml serialization of of collection of class.
        /// </summary>
        /// <param name="path">File path.</param>
        /// <param name="value">Collection.</param>
        /// <returns>True if the class is serialized and false in the opposite case.</returns>
        public static bool XmlSerialization(string path, ICollection<T> value)
        {
            bool result = false;
            List<T> values = value.ToList<T>();
            XmlSerializer format = new XmlSerializer(typeof(List<T>));
            using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                format.Serialize(fStream, values);
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Method to xml deserialization of class.
        /// </summary>
        /// <param name="path">File path.</param>
        /// <param name="version">Version of class.</param>
        /// <returns>True if the class is deserialized and false in the opposite case.</returns>
        public static T XmlDeserialization(string path, int version)
        {
            T value;
            XmlSerializer format = new XmlSerializer(typeof(T));
            using (Stream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                value = (T)format.Deserialize(fs);
                //Version =;
            }
            if (version == value.GetHashCode())
                return value;
            else
                return default(T);
        }

        /// <summary>
        /// Method to xml deserialization of collection of class.
        /// </summary>
        /// <param name="path">File path.</param>
        /// <returns>True if the class is deserialized and false in the opposite case.</returns>
        public static ICollection<T> XmlDeserializationCollection(string path)
        {
            ICollection<T> value;
            XmlSerializer format = new XmlSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                value = (ICollection<T>)format.Deserialize(fs);
            }
            return value;
        }
    }
}
