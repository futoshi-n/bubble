using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 5, 2, 9, 3, 6, 4, 1, 7, 8, 10 };
            for (int x = 0; x < list.Length; x++)
            {
                for (int i = 0; i < list.Length-1; i++)
                {
                    int tmp = 0;
                    if (list[i] > list[i + 1])
                    {
                        tmp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = tmp;
                    }

                }
            }
            Console.WriteLine(String.Join(",",list));
            Console.ReadLine();
        }
    }
}
