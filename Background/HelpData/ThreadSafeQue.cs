using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatUI.Background.HelpData
{
    class ThreadSafeQue<T>
    {
        //This is the thread lock
        private object _lock = new object();

        //Basic list for data
        private List<T> _data = new List<T>();
        public void Add(T data)
        {
            lock (_lock)
            {
                _data.Add(data);
            }
        }

        //Takes all the workd from the list
        public T[] TakeWork()
        {
            T[] result;
            lock (_lock)
            {
                result = _data.ToArray();
                _data.Clear();
            }
            return result;
        }

        //Takes last object
        public T TakeLastWork()
        {
            T result;
            lock (_lock)
            {
                result = _data.Last();
                _data.Clear();
            }
            return result;
        }

    }
}
