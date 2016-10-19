using System.Collections;
using System.Collections.Generic;

namespace HtmlGenerator
{
    internal class HtmlObjectLinkedList<T> where T : HtmlObject
    {
        public T _first;
        public T _last;

        public int _count;
        
        public void AddBefore(T node, T value)
        {
            if (node != null)
            {
                value._next = node;
                if (node._previous != null)
                {
                    node._previous._next = value;
                    value._previous = node._previous;
                }
                node._previous = value;
            }
            if (node == _first)
            {
                _first = value;
                if (_last == null)
                {
                    _last = _first;
                }
            }
            _count++;
        }

        public void AddAfter(T node, T value)
        {
            if (node != null)
            {
                value._previous = node;
                if (node._next != null)
                {
                    node._next._previous = value;
                    value._next = node._next;
                }
                node._next = value;
            }
            if (node == _last)
            {
                _last = value;
                if (_first == null)
                {
                    _first = _last;
                }
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
    }
}
