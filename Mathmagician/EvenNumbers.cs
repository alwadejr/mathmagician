using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class EvenNumbers : NaturalNumbers
    {


        public EvenNumbers()
        {
            first = 2;
        }

        public override int GetNext(int x)
        {
            return base.GetNext(x) + 1;
        }

        new public int[] GetSequence()
        {
            //  int[] output = new int[10];
            List<int> output = new List<int>();
            output.Add(GetFirst());
            while (output.Count < 10)
            {
                output.Add(GetNext(output.Last()));
            }

            return output.ToArray();
        }
    }
}
