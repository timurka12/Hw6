using System;
using System.Diagnostics;
using System.Linq;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
        var pL = Process.GetProcesses();
        foreach (var p in pL)
        {
            Console.WriteLine($"{p.Id} {p.ProcessName} {p.BasePriority}");
        }
        Console.Write("name = ");
        var name = Console.ReadLine();
        try
        {
            pL.First(p => p.ProcessName.ToLower() == name.ToLower()).Kill();
            Console.WriteLine($"{name} delated!");
        }
         catch(InvalidOperationException)
        {
                Console.WriteLine($"Process {name} not found");
        }
        }
    }
}
