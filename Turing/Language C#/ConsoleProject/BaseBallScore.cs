using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /**
     * 
     * Turing baseball problem
     * Status: solved
     * Date: 2022-03-24
     */
    sealed class BaseBallScore
    {
        internal static int GetScore(string[] scores)
        {
            int size = scores.Length;
            List<int> result = new List<int>();

            for (int i = 0, j = 0; i < size; i++)
            {
                char val = char.Parse(scores[i]);

                switch (val)
                {
                    case 'C':
                        result.RemoveAt(--j);
                        break;
                    case 'D':
                        result.Add(result[j - 1] * 2);
                        j++;
                        break;
                    case '+':
                        result.Add(result[j - 1] + result[j - 2]);
                        j++;
                        break;
                    default:
                        result.Add(int.Parse(val.ToString()));
                        j++;
                        break;
                }
            }
            return result.Sum();
        }
    }
}
