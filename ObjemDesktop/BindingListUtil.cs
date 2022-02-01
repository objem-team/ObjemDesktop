using System;
using System.ComponentModel;
using System.Linq;

namespace ObjemDesktop
{
    public class BindingListUtil
    {
        public static int FindIndex<T>(BindingList<T> list,Func<T,bool> func)
        {
            var index = list.Select((item, i) => new {Item = item, Index = i})
                .Where(item => func(item.Item))
                .Select(item => item.Index)
                .ToArray();
            if (index.Length < 1)
            {
                return -1;
            }
            return index[0];
        }

        public static void AddOrReplace<T>(BindingList<T> list, T target) where T:IEquatable<T>
        {
            var index = FindIndex(list, (item) => item.Equals(target));
            if (index >= 0)
            {
                list[index] = target;
                return;
            }
            list.Add(target);
        }
    }
}