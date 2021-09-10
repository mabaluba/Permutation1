using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Combinatorics.Collections;

namespace Permutation1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2017;
            var arr = number.ToString().ToArray().Select(i=>int.Parse(i.ToString())).ToArray();
            var perm = new Permutations<int>(arr);
            var bigList = new List<int>();
            foreach (var p in perm)
            {
                var smallList = new string[number.ToString().Length];
                for (int i = 0; i < number.ToString().Length; i++)
                {
                    smallList[i]=p[i].ToString();
                }
                bigList.Add(int.Parse(string.Join("", smallList)));
            }
            bigList.OrderBy(w => w.ToString().Sum(c => char.GetNumericValue(c)));
            var res = bigList[bigList.IndexOf(number)+1];

        }
    }
}
