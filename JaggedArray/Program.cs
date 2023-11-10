using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[][] matrix = new int[3][];
            //matrix[0]=new int[4] {1,2,3,4};
            //matrix[1] = new int[2] { 5, 6 };
            //matrix[2] = new int[3] { 7, 8,9 };
            //Console.WriteLine("Matrix[0][0]:" + matrix[0][0]);
            //Console.WriteLine("matrix[1][1]" + matrix[1][1]);
            //foreach(int[] row in matrix)
            //{
            //    foreach (int element in row)
            //    {
            //        Console.Write(element+" \t");
            //    }
            //    Console.WriteLine();
            //}
            //2nd Task
            //int element = matrix[0][1];
            //foreach (int[] row in matrix)
            //{
            //    foreach(int item in row)
            //    {
            //        Console.WriteLine(item+" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Value of the second elemeny in the first row(element):"+element);
            //task3
            //int[][] matrix = new int[3][];
            //matrix[0] = new int[4] { 1, 2, 3, 4 };
            //matrix[1] = new int[3] { 5, 6, 8 };
            //matrix[2] = new int[3] { 7, 8, 9 };
            //matrix[1][2] = 15;
            //foreach(int[] row in matrix)
            //{
            //    foreach(int item in row)
            //    {
            //        Console.Write(item+" \t");
            //    }
            //    Console.WriteLine();
            //}
            dynamic Myobject = new dynamic[2][];
            Myobject[0] = new dynamic[3] {12,"Sam",86.99 };
            Myobject[1] = new dynamic[4] { "A", true, "Sam",DateTime.Now};
            Console.WriteLine("Element of ObjectMatrix as follows");
            foreach (object[] row in Myobject)
            {
                foreach (object item in row)
                {
                    Console.WriteLine($"{item.GetType().Name}: {item}");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
