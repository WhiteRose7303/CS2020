using System;
namespace NodeInt
{
    public class Nodeint
    {
        private int value;
        private Nodeint next;
        public Nodeint(int v)
        {
            this.value = v;
            this.next = null;
        }
        public Nodeint(int v, Nodeint next)
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
        public void SetNext(Nodeint next)
        {
            this.next = next;
        }
        public Nodeint GetNext()
        {
            return this.next;
        }
        public bool HasNext()
        {
            return this.next != null;  
        }



    }
}
