#region INDOVINA IL NUMERO
using IndovinaIlNumeroConsole;

Logica logica = new();
bool firstTry = true;
int number;
EnumEsito esito = EnumEsito.NULL;

Console.WriteLine("Ora penserò ad un numero, vuoi provare ad indovinarlo?\n");

while (esito != EnumEsito.Uguale && logica.Tentativi < 10)
{
    if (firstTry)
    {
        Console.Write("Fai un tentativo: ");
        firstTry = false;
    }
    else
    {
        Console.Write("Prova di nuovo: ");
    }

    if (Int32.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine();

        esito = logica.ControllaNumero(number);

        Console.WriteLine(logica.Esito(esito));
        
    }
    else
    {
        Console.WriteLine("\nInserisci un numero valido\n");
        continue;
    }
    Console.WriteLine();
}

if (logica.Tentativi >= 12)
{
    Console.WriteLine("Hai raggiunto il limite dei tentativi, sei scarso/a :)");
}


#endregion