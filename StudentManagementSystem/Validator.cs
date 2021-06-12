using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    /// <summary>
    /// Can not create instances of this object.
    /// This works like the Math class.
    /// </summary>
    static class Validator
    {
        public static bool IsPresent(TextBox box)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                return false;
            }
            return true;
        }

        public static bool IsInt32(string input)
        {
            try
            {
                Convert.ToInt32(input);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
