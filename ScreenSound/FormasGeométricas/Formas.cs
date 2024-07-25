using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.FormasGeométricas
{
    abstract class Formas
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }

    class Quadrado : Formas
    {
        public double side { get; set; }

        public override double CalcularArea()
        {
            return side * side;
        }

        public override double CalcularPerimetro()
        {
            return 4 * side;
        }
    }

    class Circulo : Formas
    {
        public double radius { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * radius * radius;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * radius;
        }
    }

    class Triangulo : Formas
    {
        public double Base { get; set; }
        public double height { get; set; }

        public override double CalcularArea()
        {
            return 0.5 * Base * height;
        }

        public override double CalcularPerimetro()
        {
            // Considerando um triângulo genérico
            return Base + height + Math.Sqrt(Base * Base + height * height);
        }
    }
}
