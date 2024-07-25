using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.FormasGeométricas
{
    class Animal
    {
        public virtual string Sound()
        {
            return "AU";
        }
    }

    class Mamifero : Animal
    {
        public override string Sound()
        {
            return "AU";
        }
    }

    class Ave : Animal
    {
        public override string Sound()
        {
            return "AU";
        }
    }

    class Peixe : Animal
    {
        public override string Sound()
        {
            return "AU";
        }
    }
}
