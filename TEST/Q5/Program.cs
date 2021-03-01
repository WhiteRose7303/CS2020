using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class studentDetail
    {
        private string name;
        private bool HadFirst;
        private int classID;
    }
    class studentVaccine
    {
        //Atrabuties
        private studentDetail[] students = new studentDetail[1500];
        //First Function
        private studentDetail[] RetClass(int classID)
        {
            int counter = 0;
            for (int i = 0; i < this.students.Length; i++)
            {
                if (this.students[i].GetclassID() == classID)
                {
                    counter++;
                }
            }
            studentDetail[] newstudents = new studentDetail[counter];
            int countert = 0;
            for (int i = 0; i< this.students.Length;i++)
            {
                if (this.students[i].GetclassID() == classID)
                {
                    newstudents[countert] = this.students[i];
                    countert++;
                }
            }
        }
        //Seconed function
        private void PrintSeconedVac(int classID)
        {
            for (int i = 0; i>this.students.Length;i++)
            {
                if((this.students[i].GetclassID() == classID)&&(this.students[i].GetHasFirst() == true))
                    Console.WriteLine(this.students[i].GetName);
            }
        }
        private int retrecored()
        {
            int id = 0;
            int counter = 1;
            int temp = 0;
            for (int i =1; i< this.students.Length; i++)
            {
                if (this.students[i].GetclassID() == this.students[i - 1].GetclassID())
                    counter++; id = this.students[i].GetclassID();
                else
                    temp++; id = this.students[i].GetclassID();
                if (temp > counter)
                {
                    counter = temp;
                    temp = 0;
                }
            }
            return id;
        }
    }
}
