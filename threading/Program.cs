﻿using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Thread t = Thread.CurrentThread;
        t.Name = "Main Thread";
        Console.WriteLine("Current " + Thread.CurrentThread.Name);
    }
}
