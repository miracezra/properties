using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExamples
{
    class Program
    {
        //property Examples 
        //Some fields in a class do not always need to be accessed from another class. Property is defined to provide controlled access to these created private fields.
        static void Main(string[] args)
        {
            Students student = new Students();
            student.Name = "Mirac";
            student.SurName = "Ergenc";
            student.Year = 24;
            Console.WriteLine(student.Name);
            Console.WriteLine(student.SurName);
            Console.WriteLine(student.Year);
            Console.ReadKey();
        }
    }
    public class Students
    {
        private string StName;
        private string StSurname;
        private int StYear;
        public string Name {
            get{return StName;}
            set{StName = value;}
        }
        public string SurName
        {
            get{return StSurname;}
            set{ StSurname = value;}
        }
        public int Year
        {
            get { return StYear; }
            set { StYear = value;
                if (StYear<=18)
                {Console.WriteLine("Are you Child :D");}
                else
                {Console.WriteLine("You are a old man bro");}
            } 
        }
    }
}
