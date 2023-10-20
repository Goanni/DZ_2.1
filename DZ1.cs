using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2._1
{
    internal class DZ1
    {
        static void Main()
        {
            Console.WriteLine("Введите размер масива: ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            int[] m1 = new int[size1];

            Random rnd = new Random();
            for (int i = 0; i < size1; i++)
            {
                m1[i] = rnd.Next(100);
            }
            Console.Write("Исходный массив: ");
            for (int i = 0; i < m1.Length; i++)
            {
                Console.Write(m1[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Введите размер масива: ");
            int size2 = Convert.ToInt32(Console.ReadLine());
            int[] m2 = new int[size2];
            for (int i = 0; i < size2; i++)
            {
                m2[i] = rnd.Next(100);
            }
            Console.Write("Второй массив: ");
            for (int i = 0; i < m2.Length; i++)
            {
                Console.Write(m2[i] + " ");
            }

            Console.WriteLine();
            int K = rnd.Next(1, size1 + 1);
            Console.WriteLine("K = " + K);

            Array.Resize(ref m1, size1 + size2);
            //Console.WriteLine(m1.Length);
            for (int i = size1 - 1; i > K -1; i--)
            {
                m1[i + size2] = m1[i];
            }
            Console.WriteLine();
            Array.Copy(m2, 0, m1, K, size2);
            for (int i = 0; i < m1.Length; i++)
            {
                Console.Write(m1[i] + " ");
            }

        }
    }
}

