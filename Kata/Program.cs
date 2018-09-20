using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    //Problem statement:
    //Given an array, find the int that appears an odd number of times.

    //There will always be only one integer that appears an odd number of times.

    class Program
    {
        static void Main(string[] args)
        {
            var array = new[]{0,0,1,1,1,5,5,5,5,5}; 
            
            Console.WriteLine(Kata.find_it(array));
        }
    }
}
