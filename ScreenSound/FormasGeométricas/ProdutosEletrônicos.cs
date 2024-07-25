using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.FormasGeométricas
{
    class ProdutoEletronico
    {
        public string ?Model { get; set; }
        public double Price { get; set; }

        public virtual string ShowInformation()
        {
            return $"Model: {Model}, Price: {Price:C}";
        }
    }

    class Smartphone : ProdutoEletronico
    {
        public string ?OperationalSystem { get; set; }

        public override string ShowInformation()
        {
            return $"{base.ShowInformation()}, SO: {OperationalSystem}";
        }
    }

    class Tablet : ProdutoEletronico
    {
        public string ?TypeScreen { get; set; }

        public override string ShowInformation()
        {
            return $"{base.ShowInformation()}, Screen: {TypeScreen}";
        }
    }

    class Laptop : ProdutoEletronico
    {
        public string ?Processor { get; set; }

        public override string ShowInformation()
        {
            return $"{base.ShowInformation()}, Processor: {Processor}";
        }
    }
}
