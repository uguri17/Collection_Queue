using System;
using System.Collections.Generic; // Collection Library

namespace Collection_Queue
{
    class QueueExample
    {
        static void Main(string[] args)
        {
            // int타입의 queue 선언
            Queue<int> queue = new Queue<int>();

            // queue에 값 추가 (Enqueue)
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("queue에서 Dequeue()로 꺼내는 순서(선입선출)");
            Console.WriteLine("                             First In, First Out");

            while (queue.Count >= 1)
            {
                int value = queue.Dequeue();
                Console.WriteLine(value);
            }
        }
    }
}
