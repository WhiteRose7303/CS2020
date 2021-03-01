using System;

namespace StackInt
{
    public class Stackint
    {
        private NodeInt head;
        public Stackint()
        {
            this.head = null;
        }
        public bool IsEmpty()
        {
            return this.head == null;
        }
        public void Push(int v)
        {
            NodeInt ni = new NodeInt(v, this.head);
            this.head = ni;
        }
        public int Top()
        {
            return this.head.GetValue();
        }
        public int Pop()
        {
            int t = this.head.GetValue();
            this.head = this.head.GetNext();
            return t;
        }
        public override string ToString()
        {
            string ray = "";
            NodeInt temp = this.head;
            while(temp != null)
            {
                ray += temp.ToString() + " ";
                temp = temp.GetNext();
            }
            return ray;
        }

    }
    public class NodeInt
    {
        private int value;
        private NodeInt next;
        public NodeInt(int v)
        {
            this.value = v;
            this.next = null;
        }
        public NodeInt(int v, NodeInt next)
        {
            this.value = v;
            this.next = next;
        }
        public override string ToString()
        {
            return (this.value.ToString());
        }
        public void SetValue(int v)
        {
            this.value = v;
        }
        public int GetValue()
        {
            return this.value;
        }
        public void SetNext(NodeInt next)
        {
            this.next = next;
        }
        public NodeInt GetNext()
        {
            return this.next;
        }
        public bool HasNext()
        {
            return this.next != null;
        }
    }
}
