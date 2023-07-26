using System;

namespace AP_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            Console.WriteLine("Queue after being Enqueued:");
            Queue Q = new Queue(10);

            Q.insert(10);
            Q.insert(20);
            Q.insert(30);
            Q.insert(40);
            Q.insert(50);
            Q.insert(60);
            Q.insert(70);
            Q.insert(80);
            Q.insert(90);
            Q.insert(100);

            Console.WriteLine(Q.printQueue());
            Console.WriteLine("Queue after being Dequeued: ");
            Q.delete();
            Q.delete();

            Console.WriteLine(Q.printQueue());
        }
    }
}
