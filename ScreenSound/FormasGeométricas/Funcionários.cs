using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.FormasGeométricas
{
    class Funcionario
    {
        public string ?Name { get; set; }
        public double Salary { get; set; }
    }

    class Gerente : Funcionario
    {
        public string ?Sector { get; set; }
    }

    class Programador : Funcionario
    {
        public string ? ProgrammingLanguage { get; set; }
    }

    class Analista : Funcionario
    {
        public string ? OccupationArea { get; set; }
    }
}
