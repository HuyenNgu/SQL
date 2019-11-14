using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new OOPCSEntities();
            var expenditures = db.Expenditures.ToArray();
            int sum = 0;
            //for (int i = 0; i < expenditures.Length; i++)
            //    sum = sum + expenditures[i].Price;
            foreach (var expenditure in expenditures)
                sum = sum + expenditure.Price;
            Console.WriteLine(sum);

        }
    }
}
