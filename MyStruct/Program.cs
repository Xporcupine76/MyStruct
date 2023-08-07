using System;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Channels;
namespace MyStruct
{

    class Peogram
    {
        static void Main(string[] args)
        {

            // Mark mark = new Mark();
            //mark.DoThis();
            Mark m2;
            m2.x = 6;
            m2.y = 7;
            m2.DoThis();

        }
    }
    public struct Mark
    {

        public int x = 6;
        public int y = 7;
        
        public Mark(/*int a, int y*/)
        {
          // x = a;
          // y = b;  
        }
        
        public void DoThis()
        {

            Console.WriteLine(x + y);

        }

    }
}