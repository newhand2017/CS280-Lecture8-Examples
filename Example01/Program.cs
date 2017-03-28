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
            //-------------------------------------------------
            // Creat Vector
            //-------------------------------------------------
            Random random = new Random();

            Vector[] vectors = new Vector[10];
            for (int index = 0; index < vectors.Length; index++)
            {
                vectors[index] = new Vector(random);
            }

            //-------------------------------------------------
            // Sorting
            //-------------------------------------------------
            Console.WriteLine("排序前 : ");
            foreach (Vector v in vectors)
            {
                Console.WriteLine(v);
            }

            ////Sort I
            //Array.Sort(vectors);
            //Console.WriteLine("排序後 : ");
            //foreach (Vector v in vectors)
            //{
            //    Console.WriteLine(v);
            //}

            //Sort II
            //
            Console.Write("選擇排序欄位 : 1.X, 2.Y, 3.Length\n");
            Vector.Selection = int.Parse(Console.ReadLine());

            Array.Sort(vectors);
            Console.WriteLine("排序後 : ");
            foreach (Vector v in vectors)
            {
                Console.WriteLine(v);
            }

            //-------------------------------------------------
        }
    }
}