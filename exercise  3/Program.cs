using System;

namespace Double_Linked_List_exercise 
{
    //Each node consists of the information part and a lik to the next node
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
        public Node prev;
    }
    class DoubleLinkedList
    {
        Node start;
        public DoubleLinkedList()
        {
            start = null;
        }
        //adds a node in the list