using System.Collections;
using System.Collections.Generic;

namespace DotNetTest
{
    public class ExampleCollection : IteratorAggregate
    {
        private readonly List<string> _collection = new List<string>();
        
        bool _direction = true;
        
        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public int Length => _collection.Count;
        
        public List<string> GetItems()
        {
            return _collection;
        }
        
        public void AddItem(string item)
        {
            this._collection.Add(item);
        }

        public string this[int index]
        {
            get => _collection[index];
            set => _collection[index] = value;
        }
        
        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}