using System;
using System.Threading;
class ThreadLocking
{
    public void Display()
    {
        lock (this)
        {
            Console.Write("[C sharp is an");
            Thread.Sleep(15000);
            Console.WriteLine("object oriented Language]");
        }
    }
      static void Main()
    { 
        ThreadLocking obj = new ThreadLocking();
        Thread t1 = new Thread(obj.Display);
        Thread t2 = new Thread(obj.Display);
        Thread t3 = new Thread(obj.Display);
        t1.Start();
        t2.Start();
        t3.Start();
    }
}