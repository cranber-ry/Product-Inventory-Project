namespace Working_with_cards
{
    public class Menu
    {
        List<CreditCard> cards = new List<CreditCard>();

        public void CardMenu(CreditCard card)
        {
            while (true)
            {
                Console.WriteLine($"Меню карты {card.CardNumber}:");
                Console.WriteLine("1. Посмотреть баланс");
                Console.WriteLine("2. Положить деньги");
                Console.WriteLine("3. Снять деньги");
                Console.WriteLine("4. Назад");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        card.ShowBalance();
                        break;
                    case "2":
                        Console.Write("Введите сумму для пополнения: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                        {
                            card.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Некорректная сумма.");
                        }
                        break;
                    case "3":
                        Console.Write("Введите сумму для снятия: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawalAmount))
                        {
                            card.Withdraw(withdrawalAmount);
                        }
                        else
                        {
                            Console.WriteLine("Некорректная сумма.");
                        }
                        break;
                    case "4":
                        return;
                }
            }
        }
    }
}
