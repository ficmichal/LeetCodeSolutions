using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions
{
    public class MyCircularQueue
    {

        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k)
        {
            _size = k;
            _head = 0;
            _tail = -1;
            _queue = new List<int?>(Enumerable.Repeat<int?>(null, _size)) {Capacity = _size};   
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }

            _tail = _tail == _queue.Capacity - 1 ? 0 : _tail + 1;
            _queue[_tail] = value;

            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }

            _queue[_head] = null;
            _head = _head == _queue.Capacity - 1 ? 0 : _head + 1;

            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            return _queue[_head] ?? -1;
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            return _queue[_tail] ?? -1;
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            return !_queue.Any(x => x.HasValue);
        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            return _queue.Count(x => x.HasValue) == _size;
        }

        private readonly List<int?> _queue;
        private int _head;
        private int _tail;
        private readonly int _size;
    }

    /**
     * Your MyCircularQueue object will be instantiated and called as such:
     * MyCircularQueue obj = new MyCircularQueue(k);
     * bool param_1 = obj.EnQueue(value);
     * bool param_2 = obj.DeQueue();
     * int param_3 = obj.Front();
     * int param_4 = obj.Rear();
     * bool param_5 = obj.IsEmpty();
     * bool param_6 = obj.IsFull();
     */
}
