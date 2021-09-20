using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympic
{
    class Program
    {
        static void Main(string[] args)
        {
            var mylist = new List<string>() { "pasha","sssss","anna","masha","pasha", "masha", "masha", "anna", "anna", "anna" };
            var dict = new Dictionary<string, int>();

            for (int i = 0; i < mylist.Count; i++)
            {
                if(dict.ContainsKey(mylist[i]))
                {
                    dict[mylist[i]] += 1;
                }
                else
                {
                    dict.Add(mylist[i], 1);
                }
            }
            foreach(var item in dict.OrderByDescending (item => item.Value))
            {
                
                Console.WriteLine( "{0} - {1}",item.Key, item.Value) ;
            }
        }
    }
}
