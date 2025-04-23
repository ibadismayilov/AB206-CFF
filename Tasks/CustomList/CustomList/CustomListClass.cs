using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomListClass<T>
    {
        static T[] customList;
        public CustomListClass()
        {
            customList = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref customList, customList.Length + 1);
            customList[^1] = item;
        }

        public T[] GetAllItem()
        {
            return customList;
        }

        public T Remove(T item)
        {
            int index = Array.IndexOf(customList, item);

            if (index < 0)
            {
                return default(T);
            }

            T[] removeList = new T[customList.Length - 1];

            for (int i = 0; i < customList.Length - 1; i++)
            {
                if (i < index)
                {
                    removeList[i] = customList[i];
                }
                else
                {
                    removeList[i] = customList[i + 1];
                }
            }

            customList = removeList;

            return item;
        }

        public static T FindMethod(Predicate<T> pre)
        {
            foreach (var item in customList)
            {
                if (pre(item))
                {
                    return item;
                }
            }

            return default(T);
        }
    }
}


