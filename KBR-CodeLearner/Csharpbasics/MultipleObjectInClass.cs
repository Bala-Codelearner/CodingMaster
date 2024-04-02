using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBR_CodeLearner.Csharpbasics
{
    public class MultipleObjectInClass
    {
        string color = "red";
        public static void main(string[] args)
        {
            MultipleObjectInClass mycolor = new MultipleObjectInClass();
            MultipleObjectInClass mycolor2 = new MultipleObjectInClass();
            Console.WriteLine(mycolor.color);
            Console.WriteLine(mycolor2.color);
        }
    }
}
