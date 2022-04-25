using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        

        static void Main(string[] args)
        {

            ArrayList a = new ArrayList();
            a.Add("hello");
            a.Add("bye");
            a.Add(2);
            Console.WriteLine("Hiiii");
            Debug.WriteLine("Heyy");
            foreach(var s in a)
            {
                Console.WriteLine(s);
            }
           
        }
    }
}
