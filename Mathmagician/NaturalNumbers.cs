﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
   public class NaturalNumbers
    {
        protected int first;
        protected int increment;

        public NaturalNumbers()
        {
            first = 1;
            increment = 1;
        }
        
        public virtual int GetNext(int x)
        {
            return x + increment;
        }

        public int GetFirst()
        {
            return first;
        }

        public int[] GetSequence()
        {
            //  int[] output = new int[10];
            List<int> output = new List<int>();
            output.Add(GetFirst());
            while(output.Count < 10)
            {
                output.Add(GetNext(output.Last()));
            }

            return output.ToArray();
        }
        public int[] GetSequence(int length)
        {
            //int[] output = new int[length];
            
            List<int> output = new List<int>();
            output.Add(GetFirst());
     

            while(output.Count < length)
            {
                output.Add(GetNext(output.Last()));

            }

            return output.ToArray();
        }

        public string ToString(int[] array)
        {
            string output = String.Join(" ", array);
            
            return output;

        }
    }
}
