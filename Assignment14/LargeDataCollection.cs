using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    public class LargeDataCollection : IDisposable
    {
        private List<object> data;

        public LargeDataCollection(IEnumerable<object> initialdata)
        {
            data = new List<object>(initialdata);
        }
        public void AddElement(object element)
        {
            data.Add(element);
        }
        public void RemoveElement(object element)
        {
            data.Remove(element);
        }
        public object GetElement(int index)
        {
            if (index >= 0 && index < data.Count)
            {
                return data[index];
            }
            else
            {
                throw new IndexOutOfRangeException("index out of ranges");
            }
        }
        public void Dispose()
        {
            data.Clear();
            data = null;
        }
    }
}
