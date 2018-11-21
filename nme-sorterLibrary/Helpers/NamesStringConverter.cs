using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using name_sorter.Library.Models;
using name_sorter.Library.Globals;

namespace name_sorter.Library.Helpers
{
    public class NamesStringConverter
    {

        /// <summary>
        /// Convert names in one string to list of name object
        /// </summary>
        /// <param name="nameString">names in string</param>
        /// <returns></returns>
        public static List<Name> ConvertStringToNames(string nameString)
        {
            List<Name> nameList = new List<Name>();

            List<string> names = nameString.Trim().Split(new[] { Constants.NAMES_SEPARATOR }, StringSplitOptions.None).ToList();

            foreach (string onename in names)
            {
                if (!string.IsNullOrEmpty(onename))
                {
                    string[] lines = onename.Trim().Split(new[] { " " }, StringSplitOptions.None);
                    Name name = new Name();
                    name.LastName = lines.Last().ToString();
                    string[] firstNames = lines.Take(lines.Length - 1).ToArray();
                    name.FirstName = String.Join(" ", firstNames);
                    nameList.Add(name);
                }
            }

            return nameList;
        }

        /// <summary>
        /// convert list of name object to one string
        /// </summary>
        /// <param name="names">list of name object</param>
        /// <returns></returns>
        public static string ConvertNamesToString(List<Name> names)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Name name in names)
            {
                sb.Append(name.FirstName + " " + name.LastName + Environment.NewLine);   
            }
            return sb.ToString();
        }

    }
}
