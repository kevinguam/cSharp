using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 
 * April 1, 2013
 * 
 * Without using any of the .NET Collection or Linq libraries (i.e. without using List<string>), 
 * implement a ListOfStrings object that contains a set of strings. 
 * This object has the following methods:

 * AddAt(int) - inserts a string at a given index
 * RemoveAt(int) - given an index, removes the string item at that index
 * GetItemAt(int) - given an index, retrieves the string item at that index
 * Length - Number of items in the list
 * 
*/

namespace ListOfStrings
{
    class ListOfStrings
    {
        private Node headNode;

        public bool AddAt(string newEntry, int position)
        {
            Node tmp = headNode;
            if (position >= 0)
            {
                Node newNode = new Node(newEntry);
                Node tmp2 = new Node();
                if (isEmpty() || position == 0)                         // adding Node at the begining of the List
                {
                    newNode.setNextNode(tmp);
                    headNode = newNode;
                    return true;
                }
                else if (position == Length())                          // adding Node at the end of the List 
                {
                    for (int i = 0; i < (position - 1); i++)
                    {
                        tmp = tmp.getNextNode();
                    }
                    tmp.setNextNode(newNode);
                    return true;
                }
                else                                                    // inserting node between first and last node
                {
                    for (int i = -1; i < (position - 1) & tmp != null; i++)
                    {
                        if (i == (position - 2))
                        {
                            tmp2 = tmp;
                        }
                        tmp = tmp.getNextNode();

                    }
                    if (tmp == null)                                    // or if (position > Length())
                    {
                        return false;
                    }
                    newNode.setNextNode(tmp);
                    tmp2.setNextNode(newNode);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public bool AddAt(string newEntry)
        {
            return AddAt(newEntry, Length() + 1);
        }

        public bool isEmpty()
        {
            return (headNode == null);
        }

        public string RemoveAt(int position)
        {
            string tmpObject = null;
            if (isEmpty() || position < 0)
            {
                return null;
            }

            Node currentNode = headNode;

            if (position == 0)
            {
                tmpObject = currentNode.getData();
                headNode = currentNode.getNextNode();
            }
            else
            {
                for (int i = -1; i < position - 2 && currentNode != null; i++)
                {
                    currentNode = currentNode.getNextNode();
                }
                if (currentNode == null)                                       // or  if (position > Length())
                {
                    return null;
                }
                tmpObject = currentNode.getNextNode().getData();
                currentNode.setNextNode(currentNode.getNextNode().getNextNode());
            }
            return tmpObject;
        }

        public string GetItemAt(int position)
        {
            if (isEmpty() || position < 0)
            {
                return null;
            }

            Node currentNode = headNode;
            string temObject = currentNode.getData();
            for (int i = -1; i < position - 1 && currentNode != null; i++)
            {
                currentNode = currentNode.getNextNode();
            }
            if (currentNode == null)
            {
                return null;
            }
            return currentNode.getData();

        }

        public int Length()
        {
            Node currentNode = headNode;
            int count = 0;
            while (currentNode != null)
            {
                count++;
                currentNode = currentNode.getNextNode();
            }
            return count;
        }

    }
}
