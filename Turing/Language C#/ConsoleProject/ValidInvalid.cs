using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /**
     * Turing valid parameters problem
     * Status: Sovled
     * Date: 2022-03-24
     */
    sealed class ValidInvalid
    {
        public static bool IsValid(string data)
        {
            List<char> dataList = data.ToList();

            int size = dataList.Count;
            
            for(int i = 1; i < size; i++)
            {
                if (i == 0) continue;

                switch (dataList[i])
                {
                    case ')':
                        if ((dataList[i]-1) == dataList[i - 1])
                        {
                            dataList.RemoveAt(i--);
                            dataList.RemoveAt(i--);
                            size -= 2;
                        }
                        break;
                    default:
                        if ((dataList[i] - 2) == dataList[i - 1])
                        {
                            dataList.RemoveAt(i--);
                            dataList.RemoveAt(i--);
                            size -= 2;
                        }
                        break;
                }
            }    

            return size < 2;
        }
    }

}
