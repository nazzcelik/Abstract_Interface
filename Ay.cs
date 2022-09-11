using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    internal abstract class Ay
    {
        // Interface kullansaydım gün saatini bütün aylar için toplam 12 kez yazmam gerekirdi. Ancak Abstract Class ile bir kere yazmam yeterli oldu.
        public int GunSaati()
        {
            return 24;
        }
        public abstract int KacinciAy();  // Her sınıfta değişiklik gösterebildiği için abstract olarak işaretledik.
        public abstract int KaçGun();

    }
}
