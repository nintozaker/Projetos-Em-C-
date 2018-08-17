using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace colarEXE_NovosparaosDriveres
{
    class Class1
    {

        //
        private static int Contador = 10;

        //static void Main(string[] args)
            public void TT()
        {
            //Console.Clear();
            Console.WriteLine('\n');
            Timer stateTimer = new Timer(new TimerCallback(Tick), null, 0, 1000);
            Console.ReadLine();
        }
        //
        public void Tick(Object obj)
        {
            if (Contador >= 0)
            {
                Console.SetCursorPosition(2,2);
                Console.WriteLine(String.Format("......   " + "{0:00}", Contador));
                Contador--;
            }

            
        }

        
    }
}
