using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraBUS
{
    public class CheckDigit
    {
        public bool checkDigit(string s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]) == true)
                    continue;
                else
                    return false;
            }
            return true;
        }
    }
}
