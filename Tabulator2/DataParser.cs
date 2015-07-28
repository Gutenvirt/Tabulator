using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;

namespace Tabulator2
{
    public static class DataParser
    {

        public static string[,] Parser(string data)
        {
            char[] delim = new char[] { '\t' };

            string[] stext = data.Split(new char[] { '\n' }, StringSplitOptions.None);

            int nRows = stext.Length - 1;
            int nCols = stext[0].Count(x => x == delim[0]) + 1;

            string[,] result = new string[nRows, nCols];

            for (int i = 0; i < nRows; i++)
            {
                string[] t = stext[i].Split(delim, StringSplitOptions.None);
                for (int j = 0; j < nCols; j++)
                {
                    if (i > 0 & string.IsNullOrWhiteSpace(t[j]) && (!string.IsNullOrWhiteSpace(result[0, j]) | !string.IsNullOrWhiteSpace(result[1, j])))
                        t[j] = "-";
                    result[i, j] = t[j];
                }
            }
            return result;
        }

    }
}
