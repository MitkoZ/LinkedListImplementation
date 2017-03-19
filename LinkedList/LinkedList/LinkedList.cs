using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        private class ListItem
        {
            public int Data { get; set; }
            public ListItem Next { get; set; }
        }

        private ListItem first = null;

        public void Add(int item)
        {
            ListItem li = new ListItem();
            li.Data = item;
            li.Next = null;

            if (first == null)
            {
                first = li;
                return;
            }

            ListItem iterator = first;
            while (iterator.Next != null)
            {
                iterator = iterator.Next;
            }

            iterator.Next = li;
        }

        public void RemoveAt(int index)
        {
            if (Count() - 1 < index)
            {
                throw new IndexOutOfRangeException();
            }
            ListItem iterator = first;
                if (index == 0)//In the beginning
                {
                    if (iterator.Next==null)// the next element is null
                    {
                        first = null;
                    }
                    else // the next element isn't null
                    {
                        first = first.Next;
                    }
                 }
                else //somewhere different from the beginning
                {
                    if (Count()-1==index)// it's in the end
                    {

                        for (int i = 0; i < index-1; i++)
                        {
                            iterator = iterator.Next;
                        }
                    iterator.Next = null;
                    }
                    else //it's somewhere in the middle
                    {
                        for (int i = 0; i < index-1; i++)
                        {
                            iterator = iterator.Next;
                        }
                    iterator.Next= iterator.Next.Next;
                    }
                }
        }

        public int Count()
        {
            int counter = 0;
            ListItem iterator = first;
            while (iterator!=null)
            {
                counter++;
                iterator = iterator.Next;
            }
            return counter;
        }

        public int GetItemAt(int index)
        {
            if (first == null)
            {
                throw new IndexOutOfRangeException();
            }

            int counter = index;

            ListItem iterator = first;
            while (counter > 0)
            {
                counter--;
                iterator = iterator.Next;

                if (iterator == null)
                {
                    throw new IndexOutOfRangeException();
                }  
            }

            return iterator.Data;
        }
    }
}
