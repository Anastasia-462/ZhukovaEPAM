using System;
using System.Collections.Generic;

namespace TcpIp
{
    /// <summary>
    /// Class to process the messages.
    /// </summary>
    public class Parser
    {
        /// <summary>
        /// Constructor of this class.
        /// </summary>
        public Parser() { }

        /// <summary>
        /// Method which translates message.
        /// </summary>
        /// <param name="message">A string.</param>
        /// <returns>Translated message.</returns>
        public string Parsing(string message)
        {
            string result = "";
            string[] words = (message.ToLower()).Split(' ', ',', '.', '!');
            for (int i = 0; i < words.Length; i++)
            {
                char[] letters = words[i].ToCharArray();
                foreach (char x in letters)
                {
                    if ((int)x < 127)
                        result += alphabetEng[x];
                    else
                        result += alphabetRus[x];
                }
                result += " ";
            }
            return result;
        }

        /// <summary>
        /// Russian-English dictionary.
        /// </summary>
        public Dictionary<char, string> alphabetRus = new Dictionary<char, string>
        {
            ['а'] = "a",
            ['б'] = "b",
            ['в'] = "v",
            ['г'] = "g",
            ['д'] = "d",
            ['е'] = "e",
            ['ё'] = "e",
            ['ж'] = "*",
            ['з'] = "z",
            ['и'] = "i",
            ['й'] = "j",
            ['к'] = "k",
            ['л'] = "l",
            ['м'] = "m",
            ['н'] = "n",
            ['о'] = "o",
            ['п'] = "p",
            ['р'] = "r",
            ['с'] = "s",
            ['т'] = "t",
            ['у'] = "u",
            ['ф'] = "f",
            ['х'] = "x",
            ['ц'] = "c",
            ['ч'] = "$",
            ['ш'] = "h",
            ['щ'] = "w",
            ['ъ'] = "\'",
            ['ы'] = "&",
            ['ь'] = "\"",
            ['э'] = ">",
            ['ю'] = "q",
            ['я'] = "y"
        };

        /// <summary>
        /// English-Russian dictionary.
        /// </summary>
        public Dictionary<char, string> alphabetEng = new Dictionary<char, string>
        {
            ['a'] = "а",
            ['b'] = "б",
            ['v'] = "в",
            ['g'] = "г",
            ['d'] = "д",
            ['e'] = "е",
            ['*'] = "ж",
            ['z'] = "з",
            ['i'] = "и",
            ['j'] = "й",
            ['k'] = "к",
            ['l'] = "л",
            ['m'] = "м",
            ['n'] = "н",
            ['o'] = "о",
            ['p'] = "п",
            ['r'] = "р",
            ['s'] = "с",
            ['t'] = "т",
            ['u'] = "у",
            ['f'] = "ф",
            ['x'] = "х",
            ['c'] = "ц",
            ['$'] = "ч",
            ['h'] = "ш",
            ['w'] = "щ",
            ['\''] = "ъ",
            ['&'] = "ы",
            ['\"'] = "ь",
            ['>'] = "э",
            ['q'] = "ю",
            ['y'] = "я"
        };
    }
}
