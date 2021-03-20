using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_s_new_in_cSharp_9
{
    public class MyClass
    {
        public string MyValue { get; set; }
    }

    public class MyClassWithConstructor
    {
        private readonly string _myValue;

        public MyClassWithConstructor(string myValue)
        {
            _myValue = myValue;
        }
    }
}
