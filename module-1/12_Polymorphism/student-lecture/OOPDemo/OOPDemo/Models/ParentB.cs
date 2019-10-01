using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo.Models
{
    public class ParentB : GrandparentA  //ParentB derived from GrandparentA
    {
        //constructor
        public ParentB(String color)
        {
            Console.WriteLine($"ParentB constructor: {color}");
        }

        public override string VirtualMethodA2(string input)
        {
            string s = $"ParentB.VirtualMethodA2:{input}";
            return s;
        }
    }
}
