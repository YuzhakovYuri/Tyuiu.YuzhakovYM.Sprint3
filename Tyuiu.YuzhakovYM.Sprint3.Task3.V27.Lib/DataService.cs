using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YuzhakovYM.Sprint3.Task3.V27.Lib
{
    public class DataService : ISprint3Task3V27
    {
        public int ConvertStringToInt(string value)
        {
            string result = "";
            foreach(char n in value)
            {
                if (char.IsDigit(n))
                {
                    result += n;
                }
            }
            int res = Int32.Parse(result);
            return res;
        }
    }
}
