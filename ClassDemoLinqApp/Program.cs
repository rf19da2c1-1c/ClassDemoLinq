using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoLinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqWorker worker = new LinqWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
