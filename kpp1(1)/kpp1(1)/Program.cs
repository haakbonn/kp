using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpp1_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numElements = 1000000;
            const int searchIterations = 1000;

            LinkedList<int> linkedList = new LinkedList<int>();
            ArrayList arrayList = new ArrayList();
            HashSet<int> hashSet = new HashSet<int>();

            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < numElements; i++)
            {
                linkedList.AddLast(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"Time taken to add {numElements} elements to LinkedList: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for (int i = 0; i < numElements; i++)
            {
                arrayList.Add(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"Time taken to add {numElements} elements to ArrayList: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for (int i = 0; i < numElements; i++)
            {
                hashSet.Add(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"Time taken to add {numElements} elements to HashSet: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for (int i = 0; i < searchIterations; i++)
            {
                linkedList.Contains(numElements / 2);
            }
            stopwatch.Stop();
            Console.WriteLine($"Time taken to search in LinkedList: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for (int i = 0; i < searchIterations; i++)
            {
                arrayList.Contains(numElements / 2);
            }
            stopwatch.Stop();
            Console.WriteLine($"Time taken to search in ArrayList: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for (int i = 0; i < searchIterations; i++)
            {
                hashSet.Contains(numElements / 2);
            }
            stopwatch.Stop();
            Console.WriteLine($"Time taken to search in HashSet: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for (int i = 0; i < numElements; i++)
            {
                linkedList.Remove(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"Time taken to remove {numElements} elements from LinkedList: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for (int i = 0; i < numElements; i++)
            {
                arrayList.Remove(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"Time taken to remove {numElements} elements from ArrayList: {stopwatch.Elapsed}");

            stopwatch.Restart();
            for (int i = 0; i < numElements; i++)
            {
                hashSet.Remove(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"Time taken to remove {numElements} elements from HashSet: {stopwatch.Elapsed}");
        }
    }
}