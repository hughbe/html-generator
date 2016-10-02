using System.Collections;
using System.Collections.Generic;

namespace HtmlGenerator
{
    internal class HtmlObjectLinkedList<T> : IEnumerable<T> where T : HtmlObject
    {
        public T _first;
        public T _last;

        public int _count;

        public void AddFirst(T first)
        {
            AddBefore(node: _first, value: first);
            _first = first;
            if (_last == null)
            {
                _last = _first;
            }
        }

        public void AddBefore(T node, T value)
        {
            if (node != null)
            {
                node._previous = value;
                value._next = node;
            }
            _count++;
        }

        public void AddLast(T last)
        {
            AddAfter(node: _last, value: last);
            _last = last;
            if (_first == null)
            {
                _first = _last;
            }
        }

        public void AddAfter(T node, T value)
        {
            if (node != null)
            {
                value._previous = node;
                node._next = value;
            }
            _count++;
        }

        public void Remove(T node)
        {
            HtmlObject previous = node._previous;
            HtmlObject next = node._next;
            if (node == _first)
            {
                _first = (T)next;
            }
            if (node == _last)
            {
                _last = (T)previous;
            }
            if (previous != null)
            {
                previous._next = next;
            }
            if (next != null)
            {
                next._previous = previous;
            }
            node._previous = null;
            node._next = null;
            _count--;
        }

        public void Clear()
        {
            HtmlObject current = _first;
            while (current != null)
            {
                HtmlObject next = current._next;
                current._previous = null;
                current._next = null;

                current = next;
            }
            _count = 0;
            _first = null;
            _last = null;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            T current = _first;
            while (current != null)
            {
                yield return current;
                current = (T)current._next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();
    }
}
