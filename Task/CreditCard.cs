using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_cards
{
    public class CreditCard
    {

        public string CardNumber { get; set; }
        public decimal CurrentAmount { get; set; }

        public CreditCard(string cardNumber, decimal initialAmount)
        {
            CardNumber = cardNumber;
            CurrentAmount = initialAmount;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                CurrentAmount += amount;
                Console.WriteLine($"Внесено {amount} на карту. Новый баланс: {CurrentAmount}");
            }
            else
            {
                Console.WriteLine("Некорректная сумма для пополнения.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= CurrentAmount)
            {
                CurrentAmount -= amount;
                Console.WriteLine($"Снято {amount} с карты. Новый баланс: {CurrentAmount}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Некорректная сумма для снятия.");
            }
            else
            {
                Console.WriteLine("Недостаточно средств на карте.");
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Баланс карты {CardNumber}: {CurrentAmount}");
        }
    }
}
