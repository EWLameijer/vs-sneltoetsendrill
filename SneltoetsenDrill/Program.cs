// See https://aka.ms/new-console-template for more information

using BugShop.Business;
using BugShop.Domain;
using BugShop.Domain.Interfaces;

IBugService bugService = new BugService();
List<Bug> allBugs = bugService.Get().ToList();

do
{
    DisplayBugs();
    char ch = AskChoice();
    GiveBug(ch);
} while (true);

void DisplayBugs()
{
    foreach (Bug bug in allBugs) Console.WriteLine($"{bug.Id}. {bug.Name}");
}

char AskChoice() => Console.ReadKey(true).KeyChar;

void GiveBug(char ch)
{
    int index = ch - '0';
    Bug bug = new();
    try
    {
        bug = bugService.Get(index);
    }
    catch
    {
        Console.WriteLine($"'{ch}' is an invalid choice");
        return;
    }
    Console.Write(bug.Name + ": ");
    bug.Abilities.ToList().ForEach(x => Console.Write(x + " "));
    Console.WriteLine();
    Console.WriteLine("Press any key...");
    AskChoice();
    Console.Clear();
}
