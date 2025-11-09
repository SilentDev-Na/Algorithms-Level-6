using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBinarySearch.Helper
{
    public class Helper
    {
        public static string PrintArrow<T>(List<T> list, int index)
        {
            if (index == -1)
                return "";

            StringBuilder sbArrow = new StringBuilder();
            for (int i = 0; i < index; i++)
            {
                sbArrow.Append(new string(' ', list[i].ToString().Length + 1));
            }
            sbArrow.Append("⬆️");
            return sbArrow.ToString();
        }
        public static T ReadValue<T>(string Message)
        {

            Console.Write(Message + " ");
            string input = Console.ReadLine();

            try
            {
                // تحويل القيمة المدخلة إلى النوع T
                return (T)Convert.ChangeType(input, typeof(T));
            }
            catch
            {
                Console.WriteLine("Invalid input, returning default value.");
                return default(T);
            }
        }

    }
}
