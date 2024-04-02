using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBR_CodeLearner.Csharpbasics
{
    public class MultipleClasses
    {
        public string color = "red";
    }
    class program
    {
       static void main(string[] args)
        {
            MultipleClasses Mycar = new MultipleClasses();
            Console.WriteLine(Mycar.color);
        }
    }
}
