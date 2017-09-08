using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Class1
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public int GetAge(int age)
        {
            return age * 2;
        }
        public int TestCheck()
        {
            return 10;
        }
    }
}
