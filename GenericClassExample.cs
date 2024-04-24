using System.ComponentModel;
using System.Linq;

namespace GenericClassExample
{
    public class GenericClassExample<T> where T : struct
    {
        private ICollection<T> _collection;

        public void Add(T item)
        {
            _collection.Add(item);
        }

        public T Get(int number) 
        {
            if (number < _collection.Count)
            {
                return _collection.ElementAt(number);
            }
            return default(T);
        }

        public ICollection<T> GetOrderedCollection() {
            return (ICollection<T>)_collection.OrderByDescending(r => r.GetHashCode());
        }
    }
}
