using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodToLINQ
{
    public static class Extention
    {
        public static IEnumerable Top<T>(this IEnumerable<T> InputCollection, int Sample)
        {

            if ((InputCollection.Count() > 100) | (InputCollection.Count() < 1))
            {
                throw new ArgumentException("Передана некорректная информация");
            }
            float fraction = (float)InputCollection.Count() * Sample / 100;
            var number = (int)fraction;
            if (number != fraction)
            {
                number += 1;
            }
            IEnumerable outputCollection = (from a in InputCollection
                                            orderby a descending
                                            select a).Take(number).ToList();
            return outputCollection;
        }

        public static IEnumerable Top<T>(this IEnumerable<T> InputCollection, int Sample, Func<Person, int> Age)
        {
            float fraction = (float)InputCollection.Count() * Sample / 100;
            var number = (int)fraction;
            if (number != fraction)
            {
                number += 1;
            }
            List<int> primarySelection = new List<int>();
            Program program = new Program();
            foreach (var a in Program.person)
            {
                primarySelection.Add(Age(a));
            }
            IEnumerable outputCollection = (from a in primarySelection
                                            orderby a descending
                                            select a).Take(number).ToList();
            return outputCollection;

        }
    }
}

