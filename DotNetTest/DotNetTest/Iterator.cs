using System.Collections;

namespace DotNetTest
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();
        public abstract int Key();
        public abstract object Current();
        public abstract bool MoveNext();
        public abstract void Reset();
    }

    public abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
    
    class AlphabeticalOrderIterator : Iterator
    {
        private ExampleCollection _collection;

        private int _position = -1;
        
        private bool _reverse = false;

        public AlphabeticalOrderIterator(ExampleCollection collection, bool reverse = false)
        {
            this._collection = collection;
            this._reverse = reverse;

            if (reverse)
            {
                this._position = collection.GetItems().Count;
            }
        }
        
        public override object Current()
        {
            return this._collection.GetItems()[_position];
        }

        public override int Key()
        {
            return this._position;
        }
        
        public override bool MoveNext()
        {
            var updatedPosition = this._position + (this._reverse ? -1 : 1);
            if (updatedPosition >= 0 && updatedPosition < this._collection.GetItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public override void Reset()
        {
            this._position = this._reverse ? this._collection.GetItems().Count - 1 : 0;
        }
    }
}