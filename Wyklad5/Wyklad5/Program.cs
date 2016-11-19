using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyklad5
{
    enum DniTygodnia { Poniedziałek=1, Wtorek, Środa, Czwartek, Piątek, Sobota, Niedziela };

    enum Miesiące : byte { Sty, Lut, Mar, Kwi, Maj, Cze, Lip, Sie, Wrz, Paź, Lis, Gru };
    
    class Program
    {
        static void Main(string[] args)
        {
            DniTygodnia urodziny = DniTygodnia.Poniedziałek; //zmienna urodziny będzie przyjmować wartość Poniedziałek
            int numerDnia = (int)DniTygodnia.Czwartek; //zmienna numerDnia będzie miała wartość 4
        }
    }
}
