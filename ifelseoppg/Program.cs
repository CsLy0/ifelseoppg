//oppgave 1

int number = 5;
int number2 = 5;
bool isEqual = false;

if (number == number2)
{
    isEqual = true;
    Console.WriteLine("Nummerene er like!");
}
else
{
    isEqual = false;
    Console.WriteLine("Nummerene er ulike!");
}

//oppgave 2
int oppgnumber = 5;
int oppgnumber2 = 5;
bool isEqual2 = false;
int oppgnumbsum = 13;

if (oppgnumber != oppgnumber2)
{
    isEqual2 = false;

    Console.WriteLine($"Ikke like tall,{isEqual2} sum er = {oppgnumbsum}");
}
else
{
    isEqual2 = true;
    int gangesum = oppgnumber * oppgnumber2;
    Console.WriteLine($"Nummerene er like, ganing av tallene gir = {gangesum}");
}

//oppgave 3


