using Working_with_cards;

Menu menu = new Menu();
List<CreditCard> cards = new List<CreditCard>()
{
    new CreditCard("1111-2222-3333-4444", 1234),
    new CreditCard("3333-4444-5555-6666", 2569),
    new CreditCard("5555-6666-7777-8888", 3566)
};

while (true)
{
    Console.Clear();
    Console.WriteLine("Главное меню:");
    Console.WriteLine("1. Карта 1");
    Console.WriteLine("2. Карта 2");
    Console.WriteLine("3. Карта 3");
    Console.WriteLine("4. Выход");
    Console.Write("Выберите действие: ");

    string choice = Console.ReadLine();

    if (int.TryParse(choice, out int cardIndex) && cardIndex >= 1 && cardIndex <= cards.Count)
    {
        menu.CardMenu(cards[cardIndex - 1]);
    }
    else if (choice == "4")
    {
        Environment.Exit(0);
    }
}