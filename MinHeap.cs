using System;
using System.Collections.Generic;

// Do not edit the class below except for the buildHeap,
// siftDown, siftUp, Peek, Remove, and Insert methods.
// Feel free to add new properties and methods to the class.
public class Program
{
    static void Main()
    {
        List<int> heap = new List<int>();

        heap.Add(48);
        heap.Add(12);
        heap.Add(24);
        heap.Add(7);
        heap.Add(8);
        heap.Add(-5);
        heap.Add(24);
        heap.Add(391);
        heap.Add(24);
        heap.Add(56);
        heap.Add(2);
        heap.Add(6);
        heap.Add(8);
        heap.Add(41);

        MinHeap mn = new MinHeap(heap);
        mn.Remove();

    }
    public class MinHeap
    {


        public List<int> heap = new List<int>();

        public MinHeap(List<int> array)
        {
            heap = buildHeap(array);
        }

        public List<int> buildHeap(List<int> array)
        {
            // Write your code here.

            int FirstElement = (array.Count - 2) / 2;
            for (int idx = FirstElement; idx >= 0; idx--)
            {
                siftDown(idx, array.Count - 1, array);
            }
            return new List<int>();
        }

        public void siftDown(int currentIdx, int endIdx, List<int> heap)
        {
            // Write your code here.
            int ChildOne = 2 * currentIdx + 1 <= endIdx ? 2 * currentIdx + 1 : -1;

            int swapId;

            while (ChildOne <= endIdx)
            {
                int ChildTwo = 2 * currentIdx + 2 <= endIdx ? 2 * currentIdx + 1 : -1;
                if (ChildTwo != -1 && heap[ChildTwo] < heap[ChildOne])
                {
                    swapId = ChildTwo;
                }
                else
                {
                    swapId = ChildOne;
                }

                if (heap[currentIdx] > heap[swapId])
                {
                    swap(currentIdx, swapId, heap);
                    currentIdx = swapId;
                    ChildOne = 2 * currentIdx + 1;
                }
                else
                {
                    return;
                }
            }
        }

        public void swap(int currIdx, int swapId, List<int> heap)
        {
            int temp = heap[currIdx];
            heap[currIdx] = heap[swapId];
            heap[swapId] = temp;
        }

        public void siftUp(int currentIdx, List<int> heap)
        {
            // Write your code here.
            int ParentIdx = (currentIdx - 1) / 2;
            while (currentIdx > 0)
            {
                if (heap[currentIdx] < heap[ParentIdx])
                {
                    swap(currentIdx, ParentIdx, heap);
                }
                currentIdx = ParentIdx;
                ParentIdx = (currentIdx - 1) / 2;
            }
        }

        public int Peek()
        {
            // Write your code here.
            return heap[0];
        }

        public int Remove()
        {
            // Write your code here.

            swap(0, heap.Count - 1, heap);
            int valtoRemove = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            siftDown(0, heap.Count - 1, heap);

            return -1;
        }

        public void Insert(int value)
        {
            // Write your code here.
            heap.Add(value);
            siftUp(heap.Count - 1, heap);
        }
    }
}
