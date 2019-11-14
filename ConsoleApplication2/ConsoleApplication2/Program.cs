using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            OOPCSEntities db = new OOPCSEntities();
            var sum = 0;
            var expentitures = db.Expenditures.ToArray();
            for (int i = 0; i < expentitures.Length; i++)
            {
                sum += expentitures[i].Price;
            }
            Console.WriteLine("Tong Tien La : {0}", sum);
        }
    }
}
