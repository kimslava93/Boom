using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_test
{
    internal class MyString
    {

        public MyString(string s)
        {
            Value = s;
        }

        public string Value { get; set; }
        
        public bool Equals(string obj)
        {
            return Value == obj;
        }
    }
}
