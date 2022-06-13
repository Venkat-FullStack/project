using System;
using System.Threading;
class ThreadDemo
{
    static void Main()
    {
        Thread t = Thread.CurrentThread;
        t.Name = "main Thread";
        Console.WriteLine("current Thread is :" + t.Name);
    }
}