using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAkhir4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Input Value = ");
            int n;
            n = int.Parse(Console.ReadLine());
            int[] array_sort = new int[n]; 
            for (int i = 0; i < n; i++)
            {
                Console.Write("Elemen no :" +(i + 1) + " = ");
                array_sort[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 1; j <= n - 1; j++){  
                for (int k = 0; k <= n - 2; k++) {
                    if (array_sort[k] < array_sort[k + 1])
                    {
                        int temp = array_sort[k];
                        array_sort[k] = array_sort[k + 1];
                        array_sort[k + 1] = temp;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Descending Value");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array_sort[i]);
            }
            Console.ReadKey();
            */
            
            int[] angka = new int[10] {5, 2, 4, 3 ,1, 7, 6, 8, 9, 10};
            //sort array a adalah nilai sorting dan b adalah kebalinkan dari nilai sorting 
            Array.Sort(angka, (a, b) => b.CompareTo (a));
            foreach (int i in angka)
            {
                Console.WriteLine("Looping Array : {0}", i);
            }
            Console.ReadKey();
            
        }
    }
}
