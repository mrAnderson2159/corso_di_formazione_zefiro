#region SOMMA DI DUE NUMERI INTERI
using AlgoritmiConsole;

Console.WriteLine("Questo programma somma due numeri.\n");

int numero1 = ReadUtils.ReadIntWithConvert("Inserisci il primo numero: ");
int numero2 = ReadUtils.ReadIntWithConvert("Inserisci il secondo numero: ");

int somma = numero1 + numero2;

Console.WriteLine($"La somma è {somma}");
#endregion

Console.WriteLine();

#region PARI O DISPARI?
Console.WriteLine("Questo programma verifica se un numero è pari o dispari\n");

int numero = ReadUtils.ReadIntWithTryParse("Inserisci un numero: ");
string parita = PariDispari.VerificaNumero(numero);

Console.WriteLine(parita);
#endregion

Console.WriteLine();

#region PRODOTTO
Console.WriteLine("Questo programma stampa il prodotto di due numeri\n");

Console.Write("Inserisci il primo numero: ");
string? n1str = Console.ReadLine();

Console.Write("Inserisci il secondo numero: ");
string? n2str = Console.ReadLine();

string result = Prodotto.Moltiplica(n1str, n2str);
Console.WriteLine(result);
#endregion