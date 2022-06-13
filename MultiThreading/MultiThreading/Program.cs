using System;
using System.Threading;
class MultiThreading{ 
    
    static void Test1()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine("Test1:" + i);
        }
        Console.WriteLine("Thread1 is Existing");
    
}
    static void Test2()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine("Test2:" + i);
           
            if(i == 50)
            {
                Console.WriteLine("Thread2 is going to sleep");
                Thread.Sleep(1000);
                Console.WriteLine("Thread2 Woke up.");
            }
        }
        Console.WriteLine("Thread2 is Existing");
    }
    static void Test3()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine("Test3:" + i);
           
        }
        Console.WriteLine("Thread3 is Existing");
    }
    static void Main()
    {
        Console.WriteLine("Main Thread is started");
        Thread T1 = new Thread(Test1);

        Thread T2 = new Thread(Test2);
        Thread T3 = new Thread(Test3);
        T1.Start();
        T2.Start();
        T3.Start();

        T1.Join();T2.Join();T3.Join();
        Console.WriteLine("Main Thread is Exited now");
    }
}