using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace KleinenSpiel
{
    class Raumschiff : Objekt
    {
        public void RBewegung(Raumschiff raumschiff)
        {
            ConsoleKeyInfo kInfo;
            int Bewegungsreichweite = 5;
            int BewegungsreichweiteObenUnten = 2;
            //macht nur Ctrl+C ungültig
            Console.TreatControlCAsInput = true;

            kInfo = Console.ReadKey(true);
          
            
            //Console.Write(kInfo.Key.ToString());
            if(kInfo.Key == ConsoleKey.A)
            {
                if(raumschiff.X >=6)
                    raumschiff.UpdateObjekt(raumschiff.X - Bewegungsreichweite, raumschiff.Y, raumschiff);
            }
            else if(kInfo.Key == ConsoleKey.S)
            {
                
                raumschiff.UpdateObjekt(raumschiff.X, raumschiff.Y + BewegungsreichweiteObenUnten, raumschiff);
            }
            else if(kInfo.Key == ConsoleKey.D)
            {
                raumschiff.UpdateObjekt(raumschiff.X + Bewegungsreichweite, raumschiff.Y, raumschiff);
            }
            else if(kInfo.Key == ConsoleKey.W)
            {
                if(raumschiff.Y >= 5)
                    raumschiff.UpdateObjekt(raumschiff.X, raumschiff.Y - BewegungsreichweiteObenUnten, raumschiff);
            }
            else
            {

            }
            
            
        }

        public Raumschiff(int x, int y)
        {
            SForm = new string[2];
            X = x;
            Y = y;
            SetCursor();
            SForm[0] = "\\(--)/";
            SForm[1] = ":00:";
        }
    }
}
