using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SEDC.CSharpAdv.Class12.AsyncAwait
{
    public class WorkingWithInts
    {
        public List<int> Integers { get; set; }

        public WorkingWithInts()
        {
            Integers = Enumerable.Range(1, 1000).ToList();
        }

        public List<int> GetAllEvenNumbers()
        {
            List<int> ints = new List<int>();

            foreach (var num in Integers)
            {
                Thread.Sleep(10);
                if(num % 2 == 0)
                {
                    ints.Add(num);
                }
            }
            return ints;
        }

        public async Task<List<int>> GetAllEvenNumbersAsync()
        {
            return await Task.Run(() => GetAllEvenNumbers());
        }
    }
}
