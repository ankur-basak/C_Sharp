using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theory1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] excutes = { "XOXOXO", "OXOXOX", "XOXOXO", "OXOXOX" };

            foreach(String excute in excutes)
            {
                Console.WriteLine(excute);
            }
        }
    }
}
