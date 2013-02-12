using System.Collections.Generic;
using System.Linq;

namespace PortableClassLibrary1
{
    public class Class1
    {
        public static int Fib4()
        {
            var list = new List<int>();
            list.AddRange(new[] { 1, 1, 2, 3 });

            return list.Sum();
        }
    }
}
