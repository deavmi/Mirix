//Heap-related routines and types
namespace Mirix.Interpreter.Data.Heap
{

    using System.Collections.Generic;

    //Heap structure
    public sealed class Heap
    {
        //Heap items
        private List<HeapItem> heapItems = new List<HeapItem>();

        public Heap()
        {

        }

        //Clears all data from the Heap
        public void clear()
        {
            heapItems.Clear();
        }

        //Add an item to the heap
        public void addItem(HeapItem item)
        {
            heapItems.Add(item);
        }
    }

    //Represents an item on the heap
    public class HeapItem
    {

    }
}