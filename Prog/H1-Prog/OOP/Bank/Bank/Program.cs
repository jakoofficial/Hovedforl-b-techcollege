using Bank;

BankAccount ba = new BankAccount(100);
bool run = true;

do
{
    Console.Clear();
    //Console.ForegroundColor = ConsoleColor.White;
    UI.GetMenu();

    switch (UI.Input())
    {
        case 1: ba.PrintBalance(); break;
        case 2: ba.Deposit(UI.Input("How much would you like to deposit? \n> ")); break;
        case 3: ba.Withdraw(UI.Input("How much would you like to withdraw? \n> ")); break;
        case 4: UI.End(); run = false; break;
        default: break;
    }

} while (run);

Console.ReadKey();

