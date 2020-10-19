using System;

namespace ClassLibrary2
{
    public class Radical
    {
        private string a;

        public Radical(string a)
        {
            this.a = a;
        }
        public string getRad()
        {
            return "" + (Math.Sqrt(Int32.Parse(a)));
        }
    }
}
