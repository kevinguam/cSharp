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
    class Node
    {
        private string data;
        private Node next;

        public Node()
        {
            data = null;
            next = null;
        }
        public Node(string s)
        {
            data = s;
            next = null;
        }
        public Node(Node n, string s)
        {
            data = s;
            next = n;
        }
        public void setNextNode(Node n)
        {
            next = n;
        }
        public Node getNextNode()
        {
            return next;
        }
        public void setData(string s)
        {
            data = s;
        }
        public string getData()
        {
            return data;
        }
    }
}
