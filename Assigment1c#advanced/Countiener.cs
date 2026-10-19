using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment1c_advanced
{
    internal class Countiener<T>
    {
        #region answer 2 
        private T item;
        public void Add(T value)
        {
           item=value;
        }public T get()
        {
            return item;
        }
        #endregion
    }
}
