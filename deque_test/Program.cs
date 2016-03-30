using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace deque_test
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 100000000;
            const int MAX = 5;
            {
                string[] strings = { "ABC", "DEF", "GHI" };
                var list = new List<string>();
                var rand = new Random();

                var sw = Stopwatch.StartNew();
                for (var i = 0; i < N; ++i)
                {
                    list.Add(strings[rand.Next(strings.Length)]);
                    if (list.Count > MAX)
                        list.RemoveAt(0);
                }
                sw.Stop();
                Console.WriteLine($"List<T> : count = {N}, {sw.ElapsedMilliseconds}ms");
            }
            {
                string[] strings = { "ABC", "DEF", "GHI" };
                var queue = new Queue<string>();
                var rand = new Random();

                var sw = Stopwatch.StartNew();
                for (var i = 0; i < N; ++i)
                {
                    queue.Enqueue(strings[rand.Next(strings.Length)]);
                    if (queue.Count > MAX)
                        queue.Dequeue();
                }
                sw.Stop();
                Console.WriteLine($"Queue<T> : count={N}, {sw.ElapsedMilliseconds}ms");
            }
            Console.WriteLine("[END]");
            Console.ReadLine();
        }
    }
}
