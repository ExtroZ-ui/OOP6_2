using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6_2
{
        class String
    {
        private string Line;

        public String()
        {
            Line = "Пусто";
        }

        public String(string Line)
        {
            if (Line.Length > 10)
                this.Line = "Слишком длинная строка";
            else
                this.Line = Line;
        }

        public void Display()
        {
            Console.WriteLine(Line);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            String st = new String();
            st.Display();
            String st1 = new String("12345678910");
            st1.Display();
            String st2 = new String("123");
            st2.Display();

            Console.ReadKey();
        }
    }
    
}
