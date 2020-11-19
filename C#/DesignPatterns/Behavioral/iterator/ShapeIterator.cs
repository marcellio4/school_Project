using System.Collections;
using System.Collections.Generic;

namespace iterator
{
    public class ShapeIterator<TShape> : IEnumerator<TShape>
    {
        private TShape _shape;
        public ShapeIterator(TShape thing)
        {
            _shape = thing;
        }

        public bool MoveNext()
        {
           return Current.Equals(_shape);
        }

        public void Reset()
        {
            //Current;
        }

        public TShape Current { get; }

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }
    }
}