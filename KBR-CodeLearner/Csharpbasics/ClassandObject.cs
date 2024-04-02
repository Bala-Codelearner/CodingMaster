using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBR_CodeLearner.Csharpbasics
{
    internal class ClassandObject
    {
        string color = "red";
        static void main(string[] arg)
        {
            ClassandObject mycar = new ClassandObject();
            Console.WriteLine(mycar.color);
        }

    }
}
