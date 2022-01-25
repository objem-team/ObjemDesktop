using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ObjemDesktop
{
    public class ListUtil
    {
        public static IEnumerable<T> AddOrReplace<T>(List<T> array, T value) where T : IEquatable<T>
        {
            var index = array.FindIndex(s => s.Equals(value));
            if (index == -1)
            {
                array.Add(value);
            }
            else
            {
                array[index] = value;
            }
            
            return array;
        }
    }
}