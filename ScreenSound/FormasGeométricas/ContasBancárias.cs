using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.FormasGeométricas
{
    class ContaBancaria
    {
        protected double Balance { get; set; }

        public virtual void Deposit(double value)
        {
            Balance += value;
        }

        public virtual void Withdraw(double value)
        {
            Balance -= value;
        }

        public virtual double CalculateBalance()
        {
            return Balance;
        }
    }

    class ContaCorrente : ContaBancaria
    {
        private double MaintenanceFee { get; set; }

        public override void Withdraw(double value)
        {
            base.Withdraw(value + MaintenanceFee);
        }
    }

    class ContaPoupanca : ContaBancaria
    {
        private double RateIncome { get; set; }

        public override double CalculateBalance()
        {
            return base.CalculateBalance() * (1 + RateIncome);
        }
    }
}
