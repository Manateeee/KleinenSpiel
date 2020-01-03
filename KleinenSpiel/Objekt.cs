using System;
using System.Collections.Generic;
using System.Text;

namespace KleinenSpiel
{
    class Objekt
    {
        public string[] SForm;
        private int sFormHöhe;
        private int x;
        private int y;
        
        public int SFormHöhe
        {
            get { return sFormHöhe; }
            set { sFormHöhe = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public void SetCursor()
        {
            Console.SetCursorPosition(X, Y);
        }

        public void UpdateObjekt(int x, int y, Objekt obj)
        {
            
            Console.SetCursorPosition(X + obj.SForm[0].Length, Y);
            for (int i = 0; i < 2; i++)
            {
                for (int i1 = 0; i1 < obj.SForm[0].Length; i1++)
                {
                    Console.CursorLeft--;
                    Console.Write(' ');
                    Console.CursorLeft--;
                }
                Console.CursorLeft += obj.SForm[0].Length;
                Console.CursorTop++;
            }

            Console.SetCursorPosition(x, y);
            Console.Write(obj.SForm[0]);
            Console.CursorTop++;
            Console.CursorLeft -= 5;
            Console.Write(obj.SForm[1]);
            X = x;
            Y = y;
        }

        public Objekt()
        {
            SetCursor();
        }
        
        
    }
}
