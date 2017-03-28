using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();

            Vector[] vectors = new Vector[10];
            for (int index = 0; index < vectors.Length; index++)
            {
                vectors[index] = new Vector(random);
            }

            Console.WriteLine("排序前 : ");
            foreach (Vector v in vectors)
            {
                Console.WriteLine(v);
            }

            Array.Sort(vectors);
            Console.WriteLine("排序後 : ");
            foreach (Vector v in vectors)
            {
                Console.WriteLine(v);
            }
        }
    }
}