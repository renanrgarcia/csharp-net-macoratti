using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9;
public static class ExtensionMethods
{
    public static int OddSum(this List<int> numbers)
    {
        return numbers.Where(i => i % 2 != 0).Sum();
    }
}
