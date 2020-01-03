using System;
using System.Threading;
//using System.Windows.Forms;

namespace KleinenSpiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Raumschiff rs = new Raumschiff(20, 20);
            Console.Write(rs.SForm[0]);
            Console.CursorTop++;
            Console.CursorLeft -= 5;
            Console.Write(rs.SForm[1]);

            int i = 0;
            #region test
            do
            {
                rs.RBewegung(rs);
                
            } while (i == 0);
            Console.WriteLine("Schreib was: ");
            
            #endregion

            //string Antwort = Console.ReadLine();
            

            //int i = 0;
            //int neuePos = 5;
            //do
            //{
            //    neuePos += 2;
            //    rs.UpdateObjekt(neuePos, rs.Y, rs);
            //    Thread.Sleep(2000);
            //} while (i == 0);

            Console.ReadLine();
        }
    }
}
